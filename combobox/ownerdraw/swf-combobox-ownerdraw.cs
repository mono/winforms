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
// Demostrates ownerdraw ComboBoxes
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
		private Label label_fixed;
		private ComboBox comboBox_fixed;
		private Label label_variable;
		private ComboBox comboBox_variable;
		private SolidBrush brush_black;
		private StringFormat string_format;

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
			Console.WriteLine ("Hello");
			InitializeComponent ();
		}

		void InitializeComponent ()
		{
			brush_black = new SolidBrush (Color.Black);
			string_format = new StringFormat ();
			comboBox_fixed = new ComboBox ();
			label_fixed = new Label ();
			comboBox_variable = new ComboBox ();
			label_variable = new Label ();

			/* Fixed */
			label_fixed.Text = "OwnerDrawFixed";
			label_fixed.Location = new Point (10,10);

			comboBox_fixed.Location = new Point (10,30);
			comboBox_fixed.Size = new Size (180, 100);
			comboBox_fixed.DrawItem += new DrawItemEventHandler (DrawItemHandler);
			comboBox_fixed.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_fixed.DrawMode = DrawMode.OwnerDrawFixed;

			/* Variable */
			label_variable.Text = "OwnerDrawVariable";
			label_variable.Location = new Point (210,10);
			label_variable.AutoSize = true;

			comboBox_variable.Location = new Point (210,30);
			comboBox_variable.Size = new Size (180, 100);
			comboBox_variable.DrawItem += new DrawItemEventHandler (DrawItemHandler);
			comboBox_variable.MeasureItem += new MeasureItemEventHandler (MeasureItemHandler);
			comboBox_variable.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_variable.DrawMode = DrawMode.OwnerDrawVariable;

			FontCollection ifc = new InstalledFontCollection ();

			foreach (FontFamily ffm in ifc.Families) {
				if (ffm.IsStyleAvailable (FontStyle.Regular)) {
					comboBox_fixed.Items.Add (new MyItem (ffm.Name + " Abcedf", ffm.Name));
					comboBox_variable.Items.Add (new MyItem (ffm.Name + " Abcedf", ffm.Name));
				}
			}

			Text = "ComboBox ownerdraw TextApp";
			ClientSize = new System.Drawing.Size (624, 309);
			Controls.Add (comboBox_fixed);
			Controls.Add (label_fixed);
			Controls.Add (comboBox_variable);
			Controls.Add (label_variable);
		}

		public void DrawItemHandler (object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
				return;

			MyItem item = (MyItem) comboBox_fixed.Items[e.Index];			
			
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
			MyItem item = (MyItem) comboBox_fixed.Items[e.Index];			
			e.ItemHeight = item.Font.Height;
		}


		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}
}
