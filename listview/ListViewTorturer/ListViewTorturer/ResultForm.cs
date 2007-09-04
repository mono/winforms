using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public partial class ResultForm : Form
	{
		TimeSpan interval;
		ListView lv; // Not the displayed LV, but the tested one
		ListViewGroup listviewGroup;
		ListViewGroup timeGroup;

		public ResultForm ()
		{
			InitializeComponent ();
			listviewGroup = listView1.Groups [0];
			timeGroup = listView1.Groups [1];
		}

		public TimeSpan Interval
		{
			get
			{
				return interval;
			}
			set
			{
				this.interval = value;
				AddTimeInfo ();
			}
		}

		public ListView ListView
		{
			get
			{
				return lv;
			}
			set
			{
				lv = value;
				AddListViewInfo ();
			}
		}

		void AddListViewInfo ()
		{
			listView1.BeginUpdate ();

			ListViewItem item = listView1.Items.Add ("View");
			item.SubItems.Add (lv.View.ToString ());
			item.Group = listviewGroup;

			item = listView1.Items.Add ("Items");
			item.SubItems.Add (lv.Items.Count.ToString ());
			item.Group = listviewGroup;

			listView1.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize);
			listView1.EndUpdate ();
		}

		// Replace the current format with a prettier one
		void AddTimeInfo ()
		{
			listView1.BeginUpdate ();
			listView1.Items.Clear ();

			ListViewItem item = listView1.Items.Add ("Seconds");
			item.SubItems.Add (interval.Seconds.ToString ());
			item.Group = timeGroup;

			item = listView1.Items.Add ("Milliseconds");
			item.SubItems.Add (interval.Milliseconds.ToString ());
			item.Group = timeGroup;

			item = listView1.Items.Add ("Ticks");
			item.SubItems.Add (interval.Ticks.ToString ());
			item.Group = timeGroup;

			listView1.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize);
			listView1.EndUpdate ();
		}

		private void ResultForm_Load (object sender, EventArgs e)
		{

		}
	}
}