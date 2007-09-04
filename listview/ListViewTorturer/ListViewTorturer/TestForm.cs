using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public partial class TestForm : Form
	{
		IListViewTester tester;

		public TestForm ()
		{
			InitializeComponent ();
		}

		protected virtual void OnEndTest (EndTestEventArgs args)
		{
			EndTest (this, args);
		}

		protected override void OnVisibleChanged (EventArgs e)
		{
			base.OnVisibleChanged (e);
			if (!Visible)
				return;

			// We have to call asynch this method
			// because it looks like in .Net the form is not
			// actually shown until the OnVisibleChanged 
			// method returns, and we want to get all the operations
			// to be shown in screen
			StartTestDelegate del = StartTest;
			del.BeginInvoke (null, null);
		}

		delegate void StartTestDelegate ();

		void StartTest ()
		{
			// We should add a better profiling facility
			// including memory allocations and more
			DateTime dt1 = DateTime.Now;
			tester.StartTest ();
			TimeSpan interval = DateTime.Now - dt1;

			EndTestEventArgs args = new EndTestEventArgs (interval);

			DialogResult = DialogResult.OK; // Close this form - This is a little nasty

			OnEndTest (args);
			tester.OnEndTest (args);
		}

		public IListViewTester Tester {
			get {
				return tester;
			}
			set {
				this.tester = value;

				Controls.Clear ();

				tester.ListView.Dock = DockStyle.Fill;
				Controls.Add (tester.ListView);
			}
		}

		public EndTestEventHandler EndTest;
	}

	public delegate void EndTestEventHandler (object o, EndTestEventArgs args);
}