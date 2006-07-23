using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace eXterm.UI
{
	public class FormBase : Form
	{
		private int lastMouseXPos = 0;
		private int lastMouseYPos = 0;
		private bool mouseIsDown = false;

		protected const int GWL_EXSTYLE = (-20);
		protected const int WS_EX_TOOLWINDOW = 0x80;
		protected const int WS_EX_APPWINDOW = 0x40000;

		public FormBase()
		{
			DoubleBuffered = true;
			this.Activated += new EventHandler(OnActivated);
			this.MouseDown += new MouseEventHandler(OnMouseDown);
			this.MouseUp += new MouseEventHandler(OnMouseUp);
			this.MouseMove += new MouseEventHandler(OnMouseMove);
		}

		protected void SetupMovingAreas(Control[] controls)
		{
			if (controls != null)
			{
				foreach (Control control in controls)
				{
					control.MouseDown += new MouseEventHandler(OnMouseDown);
					control.MouseUp += new MouseEventHandler(OnMouseUp);
					control.MouseMove += new MouseEventHandler(OnMouseMove);
				}
			}
		}

		[DllImport("user32", CharSet = CharSet.Auto)]
		protected static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32", CharSet = CharSet.Auto)]
		protected static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		void OnActivated(object sender, EventArgs e)
		{
			SetWindowLong(
				this.Handle,
				GWL_EXSTYLE,
				(GetWindowLong(this.Handle, GWL_EXSTYLE) | WS_EX_TOOLWINDOW) & ~WS_EX_APPWINDOW
				);
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
