using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using eXterm.Data.Model;
using eXterm.Settings;
using eXterm.Utils;

namespace eXterm.UI.Controls
{
	public partial class TermControl : ControlBase, ITermView
	{
		private Term term;

		public TermControl(Term term)
		{
			InitializeComponent();
			SetupStyle();
			SetImages();

			this.term = term;

			new TermPresenter(this);
		}

		#region ITermView Members

		public Term Term
		{
			get { return term; }
			set { term = value; }
		}

		public string HourLbl
		{
			get { return lblHour.Text; }
			set { lblHour.Text = value; }
		}

		public string TextLbl
		{
			get { return lblText.Text; }
			set { lblText.Text = value; }
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

		protected new void SetupStyle()
		{
			base.SetupStyle();
			lblText.BackColor = Setup.DefaultBackgroundColor;

			lblText.Font = Setup.DefaultTermTextFont;
			lblHour.Font = Setup.DefaultTermHourFont;

			lblText.ForeColor = Setup.DefaultTermTextForegroundColor;
			lblHour.ForeColor = Setup.DefaultTermHourForegroundColor;
		}

		private void SetImages()
		{
			btnDeleteTerm.Image = ImageUtils.DeleteBitmap;
			btnEditTerm.Image = ImageUtils.EditBitmap;
		}
	}
}
