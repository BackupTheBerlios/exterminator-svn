namespace eXterm.UI.Controls
{
	partial class CalendarControl
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
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlDays = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(443, 15);
			this.pnlTop.TabIndex = 0;
			// 
			// pnlBottom
			// 
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 300);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(443, 14);
			this.pnlBottom.TabIndex = 1;
			// 
			// pnlDays
			// 
			this.pnlDays.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDays.Location = new System.Drawing.Point(0, 15);
			this.pnlDays.Name = "pnlDays";
			this.pnlDays.Size = new System.Drawing.Size(443, 285);
			this.pnlDays.TabIndex = 2;
			// 
			// CalendarControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlDays);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.Name = "CalendarControl";
			this.Size = new System.Drawing.Size(443, 314);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlDays;
	}
}
