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
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//
//
//

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	class MainForm : System.Windows.Forms.Form
	{
		private ListBox listBox1;
		private ListBox listBox2;
		private ListBox listBox3;
		private ListBox listBox4;
		private ListBox listBox5;
		private ListBox listBox6;
		private ListBox listBox7;
		private ListBox listBox8;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Button buttonAdd;
		private Label labelitems;
		private int last_item = 0;

		public MainForm()
		{
			InitializeComponent();
		}

		void InitializeComponent() 
		{
			listBox1 = new ListBox ();
			listBox2 = new ListBox ();
			listBox3 = new ListBox ();
			listBox4 = new ListBox ();
			listBox5 = new ListBox ();
			listBox6 = new ListBox ();
			listBox7 = new ListBox ();
			listBox8 = new ListBox ();
			label1 = new Label ();
			label2 = new Label ();
			label3 = new Label ();
			label4 = new Label ();
			label5 = new Label ();
			label6 = new Label ();
			label7 = new Label ();			
			label8 = new Label ();
			buttonAdd = new Button ();
			labelitems = new Label ();

			SuspendLayout ();
			
			int y = 0;

			object[] items = new object[] {
				"this is item 1",
				"this is item 2",
				"this is item 3",
				"this is item 4",
				"this is item 5",
				"this is item 6",
				"this is item 7",
				"this is item 8",
				"this is item 9",
				"this is item 10",
				"this is item 11",
				"this is item 12",
				"this is item 13",
				"this is item 14",
				"this is item 15",
				"this is item 16",
				"this is item 17",
			};
			
			
			bool listbox1 = true;
			bool listbox2 = true;
			bool listbox3 = true;
			bool listbox4 = true;
			bool listbox5 = true;
			bool listbox6 = true;
			bool listbox7 = true;
			bool listbox8 = true;
			//
			// listBox 1
			//
			if (listbox1) {
				listBox1.Location = new System.Drawing.Point (10, y + 20);
				listBox1.MultiColumn = false;
				listBox1.Size = new System.Drawing.Size (400, 65);
				listBox1.IntegralHeight = true;
				listBox1.ScrollAlwaysVisible = false;
				listBox1.HorizontalScrollbar = false;
				listBox1.Items.AddRange (items);
				label1.Location = new System.Drawing.Point (10, y);
				label1.AutoSize = true;
				label1.Text = "IntegralHeight true, ScrollAlwaysVisible(V) false, HorizontalScrollbar false";
			}

			//
			// listBox 2
			//
			if (listbox2) {
				listBox2.Location = new System.Drawing.Point (450, y + 20);
				listBox2.MultiColumn = false;
				listBox2.Size = new System.Drawing.Size (400, 65);
				listBox2.IntegralHeight = false;
				listBox2.ScrollAlwaysVisible = false;
				listBox2.HorizontalScrollbar = false;
				listBox2.Items.AddRange (items);
				label2.Location = new System.Drawing.Point (450, y);
				label2.AutoSize = true;
				label2.Text = "IntegralHeight false, ScrollAlwaysVisible(V) false, HorizontalScrollbar false";
			}
			
			y += 120;

			//
			// listBox 3
			//
			if (listbox3) {
				listBox3.Location = new System.Drawing.Point (10, y + 20);
				listBox3.MultiColumn = false;
				listBox3.Size = new System.Drawing.Size (400, 65);
				listBox3.IntegralHeight = true;
				listBox3.ScrollAlwaysVisible = false;
				listBox3.HorizontalScrollbar = true;
				listBox3.Items.AddRange (items);
				label3.Location = new System.Drawing.Point (10, y);
				label3.AutoSize = true;
				label3.Text = "IntegralHeight true, ScrollAlwaysVisible(V) false, HorizontalScrollbar true";
			}

			//
			// listBox 4
			//
			if (listbox4) {
				listBox4.Location = new System.Drawing.Point (450, y + 20);
				listBox4.MultiColumn = false;
				listBox4.Size = new System.Drawing.Size (400, 65);
				listBox4.IntegralHeight = false;
				listBox4.ScrollAlwaysVisible = false;
				listBox4.HorizontalScrollbar = true;
				listBox4.Items.AddRange (items);
				label4.Location = new System.Drawing.Point (450, y);
				label4.AutoSize = true;
				label4.Text = "IntegralHeight false, ScrollAlwaysVisible(V) false, HorizontalScrollbar true";
			}

			y += 120;
			
			//
			// listBox 5
			//
			if (listbox5) {
				listBox5.Location = new System.Drawing.Point (10, y + 20);
				listBox5.MultiColumn = true;
				listBox5.Size = new System.Drawing.Size (400, 70);
				listBox5.IntegralHeight = true;
				listBox5.ScrollAlwaysVisible = false;
				listBox5.HorizontalScrollbar = false;
				listBox5.Items.AddRange (items);
				label5.Location = new System.Drawing.Point (10, y);
				label5.AutoSize = true;
				label5.Text = "MultCol true, IntegralHeight true, ScrollAlwaysVisible(V) false, HorizontalScrollbar false";
			}

			//
			// listBox 6
			//
			if (listbox6) {
				listBox6.Location = new System.Drawing.Point (450, y + 20);
				listBox6.MultiColumn = true;
				listBox6.Size = new System.Drawing.Size (400, 70);
				listBox6.IntegralHeight = false;
				listBox6.ScrollAlwaysVisible = false;
				listBox6.HorizontalScrollbar = false;
				listBox6.Items.AddRange (items);
				label6.Location = new System.Drawing.Point (450, y);
				label6.AutoSize = true;
				label6.Text = "MultCol true, IntegralHeight false, ScrollAlwaysVisible(V) false, HorizontalScrollbar false";
			}
			
			y += 120;

			//
			// listBox 7
			//
			if (listbox7) {
				listBox7.Location = new System.Drawing.Point (10, y + 20);
				listBox7.MultiColumn = true;
				listBox7.Size = new System.Drawing.Size (400, 70);
				listBox7.IntegralHeight = true;
				listBox7.ScrollAlwaysVisible = false;
				listBox7.HorizontalScrollbar = true;
				listBox7.Items.Add ("Simple string");
				label7.Location = new System.Drawing.Point (10, y);
				label7.AutoSize = true;
				label7.Text = "MultCol true, IntegralHeight true, ScrollAlwaysVisible(V) true, HorizontalScrollbar false";
			}

			//
			// listBox 8
			//
			if (listbox8) {
				listBox8.Location = new System.Drawing.Point (450, y + 20);
				listBox8.MultiColumn = true;
				listBox8.Size = new System.Drawing.Size (400, 70);
				listBox8.IntegralHeight = false;
				listBox8.ScrollAlwaysVisible = true;
				listBox8.HorizontalScrollbar = false;
				listBox8.Items.AddRange (items);
				listBox8.ColumnWidth = 50;
				label8.Location = new System.Drawing.Point (450, y);
				label8.AutoSize = true;			
				label8.Text = "MultCol true, IntegralHeight false, ScrollAlwaysVisible(V) true, HorizontalScrollbar false";
			}
			
			buttonAdd.Location = new Point (860, 30);
			buttonAdd.Name = "button";
			buttonAdd.Size = new System.Drawing.Size (75, 25);			
			buttonAdd.Text = "Add Items";
			buttonAdd.Click += new System.EventHandler (ButtonAddClick);		
			
			labelitems.Location = new Point (860, 60);
			labelitems.Text = "items:" + listBox1.Items.Count;			

			//
			// MainForm
			//
			ClientSize = new System.Drawing.Size (950, 500);
			
			if (listbox1)
				Controls.AddRange (new Control[] {listBox1, label1});
				
			if (listbox2)
				Controls.AddRange (new Control[] {listBox2, label2});
				
			if (listbox3)
				Controls.AddRange (new Control[] {listBox3, label3});
				
			if (listbox4)
				Controls.AddRange (new Control[] {listBox4, label4});
				
			if (listbox5)
				Controls.AddRange (new Control[] {listBox5, label5});
				
			if (listbox6)
				Controls.AddRange (new Control[] {listBox6, label6});
				
			if (listbox7)
				Controls.AddRange (new Control[] {listBox7, label7});
				
			if (listbox8)
				Controls.AddRange (new Control[] {listBox8, label8});
				
			Controls.Add (buttonAdd);
			Controls.Add (labelitems);
			
			
			Text = "SWF-Listboxes";
			ResumeLayout (false);
		}
		
		void ButtonAddClick (object sender, System.EventArgs e)
		{ 
			string item_text;
			
			for (int i = last_item; i < last_item + 10; i++) {
				item_text = "new item " + last_item;
				listBox1.Items.Add (item_text);
				listBox2.Items.Add (item_text);
				listBox3.Items.Add (item_text);
				listBox4.Items.Add (item_text);
				listBox5.Items.Add (item_text);
				listBox6.Items.Add (item_text);
				listBox7.Items.Add (item_text);
				listBox8.Items.Add (item_text);
				last_item++;
			}
			
			labelitems.Text = "items:" + listBox1.Items.Count;			
		}

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}
}

