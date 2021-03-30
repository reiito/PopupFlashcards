
namespace PopupFlashcards
{
	partial class SettingsWindow
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.VocabCmb = new System.Windows.Forms.ComboBox();
			this.VocabLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.PopupTimerNum = new System.Windows.Forms.NumericUpDown();
			this.PopupTimerLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.DifficultyCmb = new System.Windows.Forms.ComboBox();
			this.DifficultyLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AnswersInLbl = new System.Windows.Forms.Label();
			this.AnswersInCmb = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.PracticeTypeLbl = new System.Windows.Forms.Label();
			this.PracticeTypeCmb = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PopupTimerNum)).BeginInit();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 461);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Controls.Add(this.VocabCmb, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.VocabLbl, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 165);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(278, 75);
			this.tableLayoutPanel6.TabIndex = 6;
			// 
			// VocabCmb
			// 
			this.VocabCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.VocabCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VocabCmb.FormattingEnabled = true;
			this.VocabCmb.Location = new System.Drawing.Point(67, 40);
			this.VocabCmb.Name = "VocabCmb";
			this.VocabCmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.VocabCmb.Size = new System.Drawing.Size(143, 33);
			this.VocabCmb.TabIndex = 4;
			this.VocabCmb.SelectedIndexChanged += new System.EventHandler(this.ElementValueChanged);
			// 
			// VocabLbl
			// 
			this.VocabLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VocabLbl.AutoSize = true;
			this.VocabLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VocabLbl.Location = new System.Drawing.Point(3, 0);
			this.VocabLbl.Name = "VocabLbl";
			this.VocabLbl.Size = new System.Drawing.Size(272, 37);
			this.VocabLbl.TabIndex = 2;
			this.VocabLbl.Text = "Vocabulary";
			this.VocabLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.PopupTimerLbl, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 75);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
			this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.PopupTimerNum, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 40);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(272, 32);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(158, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "min";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// PopupTimerNum
			// 
			this.PopupTimerNum.Dock = System.Windows.Forms.DockStyle.Right;
			this.PopupTimerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PopupTimerNum.Location = new System.Drawing.Point(95, 3);
			this.PopupTimerNum.Name = "PopupTimerNum";
			this.PopupTimerNum.ReadOnly = true;
			this.PopupTimerNum.Size = new System.Drawing.Size(57, 30);
			this.PopupTimerNum.TabIndex = 2;
			this.PopupTimerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PopupTimerNum.ValueChanged += new System.EventHandler(this.ElementValueChanged);
			// 
			// PopupTimerLbl
			// 
			this.PopupTimerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PopupTimerLbl.AutoSize = true;
			this.PopupTimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PopupTimerLbl.Location = new System.Drawing.Point(3, 0);
			this.PopupTimerLbl.Name = "PopupTimerLbl";
			this.PopupTimerLbl.Size = new System.Drawing.Size(272, 37);
			this.PopupTimerLbl.TabIndex = 0;
			this.PopupTimerLbl.Text = "Popup Timer";
			this.PopupTimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.Controls.Add(this.DifficultyCmb, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.DifficultyLbl, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 84);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(278, 75);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// DifficultyCmb
			// 
			this.DifficultyCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.DifficultyCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DifficultyCmb.FormattingEnabled = true;
			this.DifficultyCmb.Location = new System.Drawing.Point(67, 40);
			this.DifficultyCmb.Name = "DifficultyCmb";
			this.DifficultyCmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DifficultyCmb.Size = new System.Drawing.Size(143, 33);
			this.DifficultyCmb.TabIndex = 3;
			this.DifficultyCmb.SelectedIndexChanged += new System.EventHandler(this.DifficultyCmb_SelectedIndexChanged);
			// 
			// DifficultyLbl
			// 
			this.DifficultyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DifficultyLbl.AutoSize = true;
			this.DifficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DifficultyLbl.Location = new System.Drawing.Point(3, 0);
			this.DifficultyLbl.Name = "DifficultyLbl";
			this.DifficultyLbl.Size = new System.Drawing.Size(272, 37);
			this.DifficultyLbl.TabIndex = 1;
			this.DifficultyLbl.Text = "Difficulty";
			this.DifficultyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.Controls.Add(this.SaveBtn, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.CancelBtn, 0, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 408);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(278, 50);
			this.tableLayoutPanel7.TabIndex = 4;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.SaveBtn.Location = new System.Drawing.Point(158, 3);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(100, 44);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.CancelBtn.Location = new System.Drawing.Point(19, 3);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(100, 44);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.AnswersInLbl, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.AnswersInCmb, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 327);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 75);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// AnswersInLbl
			// 
			this.AnswersInLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AnswersInLbl.AutoSize = true;
			this.AnswersInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnswersInLbl.Location = new System.Drawing.Point(3, 0);
			this.AnswersInLbl.Name = "AnswersInLbl";
			this.AnswersInLbl.Size = new System.Drawing.Size(272, 37);
			this.AnswersInLbl.TabIndex = 4;
			this.AnswersInLbl.Text = "Answers In";
			this.AnswersInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AnswersInCmb
			// 
			this.AnswersInCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.AnswersInCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnswersInCmb.FormattingEnabled = true;
			this.AnswersInCmb.Location = new System.Drawing.Point(67, 40);
			this.AnswersInCmb.Name = "AnswersInCmb";
			this.AnswersInCmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.AnswersInCmb.Size = new System.Drawing.Size(143, 33);
			this.AnswersInCmb.TabIndex = 3;
			this.AnswersInCmb.SelectedIndexChanged += new System.EventHandler(this.ElementValueChanged);
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel8.Controls.Add(this.PracticeTypeLbl, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.PracticeTypeCmb, 0, 1);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 246);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(278, 75);
			this.tableLayoutPanel8.TabIndex = 8;
			// 
			// PracticeTypeLbl
			// 
			this.PracticeTypeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PracticeTypeLbl.AutoSize = true;
			this.PracticeTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PracticeTypeLbl.Location = new System.Drawing.Point(3, 0);
			this.PracticeTypeLbl.Name = "PracticeTypeLbl";
			this.PracticeTypeLbl.Size = new System.Drawing.Size(272, 37);
			this.PracticeTypeLbl.TabIndex = 1;
			this.PracticeTypeLbl.Text = "Practice Type";
			this.PracticeTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PracticeTypeCmb
			// 
			this.PracticeTypeCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.PracticeTypeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PracticeTypeCmb.FormattingEnabled = true;
			this.PracticeTypeCmb.Location = new System.Drawing.Point(67, 40);
			this.PracticeTypeCmb.Name = "PracticeTypeCmb";
			this.PracticeTypeCmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PracticeTypeCmb.Size = new System.Drawing.Size(143, 33);
			this.PracticeTypeCmb.TabIndex = 2;
			this.PracticeTypeCmb.SelectedIndexChanged += new System.EventHandler(this.ElementValueChanged);
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 461);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsWindow";
			this.Text = "SettingsWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_Closing);
			this.VisibleChanged += new System.EventHandler(this.SettingsWindow_Shown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PopupTimerNum)).EndInit();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label PopupTimerLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label PracticeTypeLbl;
		private System.Windows.Forms.ComboBox PracticeTypeCmb;
		private System.Windows.Forms.NumericUpDown PopupTimerNum;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.ComboBox VocabCmb;
		private System.Windows.Forms.Label VocabLbl;
		private System.Windows.Forms.ComboBox DifficultyCmb;
		private System.Windows.Forms.Label DifficultyLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label AnswersInLbl;
		private System.Windows.Forms.ComboBox AnswersInCmb;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
	}
}