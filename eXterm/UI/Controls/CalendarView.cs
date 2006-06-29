using System;
using System.Collections.Generic;
using System.Text;

namespace eXterm.UI.Controls
{
	public interface ICalendarView
	{
		event EventHandler Load;

		DateTime FocusedDay { get; set; }
		DayViewCollection DayViews { get; }

		int PreferedDayWidth { get; }
		int PreferedDayHeight { get; }

		void AddDayView(IDayView view);
		void RemoveDayView(IDayView view);

		void AddDayViews(DayViewCollection dayViews);
		void RemoveDayViews();

		IDayView CreateDayView(DateTime day);
	}
}
