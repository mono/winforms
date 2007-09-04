using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public class EndTestEventArgs : EventArgs
	{
		bool show_default_dialog = true;
		TimeSpan interval;

		public EndTestEventArgs (TimeSpan interval)
		{
			this.interval = interval;
		}

		public bool ShowDefaultDialog
		{
			get
			{
				return show_default_dialog;
			}
			set
			{
				show_default_dialog = value;
			}
		}

		public TimeSpan Interval
		{
			get
			{
				return interval;
			}
		}
	}
}
