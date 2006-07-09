using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace eXterm.UI.Controls
{
	public partial class VersionIndicator : ControlBase
	{
		public VersionIndicator()
		{
			InitializeComponent();
			SetupStyle();

			SetVersion();
		}

		private void SetVersion()
		{
			Version version = EXterm.Version;
			lblVersion.Text = string.Format("eXterminator {0}.{1}.{2}.{3}",
				version.Major,
				version.Minor,
				version.Build,
				version.Revision);
		}
	}
}
