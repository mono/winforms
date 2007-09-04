using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	class AddItemsTester : IListViewTester
	{
		ListView lv;
		ListViewDescriptor descriptor;
		int items_to_add;

		public AddItemsTester (ListViewDescriptor descriptor)
		{
			this.descriptor = descriptor;

			lv = new ListView ();
			lv.View = descriptor.View;

			items_to_add = descriptor.ItemCount;
		}

		public ListViewDescriptor Descriptor
		{
			get
			{
				return descriptor;
			}
		}

		public bool RequireForm
		{
			get
			{
				return true;
			}
		}

		public ListView ListView
		{
			get
			{
				return lv;
			}
		}

		public void StartTest ()
		{
			lv.EndUpdate (); // Make sure we are not in a BeginUpdate ()

			if (lv.Parent == null)
				throw new Exception ("Fuck");

			for (int i = 0; i < items_to_add; i++)
				lv.Items.Add ("Item " + i);
		}

		public void OnEndTest (EndTestEventArgs args)
		{
		}
	}
}
