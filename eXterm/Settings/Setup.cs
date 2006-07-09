using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Drawing;

using eXterm.Data;
using eXterm.Utils;

namespace eXterm.Settings
{
	public static class Setup
	{
		public static string GetString(SetupItem setupItem)
		{
			return SetupResources.ResourceManager.GetString(setupItem.ToString());
		}

		public static string GetString(SetupItem setupItem, string defaultValue)
		{
			string result = SetupResources.ResourceManager.GetString(setupItem.ToString());
			if (result == null)
				return (defaultValue == null) ? string.Empty : defaultValue;

			return result;
		}

		#region Database

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

		#endregion

		#region General UI

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

		#endregion

		#region Term UI

		public static Font DefaultTermTextFont
		{
			get
			{
				return new Font(
					GetString(SetupItem.DefaultTermTextFontFamilyName, "Verdana"),
					GetFloat(SetupItem.DefaultTermTextFontSize, 10.0f),
					GetFontStyle(SetupItem.DefaultTermTextFontStyle, FontStyle.Regular),
					GetGraphicsUnit(SetupItem.DefaultTermTextFontGraphicsUnit, GraphicsUnit.Pixel)
				);
			}
		}

		public static Font DefaultTermHourFont
		{
			get
			{
				return new Font(
					GetString(SetupItem.DefaultTermHourFontFamilyName, "Verdana"),
					GetFloat(SetupItem.DefaultTermHourFontSize, 8.0f),
					GetFontStyle(SetupItem.DefaultTermHourFontStyle, FontStyle.Bold),
					GetGraphicsUnit(SetupItem.DefaultTermHourFontGraphicsUnit, GraphicsUnit.Pixel)
				);
			}
		}

		public static Color DefaultTermTextForegroundColor
		{
			get
			{
				return GetColor(SetupItem.DefaultTermTextForegroundColor, Color.White);
			}
		}

		public static Color DefaultTermHourForegroundColor
		{
			get
			{
				return GetColor(SetupItem.DefaultTermHourForegroundColor, Color.LightGray);
			}
		}

		#endregion

		#region Private methods

		private static Color GetColor(SetupItem item, Color defaultColor)
		{
			return ConversionUtils.GetColor(GetString(item), defaultColor);
		}

		private static int GetInt(SetupItem item, int defaultInt)
		{
			return ConversionUtils.GetInt(GetString(item), defaultInt);
		}

		private static float GetFloat(SetupItem item, float defaultFloat)
		{
			return ConversionUtils.GetFloat(GetString(item), defaultFloat);
		}

		private static FontStyle GetFontStyle(SetupItem item, FontStyle defaultStyle)
		{
			return ConversionUtils.GetFontStyle(GetString(item), defaultStyle);
		}

		private static GraphicsUnit GetGraphicsUnit(SetupItem item, GraphicsUnit defaultGraphicsUnit)
		{
			return ConversionUtils.GetGraphicsUnit(GetString(item), defaultGraphicsUnit);
		}

		#endregion
	}

	public enum SetupItem
	{
		DBType,
		DBSqliteFilename,
		
		DefaultBackgroundColor,
		DefaultForegroundColor,
		DefaultHoverColor,
		
		DefaultXPosition,
		DefaultYPosition,

		DefaultTermTextFontFamilyName,
		DefaultTermTextFontSize,
		DefaultTermTextFontStyle,
		DefaultTermTextFontGraphicsUnit,

		DefaultTermHourFontFamilyName,
		DefaultTermHourFontSize,
		DefaultTermHourFontStyle,
		DefaultTermHourFontGraphicsUnit,

		DefaultTermTextForegroundColor,
		DefaultTermHourForegroundColor

	}
}
