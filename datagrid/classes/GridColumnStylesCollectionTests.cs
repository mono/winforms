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
using System.Drawing;
using System.Windows.Forms;

namespace DatagridTests
{
	class GridColumnStylesCollectionTests
	{
		public void DumpGridColumnStylesCollection (GridColumnStylesCollection ts)
		{
			Console.WriteLine ("IsSynchronized {0} ", ts.IsSynchronized);
			Console.WriteLine ("SyncRoot {0} ", ts.SyncRoot);
			//Console.WriteLine ("IsFixedSize {0} ", ts.IsFixedSize);
			Console.WriteLine ("IsReadOnly {0} ", ts.IsReadOnly);
		}

		public GridColumnStylesCollectionTests ()
		{
			DataGridTableStyle ts = new DataGridTableStyle ();
			GridColumnStylesCollection sc = ts.GridColumnStyles;

			Console.WriteLine ("GridColumnStylesCollection default --- ");
			DumpGridColumnStylesCollection (sc);

		}

		public static void Main (string[] args)
		{
			new GridColumnStylesCollectionTests ();
		}
	}
}

