using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Data.Model;

namespace eXterm.UI.Controls
{
	public interface IDayView : IComparable
	{
		event EventHandler Load;

		TermViewCollection TermViews { get; set; }
		DateTime Day { get; set; }

		int Height { get; set; }
		int Width { get; set; }
		Point Location { get; set; }

		int PreferedTermHeight { get; }
		int PreferedTermWidth { get; }

		void AddTermView (ITermView termView);
		void RemoveTermView(ITermView termView);

		void AddTermViews(TermViewCollection termViews);
		void RemoveTermViews();

		ITermView CreateTermView(Term term);
	}
}
