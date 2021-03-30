
namespace PopupFlashcards
{
	partial class FlashWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashWindow));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AnswerTxb = new System.Windows.Forms.TextBox();
			this.AnswerStatusLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TopQLbl = new System.Windows.Forms.Label();
			this.BottomQLbl = new System.Windows.Forms.Label();
			this.SettingsBtn = new System.Windows.Forms.Button();
			this.MinimizeNotifiy = new System.Windows.Forms.NotifyIcon(this.components);
			this.PopupTimer = new System.Windows.Forms.Timer(this.components);
			this.ResultTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(30);
			this.panel1.Size = new System.Drawing.Size(460, 420);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SettingsBtn, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 360);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.SubmitBtn.Location = new System.Drawing.Point(128, 291);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(143, 30);
			this.SubmitBtn.TabIndex = 2;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.AnswerTxb, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.AnswerStatusLbl, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 147);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 138);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// AnswerTxb
			// 
			this.AnswerTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.AnswerTxb.BackColor = System.Drawing.SystemColors.Window;
			this.AnswerTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.AnswerTxb.Location = new System.Drawing.Point(3, 28);
			this.AnswerTxb.Name = "AnswerTxb";
			this.AnswerTxb.Size = new System.Drawing.Size(388, 53);
			this.AnswerTxb.TabIndex = 0;
			this.AnswerTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxb_KeyDown);
			// 
			// AnswerStatusLbl
			// 
			this.AnswerStatusLbl.AutoSize = true;
			this.AnswerStatusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswerStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.AnswerStatusLbl.Location = new System.Drawing.Point(3, 110);
			this.AnswerStatusLbl.Name = "AnswerStatusLbl";
			this.AnswerStatusLbl.Size = new System.Drawing.Size(388, 28);
			this.AnswerStatusLbl.TabIndex = 1;
			this.AnswerStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.TopQLbl, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.BottomQLbl, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 138);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// TopQLbl
			// 
			this.TopQLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TopQLbl.AutoSize = true;
			this.TopQLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.TopQLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TopQLbl.Location = new System.Drawing.Point(3, 11);
			this.TopQLbl.Name = "TopQLbl";
			this.TopQLbl.Size = new System.Drawing.Size(388, 46);
			this.TopQLbl.TabIndex = 2;
			this.TopQLbl.Text = "Incorrect";
			this.TopQLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BottomQLbl
			// 
			this.BottomQLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.BottomQLbl.AutoSize = true;
			this.BottomQLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.BottomQLbl.Location = new System.Drawing.Point(3, 80);
			this.BottomQLbl.Name = "BottomQLbl";
			this.BottomQLbl.Size = new System.Drawing.Size(388, 46);
			this.BottomQLbl.TabIndex = 1;
			this.BottomQLbl.Text = "Incorrect";
			this.BottomQLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SettingsBtn
			// 
			this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.SettingsBtn.Location = new System.Drawing.Point(162, 327);
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new System.Drawing.Size(75, 30);
			this.SettingsBtn.TabIndex = 5;
			this.SettingsBtn.Text = "Settings";
			this.SettingsBtn.UseVisualStyleBackColor = true;
			this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
			// 
			// MinimizeNotifiy
			// 
			this.MinimizeNotifiy.BalloonTipText = "Application Minimized.";
			this.MinimizeNotifiy.BalloonTipTitle = "Popup Flashcards";
			this.MinimizeNotifiy.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizeNotifiy.Icon")));
			this.MinimizeNotifiy.Text = "MinimizeNotifiy";
			this.MinimizeNotifiy.Visible = true;
			this.MinimizeNotifiy.Click += new System.EventHandler(this.MinimizeNotify_Click);
			// 
			// PopupTimer
			// 
			this.PopupTimer.Tick += new System.EventHandler(this.PopupTimer_Tick);
			// 
			// ResultTimer
			// 
			this.ResultTimer.Interval = 5000;
			this.ResultTimer.Tick += new System.EventHandler(this.ResultTimer_Tick);
			// 
			// FlashWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 420);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FlashWindow";
			this.ShowInTaskbar = false;
			this.Text = "Popup Flashcard";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Resize += new System.EventHandler(this.Main_Resize);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox AnswerTxb;
		private System.Windows.Forms.Label BottomQLbl;
		private System.Windows.Forms.NotifyIcon MinimizeNotifiy;
		public System.Windows.Forms.Timer PopupTimer;
		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label AnswerStatusLbl;
		private System.Windows.Forms.Timer ResultTimer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label TopQLbl;
		private System.Windows.Forms.Button SettingsBtn;
	}
}

