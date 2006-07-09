using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Utils;

namespace eXterm.UI.Controls
{
	class TermPresenter
	{
		ITermView termView;

		public TermPresenter(ITermView termView)
		{
			this.termView = termView;

			SubscribeToEvents();

			termView.HourLbl = DateTimeUtils.GetHourMinuteStr(termView.Term.Date);
			termView.TextLbl = termView.Term.Text;
		}

		private void SubscribeToEvents()
		{
		}

		private void Initialize()
		{
		}
	}
}
