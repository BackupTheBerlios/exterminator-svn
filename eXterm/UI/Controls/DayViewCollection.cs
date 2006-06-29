using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using eXterm.Utils;

namespace eXterm.UI.Controls
{
	public class DayViewCollection : CollectionBase
	{
		public DayViewCollection()
		{
		}

		public DayViewCollection(DayViewCollection collection)
		{
			foreach (IDayView dayView in collection)
				List.Add(dayView);
		}

		public void Sort()
		{
			InnerList.Sort();
		}

		public void RemoveNotVisibleDays (DateTime referralDate)
		{
			DayViewCollection dayViewCollection = new DayViewCollection(this);

			foreach (IDayView dayView in dayViewCollection)
			{
				if (DateTimeUtils.IsDayVisible(dayView.Day, referralDate))
					List.Remove(dayView);
			}
		}

		public bool Contains(DateTime date)
		{
			bool contains = false;

			foreach (IDayView dayView in List)
			{
				if (dayView.Day == date.Date)
					contains = true;
			}

			return contains;
		}

		#region CollectionBase
		public IDayView this [int index]
		{
			get { return (IDayView) List[index]; }
			set { List[index] = value; }
		}

		public int Add(IDayView value)
		{
			return List.Add(value);
		}

		public int IndexOf(IDayView value)  
		{
			return List.IndexOf(value);
		}

		public void Insert(int index, IDayView value)  
		{
			List.Insert(index, value);
		}

		public void Remove(IDayView value)
		{
			List.Remove(value);
		}

		public bool Contains(IDayView value)
		{
			return List.Contains(value);
		}

		#region Protected methods

		protected override void OnInsert(int index, Object value)
		{
			if (!(value is IDayView))
				throw new ArgumentException("value must be of type IDayView.", "value");
		}

		protected override void OnRemove(int index, Object value)
		{
			if (!(value is IDayView))
				throw new ArgumentException("value must be of type IDayView.", "value");
		}

		protected override void OnSet(int index, Object oldValue, Object newValue)
		{
			if (!(newValue is IDayView))
				throw new ArgumentException("newValue must be of type IDayView.", "newValue");
		}

		protected override void OnValidate(Object value)
		{
			if (!(value is IDayView))
				throw new ArgumentException("value must be of type IDayView.");
		}

		#endregion

		#endregion
	}
}
