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
// Copyright (c) 2005 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//
// Demostrates ownerdraw ListBoxes
//

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;

namespace MyFormProject
{
	class MainForm : System.Windows.Forms.Form
	{
		private Label label_regular;
		private ListBox listbox_regular;
		private Label label_muticolumn;
		private ListBox listbox_multicolumn;
		private SolidBrush brush_black;
		private StringFormat string_format;
		private Font fixed_font;
		private Button button;

		class MyItem
		{
			public string font_name;
			public string text;
			public Font font;

			public MyItem (string text, string font_name)
			{
				this.text = text;
				this.font_name = font_name;
				font = null;
			}

			public Font Font {
				get {
					if (font == null) {
						font = new Font (font_name, 12);
					}

					return font;
				}
			}

			public override string ToString ()
			{
				return text;
			}
		}

		public MainForm()
		{
			InitializeComponent ();
		}

		void InitializeComponent ()
		{
			brush_black = new SolidBrush (Color.Black);
			string_format = new StringFormat ();
			listbox_regular = new ListBox ();
			label_regular = new Label ();
			listbox_multicolumn = new ListBox ();
			label_muticolumn = new Label ();
			fixed_font = new Font ("Arial", 8);

			/* Regular */
			label_regular.Text = "Regular";
			label_regular.Location = new Point (10,10);

			listbox_regular.Location = new Point (10,30);
			listbox_regular.Size = new Size (180, 200);
			listbox_regular.DrawItem += new DrawItemEventHandler (DrawItemHandlerFixed);
			listbox_regular.MeasureItem += new MeasureItemEventHandler (MeasureItemHandler);
			listbox_regular.DrawMode = DrawMode.OwnerDrawVariable;

			/* Multicolumn */
			label_muticolumn.Text = "OwnerDrawVariable";
			label_muticolumn.Location = new Point (210,10);
			label_muticolumn.AutoSize = true;

			listbox_multicolumn.Location = new Point (210,30);
			listbox_multicolumn.Size = new Size (300, 250);
			listbox_multicolumn.DrawItem += new DrawItemEventHandler (DrawItemHandlerFixed);
			listbox_multicolumn.ItemHeight = 24;
			listbox_multicolumn.MultiColumn = true;
			listbox_multicolumn.DrawMode = DrawMode.OwnerDrawFixed;

			FontCollection ifc = new InstalledFontCollection ();

			int cnt = 0;
			foreach (FontFamily ffm in ifc.Families) {
				if (ffm.IsStyleAvailable (FontStyle.Regular)) {
					listbox_regular.Items.Add (new MyItem (ffm.Name + " Abcedf", ffm.Name));
					listbox_multicolumn.Items.Add (new MyItem (ffm.Name + " Abcedf", ffm.Name));
				}
				cnt++;

				if (cnt>10)
					break;
			}

			/* Button */
			button = new Button ();
			button.Location = new Point (400, 30);
			button.Text = "Action";
			button.Size = new Size (100, 23);
			button.Click += new System.EventHandler (buttonClick);

			Text = "ListBox ownerdraw TextApp";
			ClientSize = new System.Drawing.Size (624, 600);
			Controls.Add (listbox_regular);
			Controls.Add (label_regular);
			//listbox_multicolumn.Font = new Font ("Arial", 33);
			Controls.Add (listbox_multicolumn);
			Controls.Add (label_muticolumn);
			Controls.Add (button);
		}

		private void buttonClick (object sender, System.EventArgs e)
		{
			listbox_regular.Refresh ();
		}

		public void DrawItemHandler (object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
			{
				e.Graphics.FillRectangle (new SolidBrush (Color.Red), e.Bounds);
				return;
			}

			MyItem item = (MyItem) listbox_regular.Items[e.Index];

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)  {
				e.Graphics.FillRectangle (new SolidBrush (Color.Blue), e.Bounds);
				e.Graphics.DrawString (item.ToString (), item.Font, brush_black, e.Bounds, string_format);
			}
			else {
				e.Graphics.FillRectangle (new SolidBrush (Color.White), e.Bounds);
				e.Graphics.DrawString (item.ToString (), item.Font, brush_black, e.Bounds, string_format);
			}
		}

		public void MeasureItemHandler (object sender, MeasureItemEventArgs e)
		{
			MyItem item = (MyItem) listbox_regular.Items[e.Index];
			e.ItemHeight = 15 + e.Index * 3;

			Console.WriteLine ("MeasureItemHandler {0} {1} {2}", e.Index, e.ItemHeight,
				item.font_name);
		}

		public void DrawItemHandlerFixed (object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
			{
				e.Graphics.FillRectangle (new SolidBrush (Color.Red), e.Bounds);
				return;
			}

			MyItem item = (MyItem) listbox_regular.Items[e.Index];

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)  {
				e.Graphics.FillRectangle (new SolidBrush (Color.Blue), e.Bounds);
				e.Graphics.DrawString (item.ToString (), fixed_font, brush_black, e.Bounds, string_format);
			}
			else {
				e.Graphics.FillRectangle (new SolidBrush (Color.White), e.Bounds);
				e.Graphics.DrawString (item.ToString (), fixed_font, brush_black, e.Bounds, string_format);
			}
		}

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}
}
