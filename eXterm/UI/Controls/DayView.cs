using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Data.Model;

namespace eXterm.UI.Controls
{
	public interface IDayView : IComparable
	{
		IList<Term> Terms { get; set; }
		DateTime Day { get; set; }

		int Height { get; set; }
		int Width { get; set; }
		Point Location { get; set; }		

		void AddTermView (ITermView termView);
		void RemoveTermView(ITermView termView);
	}
}
