// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2009 Novell, Inc.
//
// Author:
//	Carlos Alberto Cortez  <calberto.cortez@gmail.com>
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Test
{
	static void Main (string [] args)
	{
		Application.EnableVisualStyles ();
		TestForm form = new TestForm ();
		Application.Run (form);
	}

}

enum GroupsMode {
	Title,
	Author
}

public class TestForm : Form
{
	ListView lv;
	ListViewItem [] items;
	ColumnHeader [] columns;
	Label view_label;
	Label sorting_label;
	ComboBox view_cb;
	ComboBox sorting_cb;
	GroupsMode groups_mode;
	bool ascendent = true; // not for items, but for groups

	public TestForm ()
	{
		InitializeUIComponents ();
		AddInfo ();
	}

	void AddInfo ()
	{
		ListViewItem item1 = new ListViewItem (new string [] { "Les Miserables", "Hugo, Victor" });
		ListViewItem item2 = new ListViewItem (new string [] { "Picture of Dorian Gray", "Wilde, Oscar" });
		ListViewItem item3 = new ListViewItem (new string [] { "Count of Monte Cristo", "Dumas, Alexander" });
		ListViewItem item4 = new ListViewItem (new string [] { "Lolita", "Nabukov, Vladimir" });
		ListViewItem item5 = new ListViewItem (new string [] { "Twenty years after", "Dumas, Alexander" });
		ListViewItem item6 = new ListViewItem (new string [] { "Slowness", "Kundera, Milan" });
		ListViewItem item7 = new ListViewItem (new string [] { "Immortality", "Kundera, Milan" });
		ListViewItem item8 = new ListViewItem (new string [] { "Great expectations", "Dickens, Charles" });
		ListViewItem item9 = new ListViewItem (new string [] { "Alice in wonderland", "Caroll, Lewis" });
		ListViewItem item10 = new ListViewItem (new string [] { "Persuasion", "Austen, Jane" });
		ListViewItem item11 = new ListViewItem (new string [] { "Atonement", "McEwan, Ian" });
		ListViewItem item12 = new ListViewItem (new string [] { "Against nature", "Huysmans, Joris-Karl" });
		ListViewItem item13 = new ListViewItem (new string [] { "Aura", "Fuentes, Carlos" });
		ListViewItem item14 = new ListViewItem (new string [] { "The black book", "Pamuk, Orhan" });
		ListViewItem item15 = new ListViewItem (new string [] { "Ulises", "Joyce, James" });
		ListViewItem item16 = new ListViewItem (new string [] { "Amsterdam", "McEwan, Ian" });
		items = new ListViewItem [] { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10,
			item11, item12, item13, item14, item15, item16 };

		SetGroups ();
	}

	void SetGroups ()
	{
		lv.BeginUpdate ();

		lv.Items.Clear ();
		lv.Groups.Clear ();

		IComparer<string> comparer = new StringComparer (ascendent);
		SortedDictionary<string,ListViewGroup> groups = new SortedDictionary<string,ListViewGroup> (comparer);
		foreach (ListViewItem item in items) {
			string s;

			// obviously we are thinking the text is not empty
			if (groups_mode == GroupsMode.Title)
				s = item.SubItems [0].Text.Substring (0, 1).ToUpper ();
			else
				s = item.SubItems [1].Text.Substring (0, 1).ToUpper ();

			if (!groups.ContainsKey (s))
				groups [s] = new ListViewGroup (s);

			ListViewGroup group = groups [s];
			group.Items.Add (item);
			lv.Items.Add (item);
		}

		foreach (KeyValuePair<string,ListViewGroup> data in groups)
			lv.Groups.Add (data.Value);

		lv.EndUpdate ();
	}

	void InitializeUIComponents ()
	{
		lv = new ListView ();
		lv.Location = new Point (10, 10);
		lv.Size = new Size (400, 500);
		lv.FullRowSelect = true;
		lv.SmallImageList = new ImageList ();
		lv.LargeImageList = new ImageList ();
		lv.ColumnClick += ColumnClicked;
		UpdateView (View.Details);

		view_label = new Label ();
		view_label.Location = new Point (lv.Right + 10, 10);
		view_label.Text = "View";
		view_label.AutoSize = true;

		sorting_label = new Label ();
		sorting_label.Location = new Point (lv.Right + 10, 50);
		sorting_label.Text = "Sorting";
		sorting_label.AutoSize = true;

		view_cb = new ComboBox ();
		view_cb.Location = new Point (lv.Right + 80, 10);
		view_cb.Width = 120;
		view_cb.Items.AddRange (new object [] { View.LargeIcon, View.SmallIcon, View.List, View.Details });
		view_cb.SelectedItem = lv.View;
		view_cb.SelectedIndexChanged += ViewCBSelectedIndexChanged;

		sorting_cb = new ComboBox ();
		sorting_cb.Location = new Point (lv.Right + 80, 50);
		sorting_cb.Width = 120;
		sorting_cb.Items.AddRange (new object [] { SortOrder.None, SortOrder.Ascending, SortOrder.Descending });
		sorting_cb.SelectedItem = lv.Sorting;
		sorting_cb.SelectedIndexChanged += SortingCBSelectedIndexChanged;

		Controls.AddRange (new Control [] { lv, view_label, sorting_label, view_cb, sorting_cb });

		Text = "ListView groups tester";
		Size = new Size (620, 550);
	}

	void UpdateView (View view)
	{
		if (view == View.Details) {
			if (columns == null)
				columns = new ColumnHeader [] {
					new ColumnHeader ("Title"),
					new ColumnHeader ("Author")
				};

			lv.Columns.AddRange (columns);
			lv.AutoResizeColumns (ColumnHeaderAutoResizeStyle.ColumnContent);
		} else {
			lv.Columns.Clear ();
		}

		lv.View = view;
	}

	void ColumnClicked (object o, ColumnClickEventArgs args)
	{
		if (args.Column == 0)
			groups_mode = GroupsMode.Title;
		else
			groups_mode = GroupsMode.Author;

		ascendent = !ascendent;

		SetGroups ();
	}

	void ViewCBSelectedIndexChanged (object o, EventArgs args)
	{
		UpdateView ((View)view_cb.SelectedItem);
	}

	void SortingCBSelectedIndexChanged (object o, EventArgs args)
	{
		lv.Sorting = (SortOrder)sorting_cb.SelectedItem;
	}
}

class StringComparer : IComparer<string>
{
	bool ascendent;

	public StringComparer (bool ascendent)
	{
		this.ascendent = ascendent;
	}

	public int Compare (string a_text, string b_text)
	{
		if (ascendent)
			return String.Compare (a_text, b_text);

		return String.Compare (b_text, a_text);
	}
}

