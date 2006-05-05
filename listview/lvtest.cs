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
// Copyright (c) 2005-2006 Novell, Inc.
//
// Author:
//	Mike Kestner  <mkestner@novell.com>

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MonoSamples
{
	public class ListViewTest : Form
	{
		private ListView view;

		public ListViewTest ()
		{
			InitializeComponent ();
		}

		public static void Main (string[] args)
		{
			Application.Run(new ListViewTest());
		}

		private void InitializeComponent ()
		{

			ClientSize = new System.Drawing.Size (800, 600);
			Text = "Docked ListView";

			view = new ListView ();
			view.Dock = DockStyle.Fill;
			view.CheckBoxes = true;
			view.View = View.Details;
			view.Columns.Add ("Subcolumn 1", 100, HorizontalAlignment.Left);
			view.Columns.Add ("Subcolumn 2", 100, HorizontalAlignment.Center);
			for (int i = 0; i < 10; i++) {
				ListViewItem item = new ListViewItem ();
				item.Text = "Item " + i;
				item.SubItems.Add ("subitem1");
				item.SubItems.Add ("subitem2");
				view.Items.Add (item);
			}

			Controls.Add (view);
		}
	}
}
