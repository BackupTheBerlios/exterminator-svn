using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using eXterm.UI.Controls;

namespace eXterm.UI
{
	public partial class MainForm : FormBase, IMainView
	{
		public MainForm()
		{
			InitializeComponent();
			SetupStyle();

			new MainPresenter(this);
		}

		#region IMainView Members

		public event EventHandler CloseClick;

		public ICalendarView CalendarView
		{
			get { return ctlCalendar; }
		}

		public new void Close()
		{
			base.Close();
		}

		/*public new Point Location
		{
			get { return base.Location; }
			set { base.Location = value; }
		}*/

		#endregion

		private void btnClose_OnClick(object sender, EventArgs e)
		{
			if (CloseClick != null)
				CloseClick(sender, e);
		}
	}
}