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
		IList<Term> terms = new List<Term> ();
		DateTime day = DateTime.Today;

		public DayControl(DateTime day)
		{
			InitializeComponent();
			SetupStyle();

			this.Day = day;
		}

		#region IDayView Members

		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public IList<Term> Terms
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
				foreach (Term t in value)
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

		public void AddTermView(ITermView termView)
		{
			if ((termView is Control) && (!Controls.Contains ((Control) termView)))
				Controls.Add ((Control) termView);
		}

		public void RemoveTermView(ITermView termView)
		{
			if ((termView is Control) && (Controls.Contains((Control)termView)))
				Controls.Remove((Control)termView);
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
