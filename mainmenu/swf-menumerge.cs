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
// MenuMerge function testing
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFormProject
{

	class ourContextMenu: ContextMenu
	{
		public ourContextMenu ()
		{

		}

		public ourContextMenu (MenuItem[] items) : base (items)
		{

		}

		public void Dump (ourContextMenu src)
		{
			int pos;

			for (int i = 0; i < MenuItems.Count; i++) {
				pos = src.FindMergePosition (MenuItems[i].MergeOrder);
				Console.WriteLine ("*Pos: {0} item {1}", pos, MenuItems[i].Text);
			}
		}

	}

	class TestApp
	{
		ListBox listBoxFirst;
		ListBox listBoxSecond;
		ListBox listBoxResult;
		Button	buttonAdd;
		Button	buttonMerge;
		Button	buttonRemove;
		Button	buttonReplace;

		ourContextMenu menu;

		public TestApp ()
		{
			InitializeComponent ();
		}

		void InitializeComponent ()
		{

			MenuItem item1 = new MenuItem ("File (0)");		// Position 0
			MenuItem item2 = new MenuItem ("Print the file (1)");	// Position 1
			MenuItem item3 = new MenuItem ("Print Preview (2)");	// Position 2
			MenuItem item4 = new MenuItem ("-");			// Position 3
			MenuItem item5 = new MenuItem ("Recent files (4)");		// Position 4
			MenuItem item6 = new MenuItem ("Exit (5)");		// Position 5

			MenuItem item10 = new MenuItem ("Compare... (6)");	// Replace pos 3
			MenuItem item11 = new MenuItem ("Sort (7)");
			MenuItem item12 = new MenuItem ("Conversions (8)");
			MenuItem item13 = new MenuItem ("Specials Functions (9)");
			MenuItem item14 = new MenuItem ("Another option... (10)");

			MenuItem item20 = new MenuItem ("autors.doc");
			MenuItem item21 = new MenuItem ("testing.html");
			MenuItem item22 = new MenuItem ("proves.txt");
			
			MenuItem[] first_items = new MenuItem[] {item1, item2, item3, item4, item5, item6};
			MenuItem[] second_items = new MenuItem[] {item10, item11, item12, item13, item14};
			MenuItem[] third_items = new MenuItem[] {item20, item21, item22};
			
			item14.MergeType = MenuMerge.Remove;
			item10.MergeOrder = 40;

			item11.MergeType = MenuMerge.Replace;
			item11.MergeOrder = 30;
			item12.MergeOrder = 5;
			item10.MergeType = MenuMerge.MergeItems;			

			ourContextMenu first_menu = new ourContextMenu (first_items);
			ourContextMenu second_menu = new ourContextMenu (second_items);
			ourContextMenu third_menu = new ourContextMenu (third_items);

			//first_menu.Dump (merge_menu);
			//merge_menu.Dump (first_menu);

			first_menu.MergeMenu (second_menu);
			first_menu.MergeMenu (third_menu);


			for (int i = 0; i < first_menu.MenuItems.Count; i++)
				Console.WriteLine ("{0}", first_menu.MenuItems[i].Text);

		}


		public static void Main (string[] args)
		{
			new TestApp ();
		}
	}
}
