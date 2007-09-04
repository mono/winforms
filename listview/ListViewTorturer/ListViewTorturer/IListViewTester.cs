using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public interface IListViewTester
	{
		ListView ListView { get; }

		bool RequireForm { get; }

		void StartTest ();

		void OnEndTest (EndTestEventArgs args);
	}
}
