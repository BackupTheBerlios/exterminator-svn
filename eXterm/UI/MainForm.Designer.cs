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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new eXterm.UI.Controls.Basic.PupupButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ctlCalendar = new eXterm.UI.Controls.CalendarControl();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.versionIndicator1 = new eXterm.UI.Controls.VersionIndicator();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(692, 20);
			this.panel1.TabIndex = 1;
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
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 498);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(692, 10);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(682, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 478);
			this.panel3.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 20);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 478);
			this.panel4.TabIndex = 4;
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
			// panel5
			// 
			this.panel5.Controls.Add(this.btnClose);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(669, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(23, 20);
			this.panel5.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.versionIndicator1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(295, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(374, 20);
			this.panel6.TabIndex = 4;
			// 
			// versionIndicator1
			// 
			this.versionIndicator1.BackColor = System.Drawing.Color.Black;
			this.versionIndicator1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.versionIndicator1.ForeColor = System.Drawing.Color.White;
			this.versionIndicator1.Location = new System.Drawing.Point(0, 0);
			this.versionIndicator1.Name = "versionIndicator1";
			this.versionIndicator1.Size = new System.Drawing.Size(374, 20);
			this.versionIndicator1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 508);
			this.Controls.Add(this.ctlCalendar);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private eXterm.UI.Controls.Basic.PupupButton btnClose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private eXterm.UI.Controls.CalendarControl ctlCalendar;
		private System.Windows.Forms.Panel panel6;
		private eXterm.UI.Controls.VersionIndicator versionIndicator1;
		private System.Windows.Forms.Panel panel5;

	}
}