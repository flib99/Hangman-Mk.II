namespace Hangman_Mk.II
{
	partial class frmStart
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
			this.labelSelectedLanguage = new System.Windows.Forms.Label();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonChoose = new System.Windows.Forms.Button();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSelectedLanguage
			// 
			this.labelSelectedLanguage.AutoSize = true;
			this.labelSelectedLanguage.Location = new System.Drawing.Point(520, 140);
			this.labelSelectedLanguage.Name = "labelSelectedLanguage";
			this.labelSelectedLanguage.Size = new System.Drawing.Size(35, 13);
			this.labelSelectedLanguage.TabIndex = 0;
			this.labelSelectedLanguage.Text = "label1";
			// 
			// buttonPlay
			// 
			this.buttonPlay.Location = new System.Drawing.Point(193, 127);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(75, 23);
			this.buttonPlay.TabIndex = 3;
			this.buttonPlay.Text = "Play!";
			this.buttonPlay.UseVisualStyleBackColor = true;
			this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
			// 
			// buttonChoose
			// 
			this.buttonChoose.Location = new System.Drawing.Point(193, 168);
			this.buttonChoose.Name = "buttonChoose";
			this.buttonChoose.Size = new System.Drawing.Size(75, 23);
			this.buttonChoose.TabIndex = 4;
			this.buttonChoose.Text = "Choose Language";
			this.buttonChoose.UseVisualStyleBackColor = true;
			this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(193, 198);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 5;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
			// 
			// frmStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonChoose);
			this.Controls.Add(this.buttonPlay);
			this.Controls.Add(this.labelSelectedLanguage);
			this.Name = "frmStart";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSelectedLanguage;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Button buttonChoose;
		private System.Windows.Forms.Button buttonQuit;
	}
}

