using System;
using System.Collections.Generic;
using System.Text;

namespace eXterm.Utils
{
	public static class DateTimeUtils
	{
		public static readonly TimeSpan OneWeek = new TimeSpan (7, 0, 0, 0);
		public static readonly TimeSpan ThreeWeeks = new TimeSpan (3*7 - 1, 0, 0, 0);

		private static readonly DateTime zeroDate = DateTime.Parse("2000-01-01 00:00:00");

		public static long GetSeconds(DateTime date)
		{
			return (long) ((TimeSpan)(date - zeroDate)).TotalSeconds;
		}

		public static DateTime GetDate(long seconds)
		{
			return zeroDate.AddSeconds(seconds);
		}

		public static DateTime GetBeginningOfWeek(DateTime time)
		{
			return time.AddDays(-1 * (int)time.DayOfWeek).AddDays(1).Date;
		}

		public static bool IsDayVisible(DateTime time, DateTime referralTime)
		{
			DateTime beginningOfWeek = GetBeginningOfWeek(referralTime);

			DateTime begin = 
				 beginningOfWeek - OneWeek;

			DateTime end =
				beginningOfWeek + ThreeWeeks;

			if ((time > end) || (time < begin))
				return false;

			return true;
		}
	}
}
