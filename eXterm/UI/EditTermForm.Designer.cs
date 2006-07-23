namespace eXterm.UI
{
	partial class EditTermForm
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
			this.pupupButton1 = new eXterm.UI.Controls.Basic.PupupButton();
			this.pupupButton2 = new eXterm.UI.Controls.Basic.PupupButton();
			this.SuspendLayout();
			// 
			// pupupButton1
			// 
			this.pupupButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pupupButton1.BackColor = System.Drawing.Color.Black;
			this.pupupButton1.BtnText = "Cancel";
			this.pupupButton1.ForeColor = System.Drawing.Color.White;
			this.pupupButton1.Image = null;
			this.pupupButton1.Location = new System.Drawing.Point(151, 179);
			this.pupupButton1.Margin = new System.Windows.Forms.Padding(0);
			this.pupupButton1.Name = "pupupButton1";
			this.pupupButton1.Size = new System.Drawing.Size(123, 21);
			this.pupupButton1.TabIndex = 0;
			// 
			// pupupButton2
			// 
			this.pupupButton2.BackColor = System.Drawing.Color.Black;
			this.pupupButton2.BtnText = "OK";
			this.pupupButton2.ForeColor = System.Drawing.Color.White;
			this.pupupButton2.Image = null;
			this.pupupButton2.Location = new System.Drawing.Point(9, 179);
			this.pupupButton2.Margin = new System.Windows.Forms.Padding(0);
			this.pupupButton2.Name = "pupupButton2";
			this.pupupButton2.Size = new System.Drawing.Size(123, 21);
			this.pupupButton2.TabIndex = 1;
			// 
			// EditTermForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 209);
			this.Controls.Add(this.pupupButton2);
			this.Controls.Add(this.pupupButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EditTermForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "EditTermForm";
			this.ResumeLayout(false);

		}

		#endregion

		private eXterm.UI.Controls.Basic.PupupButton pupupButton1;
		private eXterm.UI.Controls.Basic.PupupButton pupupButton2;
	}
}