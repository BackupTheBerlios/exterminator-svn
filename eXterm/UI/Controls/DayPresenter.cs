using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using eXterm.Data.Model;
using eXterm.Data.BO;
using eXterm.UI;

namespace eXterm.UI.Controls
{
	class DayPresenter
	{
		private IDayView dayView;

		public DayPresenter(IDayView dayView)
		{
			this.dayView = dayView;
			SubscribeToEvents ();
		}

		private void SubscribeToEvents()
		{
			dayView.Load += new EventHandler(OnViewLoad);
			dayView.NewTermClick += new EventHandler(OnViewNewTermClick);
		}

		void OnViewLoad(object sender, EventArgs e)
		{
			// A hack because of bug in VS designer
			if (!EXterm.InDesignerMode)
			{
				CreateTermViews();
				ArrangeTermViewPositions();
				DisplayTermViews();
			}
		}

		void OnViewNewTermClick(object sender, EventArgs e)
		{
			IEditTermView editTermView = dayView.CreateEditTermView();
			editTermView.Term = new Term(dayView.Day);
			editTermView.Show();
		}

		private void CreateTermViews()
		{
			IList<Term> terms = new TermBO().LoadFor(dayView.Day);

			foreach (Term term in terms)
			{
				dayView.TermViews.Add(
					dayView.CreateTermView (term)
					);
			}
		}

		private void ArrangeTermViewPositions()
		{
			dayView.TermViews.Sort();

			int termNumber = 0;

			foreach (ITermView termView in dayView.TermViews)
			{
				termView.Location = new Point(
					0, termNumber * dayView.PreferedTermHeight
					);

				termView.Width = dayView.PreferedTermWidth;
				termView.Height = dayView.PreferedTermHeight;

				termNumber++;
			}
		}

		private void DisplayTermViews()
		{
			dayView.RemoveTermViews();
			dayView.AddTermViews(dayView.TermViews);
		}
	}
}
