using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using eXterm.Utils;

namespace eXterm.UI.Controls
{
	public class TermViewCollection : CollectionBase
	{
		public TermViewCollection()
		{
		}

		public TermViewCollection(TermViewCollection collection)
		{
			foreach (ITermView termView in collection)
				List.Add(termView);
		}

		public void Sort()
		{
			InnerList.Sort();
		}

		#region CollectionBase
		public ITermView this[int index]
		{
			get { return (ITermView)List[index]; }
			set { List[index] = value; }
		}

		public int Add(ITermView value)
		{
			return List.Add(value);
		}

		public int IndexOf(ITermView value)
		{
			return List.IndexOf(value);
		}

		public void Insert(int index, ITermView value)
		{
			List.Insert(index, value);
		}

		public void Remove(ITermView value)
		{
			List.Remove(value);
		}

		public bool Contains(ITermView value)
		{
			return List.Contains(value);
		}

		#region Protected methods

		protected override void OnInsert(int index, Object value)
		{
			if (!(value is ITermView))
				throw new ArgumentException("value must be of type ITermView.", "value");
		}

		protected override void OnRemove(int index, Object value)
		{
			if (!(value is ITermView))
				throw new ArgumentException("value must be of type ITermView.", "value");
		}

		protected override void OnSet(int index, Object oldValue, Object newValue)
		{
			if (!(newValue is ITermView))
				throw new ArgumentException("newValue must be of type ITermView.", "newValue");
		}

		protected override void OnValidate(Object value)
		{
			if (!(value is ITermView))
				throw new ArgumentException("value must be of type ITermView.");
		}

		#endregion

		#endregion
	}
}
