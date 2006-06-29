using System;
using System.Collections.Generic;
using System.Text;

namespace eXterm.Data.Model
{
	public class Setting : ModelObjectBase
	{
		private string name = string.Empty;
		private string value = string.Empty;

		public Setting(string name, string value)
		{
			this.name = name;
			this.value = value;
			this.dirty = true;
		}

		public string Name
		{
			get { return name; }
			set
			{
				dirty = true;
				if (value != null)
					name = value;
				else
					name = string.Empty;
			}
		}

		public string Value
		{
			get { return value; }
			set
			{
				dirty = true;
				if (value != null)
					this.value = value;
				else
					this.value = string.Empty;
			}
		}
	}
}
