using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Utils;

namespace eXterm.Data.Model
{
	public class Term : ModelObjectBase, IComparable
	{
		private long id = 0;
		private DateTime date = DateTime.Now;
		private string text = string.Empty;

		public Term(DateTime date, string text)
		{
			this.date = date;
			this.text = text;
			this.dirty = true;
		}

		public Term(DateTime date)
			: this(date, string.Empty)
		{ }

		public Term()
			: this(DateTime.Now)
		{ }

		public long Id
		{
			get { return id; }
			set
			{
				if (id <= 0)
					id = value;
			}
		}

		public DateTime Date
		{
			get { return date; }
			set
			{
				date = value;
				dirty = true;
			}
		}

		public string Text
		{
			get { return text; }
			set
			{
				if (value != null)
					text = value;
				else
					text = string.Empty;
			}
		}

		public int CompareTo(object o)
		{
			if (!(o is Term))
				return -1;

			Term term = (Term)o;

			return DateTimeUtils.FlattenDate(Date).CompareTo(
				DateTimeUtils.FlattenDate(term.Date)
				);
		}
	}
}
