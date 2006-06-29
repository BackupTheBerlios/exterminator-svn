using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;
using eXterm.Data.DAO;
using eXterm.Settings;
using eXterm.Utils;

namespace eXterm.Data.BO
{
	public class SettingsBO
	{
		private ISettingDAO settingsDAO = null;

		public SettingsBO()
		{
			settingsDAO = EXterm.DbConnection.CreateDAOFactory().CreateSettingsDAO();
		}

		public SettingsBO(ISettingDAO settingsDAO)
		{
			this.settingsDAO = settingsDAO;
		}

		public int XPosition
		{
			get
			{
				Setting setting = settingsDAO.Load("XPosition");
				if (setting == null)
					return Setup.DefaultXPosition;
				return ConversionUtils.GetInt(
					setting.Value,
					Setup.DefaultXPosition
				);
			}

			set
			{
				Setting currentSetting = settingsDAO.Load("XPosition");
				if (currentSetting == null)
				{
					Setting xPositionSetting = new Setting("XPosition", value.ToString());
					settingsDAO.Insert(xPositionSetting);
					return;
				}

				currentSetting.Value = value.ToString();
				settingsDAO.Update(currentSetting);
			}
		}

		public int YPosition
		{
			get
			{
				Setting setting = settingsDAO.Load("YPosition");
				if (setting == null)
					return Setup.DefaultYPosition;
				return ConversionUtils.GetInt(
					setting.Value,
					Setup.DefaultYPosition
				);
			}

			set
			{
				Setting currentSetting = settingsDAO.Load("YPosition");
				if (currentSetting == null)
				{
					Setting yPositionSetting = new Setting("YPosition", value.ToString());
					settingsDAO.Insert(yPositionSetting);
					return;
				}

				currentSetting.Value = value.ToString();
				settingsDAO.Update(currentSetting);
			}
		}
	}
}
