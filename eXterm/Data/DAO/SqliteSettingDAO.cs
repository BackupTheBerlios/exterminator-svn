using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using eXterm.Data.Model;

namespace eXterm.Data.DAO
{
	public class SqliteSettingDAO : ISettingDAO
	{
		public IList<Setting> LoadAll()
		{
			DataTable tableTemplate = new DataTable();
			tableTemplate.Columns.Add(new DataColumn("name", Type.GetType("System.String")));
			tableTemplate.Columns.Add(new DataColumn("value", Type.GetType("System.String")));

			EXterm.DbConnection.Lock();

			DataTable settingsTable = EXterm.DbConnection.ExecuteQuery(
				"SELECT Name, Value FROM Settings",
				tableTemplate
				);

			EXterm.DbConnection.Unlock();

			IList<Setting> settings = new List<Setting>(settingsTable.Rows.Count);

			foreach (DataRow row in settingsTable.Rows)
			{
				Setting s = CreateValidSetting(row["Name"], row["Value"]);

				if (s != null)
					settings.Add(s);
			}

			return settings;
		}

		public Setting Load(string name)
		{
			#region Checking prerequisities
			if (name == null)
				throw new ArgumentException("name");
			#endregion

			DataTable tableTemplate = new DataTable();
			tableTemplate.Columns.Add(new DataColumn("value", Type.GetType("System.String")));

			EXterm.DbConnection.Lock();

			DataTable settingTable = EXterm.DbConnection.ExecuteQuery(
				"SELECT Value FROM Setting WHERE Name = '" + name + "'",
				tableTemplate
				);

			EXterm.DbConnection.Unlock();

			if (settingTable.Rows.Count <= 0)
				return null;

			return CreateValidSetting(name, settingTable.Rows[0]["Value"]);
		}

		public void Insert(Setting setting)
		{
			#region Checking prerequisities
			if (setting == null)
				throw new ArgumentNullException("setting");

			if (setting.Name == null)
				throw new ArgumentException("setting.Name");

			if (setting.Value == null)
				throw new ArgumentException("setting.Name");
			#endregion

			EXterm.DbConnection.Lock();
			EXterm.DbConnection.ExecuteNonQuery(
				"INSERT INTO Setting (" +
				"'Name', 'Value'" +
				") VALUES (" +
				"'" + setting.Name + "', " +
				"'" + setting.Value + "' " +
				")"
				);

			setting.Dirty = false;
			EXterm.DbConnection.Unlock();
		}

		public void Update(Setting setting)
		{
			#region Checking prerequisities
			if (setting == null)
				throw new ArgumentNullException("setting");

			if (setting.Name == null)
				throw new ArgumentException("setting.Name");

			if (setting.Value == null)
				throw new ArgumentException("setting.Name");
			#endregion

			if (!setting.Dirty)
				return;

			EXterm.DbConnection.Lock();

			EXterm.DbConnection.ExecuteNonQuery(
				"UPDATE Setting SET " +
				"Value = '" + setting.Value + "' " +
				"WHERE Name = '" + setting.Name + "' "
				);

			EXterm.DbConnection.Unlock();

			setting.Dirty = false;
		}

		public void PerformStartup()
		{
			EXterm.DbConnection.Lock();

			if (!SettingTableExist())
				CreateTable();

			EXterm.DbConnection.Lock();
		}

		private Setting CreateValidSetting(object name, object value)
		{
			if (name == null)
				return null;

			return new Setting (name.ToString (), (value == null) ? String.Empty : value.ToString());
		}

		private bool SettingTableExist()
		{
			DataTable tableTemplate = new DataTable();
			tableTemplate.Columns.Add(new DataColumn("name", Type.GetType("System.String")));

			EXterm.DbConnection.Lock();

			DataTable table = EXterm.DbConnection.ExecuteQuery(
				"SELECT name FROM sqlite_master WHERE type='table' AND name='Setting';",
				tableTemplate
			);

			EXterm.DbConnection.Unlock();

			return table.Rows.Count >= 1;
		}

		private void CreateTable()
		{
			EXterm.DbConnection.ExecuteNonQuery(
				"CREATE TABLE Setting (Name TEXT PRIMARY KEY, Value TEXT)"
			);
		}
	}
}
