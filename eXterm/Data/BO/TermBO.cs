using System;
using System.Collections.Generic;
using System.Text;

using eXterm.Data.Model;
using eXterm.Data.DAO;

namespace eXterm.Data.BO
{
	class TermBO
	{
		private ITermDAO termDAO = null;

		public TermBO()
		{
			termDAO = EXterm.DbConnection.CreateDAOFactory().CreateTermDAO();
		}

		public TermBO(ITermDAO termDAO)
		{
			this.termDAO = termDAO;
		}

		public IList<Term> LoadFor(DateTime day)
		{
			IList <Term> terms = termDAO.LoadNonRepetitiveFor(day);
			/* TODO:
			 * load repeatable */
			return terms;
		}
	}
}
