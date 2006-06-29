using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using eXterm.Data.Model;

namespace eXterm.Data.DAO
{
	public class SqliteTermDAO : ITermDAO
	{
		public IList<Term> LoadAll ()
		{
			DataTable termTableTemplate = new DataTable();
			termTableTemplate.Columns.Add(new DataColumn("Id"));
			termTableTemplate.Columns.Add(new DataColumn("Date"));
			termTableTemplate.Columns.Add(new DataColumn("Text"));

			EXterm.DbConnection.Lock();

			DataTable termsTable = EXterm.DbConnection.ExecuteQuery(
				"SELECT * FROM Term",
				termTableTemplate
			);

			EXterm.DbConnection.Unlock();

			IList<Term> terms = new List<Term>(termsTable.Rows.Count);

			foreach (DataRow row in termsTable.Rows)
			{
				Term t = CreateValidTerm(row["Id"], row["Date"], row["Text"]);

				if (t != null)
					terms.Add(t);
			}

			return terms;
		}

		public bool Insert(Term term)
		{
			EXterm.DbConnection.Lock();
			EXterm.DbConnection.ExecuteNonQuery (
				"INSERT INTO Term (" +
				"'Id', 'Date', 'Text'" +
				") VALUES (" +
				"NULL, '" +
				Utils.DateTimeUtils.GetSeconds(term.Date) + "', '" +
				term.Text + "'" +
				")"
				);

			term.Id = EXterm.DbConnection.LastInsertId;
			term.Dirty = false;
			EXterm.DbConnection.Unlock();

			return true;
		}

		public bool Update(Term term)
		{
			if (!term.Dirty)
				return true;

			EXterm.DbConnection.Lock();

			EXterm.DbConnection.ExecuteNonQuery(
				"UPDATE Term SET " +
				"'Date' = " + Utils.DateTimeUtils.GetSeconds(term.Date) + ", " +
				"'Text' = '" + term.Text + "' " +
				"WHERE 'Id' = " + term.Id
				);

			EXterm.DbConnection.Unlock();
			
			term.Dirty = false;
			return true;
		}

		public bool Delete(Term term)
		{
			EXterm.DbConnection.Lock();

			EXterm.DbConnection.ExecuteNonQuery(
				"DELETE FROM Term WHERE " +
				"WHERE 'Id' = " + term.Id
				);

			EXterm.DbConnection.Unlock();

			return true;
		}

		public void PerformStartup ()
		{
			EXterm.DbConnection.Lock();

			if (!SettingsTableExist())
				CreateTable();

			EXterm.DbConnection.Unlock();
		}

		private bool SettingsTableExist()
		{
			DataTable tableTemplate = new DataTable();
			tableTemplate.Columns.Add(new DataColumn("name", Type.GetType("System.String")));

			DataTable table = EXterm.DbConnection.ExecuteQuery(
				"SELECT name FROM sqlite_master WHERE type='table' AND name='Term';",
				tableTemplate
			);

			return table.Rows.Count >= 1;
		}

		private void CreateTable()
		{
			EXterm.DbConnection.ExecuteNonQuery(
				"CREATE TABLE Term (" +
				"Id INTEGER PRIMARY KEY, " +
				"Date INTEGER, " +
				"Text TEXT" +
				")"
			);
		}

		private static Term CreateValidTerm(object id, object date, object text)
		{
			long validId = 0;
			DateTime validDate = DateTime.MinValue;
			string validText = String.Empty;

			if ((id != null) && (id != DBNull.Value))
				validId = long.Parse(id.ToString());
			else
				return null;

			if ((date != null) && (date != DBNull.Value))
				validDate = Utils.DateTimeUtils.GetDate (long.Parse(date.ToString()));
			else
				return null;

			if ((text != null) && (text != DBNull.Value))
				validText = text.ToString();

			Term t = new Term(validDate, validText);
			t.Id = validId;

			return t;
		}
	}
}
