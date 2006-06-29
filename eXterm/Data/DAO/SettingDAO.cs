using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.Data.DAO
{
	public interface ISettingDAO
	{
		IList<Setting> LoadAll();

		Setting Load(string name);
		void Insert(Setting setting);
		void Update(Setting setting);		

		void PerformStartup();
	}
}
