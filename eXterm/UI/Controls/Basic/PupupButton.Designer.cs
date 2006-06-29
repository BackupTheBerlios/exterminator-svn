namespace eXterm.UI.Controls.Basic
{
	partial class PupupButton
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
			this.btnButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnButton
			// 
			this.btnButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnButton.Location = new System.Drawing.Point(0, 0);
			this.btnButton.Name = "btnButton";
			this.btnButton.Size = new System.Drawing.Size(149, 46);
			this.btnButton.TabIndex = 0;
			this.btnButton.UseVisualStyleBackColor = true;
			this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
			this.btnButton.MouseHover += new System.EventHandler(this.btnButton_MouseHover);
			// 
			// PupupButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnButton);
			this.Name = "PupupButton";
			this.Size = new System.Drawing.Size(149, 46);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnButton;
	}
}
