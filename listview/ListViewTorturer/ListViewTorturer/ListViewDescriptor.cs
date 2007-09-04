using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public class ListViewDescriptor
	{
		int item_count;
		bool groups;
		View view;

		public int ItemCount
		{
			get
			{
				return item_count;
			}
			set
			{
				item_count = value;
			}
		}

		public bool Groups
		{
			get
			{
				return groups;
			}
			set
			{
				groups = value;
			}
		}

		public View View
		{
			get
			{
				return view;
			}
			set
			{
				view = value;
			}
		}
	}
}
