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
	class DataGridBoolColumnTests
	{
		public void DumpDataGridBoolColumn (DataGridBoolColumn ts)
		{
			Console.WriteLine ("AllowNull {0} ", ts.AllowNull);
			Console.WriteLine ("FalseValue {0} ", ts.FalseValue);
			Console.WriteLine ("NullValue {0} ", ts.NullValue);
			Console.WriteLine ("TrueValue {0} ", ts.TrueValue);
			Console.WriteLine ("Alignment {0} ", ts.Alignment);
			Console.WriteLine ("DataGridTableStyle {0} ", ts.DataGridTableStyle);
			Console.WriteLine ("HeaderAccessibleObject {0} ", ts.HeaderAccessibleObject);
			Console.WriteLine ("HeaderText {0} ", ts.HeaderText);
			Console.WriteLine ("MappingName {0} ", ts.NullText);
			Console.WriteLine ("PropertyDescriptor {0} ", ts.PropertyDescriptor);
			Console.WriteLine ("ReadOnly {0} ", ts.ReadOnly);
			Console.WriteLine ("Width {0} ", ts.Width);
		}

		public DataGridBoolColumnTests ()
		{
			DataGridBoolColumn bc = new DataGridBoolColumn ();
			bc.FalseValueChanged += new System.EventHandler (OnFalseValueChanged);

			Console.WriteLine ("DataGridBoolColumn default --- ");
			DumpDataGridBoolColumn (bc);
			bc.FalseValue = true;

		}

		public static void Main (string[] args)
		{
			new DataGridBoolColumnTests ();
		}

		private void OnFalseValueChanged (object sender, System.EventArgs e)
		{
			Console.WriteLine ("FalseValueChanged fired");
		}

	}
}
