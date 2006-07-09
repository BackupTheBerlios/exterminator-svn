namespace eXterm.UI.Controls
{
	partial class VersionIndicator
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
			this.lblVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblVersion
			// 
			this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblVersion.Location = new System.Drawing.Point(0, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(305, 31);
			this.lblVersion.TabIndex = 0;
			this.lblVersion.Text = "version";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// VersionIndicator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblVersion);
			this.Name = "VersionIndicator";
			this.Size = new System.Drawing.Size(305, 31);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblVersion;
	}
}
