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
//	Jordi Mas i Hernandez <jordi@ximian.com>
//
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatagridTests
{
	class DataGridCellTests
	{
		public DataGridCellTests ()
		{
			DataGridCell dg = new DataGridCell ();
			Console.WriteLine ("DataGridCell default --- ");
			Console.WriteLine ("Column {0}", dg.RowNumber);
			Console.WriteLine ("Row {0}", dg.ColumnNumber);

			dg.RowNumber = 10;
			dg.ColumnNumber = 5;

			Console.WriteLine ("ToString {0}", dg.ToString ());
			Console.WriteLine ("GetHashCode {0}", dg.GetHashCode ());
		}

		public static void Main (string[] args)
		{
			new DataGridCellTests ();
		}


	}
}
