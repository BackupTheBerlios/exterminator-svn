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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDeleteTerm = new eXterm.UI.Controls.Basic.PupupButton();
			this.btnEditTerm = new eXterm.UI.Controls.Basic.PupupButton();
			this.lblHour = new System.Windows.Forms.Label();
			this.lblText = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDeleteTerm);
			this.panel1.Controls.Add(this.btnEditTerm);
			this.panel1.Controls.Add(this.lblHour);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(194, 16);
			this.panel1.TabIndex = 4;
			// 
			// btnDeleteTerm
			// 
			this.btnDeleteTerm.BackColor = System.Drawing.Color.Black;
			this.btnDeleteTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDeleteTerm.BtnText = "";
			this.btnDeleteTerm.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnDeleteTerm.ForeColor = System.Drawing.Color.White;
			this.btnDeleteTerm.Image = null;
			this.btnDeleteTerm.Location = new System.Drawing.Point(42, 0);
			this.btnDeleteTerm.Margin = new System.Windows.Forms.Padding(0);
			this.btnDeleteTerm.Name = "btnDeleteTerm";
			this.btnDeleteTerm.Size = new System.Drawing.Size(16, 16);
			this.btnDeleteTerm.TabIndex = 7;
			// 
			// btnEditTerm
			// 
			this.btnEditTerm.BackColor = System.Drawing.Color.Black;
			this.btnEditTerm.BtnText = "";
			this.btnEditTerm.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnEditTerm.ForeColor = System.Drawing.Color.White;
			this.btnEditTerm.Image = null;
			this.btnEditTerm.Location = new System.Drawing.Point(28, 0);
			this.btnEditTerm.Margin = new System.Windows.Forms.Padding(0);
			this.btnEditTerm.Name = "btnEditTerm";
			this.btnEditTerm.Size = new System.Drawing.Size(14, 16);
			this.btnEditTerm.TabIndex = 6;
			// 
			// lblHour
			// 
			this.lblHour.AutoSize = true;
			this.lblHour.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblHour.Location = new System.Drawing.Point(0, 0);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(28, 13);
			this.lblHour.TabIndex = 4;
			this.lblHour.Text = "0:00";
			// 
			// lblText
			// 
			this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblText.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblText.Location = new System.Drawing.Point(0, 16);
			this.lblText.Multiline = true;
			this.lblText.Name = "lblText";
			this.lblText.ReadOnly = true;
			this.lblText.Size = new System.Drawing.Size(194, 53);
			this.lblText.TabIndex = 5;
			// 
			// TermControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.panel1);
			this.Name = "TermControl";
			this.Size = new System.Drawing.Size(194, 69);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.TextBox lblText;
		private eXterm.UI.Controls.Basic.PupupButton btnDeleteTerm;
		private eXterm.UI.Controls.Basic.PupupButton btnEditTerm;

	}
}
