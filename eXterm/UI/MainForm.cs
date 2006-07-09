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
		private bool shown = false;

		public MainForm()
		{
			InitializeComponent();
			SetupStyle();
			SetupMovingAreas(
				new Control[] { pnlTop, pnlLeft, pnlBottom, pnlRight, lblVersionIndicator }
				);

			new MainPresenter(this);
		}

		#region IMainView Members

		public event EventHandler CloseClick;

		public ICalendarView CalendarView
		{
			get { return ctlCalendar; }
		}

		public new bool Shown
		{
			get { return shown; }
		}

		public new void Show()
		{
			shown = true;
			base.Show();
		}

		public new void Close()
		{
			shown = false;
			base.Close();
		}

		public new void Hide()
		{
			shown = false;
			base.Hide();
		}

		/*public new Point Location
		{
			get { return base.Location; }
			set { base.Location = value; }
		}*/

		#endregion

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (CloseClick != null)
				CloseClick(sender, e);
		}
	}
}