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
	public partial class DayControl : ControlBase, IDayView
	{
		TermViewCollection terms = new TermViewCollection ();
		DateTime day = DateTime.Today;

		public DayControl(DateTime day)
		{
			InitializeComponent();
			SetupStyle();

			this.Day = day;

			new DayPresenter(this);
		}

		#region IDayView Members

		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public TermViewCollection TermViews
		{
			get { return terms; }
			set
			{
				if (value == null)
				{
					terms.Clear ();
					return;
				}
				terms.Clear ();
				foreach (ITermView t in value)
					terms.Add (t);
			}
		}

		public DateTime Day
		{
			get { return day; }
			set
			{
				day = value;
				lblDay.Text = value.Day.ToString();
			}
		}

		public int PreferedTermHeight
		{
			get
			{
				return Height / 4;
			}
		}

		public int PreferedTermWidth
		{
			get { return Width * 9 / 10; }
		}

		public void AddTermView(ITermView termView)
		{
			if ((termView is Control) && (!pnlTerms.Controls.Contains((Control)termView)))
				pnlTerms.Controls.Add ((Control) termView);
		}

		public void RemoveTermView(ITermView termView)
		{
			if ((termView is Control) && (pnlTerms.Controls.Contains((Control)termView)))
				pnlTerms.Controls.Remove((Control)termView);
		}

		public void AddTermViews(TermViewCollection termViews)
		{
			foreach (ITermView termView in termViews)
				AddTermView(termView);
		}

		public void RemoveTermViews()
		{
			pnlTerms.Controls.Clear();
		}

		public ITermView CreateTermView(Term term)
		{
			return new TermControl(term);
		}

		#endregion

		#region IComparable members

		public int CompareTo(object o)
		{
			if (!(o is IDayView))
				return -1;

			IDayView dayView = (IDayView)o;

			return Day.CompareTo(dayView.Day);
		}

		#endregion
	}
}
