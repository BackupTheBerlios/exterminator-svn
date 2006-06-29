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
			this.lblDay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDay
			// 
			this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDay.BackColor = System.Drawing.Color.Transparent;
			this.lblDay.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			this.lblDay.Location = new System.Drawing.Point(84, 0);
			this.lblDay.Name = "lblDay";
			this.lblDay.Size = new System.Drawing.Size(73, 36);
			this.lblDay.TabIndex = 0;
			this.lblDay.Text = "0";
			this.lblDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// DayControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblDay);
			this.Name = "DayControl";
			this.Size = new System.Drawing.Size(157, 168);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblDay;
	}
}
