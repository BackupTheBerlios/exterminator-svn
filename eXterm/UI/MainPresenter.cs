using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Data.BO;

namespace eXterm.UI
{
	public class MainPresenter
	{
		private IMainView mainView;

		public MainPresenter(IMainView mainView)
		{
			this.mainView = mainView;

			SubscribeToEvents();
		}

		private void SubscribeToEvents()
		{
			mainView.Load += new EventHandler(OnViewLoad);
			mainView.CloseClick += new EventHandler(OnViewCloseClick);
		}

		private void OnViewLoad(object sender, EventArgs e)
		{
			if (!EXterm.InDesignerMode)
			{
				SettingsBO settings = new SettingsBO();

				mainView.Location = new Point(
					settings.XPosition,
					settings.YPosition
					);
			}
		}

		private void OnViewCloseClick(object sender, EventArgs e)
		{
			new SettingsBO().SavePosition(mainView.Location.X, mainView.Location.Y);

			mainView.Hide ();
		}
	}
}
