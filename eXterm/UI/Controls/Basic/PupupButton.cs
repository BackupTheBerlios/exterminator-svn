using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace eXterm.UI.Controls.Basic
{
	public partial class PupupButton : ControlBase
	{
		public new event EventHandler Click;

		public PupupButton()
		{
			InitializeComponent();
			SetupStyle();
		}

		[Browsable (true)]
		[Category ("Data")]
		public string BtnText
		{
			get { return btnButton.Text; }
			set { btnButton.Text = value; }
		}

		public Image Image
		{
			get
			{
				return btnButton.Image;
			}
			set
			{
				btnButton.Image = value;
			}
		}

		private void btnButton_Click(object sender, EventArgs e)
		{
			if (Click != null)
				Click(sender, e);
		}

		private void btnButton_MouseHover(object sender, EventArgs e)
		{
			btnButton.ForeColor = Color.White;
		}
	}
}
