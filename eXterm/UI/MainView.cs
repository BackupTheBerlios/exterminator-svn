using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.UI.Controls;

namespace eXterm.UI
{
	public interface IMainView
	{
		event EventHandler Load;
		event EventHandler CloseClick;

		ICalendarView CalendarView { get; }
		Point Location { get; set; }

		void Close();
	}
}
