
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AnswerStatusLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.Ans1Btn = new System.Windows.Forms.Button();
			this.Ans2Btn = new System.Windows.Forms.Button();
			this.Ans3Btn = new System.Windows.Forms.Button();
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
			this.tableLayoutPanel4.SuspendLayout();
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
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SettingsBtn, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 360);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.AnswerStatusLbl, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 165);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 156);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// AnswerStatusLbl
			// 
			this.AnswerStatusLbl.AutoSize = true;
			this.AnswerStatusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswerStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.AnswerStatusLbl.Location = new System.Drawing.Point(3, 124);
			this.AnswerStatusLbl.Name = "AnswerStatusLbl";
			this.AnswerStatusLbl.Size = new System.Drawing.Size(388, 32);
			this.AnswerStatusLbl.TabIndex = 1;
			this.AnswerStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel4.Controls.Add(this.Ans1Btn, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.Ans2Btn, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.Ans3Btn, 2, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(388, 118);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// Ans1Btn
			// 
			this.Ans1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Ans1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ans1Btn.Location = new System.Drawing.Point(3, 3);
			this.Ans1Btn.Name = "Ans1Btn";
			this.Ans1Btn.Size = new System.Drawing.Size(123, 112);
			this.Ans1Btn.TabIndex = 0;
			this.Ans1Btn.Text = "button1";
			this.Ans1Btn.UseVisualStyleBackColor = true;
			this.Ans1Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnsBtn_MouseClick);
			// 
			// Ans2Btn
			// 
			this.Ans2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Ans2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ans2Btn.Location = new System.Drawing.Point(132, 3);
			this.Ans2Btn.Name = "Ans2Btn";
			this.Ans2Btn.Size = new System.Drawing.Size(123, 112);
			this.Ans2Btn.TabIndex = 1;
			this.Ans2Btn.Text = "button2";
			this.Ans2Btn.UseVisualStyleBackColor = true;
			this.Ans2Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnsBtn_MouseClick);
			// 
			// Ans3Btn
			// 
			this.Ans3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Ans3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ans3Btn.Location = new System.Drawing.Point(261, 3);
			this.Ans3Btn.Name = "Ans3Btn";
			this.Ans3Btn.Size = new System.Drawing.Size(124, 112);
			this.Ans3Btn.TabIndex = 2;
			this.Ans3Btn.Text = "button3";
			this.Ans3Btn.UseVisualStyleBackColor = true;
			this.Ans3Btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnsBtn_MouseClick);
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
			this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 156);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// TopQLbl
			// 
			this.TopQLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TopQLbl.AutoSize = true;
			this.TopQLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.TopQLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TopQLbl.Location = new System.Drawing.Point(3, 16);
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
			this.BottomQLbl.Location = new System.Drawing.Point(3, 94);
			this.BottomQLbl.Name = "BottomQLbl";
			this.BottomQLbl.Size = new System.Drawing.Size(388, 46);
			this.BottomQLbl.TabIndex = 1;
			this.BottomQLbl.Text = "Incorrect";
			this.BottomQLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SettingsBtn
			// 
			this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SettingsBtn.Location = new System.Drawing.Point(124, 327);
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new System.Drawing.Size(152, 30);
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
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label BottomQLbl;
		private System.Windows.Forms.NotifyIcon MinimizeNotifiy;
		public System.Windows.Forms.Timer PopupTimer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label AnswerStatusLbl;
		private System.Windows.Forms.Timer ResultTimer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label TopQLbl;
		private System.Windows.Forms.Button SettingsBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button Ans1Btn;
		private System.Windows.Forms.Button Ans2Btn;
		private System.Windows.Forms.Button Ans3Btn;
	}
}

