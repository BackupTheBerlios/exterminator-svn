using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.UI
{
	class EditTermPresenter
	{
		IEditTermView editTermView;

		public EditTermPresenter(IEditTermView editTermView)
		{
			this.editTermView = editTermView;

			SubscribeToEvents();
		}

		private void SubscribeToEvents()
		{
			editTermView.Load += new EventHandler(OnViewLoad);
		}

		void OnViewLoad(object sender, EventArgs e)
		{
			if (editTermView.Term == null)
			{
				editTermView.Term = new Term();
			}
		}
	}
}
