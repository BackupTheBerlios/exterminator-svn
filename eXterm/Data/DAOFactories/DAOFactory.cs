using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.DAO;
using eXterm.Data.DBUtils;
using eXterm.Settings;

namespace eXterm.Data.DAOFactories
{
	public abstract class DAOFactory
	{
		public static DAOFactory CreateDAOFactory()
		{
			switch (Setup.DBType)
			{
				case DBType.Sqlite:
					return new SqliteDAOFactory ();
			}

			return null;
		}

		public abstract ITermDAO CreateTermDAO();

		public abstract ISettingDAO CreateSettingsDAO();

		public abstract Starter CreateStarter();
	}
}
