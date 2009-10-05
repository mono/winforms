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
using System.ComponentModel;
using System.Drawing;
using System.IO;
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

public class TestForm : Form
{
	ListView lv;
	ColumnHeader [] columns;
	ComboBox view_cb;
	Label view_label;
	Label warning_label;

	const int ItemsCount = 500;

	static readonly string [] Images = {
				"abiword_48.png",
				"bmp.png",
				"disks.png"
	};

	static readonly string ImagesPath = "listview-items-icons/32x32/";

	public TestForm ()
	{
		InitializeUIComponents ();
	}

	void InitializeUIComponents ()
	{
		lv = new ListView ();
		lv.Location = new Point (10, 10);
		lv.Size = new Size (400, 500);
		lv.FullRowSelect = true;
		lv.SmallImageList = new ImageList ();
		lv.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
		lv.SmallImageList.ImageSize = new Size (24, 24);
		lv.LargeImageList = new ImageList ();
		lv.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
		lv.LargeImageList.ImageSize = new Size (32, 32);
		lv.RetrieveVirtualItem += ListViewRetrieveItem;
		lv.VirtualListSize = ItemsCount;
		lv.VirtualMode = true;
		LoadListViewImages ();

		view_label = new Label ();
		view_label.Location = new Point (lv.Right + 10, 10);
		view_label.Text = "View";
		view_label.AutoSize = true;

		warning_label = new Label ();
		warning_label.Location = new Point (10, lv.Bottom + 5);
		warning_label.Font = new Font (Font, FontStyle.Bold);
		warning_label.ForeColor = Color.Red;
		warning_label.AutoSize = true;

		view_cb = new ComboBox ();
		view_cb.Location = new Point (lv.Right + 70, 10);
		view_cb.Items.AddRange (new object [] { View.LargeIcon, View.SmallIcon, View.List, View.Details });
		view_cb.SelectedItem = lv.View;
		view_cb.SelectedIndexChanged += ViewCBSelectedIndexChanged;

		Controls.AddRange (new Control [] { lv, view_label, warning_label, view_cb });

		Size = new Size (630, 580);
		Text = "VirtualMode tester";
	}

	void UpdateView (View view)
	{
		if (view == View.Details) {
			if (columns == null)
				columns = new ColumnHeader [] {
					new ColumnHeader ("Main column"),
					new ColumnHeader ("Sub column #1"),
					new ColumnHeader ("Sub column #2")
				};

			lv.Columns.AddRange (columns);
			lv.AutoResizeColumns (ColumnHeaderAutoResizeStyle.HeaderSize);
		} else {
			lv.Columns.Clear ();
		}

		lv.View = view;
	}

	void ListViewRetrieveItem (object o, RetrieveVirtualItemEventArgs args)
	{
		if (args.ItemIndex == ItemsCount -1 && !IsHandleCreated)
			warning_label.Text = "Warning: The very last item was requested, which should not happen in load time (not visible yet)";

		// for testing purposes, we are creating one item per
		// invocation
		ListViewItem item = new ListViewItem ("Item #" + args.ItemIndex);
		item.SubItems.Add ("Sub item " + args.ItemIndex + "-1");
		item.SubItems.Add ("Sub item " + args.ItemIndex + "-2");
		if (lv.View == View.Details && args.ItemIndex % 2 == 0)
			item.BackColor = Color.WhiteSmoke;

		item.ImageIndex = args.ItemIndex % Images.Length;
		args.Item = item;
	}

	void ViewCBSelectedIndexChanged (object o, EventArgs args)
	{
		UpdateView ((View)view_cb.SelectedItem);
	}

	void LoadListViewImages ()
	{
		if (!Directory.Exists (ImagesPath)) {
			Console.WriteLine ("Images path " + ImagesPath + " does not exist.");
			return;
		}

		foreach (string image_file in Images)
			if (File.Exists (ImagesPath + image_file)) {
				Image img = Image.FromFile (ImagesPath + image_file);
				lv.SmallImageList.Images.Add (img);
				lv.LargeImageList.Images.Add (img);
			}
	}
}

