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

		void OnViewLoad(object sender, EventArgs e)
		{
			if (!EXterm.InDesignerMode)
			{
				SettingsBO settings = new SettingsBO(
					EXterm.DbConnection.CreateDAOFactory().CreateSettingsDAO()
				);

				mainView.Location = new Point(
					settings.XPosition,
					settings.YPosition
					);
			}
		}

		void OnViewCloseClick(object sender, EventArgs e)
		{
			SettingsBO settings = new SettingsBO(
					EXterm.DbConnection.CreateDAOFactory().CreateSettingsDAO()
				);
			settings.XPosition = mainView.Location.X;
			settings.YPosition = mainView.Location.Y;
			mainView.Close ();
		}
	}
}
