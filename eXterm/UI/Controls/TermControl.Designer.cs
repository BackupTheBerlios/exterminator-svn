namespace eXterm.UI.Controls
{
	partial class TermControl
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
			this.dateLbl = new System.Windows.Forms.Label();
			this.textLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateLbl
			// 
			this.dateLbl.AutoSize = true;
			this.dateLbl.Location = new System.Drawing.Point(3, 19);
			this.dateLbl.Name = "dateLbl";
			this.dateLbl.Size = new System.Drawing.Size(28, 13);
			this.dateLbl.TabIndex = 0;
			this.dateLbl.Text = "0:00";
			// 
			// textLbl
			// 
			this.textLbl.AutoSize = true;
			this.textLbl.Location = new System.Drawing.Point(46, 19);
			this.textLbl.Name = "textLbl";
			this.textLbl.Size = new System.Drawing.Size(24, 13);
			this.textLbl.TabIndex = 1;
			this.textLbl.Text = "text";
			// 
			// TermControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textLbl);
			this.Controls.Add(this.dateLbl);
			this.Name = "TermControl";
			this.Size = new System.Drawing.Size(157, 62);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label dateLbl;
		private System.Windows.Forms.Label textLbl;
	}
}
