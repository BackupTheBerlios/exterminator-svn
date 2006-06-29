using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using eXterm.Data.Connections;
using eXterm.Data.DBUtils;
using eXterm.Settings;
using eXterm.UI;

namespace eXterm
{
	static class EXterm
	{
		private static Connection dbConnection = null;

		public static Connection DbConnection
		{
			get { return dbConnection; }
		}

		public static bool InDesignerMode
		{
			get { return DbConnection == null; }
		}

		public static Version Version
		{
			get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; }
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			PerformDatabaseStartup();

			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private static void PerformDatabaseStartup ()
		{
			// Creating file if necessary
			if (!File.Exists(Setup.DBSqliteFilename))
			{
				FileStream file = File.Create(Setup.DBSqliteFilename);
				file.Close();
			}

			dbConnection = Connection.CreateConnection(Setup.ConnectionString);
			dbConnection.Connect();
			dbConnection.PerformStartup();
		}
	}
}