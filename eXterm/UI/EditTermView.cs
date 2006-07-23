using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.UI
{
	public interface IEditTermView
	{
		Term Term { get; set; }

		event EventHandler Load;

		void Show();
	}
}
