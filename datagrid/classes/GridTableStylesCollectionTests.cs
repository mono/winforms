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
//	Jordi Mas i Hernadez <jordi@ximian.com>
//
//

using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace DatagridTests
{
	class GridTableStylesCollectionTests
	{
		public void DumpGridTableStylesCollection (GridTableStylesCollection ts)
		{
			Console.WriteLine ("IsSynchronized {0} ", ts.IsSynchronized);
			Console.WriteLine ("SyncRoot {0} ", ts.SyncRoot);
			Console.WriteLine ("IsReadOnly {0} ", ts.IsReadOnly);
		}

		public GridTableStylesCollectionTests ()
		{
			DataGrid grid = new DataGrid ();
			GridTableStylesCollection sc = grid.TableStyles;
			sc.CollectionChanged += new CollectionChangeEventHandler (OnCollectionChanged);

			Console.WriteLine ("GridColumnStylesCollection default --- ");
			DumpGridTableStylesCollection (sc);

			Console.WriteLine ("Add single item");
			DataGridTableStyle ts = new DataGridTableStyle ();
			ts.MappingName = "Table1";
			sc.Add (ts);

			Console.WriteLine ("Add multipleitems");
			sc.AddRange (new DataGridTableStyle [] {new DataGridTableStyle (), new DataGridTableStyle ()});
			Console.WriteLine ("Remove At");
			sc.RemoveAt (2);

			Console.WriteLine ("Add single item");
			ts = new DataGridTableStyle ();
			ts.MappingName = "Table2";
			sc.Add (ts);

			for (int i = 0; i < sc.Count; i ++)
				Console.WriteLine ("Element {0}:{1}", i, sc[i].MappingName);

			sc.Remove (ts);
			Console.WriteLine ("Contains Table1 {0}", sc.Contains ("Table1"));
			Console.WriteLine ("Contains Table4 {0}", sc.Contains ("Table4"));
		}

		public static void Main (string[] args)
		{
			new GridTableStylesCollectionTests ();
		}

		private void OnCollectionChanged (object sender, CollectionChangeEventArgs e)
		{
			Console.WriteLine ("OnCollectionChanged fired: Action [{0}] Element [{1}]",
				e.Action, e.Element);
		}

	}
}
