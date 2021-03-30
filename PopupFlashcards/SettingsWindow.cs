using System.IO;
using System.Windows.Forms;

namespace PopupFlashcards
{
	public partial class SettingsWindow : Form
	{
		public Settings settings;

		FlashWindow flashWindow;

		bool settingsChanged = false;

		public SettingsWindow(FlashWindow _flashWindow)
		{
			InitializeComponent();

			settings = new Settings();
			settings.Load();

			flashWindow = _flashWindow;

			// timer setup
			flashWindow.PopupTimer.Interval = settings.GetPopupTimeInMilliseconds();

			// difficulty setup
			DifficultyCmb.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });

			// vocab setup
			VocabCmb.Items.Add("All");
			foreach (FileInfo file in new DirectoryInfo(FileManager.VocabPath).GetFiles("*.csv"))
				VocabCmb.Items.Add(Path.GetFileNameWithoutExtension(file.Name));

			// answer setup
			AnswersInCmb.Items.AddRange(new object[] { "English", "Japanese" });

			SetSettingsUI();
		}

		public void SetTypeUI()
		{
			// type setup
			PracticeTypeCmb.Items.Add("All");
			foreach (Card card in flashWindow.cards)
				if (!PracticeTypeCmb.Items.Contains(card.Type))
					PracticeTypeCmb.Items.Add(card.Type);
			PracticeTypeCmb.SelectedItem = settings.PracticeType;
		}

		void SetSettingsUI()
		{
			PopupTimerNum.Value = settings.PopupTime;
			DifficultyCmb.SelectedItem = settings.Difficulty;
			VocabCmb.SelectedItem = settings.VocabList;
			PracticeTypeCmb.SelectedItem = settings.PracticeType;
			AnswersInCmb.SelectedItem = settings.AnswersIn;
		}

		//public void ChangeProgramLanguage()
		//{
		//	if (settings.Difficulty.Equals("Hard"))
		//	{
		//		PopupTimerLbl.Text = "間隔計時機構";
		//		DifficultyLbl.Text = "困難";
		//		DifficultyCmb.Items.Clear();
		//		DifficultyCmb.Items.AddRange(new object[] { "容易", "並", "難しい" });
		//		VocabLbl.Text = "語彙";
		//		PracticeTypeLbl.Text = "練習型";
		//		AnswersInLbl.Text = "解答";
		//		AnswersInCmb.Items.Clear();
		//		AnswersInCmb.Items.AddRange(new object[] { "英語", "日本語" });
		//		CancelBtn.Text = "キャンセル";
		//		SaveBtn.Text = "セーブ";
		//	}
		//	else if (settings.Difficulty.Equals("Medium"))
		//	{
		//		PopupTimerLbl.Text = "かんかくけいじきこう";
		//		DifficultyLbl.Text = "こんなん";
		//		DifficultyCmb.Items.Clear();
		//		DifficultyCmb.Items.AddRange(new object[] { "ようい", "なみ", "むずかしい" });
		//		VocabLbl.Text = "ごい";
		//		PracticeTypeLbl.Text = "れんしゅうかた";
		//		AnswersInLbl.Text = "かいとうは";
		//		AnswersInCmb.Items.Clear();
		//		AnswersInCmb.Items.AddRange(new object[] { "えいご", "にほんご" });
		//		CancelBtn.Text = "キャンセル";
		//		SaveBtn.Text = "セーブ";
		//	}
		//	else
		//	{
		//		PopupTimerLbl.Text = "Popup Timer";
		//		DifficultyLbl.Text = "Difficulty";
		//		DifficultyCmb.Items.Clear();
		//		DifficultyCmb.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
		//		VocabLbl.Text = "Vocabulary";
		//		PracticeTypeLbl.Text = "Practice Type";
		//		AnswersInLbl.Text = "Answers In";
		//		AnswersInCmb.Items.Clear();
		//		AnswersInCmb.Items.AddRange(new object[] { "English", "Japanese" });
		//		CancelBtn.Text = "Cancel";
		//		SaveBtn.Text = "Save";
		//	}
		//}

		private void SettingsWindow_Shown(object sender, System.EventArgs e)
		{
			settingsChanged = false;
		}

		private void SaveBtn_Click(object sender, System.EventArgs e)
		{
			settings = new Settings(
				(int)PopupTimerNum.Value,
				DifficultyCmb.SelectedItem.ToString(),
				VocabCmb.SelectedItem.ToString(),
				PracticeTypeCmb.SelectedItem.ToString(),
				AnswersInCmb.SelectedItem.ToString()
			);

			flashWindow.PopupTimer.Interval = settings.GetPopupTimeInMilliseconds();

			settings.Save();

			Hide();
			flashWindow.Enabled = true;
		}

		void CloseWithoutSaving()
		{
			DialogResult result = DialogResult.None;
			if (settingsChanged)
			{
				result = MessageBox.Show("The new settings will not be saved, would you like to continue", "Settings will not be saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			}

			if (result == DialogResult.Yes || !settingsChanged)
			{
				Hide();
				flashWindow.Enabled = true;
				SetSettingsUI();
			}
		}
		private void CancelBtn_Click(object sender, System.EventArgs e)
		{
			CloseWithoutSaving();
		}
		public bool ClosedByXButtonOrAltF4 { get; private set; }
		private const int SC_CLOSE = 0xF060;
		private const int WM_SYSCOMMAND = 0x0112;
		protected override void WndProc(ref Message msg)
		{
			if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
				ClosedByXButtonOrAltF4 = true;
			base.WndProc(ref msg);
		}
		private void SettingsWindow_Closing(object sender, FormClosingEventArgs e)
		{
			if (ClosedByXButtonOrAltF4 && e.CloseReason == CloseReason.UserClosing)
			{
				CloseWithoutSaving();
				e.Cancel = true;
			}
		}

		// change detection
		private void ElementValueChanged(object sender, System.EventArgs e) { settingsChanged = true; }
		private void DifficultyCmb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			settingsChanged = true;
		}
	}
}
