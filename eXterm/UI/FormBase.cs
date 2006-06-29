using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace eXterm.UI
{
	public class FormBase : Form
	{
		private int lastMouseXPos = 0;
		private int lastMouseYPos = 0;
		private bool mouseIsDown = false;

		public FormBase()
		{
			this.MouseDown += new MouseEventHandler(OnMouseDown);
			this.MouseUp += new MouseEventHandler(OnMouseUp);
			this.MouseMove += new MouseEventHandler(OnMouseMove);
		}

		protected void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (mouseIsDown)
			{
				Left += e.X - lastMouseXPos;
				Top += e.Y - lastMouseYPos;
			}
		}

		protected void OnMouseUp(object sender, MouseEventArgs e)
		{
			mouseIsDown = false;
			lastMouseXPos = 0;
			lastMouseYPos = 0;
		}

		protected void OnMouseDown(object sender, MouseEventArgs e)
		{
			mouseIsDown = true;
			lastMouseXPos = e.X;
			lastMouseYPos = e.Y;
		}

		protected void SetupStyle()
		{
			this.BackColor = Settings.Setup.DefaultBackgroundColor;
			this.ForeColor = Settings.Setup.DefaultForegroundColor;
		}
	}
}
