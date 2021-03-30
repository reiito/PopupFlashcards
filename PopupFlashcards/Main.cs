using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PopupFlashcards
{
	public partial class FlashWindow : Form
	{
		SettingsWindow settingsWindow;

		public List<Card> cards = new List<Card>();

		string[] currentAnswers;

		const int maxChances = 4;
		int chances = maxChances;
		int genRand = -1;

		bool first = true;

		SoundPlayer player = new SoundPlayer();

		int prevQuestionLimit = 20;
		List<string> previousQuestions = new List<string>();

		SymSpell symSpell;

		public FlashWindow()
		{
			InitializeComponent();

			FileManager.CreateFolders();

			player.SoundLocation = FileManager.PopupSoundLocation;

			// settings setup
			settingsWindow = new SettingsWindow(this);
			settingsWindow.Hide();

			// cards setup
			if (settingsWindow.settings.VocabList.Equals("All"))
			{
				List<List<Card>> allVocabLists = new List<List<Card>>();
				foreach (string file in Directory.GetFiles(FileManager.VocabPath, "*.csv"))
				{
					using (var reader = new StreamReader(file))
					using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
						allVocabLists.Add(csv.GetRecords<Card>().ToList());
				}

				foreach (List<Card> cardList in allVocabLists)
					foreach (Card card in cardList)
						cards.Add(card);
			}
			else
			{
				using (var reader = new StreamReader(FileManager.VocabPath + settingsWindow.settings.VocabList + ".csv"))
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
					cards = csv.GetRecords<Card>().ToList();
			}

			settingsWindow.SetTypeUI();

			// spell check setup
			const int initialCapacity = 82765;
			const int maxEditDistance = 2;
			const int prefixLength = 7;
			symSpell = new SymSpell(initialCapacity, maxEditDistance, prefixLength);
			if (!symSpell.LoadDictionary(FileManager.DictionaryLocation, 0, 1)) { Console.Error.WriteLine("\rFile not found: " + Path.GetFullPath(FileManager.DictionaryLocation)); return; }
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

		void ResetValues()
		{
			chances = maxChances;
			AnswerTxb.Text = "";
			AnswerStatusLbl.Text = "";
			currentAnswers = null;
			Enabled = true;
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
			player.SoundLocation = FileManager.PopupSoundLocation;
			player.Play();

			PopupTimer.Stop();

			ResetValues();

			AnswerTxb.Focus();

			Show();
			ShowInTaskbar = true;
			MinimizeNotifiy.Visible = false;
			WindowState = FormWindowState.Normal;
		}

		void GetRandomCard()
		{
			Random r = new Random();
			genRand = r.Next(0, cards.Count);

			bool decided = false;
			while (!decided)
			{
				if (settingsWindow.settings.PracticeType.Equals("All"))
					decided = true;
				else if (!cards[genRand].Type.Equals(settingsWindow.settings.PracticeType))
					decided = false;

				if (previousQuestions.Count == 0)
				{
					previousQuestions.Add(cards[genRand].GetJapaneseQuestions(settingsWindow.settings.Difficulty)[0]);
					decided = true;
				}
				else
				{
					foreach (string q in previousQuestions)
					{
						if (q == cards[genRand].GetJapaneseQuestions(settingsWindow.settings.Difficulty)[0])
						{
							decided = false;
							break;
						}
						else
						{
							if (previousQuestions.Count > prevQuestionLimit)
								previousQuestions.RemoveAt(0);

							previousQuestions.Add(cards[genRand].GetJapaneseQuestions(settingsWindow.settings.Difficulty)[0]);
							decided = true;
							break;
						}
					}
				}

				if (!decided)
					genRand = r.Next(0, cards.Count);
			}

			TopQLbl.Text = cards[genRand].GetJapaneseQuestions(settingsWindow.settings.Difficulty)[0];
			BottomQLbl.Text = cards[genRand].GetJapaneseQuestions(settingsWindow.settings.Difficulty)[1];
			currentAnswers = cards[genRand].GetEnglishAnswers();
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			chances--;

			switch (chances)
			{
				case 2:
					AnswerStatusLbl.Text = "Hint: " + cards[genRand].GetHints()[0];
					break;
				case 1:
					AnswerStatusLbl.Text = "Hint: " + cards[genRand].GetHints()[1];
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
					player.SoundLocation = FileManager.CorrectSoundLocation;
				}
				else
				{
					AnswerStatusLbl.Text = "You'll get it next time!";
					player.SoundLocation = FileManager.IncorrectSoundLocation;
				}
					

				player.Play();
				AnswerTxb.Text = cards[genRand].English;
				Enabled = false;
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
					if (splitUserAnswer[i].Length == 1 && (char.IsSymbol(splitUserAnswer[i][0]) || char.IsPunctuation(splitUserAnswer[i][0])))
					{
						correctCount++;
						continue;
					}

					List<SymSpell.SuggestItem> suggestions = symSpell.Lookup(splitUserAnswer[i], verbosity);
					if (suggestions.Count != 0)
					{
						foreach (SymSpell.SuggestItem suggestion in suggestions)
						{
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

		//public void ChangeProgramLanguage()
		//{
		//	if (settingsWindow.settings.Difficulty.Equals("Hard"))
		//	{
		//		SubmitBtn.Text = "差し出す";
		//		SettingsBtn.Text = "設定";
		//	}
		//	else if (settingsWindow.settings.Difficulty.Equals("Medium"))
		//	{
		//		SubmitBtn.Text = "さしだす";
		//		SettingsBtn.Text = "せってい";
		//	}
		//	else
		//	{
		//		SubmitBtn.Text = "Submit";
		//		SettingsBtn.Text = "Settings";
		//	}
		//}
	}
}
