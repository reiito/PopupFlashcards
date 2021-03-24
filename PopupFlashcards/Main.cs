using CsvHelper;
using System;
using System.Collections.Generic;
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
		Settings settings;

		List<Card> cards = new List<Card>();

		List<string> currentAnswers = new List<string>();

		const int maxChances = 4;
		int chances = maxChances;
		int genRand = -1;

		bool first = true;

		SoundPlayer player = new SoundPlayer();

		int prevQuestionLimit = 10;
		List<string> previousQuestions = new List<string>();

		SymSpell symSpell;

		// Files
		static readonly string resourcesFolderPath = AppContext.BaseDirectory + "resources\\";
		public static readonly string settingsLocation = resourcesFolderPath + "settings.csv";
		static readonly string cardsLocation = resourcesFolderPath + "cards.csv";
		static readonly string dictionaryLocation = resourcesFolderPath + "frequency_dictionary_en_82_765.txt";
		static readonly string popupSoundLocation = resourcesFolderPath + "notification.wav";
		static readonly string correctSoundLocation = resourcesFolderPath + "correct.wav";
		static readonly string incorrectSoundLocation = resourcesFolderPath + "incorrect.wav";

		public FlashWindow()
		{
			InitializeComponent();

			if (!Directory.Exists(resourcesFolderPath))
				Directory.CreateDirectory(resourcesFolderPath);

			cards = LoadCardFile();

			player.SoundLocation = popupSoundLocation;

			// settings
			settings = new Settings();
			settings.Load(settingsLocation);
			settingsWindow = new SettingsWindow(this, settings, cards);
			settingsWindow.Hide();

			// spell check setup
			const int initialCapacity = 82765;
			const int maxEditDistance = 2;
			const int prefixLength = 7;
			symSpell = new SymSpell(initialCapacity, maxEditDistance, prefixLength);
			if (!symSpell.LoadDictionary(dictionaryLocation, 0, 1)) { Console.Error.WriteLine("\rFile not found: " + Path.GetFullPath(dictionaryLocation)); Console.ReadKey(); return; }
		}

		private void Main_Load(object sender, EventArgs e)
		{
			AnswerTxb.Focus();

			if (first)
			{
				ShowFromSystemTray();
				first = false;
			}
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				SendToSystemTray();
			}
		}

		private void MinimizeNotify_Click(object sender, EventArgs e)
		{
			ShowFromSystemTray();
		}

		private void PopupTimer_Tick(object sender, EventArgs e)
		{
			if (!ShowInTaskbar)
			{
				ShowFromSystemTray();
			}
		}

		void ResetValues()
		{
			chances = maxChances;
			AnswerTxb.Text = "";
			AnswerStatusLbl.Text = "";
			currentAnswers = new List<string>();
			SubmitBtn.Enabled = true;
			AnswerTxb.Enabled = true;
			GetRandomCard();
		}

		void SendToSystemTray()
		{
			Hide();
			ShowInTaskbar = false;
			MinimizeNotifiy.Visible = true;
			MinimizeNotifiy.ShowBalloonTip(1000);
			WindowState = FormWindowState.Minimized;

			PopupTimer.Stop();
			PopupTimer.Start();
		}

		void ShowFromSystemTray()
		{
			player.SoundLocation = popupSoundLocation;
			player.Play();

			PopupTimer.Stop();

			ResetValues();

			AnswerTxb.Focus();

			Show();
			ShowInTaskbar = true;
			MinimizeNotifiy.Visible = false;
			WindowState = FormWindowState.Normal;
		}

		static List<Card> LoadCardFile()
		{
			using (var reader = new StreamReader(cardsLocation))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				return csv.GetRecords<Card>().ToList();
			}
		}

		void GetRandomCard()
		{
			Random r = new Random();
			genRand = r.Next(0, cards.Count);

			bool decided = false;
			while (!decided)
			{
				if (settings.PracticeType.Equals("All"))
				{
					decided = true;
				}
				else if (!cards[genRand].Type.Equals(settings.PracticeType))
				{
					genRand = r.Next(0, cards.Count);
					continue;
				}

				if (previousQuestions.Count == 0)
				{
					decided = true;
				}
				else
				{
					foreach (string q in previousQuestions)
					{
						if (q.Equals(cards[genRand].Hiragana))
						{
							genRand = r.Next(0, cards.Count);
							decided = false;
							break;
						}
						else
						{
							if (previousQuestions.Count > prevQuestionLimit)
								previousQuestions.RemoveAt(0);

							previousQuestions.Add(cards[genRand].Hiragana);
							decided = true;
							break;
						}
					}
				}
			}

			QuestionLbl.Text = cards[genRand].Hiragana;
			KanjiLbl.Text = cards[genRand].Kanji;
			currentAnswers = cards[genRand].English.Split(';').ToList();
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			chances--;

			switch (chances)
			{
				case 2:
					AnswerStatusLbl.Text = "Hint: " + cards[genRand].HardHint;
					break;
				case 1:
					AnswerStatusLbl.Text = "Hint: " + cards[genRand].EasyHint;
					break;
				default:
					AnswerStatusLbl.Text = "Incorrect, chances left: " + chances;
					break;
			}

			if (chances == 0 || CorrectAnswerCheck())
			{
				if (CorrectAnswerCheck())
				{
					AnswerStatusLbl.Text = "Correct!";
					player.SoundLocation = correctSoundLocation;
				}
				else
				{
					AnswerStatusLbl.Text = "You'll get it next time!";
					player.SoundLocation = incorrectSoundLocation;
				}
					

				player.Play();
				SubmitBtn.Enabled = false;
				AnswerTxb.Enabled = false;
				AnswerTxb.Text = cards[genRand].English;
				ResultTimer.Start();
				return;
			}

			AnswerTxb.Text = "";
		}

		private void ResultTimer_Tick(object sender, EventArgs e)
		{
			if (ShowInTaskbar)
			{	
				ResultTimer.Stop();
				SendToSystemTray();
			}
		}

		private void AnswerTxb_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SubmitBtn.PerformClick();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private bool CorrectAnswerCheck()
		{
			int correctCount = 0;
			const SymSpell.Verbosity verbosity = SymSpell.Verbosity.Closest;

			string[] splitUserAnswer = AnswerTxb.Text.Split(' ');
			List<string[]> splitCorrectAnswerList = new List<string[]>();
			foreach (string answer in currentAnswers)
			{
				splitCorrectAnswerList.Add(answer.Split(' '));
			}
			foreach (string[] splitCorrectAnswer in splitCorrectAnswerList)
			{
				if (splitCorrectAnswer.Length != splitUserAnswer.Length)
				{
					continue;
				}

				for (int i = 0; i < splitUserAnswer.Length; i++)
				{
					List<SymSpell.SuggestItem> suggestions = symSpell.Lookup(splitUserAnswer[i], verbosity);
					if (suggestions.Count != 0)
					{
						foreach (SymSpell.SuggestItem suggestion in suggestions)
						{
							Console.WriteLine(suggestion.term + " ?= " + splitCorrectAnswer[i]);
							if (suggestion.term.Equals(splitCorrectAnswer[i]))
							{
								correctCount++;
								break;
							}
						}
					}
				}
			}

			if (correctCount == splitUserAnswer.Length)
				return true;
			else
				return false;
		}

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			Enabled = false;
			settingsWindow.Show();
		}
	}
}
