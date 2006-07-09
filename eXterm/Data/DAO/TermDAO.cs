using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;

namespace eXterm.Data.DAO
{
	public interface ITermDAO
	{
		IList<Term> LoadAll();
		IList<Term> LoadNonRepetitiveFor(long fromDate, long toDate);
		IList<Term> LoadNonRepetitiveFor(DateTime fromDate, DateTime toDate);
		IList<Term> LoadNonRepetitiveFor(DateTime day);		

		bool Insert(Term term);
		bool Update(Term term);
		bool Delete(Term term);

		void PerformStartup();
	}
}
