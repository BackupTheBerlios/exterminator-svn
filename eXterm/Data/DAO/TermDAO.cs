using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.Data.DAO
{
	public interface ITermDAO
	{

		IList<Term> LoadAll();

		bool Insert(Term term);
		bool Update(Term term);
		bool Delete(Term term);

		void PerformStartup();
	}
}
