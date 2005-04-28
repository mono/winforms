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
// ListBox, ComboBox and CheckedListBox Complex Databiding Sample
//

using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace Samples
{
	public class ourListBox : ListBox
	{
		public ourListBox ()  : base ()
		{

		}
				
		public CurrencyManager _DataManager {
			get { return DataManager; }
		}
	}

	// Data container
	public class Simbols
	{
		private string simbol;
		private string descripcio;

		public Simbols (string descripcio, string simbol)
		{
			this.simbol = simbol;
			this.descripcio = descripcio;
		}

		public string Simbol {
			get { return simbol;}
		}

		public string Descripcio {
			get { return descripcio; }
		}

		public string DescripcioLlarga {
			get { return descripcio; }
		}

		public override string ToString ()
		{
			return descripcio + " / " + simbol;
		}
	}

	class MainForm : System.Windows.Forms.Form
	{
		private ourListBox listBox = new ourListBox ();
		private TextBox textbox_listbox = new TextBox ();
		private ComboBox comboBox = new ComboBox ();
		private TextBox textbox_combobox = new TextBox ();
		private CheckedListBox checkedListbox = new CheckedListBox ();
		private TextBox textbox_checkedlistbox = new TextBox ();
		private ArrayList simbols = new ArrayList ();
		private CheckBox singledata_checkbox = new CheckBox ();


		public MainForm ()
		{
			/* Data */
			simbols.Add (new  Simbols ("Fons Monetari Internacional", "FMI"));
			simbols.Add (new  Simbols ("Centimetre", "cm"))  ;
			simbols.Add (new  Simbols ("Ferrocarril", "FC"));
			simbols.Add (new  Simbols ("Megahertz", "MHz")) ;
			simbols.Add (new  Simbols ("pesseta", "PTA"));
			simbols.Add (new  Simbols ("quilogram", "kg"));
			simbols.Add (new  Simbols ("watt", "W"));

			/* Settings */
			singledata_checkbox.Location = new Point (20, 10);
			singledata_checkbox.Text = "Single Data source (test Position)";
			singledata_checkbox.CheckedChanged += new EventHandler (singledata_checkboxCheckedChanged);
			singledata_checkbox.Size = new Size (250, 30);

			/* ListBox */
			listBox.Location = new Point (20, 40);
			listBox.Size = new Size (250, 130);

			textbox_listbox.Location = new Point (20, 180);
			textbox_listbox.Size = new Size (250, 24);
			listBox.SelectedValueChanged += new EventHandler (listBox_SelectedValueChanged);

			listBox.DataSource = simbols;
			listBox.DisplayMember = "Descripcio";
			listBox.ValueMember = "Simbol";

			/* ComboBox */
			comboBox.Location = new Point (300, 40);
			comboBox.Size = new Size (250, 130);

			textbox_combobox.Location = new Point (300, 180);
			textbox_combobox.Size = new Size (250, 24);
			comboBox.SelectedValueChanged += new EventHandler (comboBox_SelectedValueChanged);

			comboBox.DataSource = simbols.Clone ();
			comboBox.DisplayMember = "Descripcio";
			comboBox.ValueMember = "Simbol";

			/* CheckedListBox */
			checkedListbox.Location = new Point (20, 250);
			checkedListbox.Size = new Size (250, 130);

			textbox_checkedlistbox.Location = new Point (20, 400);
			textbox_checkedlistbox.Size = new Size (250, 24);
			checkedListbox.SelectedValueChanged += new EventHandler (checkedListbox_SelectedValueChanged);

			checkedListbox.DataSource = simbols.Clone ();
			checkedListbox.DisplayMember = "Descripcio";
			checkedListbox.ValueMember = "Simbol";

            		ClientSize = new Size (600, 600);
            		Text = "ListBox Complex Databinding Sample";

			Controls.AddRange (new Control[] {listBox, textbox_listbox, singledata_checkbox,
				textbox_checkedlistbox, comboBox, textbox_combobox, checkedListbox});

            	}

		private void listBox_SelectedValueChanged (object sender, EventArgs e)
	        {
			if (listBox.SelectedIndex != -1)
	                	textbox_listbox.Text = listBox.SelectedValue.ToString ();
	        }

	        private void comboBox_SelectedValueChanged (object sender, EventArgs e)
	        {
			if (listBox.SelectedIndex != -1)
	                	textbox_combobox.Text = comboBox.SelectedValue.ToString ();
	        }

	        private void checkedListbox_SelectedValueChanged (object sender, EventArgs e)
	        {
			if (checkedListbox.SelectedIndex != -1)
	                	textbox_checkedlistbox.Text = checkedListbox.SelectedValue.ToString ();
	        }


	        private void singledata_checkboxCheckedChanged (object sender, EventArgs e)
	        {
	        	if (singledata_checkbox.Checked) {
	        		comboBox.DataSource = simbols;
	        		checkedListbox.DataSource = simbols;

	        	} else {
	        		comboBox.DataSource = simbols.Clone ();
	        		checkedListbox.DataSource = simbols.Clone ();
	        	}
	        }

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}

}


