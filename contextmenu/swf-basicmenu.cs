//
//
// System.Windows.Forms ContextMenu simple context menu sample
//
//
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
// Autors:
//		Jordi Mas i Hernandez, jordi@ximian.com
//
// Copyright (C) Novell Inc., 2004
//
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleMenus
{
	class MainForm : System.Windows.Forms.Form
	{

		ContextMenu context_menu;

		public MainForm ()
		{

			Click += new EventHandler (OnClick);

			MenuItem item1 = new MenuItem ("File");
			MenuItem item2 = new MenuItem ("Print the file");
			MenuItem item3 = new MenuItem ("Print Preview");
			MenuItem item4 = new MenuItem ("-");
			MenuItem item5 = new MenuItem ("Save");
			MenuItem item6 = new MenuItem ("Exit");

			MenuItem item7 = new MenuItem ("Edit");
			item7.BarBreak = true;
			MenuItem item8 = new MenuItem ("Undo");
			MenuItem item9 = new MenuItem ("Cut");
			MenuItem item10 = new MenuItem ("Paste");


			MenuItem item12 = new MenuItem ("Format Table");
			item12.Break = true;
			MenuItem item13 = new MenuItem ("Format Page");

			MenuItem item14 = new MenuItem ();
			item14.Break = true;
			MenuItem item15 = new MenuItem ("Help");

			MenuItem[] items = new MenuItem[] {item1, item2, item3, item4, item5,
				item6, item7, item8, item9, item10, item12,
				item13, item14, item15};

			Text = "Basic ContextMenu Sample";
			context_menu = new 	ContextMenu (items);

		}


		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run (new MainForm());
		}

		void OnClick (object sender, EventArgs e)
		{
			Console.WriteLine ("TrackPopupMenu start");
			Console.WriteLine ("OnClick");

			Point pnt;
			pnt = PointToClient (MousePosition);
			context_menu.Show (this, pnt);
			Console.WriteLine ("TrackPopupMenu end");
		}
	}
}

