using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Drawing;

using eXterm.Data;
using eXterm.Utils;

namespace eXterm.Settings
{
	public class Setup
	{
		public static string GetString(SetupItem setupItem)
		{
			return SetupResources.ResourceManager.GetString(setupItem.ToString());
		}

		public static DBType DBType
		{
			get
			{
				string dbTypeStr = GetString(SetupItem.DBType);

				if ((dbTypeStr == null) || (dbTypeStr.Length <= 0))
					return DBType.Unknown;

				int dbType = -1;

				try
				{
					dbType = int.Parse(dbTypeStr);
				}
				catch (FormatException)
				{
					dbType = -1;
				}

				if (!Enum.IsDefined(typeof(DBType), dbType))
					return DBType.Unknown;

				return (DBType)dbType;
			}
		}

		public static string ConnectionString
		{
			get
			{
				switch (DBType)
				{
					case DBType.Sqlite:
						return "Data Source=" + GetString(SetupItem.DBSqliteFilename) + ";Version=3;New=False;Compress=False;";
				}
				return String.Empty;
			}
		}

		public static string DBSqliteFilename
		{
			get
			{
				return GetString(SetupItem.DBSqliteFilename);
			}
		}

		public static Color DefaultBackgroundColor
		{
			get { return GetColor(SetupItem.DefaultBackgroundColor, Color.Black); }
		}

		public static Color DefaultForegroundColor
		{
			get { return GetColor(SetupItem.DefaultForegroundColor, Color.White); }
		}

		public static Color DefaultHoverColor
		{
			get { return GetColor(SetupItem.DefaultHoverColor, Color.DarkGray); }
		}

		public static int DefaultXPosition
		{
			get { return GetInt(SetupItem.DefaultXPosition, 100); }
		}

		public static int DefaultYPosition
		{
			get { return GetInt(SetupItem.DefaultYPosition, 100); }
		}

		private static Color GetColor(SetupItem item, Color defaultColor)
		{
			return ConversionUtils.GetColor(GetString(item), defaultColor);
		}

		private static int GetInt(SetupItem item, int defaultInt)
		{
			return ConversionUtils.GetInt(GetString(item), defaultInt);
		}
	}

	public enum SetupItem
	{
		DBType,
		DBSqliteFilename,
		DefaultBackgroundColor,
		DefaultForegroundColor,
		DefaultHoverColor,
		DefaultXPosition,
		DefaultYPosition
	}
}
