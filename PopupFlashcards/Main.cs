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

		int genRand = -1;

		Card currentCard;
		List<Card> previousCards;
		List<Card> correctCards;

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
			correctCards = new List<Card>();

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

		private List<Card> GetLessonCards(string lessonNum)
		{
			List<Card> lCards = new List<Card>();
			foreach (Card c in cards)
			{
				if (c.Set.Contains(lessonNum))
				{
					lCards.Add(c);
				}
			}

			return lCards;
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
			MinimizeNotifiy.Visible = false;
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
					genRand = r.Next(0, cards.Count);
					continue;
				}
				else if (correctCards.Contains(cards[genRand]))
				{
					genRand = r.Next(0, cards.Count);
					continue;
				}
				else
				{
					if (correctCards.Count >= GetLessonCards(settingsWindow.settings.CurrentLesson).Count)
						correctCards.Clear();

					if (previousCards.Count > 5)
						previousCards.Clear();
					else
						previousCards.Add(cards[genRand]);

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
			currentCard = cards[genRand];
			foreach (Button ab in answerButtons)
			{
				if (ab == answerButtons[randAnswerButton])
					continue;

				Card tempCard = cards[r.Next(0, cards.Count)];
				while (true)
				{
					if (freqRand < (float)settingsWindow.settings.Frequency && tempCard.Set != settingsWindow.settings.CurrentLesson)
					{
						tempCard = cards[r.Next(0, cards.Count)];
						continue;
					}

					if (tempCard.GetAnswer() == cards[genRand].GetAnswer())
					{
						tempCard = cards[r.Next(0, cards.Count)];
						continue;
					}

					if (cards[genRand].Kanji.Contains("ます") && !tempCard.Kanji.Contains("ます"))
					{
						tempCard = cards[r.Next(0, cards.Count)];
						continue;
					}

					break;
				}

				ab.Text = tempCard.GetAnswer();
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
			if (sender == correctAnswerButton)
			{
				AnswerStatusLbl.Text = "Correct!";
				player.SoundLocation = FileManager.CorrectSoundLocation;
				correctCards.Add(currentCard);
			}
			else
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
