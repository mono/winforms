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
// Tests DataGridTableStyles class implementation
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatagridTests
{
	class DataGridTableStylesTests
	{
		public class ourDataGridTableStyle : System.Windows.Forms.DataGridTableStyle
		{
			public ourDataGridTableStyle () : base ()
			{

			}

			public void DumpDataGridTableStyleShouldSerialize ()
			{
				Console.WriteLine ("ShouldSerializeAlternatingBackColor {0} ", ShouldSerializeAlternatingBackColor ());
				Console.WriteLine ("ShouldSerializeBackColor {0} ", ShouldSerializeBackColor ());
				Console.WriteLine ("ShouldSerializeForeColor {0} ", ShouldSerializeForeColor ());
				Console.WriteLine ("ShouldSerializeGridLineColor {0} ", ShouldSerializeGridLineColor ());
				Console.WriteLine ("ShouldSerializeHeaderBackColor {0} ", ShouldSerializeHeaderBackColor ());
				Console.WriteLine ("ShouldSerializeHeaderForeColor {0} ", ShouldSerializeHeaderForeColor ());
				Console.WriteLine ("ShouldSerializeLinkColor {0} ", ShouldSerializeLinkColor ());
				Console.WriteLine ("ShouldSerializeLinkHoverColor {0} ", ShouldSerializeLinkHoverColor ());
				Console.WriteLine ("ShouldSerializePreferredRowHeight {0} ", ShouldSerializePreferredRowHeight ());
				Console.WriteLine ("ShouldSerializeSelectionBackColor {0} ", ShouldSerializeSelectionBackColor ());
				Console.WriteLine ("ShouldSerializeSelectionForeColor {0} ", ShouldSerializeSelectionForeColor ());
			}
		}

		public void DumpDataGridTableStyleProperties (DataGridTableStyle ts)
		{
			Console.WriteLine ("AllowSorting {0} ", ts.AllowSorting);
			Console.WriteLine ("AlternatingBackColor {0} ", ts.AlternatingBackColor);
			Console.WriteLine ("BackColor {0} ", ts.BackColor);
			Console.WriteLine ("ColumnHeadersVisible {0} ", ts.ColumnHeadersVisible);
			Console.WriteLine ("ForeColor {0} ", ts.ForeColor);
			Console.WriteLine ("GridLineColor {0} ", ts.GridLineColor);
			Console.WriteLine ("GridLineStyle {0} ", ts.GridLineStyle);
			Console.WriteLine ("HeaderBackColor {0} ", ts.HeaderBackColor);
			Console.WriteLine ("HeaderFont {0} ", ts.HeaderFont);
			Console.WriteLine ("HeaderForeColor {0} ", ts.HeaderForeColor);
			Console.WriteLine ("LinkColor {0} ", ts.LinkColor);
			Console.WriteLine ("LinkHoverColor {0} ", ts.LinkHoverColor);
			Console.WriteLine ("MappingName {0} ", ts.MappingName);
			Console.WriteLine ("PreferredColumnWidth {0} ", ts.PreferredColumnWidth);
			Console.WriteLine ("PreferredRowHeight {0} ", ts.PreferredRowHeight);
			Console.WriteLine ("ReadOnly {0} ", ts.ReadOnly);
			Console.WriteLine ("RowHeadersVisible {0} ", ts.RowHeadersVisible);
			Console.WriteLine ("RowHeaderWidth {0} ", ts.RowHeaderWidth);
			Console.WriteLine ("SelectionBackColor {0} ", ts.SelectionBackColor);
			Console.WriteLine ("SelectionForeColor {0} ", ts.SelectionForeColor);
		}

		public DataGridTableStylesTests ()
		{
			ourDataGridTableStyle ts = new ourDataGridTableStyle ();
			Console.WriteLine ("DataGridTableStyle default --- ");
			DumpDataGridTableStyleProperties (ts);

			ts.BackColor = Color.White;
			ts.SelectionForeColor = Color.Blue;

			ts.DumpDataGridTableStyleShouldSerialize ();
			Console.WriteLine ("BackColor {0} ", ts.BackColor);

			ts.ResetBackColor ();
			ts.ResetSelectionForeColor ();
			Console.WriteLine ("DataGridTableStyle after Reset --- ");
			DumpDataGridTableStyleProperties (ts);
		}

		public static void Main (string[] args)
		{
			new DataGridTableStylesTests ();
		}

	}
}
