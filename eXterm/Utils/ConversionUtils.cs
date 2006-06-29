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
	}
}
