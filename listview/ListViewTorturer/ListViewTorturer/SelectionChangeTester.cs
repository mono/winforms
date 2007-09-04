using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public class SelectionChangeTester : IListViewTester
	{
		ListViewDescriptor descriptor;
		ListView lv;

		public SelectionChangeTester (ListViewDescriptor descriptor)
		{
			this.descriptor = descriptor;

			lv = new ListView ();
			lv.View = descriptor.View;

			lv.BeginUpdate ();
			for (int i = 0; i < descriptor.ItemCount; i++)
				lv.Items.Add ("Item " + i);
			lv.EndUpdate ();
		}

		public ListView ListView
		{
			get
			{
				return lv;
			}
		}

		public bool RequireForm
		{
			get
			{
				return true;
			}
		}

		public void StartTest ()
		{
			lv.SelectedIndices.Clear ();

			//
			// First approach: Linear, adding one by one
			//
			for (int i = 0; i < lv.Items.Count; i++)
				lv.SelectedIndices.Add (i);

			//
			// Second approach: Linear reverse de-selecting
			//
			for (int i = 0; i < lv.Items.Count; i++)
				lv.SelectedIndices.Remove (i);

			//
			// Third approach: Select and then select all items
			//
			for (int i = 0; i < lv.Items.Count; i++) {
				lv.SelectedIndices.Add (i);
				lv.SelectedIndices.Remove (i);
			}
		}

		public void OnEndTest (EndTestEventArgs args)
		{
		}
	}
}
