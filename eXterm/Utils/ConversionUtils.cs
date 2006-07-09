using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace eXterm.Utils
{
	public class ConversionUtils
	{
		public static int GetInt(object value, int defaultInt)
		{
			if ((value == null) || (value == DBNull.Value))
				return defaultInt;

			string intString = value.ToString();
			int result = defaultInt;

			try
			{
				result = int.Parse(intString);
			}
			catch (FormatException)
			{
				result = defaultInt;
			}

			return result;
		}

		public static float GetFloat(object value, float defaultFloat)
		{
			if ((value == null) || (value == DBNull.Value))
				return defaultFloat;

			string floatString = value.ToString();
			float result = defaultFloat;

			try
			{
				result = float.Parse(floatString);
			}
			catch (FormatException)
			{
				result = defaultFloat;
			}

			return result;
		}

		public static Color GetColor(object value, Color defaultColor)
		{
			if ((value == null) || (value == DBNull.Value))
				return defaultColor;

			string colorString = value.ToString ();
			Color color = defaultColor;

			try
			{
				color = Color.FromName(colorString);
			}
			catch (FormatException)
			{
				color = defaultColor;
			}

			return color;
		}

		public static FontStyle GetFontStyle(object value, FontStyle defaultFontStyle)
		{
			if ((value == null) || (value == DBNull.Value))
				return defaultFontStyle;

			string fontStyleString = value.ToString();
			FontStyle fontStyle = defaultFontStyle;

			try
			{
				fontStyle = (FontStyle) Enum.Parse(typeof(FontStyle), fontStyleString);
			}
			catch (ArgumentException)
			{
				fontStyle = defaultFontStyle;
			}

			return fontStyle;
		}

		public static GraphicsUnit GetGraphicsUnit(object value, GraphicsUnit defaultGraphicsUnit)
		{
			if ((value == null) || (value == DBNull.Value))
				return defaultGraphicsUnit;

			string graphicsUnitString = value.ToString();
			GraphicsUnit graphicsUnit = defaultGraphicsUnit;

			try
			{
				graphicsUnit = (GraphicsUnit) Enum.Parse(typeof(GraphicsUnit), graphicsUnitString);
			}
			catch (ArgumentException)
			{
				graphicsUnit = defaultGraphicsUnit;
			}

			return graphicsUnit;
		}
	}
}
