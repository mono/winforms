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
// Copyright (c) 2005 Novell, Inc. (http://www.novell.com)
//
// Author:
//	Jordi Mas i Hernandez <jordi@ximian.com>
//
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatagridSamples
{
	class DataGridSamples : Form
	{
		class OurButton : Button
		{
			public Form form = null;

			public OurButton (Form f)
			{
				form = f;
			}
		}

		public DataGridSamples ()
		{
			InitializeComponent ();
		}

		public void CreateSampleEntry (string description, Form form, ref int y)
		{
			Label label = new Label ();
			label.Text = description;
			label.Location = new Point (10, y + 5);
			label.AutoSize = true;
			Controls.Add (label);

			OurButton button = new OurButton (form);
			button.Text = "Run sample";
			button.Location = new Point (180, y);
			button.Click += new System.EventHandler (this.label2_Click);
			Controls.Add (button);

			y += 30;
		}

		private void label2_Click (object sender, System.EventArgs e)
		{
			((OurButton)sender).form.ShowDialog (this);
		}


		void InitializeComponent ()
		{
			int y = 10;

			CreateSampleEntry ("With real data ", new DataGridRealSample (), ref y);
			CreateSampleEntry ("Properties testing", new DataGridTestProperties (), ref y);
			CreateSampleEntry ("Properties table navigation", new DataGridTableNavigation (), ref y);
			CreateSampleEntry ("Table and column styles", new DataGridStyles (), ref y);
			Text = "SWF-Datagrid app";
			Name = "MainForm";
			ClientSize = new Size (300, 300);
		}


		public static void Main (string[] args)
		{
			Application.Run (new DataGridSamples ());
		}

	}
}
