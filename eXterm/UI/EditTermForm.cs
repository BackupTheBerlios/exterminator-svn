using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using eXterm.Data.Model;

namespace eXterm.UI
{
	public partial class EditTermForm : FormBase, IEditTermView
	{
		private Term term = null;

		public EditTermForm()
		{
			InitializeComponent();
			SetupStyle ();
			SetupMovingAreas (
				null
				);
		}

		#region EditTermView members

		public Term Term
		{
			get { return term; }
			set { term = value; }
		}

		public new void Show()
		{
			base.ShowDialog();
		}

		#endregion
	}
}