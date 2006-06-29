using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using eXterm.Settings;

namespace eXterm.UI.Controls
{
	public class ControlBase : UserControl
	{
		protected void SetupStyle()
		{
			BackColor = Setup.DefaultBackgroundColor;
			ForeColor = Setup.DefaultForegroundColor;
		}
	}
}
