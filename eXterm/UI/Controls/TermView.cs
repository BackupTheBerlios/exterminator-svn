using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.UI.Controls
{
	public interface ITermView
	{
		Term Term { get; set; }

		string DateLbl { get; set; }
		string TextLbl { get; set; }
	}
}
