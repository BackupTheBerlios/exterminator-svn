using System;
using System.Collections.Generic;
using System.Text;

namespace eXterm.Data.Model
{
	public abstract class ModelObjectBase
	{
		protected bool dirty = true;

		public bool Dirty
		{
			get { return dirty; }
			set { dirty = false; }
		}
	}
}
