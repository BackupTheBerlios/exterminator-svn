using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading;

using eXterm.Settings;
using eXterm.Data.DAOFactories;
using eXterm.Data.DBUtils;

namespace eXterm.Data.Connections
{
	public abstract class Connection
	{
		public abstract void Connect();
		public abstract void ExecuteNonQuery(string query);
		public abstract IDataReader ExecuteQuery(string query);
		public abstract DataTable ExecuteQuery(string query, DataTable tableTemplate);
		public abstract DAOFactory CreateDAOFactory();

		public void Lock()
		{
			Monitor.Enter(this);
		}

		public void Unlock()
		{
			Monitor.Exit(this);
		}

		public static Connection CreateConnection(string connectionString)
		{
			switch (Setup.DBType)
			{
				case DBType.Sqlite:
					return new SqliteConnection(connectionString);
			}

			return null;
		}

		public abstract long LastInsertId { get; }
		public abstract void PerformStartup();
	}
}
