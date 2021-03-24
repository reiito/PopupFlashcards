using System.Collections.Generic;
using System.Windows.Forms;

namespace PopupFlashcards
{
	public partial class SettingsWindow : Form
	{
		FlashWindow flashWindow;
		Settings settings;

		bool settingsChanged = false;

		public SettingsWindow(FlashWindow _flashWindow, Settings _settings, List<Card> _cards)
		{
			InitializeComponent();

			flashWindow = _flashWindow;
			settings = _settings;

			flashWindow.PopupTimer.Interval = settings.GetPopupTimeInMilliseconds();

			PracticeTypeCmb.Items.Add("All");
			foreach (Card card in _cards)
			{
				if (!PracticeTypeCmb.Items.Contains(card.Type))
					PracticeTypeCmb.Items.Add(card.Type);
			}

			AnswersInCmb.Items.Add("English");
			AnswersInCmb.Items.Add("Japanese");

			PopupTimerNum.Value = settings.PopupTime;
			PracticeTypeCmb.SelectedItem = settings.PracticeType;
			AnswersInCmb.SelectedItem = settings.AnswersIn;
		}

		private void SettingsWindow_Shown(object sender, System.EventArgs e)
		{
			System.Console.WriteLine("value reset");
			settingsChanged = false;
		}

		private void SaveBtn_Click(object sender, System.EventArgs e)
		{
			settings.PopupTime = (int)PopupTimerNum.Value;
			settings.PracticeType = PracticeTypeCmb.SelectedItem.ToString();
			settings.AnswersIn = AnswersInCmb.SelectedItem.ToString();

			flashWindow.PopupTimer.Interval = settings.GetPopupTimeInMilliseconds();

			settings.Save(FlashWindow.settingsLocation);

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
				PopupTimerNum.Value = settings.PopupTime;
				PracticeTypeCmb.SelectedItem = settings.PracticeType;
				AnswersInCmb.SelectedItem = settings.AnswersIn;
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
		private void PopupTimerNum_ValueChanged(object sender, System.EventArgs e) { settingsChanged = true; }
		private void PracticeTypeCmb_SelectedIndexChanged(object sender, System.EventArgs e) { settingsChanged = true; }
		private void AnswersInCmb_SelectedIndexChanged(object sender, System.EventArgs e) { settingsChanged = true; }
	}
}
