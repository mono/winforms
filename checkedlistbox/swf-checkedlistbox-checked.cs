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
// CheckedListBox sample that shows the checked elements 
//

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	class MainForm : System.Windows.Forms.Form
	{
		private CheckedListBox listBox1;
		private CheckedListBox listBox2;
		private CheckedListBox listBox3;
		private CheckedListBox listBox4;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label labelSel;
		private Button buttonAdd;
		private Button buttonClear;
		private Label labelitems;
		private int last_item = 0;

		public MainForm()
		{
			InitializeComponent();
		}

		void InitializeComponent()
		{
			listBox1 = new CheckedListBox ();
			listBox2 = new CheckedListBox ();
			listBox3 = new CheckedListBox ();
			listBox4 = new CheckedListBox ();
			label1 = new Label ();
			label2 = new Label ();
			label3 = new Label ();
			label4 = new Label ();
			labelSel = new Label ();
			buttonAdd = new Button ();
			buttonClear = new Button ();
			labelitems = new Label ();

			SuspendLayout ();

			int y = 0;

			object[] items = new object[] {
				"this is item 0",
				"this is item 1",
				"this is item 2",
				"this is item 3",
				"this is item 4",
				"this is item 5",
				"this is item 6",
				//"this is item 6 this is really long item as a matter of fact that I may be longer that you expect",
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

			object[] items_comarques = new object[]
			{
				"Conca de Barberà", "Vallès Occidental", "Ripollès", 
				"Alt Urgell", "Alta Ribagorça",
				"Anoia", "Bages", "Baix Empordà", "Baix Llobregat", 
				"Baix Penedès", "Barcelonès",
				"Berguedà", "Cerdanya", "Garraf", "Garrigues", 				
				"Montsià", "Noguera", "Osona", "Pallars Jussà", "Pla d'Urgell",
				"Priorat", "Ribera d'Ebre", "Alt Penedès", 
				"Segarra", "Segrià", "Selva", "Solsonès", "Tarragonès",
				"Garrotxa", "Gironès", "Maresme", "Pallars Sobirà", 
				"Terra Alta", "Baix Camp", "Baix Ebre", "Urgell", "Val d'Aran",
				"Vallès Oriental", "Alt Empordà", "Alt Camp",
			};

			bool CheckedListbox1 = true;
			bool CheckedListbox2 = true;
			bool CheckedListbox3 = true;
			bool CheckedListbox4 = true;
			bool CheckedListbox5 = true;
			bool CheckedListbox6 = true;


			//
			// CheckedlistBox 1
			//
			if (CheckedListbox1) {
				listBox1.Location = new System.Drawing.Point (10, y + 20);
				listBox1.MultiColumn = false;
				listBox1.SelectionMode = SelectionMode.One;
				listBox1.Size = new System.Drawing.Size (400, 65);
				listBox1.IntegralHeight = true;
				listBox1.ScrollAlwaysVisible = false;
				listBox1.HorizontalScrollbar = false;
				listBox1.Items.AddRange (items);
				listBox1.ItemCheck += new ItemCheckEventHandler (IndexChangedCheckedListBox1);
				listBox1.ThreeDCheckBoxes = true;
				listBox1.CheckOnClick = true;
				listBox1.SelectedIndex = 1;
				listBox1.SelectedIndex = 2;

				label1.Location = new System.Drawing.Point (10, y);
				label1.AutoSize = true;
				label1.Text = "MultiColumn:" + listBox1.MultiColumn + " Selection:" + listBox1.SelectionMode;
			}


			//
			// CheckedListBox 2
			//
			if (CheckedListbox2) {
				listBox2.Location = new System.Drawing.Point (450, y + 20);
				listBox2.Size = new System.Drawing.Size (400, 65);
				listBox2.IntegralHeight = false;
				listBox2.CheckOnClick = true;
				listBox2.ScrollAlwaysVisible = false;
				listBox2.HorizontalScrollbar = false;
				listBox2.MultiColumn = false;
				listBox2.Items.AddRange (items);
				listBox2.SelectedIndex = 1;
				listBox2.SelectedIndex = 2;
				listBox2.ItemCheck += new ItemCheckEventHandler (IndexChangedCheckedListBox2);
				label2.Location = new System.Drawing.Point (450, y);
				label2.AutoSize = true;
				label2.Text = "MultiColumn:" + listBox2.MultiColumn + " Selection:" + listBox2.SelectionMode;
			}

			y += 120;

			//
			// CheckedListBox 3
			//
			if (CheckedListbox3) {

				listBox3.Location = new System.Drawing.Point (10, y + 20);
				listBox3.MultiColumn = true;
				listBox3.Size = new System.Drawing.Size (400, 70);
				listBox3.IntegralHeight = true;
				listBox3.ScrollAlwaysVisible = false;
				listBox3.HorizontalScrollbar = false;
				listBox3.Items.AddRange (items_comarques);
				listBox3.Text = listBox3.Items[5].ToString ();
				listBox3.ThreeDCheckBoxes = true;
				listBox3.ItemCheck += new ItemCheckEventHandler (IndexChangedCheckedListBox3);
				listBox3.Sorted = true;
				label3.Location = new System.Drawing.Point (10, y);
				label3.AutoSize = true;
				label3.Text = "MultiColumn:" + listBox3.MultiColumn + " Selection:" + listBox3.SelectionMode;
			}

			//
			// CheckedListBox 4
			//
			if (CheckedListbox4) {
				listBox4.Location = new System.Drawing.Point (450, y + 20);
				listBox4.MultiColumn = true;
				listBox4.Sorted = true;
				listBox4.Size = new System.Drawing.Size (400, 70);
				listBox4.IntegralHeight = false;
				listBox4.ScrollAlwaysVisible = false;
				listBox4.HorizontalScrollbar = false;
				listBox4.Items.AddRange (items_comarques);
				listBox4.ItemCheck += new ItemCheckEventHandler (IndexChangedCheckedListBox4);
				label4.Location = new System.Drawing.Point (450, y);
				label4.AutoSize = true;
				label4.Text = "MultiColumn:" + listBox4.MultiColumn + " Selection:" + listBox4.SelectionMode;
			}

			y += 120;
			labelSel.Location = new System.Drawing.Point (10, y);
			labelSel.AutoSize = true;
			labelSel.Text = "Seleteced Items None";

			buttonAdd.Location = new Point (860, 30);
			buttonAdd.Name = "button";
			buttonAdd.Size = new System.Drawing.Size (75, 25);
			buttonAdd.Text = "Add Items";
			buttonAdd.Click += new System.EventHandler (ButtonAddClick);

			buttonClear.Location = new Point (860, 300);
			buttonClear.Name = "button";
			buttonClear.Size = new System.Drawing.Size (90, 25);
			buttonClear.Text = "Clear Sel Items";
			buttonClear.Click += new System.EventHandler (ButtonClearClick);

			labelitems.Location = new Point (860, 60);
			labelitems.Text = "items:" + listBox1.Items.Count;

			//
			// MainForm
			//
			ClientSize = new System.Drawing.Size (950, 350);

			if (CheckedListbox1)
				Controls.AddRange (new Control[] {listBox1, label1});

			if (CheckedListbox2)
				Controls.AddRange (new Control[] {listBox2, label2});

			if (CheckedListbox3)
				Controls.AddRange (new Control[] {listBox3, label3});

			if (CheckedListbox4)
				Controls.AddRange (new Control[] {listBox4, label4});

			Controls.Add (buttonAdd);
			Controls.Add (labelitems);
			Controls.Add (labelSel);
			Controls.Add (buttonClear);

			Text = "SWF-Listboxes";
			ResumeLayout (false);
		}

		void ButtonAddClick (object sender, System.EventArgs e)
		{
			string item_text;
			int last = last_item;

			for (int i = last_item; i < last + 10; i++) {
				item_text = "New item " + last_item;
				listBox1.Items.Add (item_text);
				listBox2.Items.Add (item_text);
				listBox3.Items.Add (item_text);
				listBox4.Items.Add (item_text);
				last_item++;
			}

			labelitems.Text = "items:" + listBox1.Items.Count;
		}

		void ButtonClearClick (object sender, System.EventArgs e)
		{
			listBox2.ClearSelected ();
		}

		string DumpElements (CheckedListBox listbox)
		{
			string str;
			str = " CheckedIndices ";

			for (int i = 0; i < listbox.CheckedIndices.Count; i++) {
				str += "" + listbox.CheckedIndices[i];
				str += ";";
			}

			str += " - CheckedObjects ";

			for (int i = 0; i < listbox.CheckedItems.Count; i++) {
				str += "" + listbox.CheckedItems[i];
				str += ";";
			}

			return str;
		}

		void IndexChangedCheckedListBox1 (object sender, ItemCheckEventArgs e)
		{
			labelSel.Text = "CheckedListBox1" + DumpElements ((CheckedListBox)sender);
		}

		void IndexChangedCheckedListBox2 (object sender, ItemCheckEventArgs e)
		{
			labelSel.Text = "CheckedListBox2" + DumpElements ((CheckedListBox)sender);
		}

		void IndexChangedCheckedListBox3 (object sender, ItemCheckEventArgs e)
		{
			labelSel.Text = "CheckedListBox3" + DumpElements ((CheckedListBox)sender);
		}

		void IndexChangedCheckedListBox4 (object sender, ItemCheckEventArgs e)
		{
			labelSel.Text = "CheckedListBox4" + DumpElements ((CheckedListBox)sender);
		}

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}
}

