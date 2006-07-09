using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using eXterm.Data.Model;

namespace eXterm.UI.Controls
{
	public partial class TermControl : ControlBase, ITermView
	{
		private Term term;

		public TermControl(Term term)
		{
			InitializeComponent();
			SetupStyle();

			this.term = term;

			new TermPresenter(this);
		}

		#region ITermView Members

		public Term Term
		{
			get { return term; }
			set { term = value; }
		}

		public string DateLbl
		{
			get { return dateLbl.Text; }
			set { dateLbl.Text = value; }
		}

		public string TextLbl
		{
			get { return textLbl.Text; }
			set { textLbl.Text = value; }
		}

		#endregion

		#region IComparable members

		public int CompareTo(object o)
		{
			if (!(o is ITermView))
				return -1;

			ITermView termView = (ITermView)o;

			return term.CompareTo(term);
		}

		#endregion
	}
}
