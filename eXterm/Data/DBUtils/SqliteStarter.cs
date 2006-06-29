using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.DAOFactories;
using eXterm.Data.DAO;

namespace eXterm.Data.DBUtils
{
	public class SqliteStarter : Starter
	{

		public SqliteStarter()
		{
		}

		public void PerformStartup()
		{
			SqliteDAOFactory daoFactory = new SqliteDAOFactory();
			{
				ISettingDAO settingsDAO = daoFactory.CreateSettingsDAO();
				settingsDAO.PerformStartup();
			}
			{
				ITermDAO termDAO = daoFactory.CreateTermDAO();
				termDAO.PerformStartup();
			}
		}
	}
}
