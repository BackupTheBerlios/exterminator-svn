using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Utils;

namespace eXterm.UI.Controls
{
	public class CalendarPresenter
	{
		ICalendarView calendarView;

		public CalendarPresenter(ICalendarView calendarView)
		{
			this.calendarView = calendarView;

			SubscribeToEvents();
		}

		private void SubscribeToEvents()
		{
			calendarView.Load += new EventHandler(OnViewLoad);
		}

		void OnViewLoad(object sender, EventArgs e)
		{
			// A hack because of bug in VS designer
			if (!EXterm.InDesignerMode)
			{
				calendarView.FocusedDay = DateTime.Now;
				UpdateCalendar();
			}
		}

		private void UpdateCalendar ()
		{
			CreateDayViews();
			ArrangeDayViewPositions();
			DisplayDayViews();
		}

		private void CreateDayViews()
		{
			DateTime begin =
				DateTimeUtils.GetBeginningOfWeek(calendarView.FocusedDay) - DateTimeUtils.OneWeek;

			DateTime end =
				DateTimeUtils.GetBeginningOfWeek(calendarView.FocusedDay) + DateTimeUtils.ThreeWeeks;

			DateTime cur = begin;

			while (cur <= end)
			{
				if (calendarView.DayViews.Contains(cur))
					continue;

				calendarView.DayViews.Add(
					calendarView.CreateDayView (cur)
					);

				cur = cur.AddDays(1);
			}
		}

		private void ArrangeDayViewPositions()
		{
			calendarView.DayViews.Sort();

			int dayNumber = 0;

			foreach (IDayView dayView in calendarView.DayViews)
			{
				dayView.Location = new Point(
					(dayNumber % 7) * calendarView.PreferedDayWidth,
					(dayNumber / 7) * calendarView.PreferedDayHeight);

				dayView.Width = calendarView.PreferedDayWidth;
				dayView.Height = calendarView.PreferedDayHeight;

				dayNumber++;
			}
		}

		private void DisplayDayViews()
		{
			calendarView.RemoveDayViews();
			calendarView.AddDayViews(calendarView.DayViews);
		}
	}
}
