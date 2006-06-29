using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using eXterm.Data.DAOFactories;
using eXterm.Data.DBUtils;
using Finisar.SQLite;

namespace eXterm.Data.Connections
{
	public class SqliteConnection : Connection
	{
		private string connectionString = String.Empty;
		private SQLiteConnection connection = null;

		public SqliteConnection(string connectionString)
		{
			if (connectionString == null)
				this.connectionString = String.Empty;
			else
				this.connectionString = connectionString;
		}

		#region Connection Members

		public override void Connect()
		{
			connection = new SQLiteConnection(connectionString);
			connection.Open();
		}

		public override void ExecuteNonQuery(string query)
		{
			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = query;
			command.ExecuteNonQuery();
		}

		public override IDataReader ExecuteQuery(string query)
		{
			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = query;
			return command.ExecuteReader();
		}

		public override DataTable ExecuteQuery(string query, DataTable tableTemplate)
		{
			IDataReader dataReader = ExecuteQuery (query);

			DataTable resultTable = new DataTable();

			foreach (DataColumn column in tableTemplate.Columns)
				resultTable.Columns.Add(column.ColumnName, column.DataType);

			while (dataReader.Read())
			{
				DataRow row = resultTable.NewRow();
				foreach (DataColumn column in resultTable.Columns)
				{
					if (dataReader[column.ColumnName] != DBNull.Value)
						row[column] = Convert.ChangeType(dataReader[column.ColumnName], column.DataType);
				}
				resultTable.Rows.Add(row);
			}

			return resultTable;
		}

		public override DAOFactory CreateDAOFactory()
		{
			return new SqliteDAOFactory();
		}

		public override void PerformStartup()
		{
			Starter starter = new SqliteStarter();
			starter.PerformStartup();
		}

		public override long LastInsertId
		{
			get
			{
				IDataReader dr = ExecuteQuery("SELECT last_insert_rowid()");
				if (dr.FieldCount <= 0)
					return 0;

				dr.Read();

				long lastInsertId = 0;
				try
				{
					lastInsertId = long.Parse(dr[0].ToString());
				}
				catch (FormatException e)
				{
					lastInsertId = 0;
				}
				return lastInsertId;
			}
		}


		#endregion
	}
}
