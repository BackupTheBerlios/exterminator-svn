using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.DAO;
using eXterm.Data.DBUtils;

namespace eXterm.Data.DAOFactories
{
	public class SqliteDAOFactory : DAOFactory
	{
		public SqliteDAOFactory()
		{
		}

		public override ITermDAO CreateTermDAO()
		{
			return new SqliteTermDAO();
		}

		public override ISettingDAO CreateSettingsDAO()
		{
			return new SqliteSettingDAO();
		}

		public override Starter CreateStarter()
		{
			return new SqliteStarter();
		}
	}
}
