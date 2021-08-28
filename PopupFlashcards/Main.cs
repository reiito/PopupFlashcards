using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PopupFlashcards
{

	public partial class FlashWindow : Form
	{
		SettingsWindow settingsWindow;

		public List<Card> cards = new List<Card>();
		public List<Card> currentLessonCards = new List<Card>();

		List<Button> answerButtons = new List<Button>();
		Button correctAnswerButton;

		const int maxChances = 2;
		int chances = maxChances;
		int genRand = -1;

		int previousLimit = 2;
		List<Card> previousCards;

		bool first = true;

		SoundPlayer player = new SoundPlayer();

		public FlashWindow()
		{
			InitializeComponent();

			FileManager.CreateFolders();

			player.SoundLocation = FileManager.PopupSoundLocation;

			// settings setup
			settingsWindow = new SettingsWindow(this);
			settingsWindow.Hide();

			// cards setup
			LoadCards();
			previousCards = new List<Card>();

			// answer button setup
			var c = GetAll(this, typeof(Button));
			foreach (Button b in c)
				if (b.Name.Contains("Ans"))
					answerButtons.Add(b);

			settingsWindow.SetLessonUI();
		}

		public void LoadCards()
		{
			using (var reader = new StreamReader(FileManager.VocabLocation))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				cards = csv.GetRecords<Card>().ToList();

			for (int i = cards.Count - 1; i >= 0; i--)
			{
				if (settingsWindow.settings.VocabList == "Mina" && cards[i].Set.Contains("N"))
					cards.RemoveAt(i);
				else if (settingsWindow.settings.VocabList == "N#" && cards[i].Set.Contains("L"))
					cards.RemoveAt(i);
			}
		}

		private IEnumerable<Control> GetAll(Control control, Type type)
		{
			var controls = control.Controls.Cast<Control>();
			return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			if (first)
			{
				ShowFromSystemTray();
				first = false;
			}
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				SendToSystemTray();
		}

		private void MinimizeNotify_Click(object sender, EventArgs e)
		{
			ShowFromSystemTray();
		}

		private void PopupTimer_Tick(object sender, EventArgs e)
		{
			if (!ShowInTaskbar)
				ShowFromSystemTray();
		}

		private void ResetValues()
		{
			chances = maxChances;
			AnswerStatusLbl.Text = "";
			Enabled = true;
			correctAnswerButton = null;
			foreach (Button b in answerButtons)
				b.BackColor = SystemColors.Control;
			GetRandomCard();
		}

		private void SendToSystemTray()
		{
			Hide();
			ShowInTaskbar = false;
			MinimizeNotifiy.Visible = true;
			MinimizeNotifiy.ShowBalloonTip(1000);
			WindowState = FormWindowState.Minimized;

			PopupTimer.Stop();
			PopupTimer.Start();
		}

		private void ShowFromSystemTray()
		{
			player.SoundLocation = FileManager.PopupSoundLocation;
			player.Play();

			PopupTimer.Stop();

			ResetValues();

			Show();
			ShowInTaskbar = true;
			MinimizeNotifiy.Visible = false;
			WindowState = FormWindowState.Normal;
		}

		private void GetRandomCard()
		{
			Random r = new Random();
			genRand = r.Next(0, cards.Count);

			bool cardFound = false;
			double freqRand = r.NextDouble();
			while (!cardFound)
			{
				if (freqRand < (float)settingsWindow.settings.Frequency && cards[genRand].Set != settingsWindow.settings.CurrentLesson)
				{
					genRand = r.Next(0, cards.Count);
					continue;
				}

				if (previousCards.Contains(cards[genRand]))
				{
					Console.WriteLine("previous card, no!");
					genRand = r.Next(0, cards.Count);
				}
				else
				{
					if (previousCards.Count >= previousLimit)
						previousCards.RemoveAt(0);

					previousCards.Add(cards[genRand]);
					foreach (Card c in previousCards)
					{
						Console.WriteLine(c.Meaning);
					}
					cardFound = true;
				}
			}

			if (cards[genRand].Kanji != "")
			{
				TopQLbl.Text = settingsWindow.settings.KanjiOnly ? "" : cards[genRand].Word;
				BottomQLbl.Text = cards[genRand].Kanji;
			}
			else
			{
				TopQLbl.Text = "";
				BottomQLbl.Text = cards[genRand].Word;
			}

			int randAnswerButton = r.Next(0, answerButtons.Count);
			correctAnswerButton = answerButtons[randAnswerButton];
			answerButtons[randAnswerButton].Text = cards[genRand].GetAnswer();
			foreach (Button ab in answerButtons)
			{
				if (ab.Text != cards[genRand].GetAnswer())
					ab.Text = cards[r.Next(0, cards.Count)].GetAnswer();
			}
		}

		private void ResultTimer_Tick(object sender, EventArgs e)
		{
			if (ShowInTaskbar)
			{	
				ResultTimer.Stop();
				SendToSystemTray();
			}
		}

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			Enabled = false;
			settingsWindow.Show();
		}

		private void AnsBtn_MouseClick(object sender, MouseEventArgs e)
		{
			chances--;

			if (cards[genRand].GetAnswerNote() != "")
				AnswerStatusLbl.Text = "Incorrect, hint: " + cards[genRand].GetAnswerNote() + ", chances left: " + chances;
			else
				AnswerStatusLbl.Text = "Incorrect, chances left: " + chances;

			if (sender == correctAnswerButton || chances == 0)
			{
				if (sender == correctAnswerButton)
				{
					AnswerStatusLbl.Text = "Correct!";
					player.SoundLocation = FileManager.CorrectSoundLocation;
				}
				else if (chances == 0)
				{
					AnswerStatusLbl.Text = "You'll get it next time!";
					player.SoundLocation = FileManager.IncorrectSoundLocation;
					(sender as Button).BackColor = Color.Red;
				}

				player.Play();
				correctAnswerButton.BackColor = Color.Green;
				Enabled = false;
				ResultTimer.Start();
			}
		}
	}
}
