namespace eXterm.UI.Controls
{
	partial class DayControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.btnNewTerm = new eXterm.UI.Controls.Basic.PupupButton();
			this.lblDay = new System.Windows.Forms.Label();
			this.pnlTerms = new System.Windows.Forms.Panel();
			this.pnlTop.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.pnlButtons);
			this.pnlTop.Controls.Add(this.lblDay);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(169, 25);
			this.pnlTop.TabIndex = 2;
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.btnNewTerm);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlButtons.Location = new System.Drawing.Point(0, 0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(144, 25);
			this.pnlButtons.TabIndex = 3;
			// 
			// btnNewTerm
			// 
			this.btnNewTerm.BackColor = System.Drawing.Color.Black;
			this.btnNewTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNewTerm.BtnText = "";
			this.btnNewTerm.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnNewTerm.ForeColor = System.Drawing.Color.White;
			this.btnNewTerm.Image = null;
			this.btnNewTerm.Location = new System.Drawing.Point(119, 0);
			this.btnNewTerm.Margin = new System.Windows.Forms.Padding(0);
			this.btnNewTerm.Name = "btnNewTerm";
			this.btnNewTerm.Size = new System.Drawing.Size(25, 25);
			this.btnNewTerm.TabIndex = 0;
			this.btnNewTerm.Click += new System.EventHandler(this.btnNewTerm_Click);
			// 
			// lblDay
			// 
			this.lblDay.AutoSize = true;
			this.lblDay.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblDay.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			this.lblDay.Location = new System.Drawing.Point(144, 0);
			this.lblDay.Name = "lblDay";
			this.lblDay.Size = new System.Drawing.Size(25, 25);
			this.lblDay.TabIndex = 1;
			this.lblDay.Text = "0";
			this.lblDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pnlTerms
			// 
			this.pnlTerms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTerms.Location = new System.Drawing.Point(0, 25);
			this.pnlTerms.Name = "pnlTerms";
			this.pnlTerms.Size = new System.Drawing.Size(169, 180);
			this.pnlTerms.TabIndex = 3;
			// 
			// DayControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlTerms);
			this.Controls.Add(this.pnlTop);
			this.Name = "DayControl";
			this.Size = new System.Drawing.Size(169, 205);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.pnlButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label lblDay;
		private System.Windows.Forms.Panel pnlTerms;
		private System.Windows.Forms.Panel pnlButtons;
		private eXterm.UI.Controls.Basic.PupupButton btnNewTerm;

	}
}
