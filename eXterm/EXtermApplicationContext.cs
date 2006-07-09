using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

using eXterm.Utils;
using eXterm.UI;
using eXterm.Data.DAO;
using eXterm.Data.BO;

namespace eXterm
{
	class EXtermApplicationContext: ApplicationContext
	{
		private IMainView mainView;
		private IContainer components;
		private NotifyIcon icnNotify;
		private ContextMenu mnuNotifyMenu;
		private MenuItem mnuiExit;
		private MenuItem mnuiShow;

		public EXtermApplicationContext(IMainView mainView)
		{
			this.mainView = mainView;
			InitializeContext();
			mainView.Show();
		}

		private void InitializeContext ()
		{
			components = new Container();

			// Menu item: Show
			mnuiShow = new MenuItem("&Show");
			mnuiShow.Index = 0;
			mnuiShow.Click += new EventHandler(OnMenuShowClick);

			// Menu item: Exit
			mnuiExit = new MenuItem("&Exit");
			mnuiExit.Index = 9;
			mnuiExit.Click += new EventHandler(OnMenuExitClick);

			// Menu
			mnuNotifyMenu = new ContextMenu(
				new MenuItem[] {
					mnuiShow,
					mnuiExit
				}
				);

			// Notify icon
			icnNotify = new NotifyIcon(components);
			icnNotify.Visible = true;
			icnNotify.Icon = ImageUtils.NotifyIcon;
			icnNotify.ContextMenu = mnuNotifyMenu;
			icnNotify.DoubleClick += new EventHandler(OnNotifyIconDoubleClick);
		}

		private void ToggleShowHide()
		{
			if (mainView.Shown)
			{
				mainView.Hide();
			}
			else
			{
				mainView.Hide();
				mainView.Show();
			}
		}

		private void OnNotifyIconDoubleClick(object sender, EventArgs e)
		{
			mainView.Hide();
			mainView.Show();
		}

		private void OnMenuShowClick(object sender, EventArgs e)
		{
			mainView.Hide();
			mainView.Show();
		}

		private void OnMenuExitClick(object sender, EventArgs e)
		{
			new SettingsBO().SavePosition(mainView.Location.X, mainView.Location.Y);
			mainView.Close();
			ExitThread();
		}
	}
}
