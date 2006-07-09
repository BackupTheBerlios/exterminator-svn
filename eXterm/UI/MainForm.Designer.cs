namespace eXterm.UI
{
	partial class MainForm
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
			this.pnlTop = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblVersionIndicator = new eXterm.UI.Controls.VersionIndicator();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnClose = new eXterm.UI.Controls.Basic.PupupButton();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlRight = new System.Windows.Forms.Panel();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.ctlCalendar = new eXterm.UI.Controls.CalendarControl();
			this.pnlTop.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.panel6);
			this.pnlTop.Controls.Add(this.panel5);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(692, 20);
			this.pnlTop.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lblVersionIndicator);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(295, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(374, 20);
			this.panel6.TabIndex = 4;
			// 
			// lblVersionIndicator
			// 
			this.lblVersionIndicator.BackColor = System.Drawing.Color.Black;
			this.lblVersionIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblVersionIndicator.ForeColor = System.Drawing.Color.White;
			this.lblVersionIndicator.Location = new System.Drawing.Point(0, 0);
			this.lblVersionIndicator.Name = "lblVersionIndicator";
			this.lblVersionIndicator.Size = new System.Drawing.Size(374, 20);
			this.lblVersionIndicator.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btnClose);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(669, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(23, 20);
			this.panel5.TabIndex = 3;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.BtnText = "X";
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(4, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(16, 16);
			this.btnClose.TabIndex = 2;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 498);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(692, 10);
			this.pnlBottom.TabIndex = 2;
			// 
			// pnlRight
			// 
			this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlRight.Location = new System.Drawing.Point(682, 20);
			this.pnlRight.Name = "pnlRight";
			this.pnlRight.Size = new System.Drawing.Size(10, 478);
			this.pnlRight.TabIndex = 3;
			// 
			// pnlLeft
			// 
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 20);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(10, 478);
			this.pnlLeft.TabIndex = 4;
			// 
			// ctlCalendar
			// 
			this.ctlCalendar.BackColor = System.Drawing.Color.Black;
			this.ctlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlCalendar.ForeColor = System.Drawing.Color.White;
			this.ctlCalendar.Location = new System.Drawing.Point(10, 20);
			this.ctlCalendar.Name = "ctlCalendar";
			this.ctlCalendar.Size = new System.Drawing.Size(672, 478);
			this.ctlCalendar.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 508);
			this.Controls.Add(this.ctlCalendar);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.pnlRight);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MainForm";
			this.pnlTop.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private eXterm.UI.Controls.Basic.PupupButton btnClose;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlRight;
		private System.Windows.Forms.Panel pnlLeft;
		private eXterm.UI.Controls.CalendarControl ctlCalendar;
		private System.Windows.Forms.Panel panel6;
		private eXterm.UI.Controls.VersionIndicator lblVersionIndicator;
		private System.Windows.Forms.Panel panel5;

	}
}