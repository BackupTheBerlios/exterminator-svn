using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace eXterm.UI.Controls
{
	public partial class CalendarControl : ControlBase, ICalendarView
	{
		private DateTime focusedDate = DateTime.Now;
		private DayViewCollection dayViews = new DayViewCollection ();

		public CalendarControl()
		{
			InitializeComponent();
			SetupStyle();

			new CalendarPresenter(this);
		}

		#region ICalendarView Members

		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		[Browsable (false)]
		public DateTime FocusedDay
		{
			get { return focusedDate.Date; }
			set { focusedDate = value.Date; }
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DayViewCollection DayViews
		{
			get { return dayViews; }
		}

		public int PreferedDayWidth
		{
			get { return pnlDays.Width / 7; }
		}

		public int PreferedDayHeight
		{
			get { return pnlDays.Height / 4; }
		}

		public void AddDayView(IDayView dayView)
		{
			if ((dayView is Control) && (!pnlDays.Controls.Contains((Control)dayView)))
				pnlDays.Controls.Add((Control)dayView);
		}

		public void RemoveDayView(IDayView dayView)
		{
			if ((dayView is Control) && (pnlDays.Controls.Contains((Control)dayView)))
				pnlDays.Controls.Remove((Control)dayView);
		}

		public void AddDayViews(DayViewCollection dayViews)
		{
			foreach (IDayView dayView in dayViews)
				AddDayView(dayView);
		}

		public void RemoveDayViews()
		{
			pnlDays.Controls.Clear();
		}


		public IDayView CreateDayView(DateTime day)
		{
			return new DayControl(day);
		}

		#endregion
	}
}
