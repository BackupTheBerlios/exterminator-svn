using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Data.Model;

namespace eXterm.UI.Controls
{
	public interface ITermView : IComparable
	{
		Term Term { get; set; }

		int Height { get; set; }
		int Width { get; set; }
		Point Location { get; set; }

		string DateLbl { get; set; }
		string TextLbl { get; set; }
	}
}
