
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
			this.KanjiLbl = new System.Windows.Forms.Label();
			this.QuestionLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.JapaneseCbx = new System.Windows.Forms.CheckBox();
			this.EnglishCbx = new System.Windows.Forms.CheckBox();
			this.VerbsCbx = new System.Windows.Forms.CheckBox();
			this.NounsCbx = new System.Windows.Forms.CheckBox();
			this.MinimizeNotifiy = new System.Windows.Forms.NotifyIcon(this.components);
			this.PopupTimer = new System.Windows.Forms.Timer(this.components);
			this.ResultTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// SubmitBtn
			// 
			resources.ApplyResources(this.SubmitBtn, "SubmitBtn");
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.AnswerTxb, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.AnswerStatusLbl, 0, 1);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// AnswerTxb
			// 
			resources.ApplyResources(this.AnswerTxb, "AnswerTxb");
			this.AnswerTxb.BackColor = System.Drawing.SystemColors.Window;
			this.AnswerTxb.Name = "AnswerTxb";
			this.AnswerTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTxb_KeyDown);
			// 
			// AnswerStatusLbl
			// 
			resources.ApplyResources(this.AnswerStatusLbl, "AnswerStatusLbl");
			this.AnswerStatusLbl.Name = "AnswerStatusLbl";
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.KanjiLbl, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.QuestionLbl, 0, 1);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// KanjiLbl
			// 
			resources.ApplyResources(this.KanjiLbl, "KanjiLbl");
			this.KanjiLbl.Name = "KanjiLbl";
			// 
			// QuestionLbl
			// 
			resources.ApplyResources(this.QuestionLbl, "QuestionLbl");
			this.QuestionLbl.Name = "QuestionLbl";
			// 
			// tableLayoutPanel4
			// 
			resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.JapaneseCbx, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.EnglishCbx, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.VerbsCbx, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.NounsCbx, 4, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// JapaneseCbx
			// 
			resources.ApplyResources(this.JapaneseCbx, "JapaneseCbx");
			this.JapaneseCbx.Checked = true;
			this.JapaneseCbx.CheckState = System.Windows.Forms.CheckState.Checked;
			this.JapaneseCbx.Name = "JapaneseCbx";
			this.JapaneseCbx.TabStop = false;
			this.JapaneseCbx.UseVisualStyleBackColor = true;
			// 
			// EnglishCbx
			// 
			resources.ApplyResources(this.EnglishCbx, "EnglishCbx");
			this.EnglishCbx.Name = "EnglishCbx";
			this.EnglishCbx.TabStop = false;
			this.EnglishCbx.UseVisualStyleBackColor = true;
			// 
			// VerbsCbx
			// 
			resources.ApplyResources(this.VerbsCbx, "VerbsCbx");
			this.VerbsCbx.Checked = true;
			this.VerbsCbx.CheckState = System.Windows.Forms.CheckState.Checked;
			this.VerbsCbx.Name = "VerbsCbx";
			this.VerbsCbx.TabStop = false;
			this.VerbsCbx.UseVisualStyleBackColor = true;
			this.VerbsCbx.CheckedChanged += new System.EventHandler(this.VerbsCbx_CheckedChanged);
			// 
			// NounsCbx
			// 
			resources.ApplyResources(this.NounsCbx, "NounsCbx");
			this.NounsCbx.Checked = true;
			this.NounsCbx.CheckState = System.Windows.Forms.CheckState.Checked;
			this.NounsCbx.Name = "NounsCbx";
			this.NounsCbx.TabStop = false;
			this.NounsCbx.UseVisualStyleBackColor = true;
			this.NounsCbx.CheckedChanged += new System.EventHandler(this.NounsCbx_CheckedChanged);
			// 
			// MinimizeNotifiy
			// 
			resources.ApplyResources(this.MinimizeNotifiy, "MinimizeNotifiy");
			this.MinimizeNotifiy.Click += new System.EventHandler(this.MinimizeNotify_Click);
			// 
			// PopupTimer
			// 
			this.PopupTimer.Interval = 600000;
			this.PopupTimer.Tick += new System.EventHandler(this.PopupTimer_Tick);
			// 
			// ResultTimer
			// 
			this.ResultTimer.Interval = 5000;
			this.ResultTimer.Tick += new System.EventHandler(this.ResultTimer_Tick);
			// 
			// FlashWindow
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "FlashWindow";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.Main_Load);
			this.Resize += new System.EventHandler(this.Main_Resize);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox AnswerTxb;
		private System.Windows.Forms.Label QuestionLbl;
		private System.Windows.Forms.NotifyIcon MinimizeNotifiy;
		private System.Windows.Forms.Timer PopupTimer;
		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label AnswerStatusLbl;
		private System.Windows.Forms.Timer ResultTimer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label KanjiLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox JapaneseCbx;
		private System.Windows.Forms.CheckBox EnglishCbx;
		private System.Windows.Forms.CheckBox VerbsCbx;
		private System.Windows.Forms.CheckBox NounsCbx;
	}
}

