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
// ListBox Complex Databiding Sample
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
		public ourListBox ()
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
		private TextBox textBox = new TextBox ();

		public MainForm ()
		{
			Console.WriteLine ("ListBox [{0}] {1}", listBox.DataSource, listBox.DataSource == null);
			Console.WriteLine ("ListBox [{0}] {1}", listBox.DisplayMember, listBox.DisplayMember == string.Empty);
			Console.WriteLine ("ListBox [{0}] {1}", listBox.ValueMember, listBox.ValueMember == string.Empty);

			listBox.Location = new Point (20, 16);
			listBox.Size = new Size (250, 130);

			textBox.Location = new Point (20, 160) ;
			textBox.Size = new Size (250, 24) ;

			Controls.AddRange (new Control[] {listBox, textBox});
			ArrayList simbols = new ArrayList ();
			simbols.Add (new  Simbols ("Fons Monetari Internacional", "FMI"));
			simbols.Add (new  Simbols ("Centimetre", "cm"))  ;
			simbols.Add (new  Simbols ("Ferrocarril", "FC"));
			simbols.Add (new  Simbols ("Megahertz", "MHz")) ;
			simbols.Add (new  Simbols ("pesseta", "PTA"));
			simbols.Add (new  Simbols ("quilogram", "kg"));
			simbols.Add (new  Simbols ("watt", "W"));

			listBox.SelectedValueChanged += new EventHandler (listBox_SelectedValueChanged);

			listBox.DataSource = simbols;
			listBox.DisplayMember = "Descripcio";
			listBox.ValueMember = "Simbol";

            		ClientSize = new Size (350, 250);
            		Text = "ListBox Complex Databinding Sample";           		
            		
            		PropertyDescriptorCollection col = listBox._DataManager.GetItemProperties ();
						
			Console.WriteLine ("**Items {0}", col.Count);
			for (int i = 0; i < col.Count; i++)
				Console.WriteLine ("**   item [{0}], ComponentType:{1}, PropertyType:{2}, DisplayName {3}, Name {4}", col[i], col[i].ComponentType,
					col[i].PropertyType, col[i].DisplayName, col[i].PropertyType, col[i].Name);				
			
            	}

		private void listBox_SelectedValueChanged (object sender, EventArgs e)
	        {
		        Console.WriteLine ("Value changed {0}", listBox.SelectedIndex);
	        	    if (listBox.SelectedIndex != -1)
	                	textBox.Text = listBox.SelectedValue.ToString();
	        }

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}

}


