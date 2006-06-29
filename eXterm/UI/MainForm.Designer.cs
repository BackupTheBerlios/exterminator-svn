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
			this.ctlCalendar = new eXterm.UI.Controls.CalendarControl();
			this.btnClose = new eXterm.UI.Controls.Basic.PupupButton();
			this.SuspendLayout();
			// 
			// ctlCalendar
			// 
			this.ctlCalendar.BackColor = System.Drawing.Color.Black;
			this.ctlCalendar.ForeColor = System.Drawing.Color.White;
			this.ctlCalendar.Location = new System.Drawing.Point(12, 32);
			this.ctlCalendar.Name = "ctlCalendar";
			this.ctlCalendar.Size = new System.Drawing.Size(668, 426);
			this.ctlCalendar.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.BtnText = "X";
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(664, 11);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(16, 16);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_OnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 470);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctlCalendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private eXterm.UI.Controls.CalendarControl ctlCalendar;
		private eXterm.UI.Controls.Basic.PupupButton btnClose;
	}
}