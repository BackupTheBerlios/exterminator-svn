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

		private static string newBitmapName = "eXterm.Images.page9.png";
		private static string deleteBitmapName = "eXterm.Images.delete.png";
		private static string editBitmapName = "eXterm.Images.find10.gif";

		private static IDictionary<string, Bitmap> bitmaps = new Dictionary<string, Bitmap> ();

		public static Icon NotifyIcon
		{
			get { return GetIcon(notifyIconName); }
		}

		public static Bitmap NewBitmap
		{
			get { return GetBitmap(newBitmapName); }
		}

		public static Bitmap DeleteBitmap
		{
			get { return GetBitmap(deleteBitmapName); }
		}

		public static Bitmap EditBitmap
		{
			get { return GetBitmap(editBitmapName); }
		}

		private static Stream GetStream(string resourceName)
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			string[] resNames = assembly.GetManifestResourceNames();
			return assembly.GetManifestResourceStream(resourceName);
		}

		private static Bitmap GetBitmap (string resourceName)
		{
			Bitmap cachedBitmap = null;
			if (bitmaps.Keys.Contains (resourceName))
				cachedBitmap = bitmaps[resourceName];
			if (cachedBitmap != null)
				return cachedBitmap;

			bitmaps [resourceName] = cachedBitmap = new Bitmap(GetStream(resourceName));
			return cachedBitmap;
		}

		private static Icon GetIcon(string resourceName)
		{
			Bitmap bitmap = GetBitmap(resourceName);
			return Icon.FromHandle(bitmap.GetHicon());
		}
	}
}
