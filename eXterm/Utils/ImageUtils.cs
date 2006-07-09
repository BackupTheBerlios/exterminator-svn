using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace eXterm.Utils
{
	public class ImageUtils
	{
		private static string notifyIconName = "eXterm.Images.calendar16red.gif";

		public static Icon NotifyIcon
		{
			get { return GetIcon(notifyIconName); }
		}

		private static Stream GetStream(string resourceName)
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			string[] resNames = assembly.GetManifestResourceNames();
			return assembly.GetManifestResourceStream(resourceName);
		}

		private static Bitmap GetBitmap (string resourceName)
		{
			return new Bitmap(GetStream(resourceName));
		}

		private static Icon GetIcon(string resourceName)
		{
			Bitmap bitmap = GetBitmap(resourceName);
			return Icon.FromHandle(bitmap.GetHicon());
		}
	}
}
