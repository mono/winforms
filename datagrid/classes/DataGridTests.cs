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
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace DatagridTests
{
	
	class DataGridTests : Form
	{
		public void DumpDataGrid (DataGrid dg)
		{
			
			Console.WriteLine ("Datagrid default --- ");
			Console.WriteLine ("AllowNavigation {0} ", dg.AllowNavigation);
			Console.WriteLine ("AllowSorting {0} ", dg.AllowSorting);
			Console.WriteLine ("AlternatingBackColor {0} ", dg.AlternatingBackColor);
			Console.WriteLine ("BackColor {0} ", dg.BackColor);
			Console.WriteLine ("BackgroundColor {0} ", dg.BackgroundColor);
			Console.WriteLine ("BackgroundImage {0} ", dg.BackgroundImage);
			Console.WriteLine ("BorderStyle {0} ", dg.BorderStyle);
			Console.WriteLine ("CaptionBackColor {0} ", dg.CaptionBackColor);
			Console.WriteLine ("CaptionFont {0} ", dg.CaptionFont);
			Console.WriteLine ("CaptionForeColor {0} ", dg.CaptionForeColor);
			Console.WriteLine ("CaptionText {0} ", dg.CaptionText);
			Console.WriteLine ("CaptionVisible {0} ", dg.CaptionVisible);
			Console.WriteLine ("ColumnHeadersVisible {0} ", dg.ColumnHeadersVisible);
			Console.WriteLine ("CurrentCell {0} ", dg.CurrentCell);
			Console.WriteLine ("CurrentRowIndex {0} ", dg.CurrentRowIndex);
			Console.WriteLine ("Cursor {0} ", dg.Cursor);
			Console.WriteLine ("DataMember {0} ", dg.DataMember);
			Console.WriteLine ("DataSource {0} ", dg.DataSource);
			Console.WriteLine ("FirstVisibleColumn {0} ", dg.FirstVisibleColumn);
			Console.WriteLine ("FlatMode {0} ", dg.FlatMode);
			Console.WriteLine ("ForeColor {0} ", dg.ForeColor);
			Console.WriteLine ("GridLineColor {0} ", dg.GridLineColor);
			Console.WriteLine ("GridLineStyle {0} ", dg.GridLineStyle);
			Console.WriteLine ("HeaderBackColor {0} ", dg.HeaderBackColor);
			Console.WriteLine ("HeaderFont {0} ", dg.HeaderFont);
			Console.WriteLine ("HeaderForeColor {0} ", dg.HeaderForeColor);
			Console.WriteLine ("LinkColor {0} ", dg.LinkColor);
			Console.WriteLine ("LinkHoverColor {0} ", dg.LinkHoverColor);
			Console.WriteLine ("ParentRowsBackColor {0} ", dg.ParentRowsBackColor);
			Console.WriteLine ("ParentRowsForeColor {0} ", dg.ParentRowsForeColor);
			Console.WriteLine ("ParentRowsLabelStyle {0} ", dg.ParentRowsLabelStyle);
			Console.WriteLine ("ParentRowsVisible {0} ", dg.ParentRowsVisible);
			Console.WriteLine ("PreferredColumnWidth {0} ", dg.PreferredColumnWidth);
			Console.WriteLine ("PreferredRowHeight {0} ", dg.PreferredRowHeight);
			Console.WriteLine ("ReadOnly {0} ", dg.ReadOnly);
			Console.WriteLine ("RowHeadersVisible {0} ", dg.RowHeadersVisible);
			Console.WriteLine ("RowHeaderWidth {0} ", dg.RowHeaderWidth);
			Console.WriteLine ("SelectionBackColor {0} ", dg.SelectionBackColor);
			Console.WriteLine ("SelectionForeColor {0} ", dg.SelectionForeColor);
			Console.WriteLine ("Site {0} ", dg.Site);
			Console.WriteLine ("TableStyles{0} ", dg.TableStyles);
			Console.WriteLine ("Text {0} ", dg.Text);
			Console.WriteLine ("VisibleColumnCount {0} ", dg.VisibleColumnCount);
			Console.WriteLine ("VisibleRowCount {0} ", dg.VisibleRowCount);
		}

		public DataGridTests ()
		{			
			DataGrid dg = new DataGrid ();
			dg.Size = new Size (300,300);
			
			//dg.CreateControl ();
			
			//bc.FalseValueChanged += new System.EventHandler (OnFalseValueChanged);		
			//DumpDataGrid (dg);	
					
			CreateStylesFromDataSet (dg);
		}

		public static void Main (string[] args)
		{
			//new DataGridTests ();
			Application.Run(new DataGridTests ());
		}

		private void OnFalseValueChanged (object sender, System.EventArgs e)
		{
			Console.WriteLine ("FalseValueChanged fired");
		}
		
		private void CreateStylesFromDataSet (DataGrid dg)
		{			
			Console.WriteLine ("Datagrid StylesFromDataSet --- ");
			DataSet dsSource = new DataSet ();
			dg.DataSource = dsSource;			
			
			/* Load Data */
			DataTable users	= dsSource.Tables.Add ("Users");
			DataTable zipcodes = dsSource.Tables.Add ("ZipCodes");
			DataTable countries = dsSource.Tables.Add ("Countries");
			DataColumn users_id, zip_zipid, col;
			
			// Countries
			col = countries.Columns.Add ("name", Type.GetType ("System.String"));
			col.Caption = "Available Countries";

			// Zipcodes
			zip_zipid = zipcodes.Columns.Add ("zipID", Type.GetType ("System.Int32"));
			zip_zipid.AutoIncrement = true;
			zipcodes.Columns.Add ("area", Type.GetType ("System.String"));
			zipcodes.Columns.Add ("zipcode", Type.GetType ("System.String"));
			
			// Users
			users_id = users.Columns.Add ("userID", Type.GetType ("System.Int32"));
			users_id.AutoIncrement = true;
			users.Columns.Add ("name", Type.GetType	("System.String"));
			users.Columns.Add ("address", Type.GetType ("System.String"));
			users.Columns.Add ("zipcode", Type.GetType ("System.Int32"));		
			
			// Countries
			DataRow tempRow	= countries.NewRow ();
			tempRow["name"]	= "France";
			countries.Rows.Add(tempRow);

			tempRow	= countries.NewRow ();
			tempRow["name"]	= "Spain";
			countries.Rows.Add(tempRow);					
			
			ShowMappingName (dg.DataSource);
			Controls.Add (dg);
			
			dg.DataMember = "ZipCodes";			
			
			Console.WriteLine ("dg.BindingContext is null {0}",  dg.BindingContext == null);
			Console.WriteLine ("dg.BindingContext is null {0}",  BindingContext == null);
			
			//CurrencyManager manager = (CurrencyManager) dg.BindingContext 
			//	[dg.DataSource, dg.DataMember];
			
			//Console.WriteLine ("DataGrid.ListManager (CurrencyManager) cnt {0} [rows]", manager.Count);
			
			DataGridTableStyle tablestyles = new DataGridTableStyle ();
			//tablestyles.GridColumnStyles.Add (new DataGridBoolColumn ());
			tablestyles.MappingName = "ZipCodes";
			dg.TableStyles.Add (tablestyles);
			Console.WriteLine ("Table Styles {0}", tablestyles.GridColumnStyles.Count);
			
		}
		
		
		void ShowMappingName(object src)
		{
			string mapping_name;
		     IList list = null;
		     Type type = null;
		     if(src is Array)
		     {
		          type = src.GetType();
		          list = src as IList;
		     }
		     else
		     {
		          if(src is IListSource)
		               src = (src as IListSource).GetList();
		          if(src is IList)
		          {
		               type = src.GetType();
		               list = src as IList;
		          }
		          else
		          {
		               MessageBox.Show("error");
		               return;
		          }
		     }
		     if(list is ITypedList)
		          mapping_name = (list as ITypedList).GetListName(null);
		     else
		          mapping_name = type.Name;
		          
		     Console.WriteLine ("SourceData={0}", mapping_name);
		} 
		
		private void CreateStylesFromArray ()
		{
			
		}

	}
}
