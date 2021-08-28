using System;
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

			// vocab setup
			VocabCmb.Items.AddRange(new object[] { "All", "Mina", "N#" });

			// kanji setup
			KanjiCmb.Items.AddRange(new object[] { "TRUE", "FALSE" });

			SetSettingsUI();
		}

		public void SetLessonUI()
		{
			// type setup
			foreach (Card card in flashWindow.cards)
				if (!CurrentLessonCmb.Items.Contains(card.Set))
					CurrentLessonCmb.Items.Add(card.Set);
			CurrentLessonCmb.SelectedItem = settings.CurrentLesson;
		}

		void SetSettingsUI()
		{
			PopupTimerNum.Value = settings.PopupTime;
			CurrentLessonCmb.SelectedItem = settings.CurrentLesson;
			FrequencyNum.Value = settings.Frequency;
			VocabCmb.SelectedItem = settings.VocabList;
			KanjiCmb.SelectedIndex = settings.KanjiOnly ? 0 : 1;
		}

		private void SettingsWindow_Shown(object sender, System.EventArgs e)
		{
			settingsChanged = false;
		}

		private void SaveBtn_Click(object sender, System.EventArgs e)
		{
			settings = new Settings(
				(int)PopupTimerNum.Value,
				CurrentLessonCmb.SelectedItem.ToString(),
				FrequencyNum.Value,
				VocabCmb.SelectedItem.ToString(),
				Convert.ToBoolean(KanjiCmb.SelectedItem)
			);

			flashWindow.PopupTimer.Interval = settings.GetPopupTimeInMilliseconds();
			flashWindow.LoadCards();
			SetLessonUI();

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
