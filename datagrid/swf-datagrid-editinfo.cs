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
// Copyright (c) 2006 Novell, Inc. (http://www.novell.com)
//
// Author:
//	Chris Toshok <toshok@ximian.com>
//
//

using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace DatagridSamples
{
	class MyDataGridTextBox : DataGridTextBox
	{
		protected override void SetVisibleCore (bool value)
		{
			Console.WriteLine ("SetVisibleCore ({0})\n{1}", value, Environment.StackTrace);
			base.SetVisibleCore (value);
		}
	}

	class MyDataGridColumn : DataGridTextBoxColumn
	{
		public MyDataGridColumn (PropertyDescriptor prop,  bool isDefault)
			: base (prop, isDefault)
		{
			Console.WriteLine ("MyDataGridColumn.ctor");
			Console.WriteLine ("TextBox bounds = {0} and is {1}, parent = {2}", TextBox.Bounds, TextBox.Visible ? "visible" : "not visible", TextBox.Parent == null ? "null" : TextBox.Parent.GetType().ToString());
		}

		protected override void ColumnStartedEditing (Control editingControl)
		{
			Console.WriteLine ("ColumnStartedEditing {0} {1}\n{2}", editingControl.GetType (), editingControl.Bounds, Environment.StackTrace);
			base.ColumnStartedEditing (editingControl);
		}

		protected override void ConcedeFocus ()
		{
			Console.WriteLine ("ConcedeFocus {0}", Environment.StackTrace);
			base.ConcedeFocus ();
		}

		protected override bool Commit (CurrencyManager dataSource, int rowNum)
		{
			Console.WriteLine ("Commit (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
			return base.Commit (dataSource, rowNum);
		}

		protected override void Abort (int rowNum)
		{
			Console.WriteLine ("Abort row {0}", rowNum);
			Console.WriteLine (Environment.StackTrace);
		}

		protected override void Edit (CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
		{
			Console.WriteLine ("TextBox bounds = {0} and is {1}, parent = {2}", TextBox.Bounds, TextBox.Visible ? "visible" : "not visible", TextBox.Parent == null ? "null" : TextBox.Parent.GetType().ToString());
			Console.WriteLine ("Edit\n{0}", Environment.StackTrace);
			base.Edit (source, rowNum, bounds, readOnly, instantText, cellIsVisible);
			Console.WriteLine ("TextBox bounds = {0} and is {1}, parent = {2}", TextBox.Bounds, TextBox.Visible ? "visible" : "not visible", TextBox.Parent == null ? "null" : TextBox.Parent.GetType().ToString());
		}

		protected override void EnterNullValue ()
		{
			Console.WriteLine ("EnterNullValue\n{0}", Environment.StackTrace);
			base.EnterNullValue ();
		}

		protected override object GetColumnValueAtRow (CurrencyManager source, int rowNum)
		{
			Console.WriteLine ("GetColumnValueAtRow (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
			return base.GetColumnValueAtRow (source, rowNum);
		}

		protected override void Invalidate ()
		{
			Console.WriteLine ("Invalidate\n{0}", Environment.StackTrace);
			base.Invalidate ();
		}

		protected override void SetDataGridInColumn (DataGrid value)
		{
			Console.WriteLine ("SetDataGridInColumn\n{0}", Environment.StackTrace);
			base.SetDataGridInColumn (value);
		}

		protected override void UpdateUI (CurrencyManager source, int rowNum, string instantText)
		{
			Console.WriteLine ("TextBox bounds = {0} and is {1}, parent = {2}", TextBox.Bounds, TextBox.Visible ? "visible" : "not visible", TextBox.Parent == null ? "null" : TextBox.Parent.GetType().ToString());
			Console.WriteLine ("UpdateUI ({0}, {1})\n{2}", rowNum, instantText, Environment.StackTrace);
			base.UpdateUI (source, rowNum, instantText);
		}

		MyDataGridTextBox textbox;
		public override TextBox TextBox {
			get {
				//Console.WriteLine ("get_TextBox\n{0}", Environment.StackTrace);
				return base.TextBox;
			}
		}

		DataGrid grid;
		protected override void SetDataGrid (DataGrid value)
		{
			Console.WriteLine ("SetDataGrid\n{0}", Environment.StackTrace);
			grid = value;
			base.SetDataGrid (value);
		}

		MyDataGridTextBox CreateTextBox ()
		{
			MyDataGridTextBox textbox = new MyDataGridTextBox ();
			textbox.SetDataGrid (DataGridTableStyle.DataGrid);
			textbox.Multiline = true;
			textbox.WordWrap = false;
			textbox.BorderStyle = BorderStyle.None;
			textbox.Visible = false;

			return textbox;
		}
	}

	class MyDataGridBoolColumn : DataGridBoolColumn
	{
		public MyDataGridBoolColumn (PropertyDescriptor prop, bool isDefault)
			: base (prop, isDefault)
		{
			Console.WriteLine ("MyDataGridBoolColumn.ctor");
		}

		protected override void ColumnStartedEditing (Control editingControl)
		{
			Console.WriteLine ("ColumnStartedEditing {0} {1}\n{2}", editingControl.GetType (), editingControl.Bounds, Environment.StackTrace);
			base.ColumnStartedEditing (editingControl);
		}

		protected override void ConcedeFocus ()
		{
			Console.WriteLine ("ConcedeFocus {0}", Environment.StackTrace);
			base.ConcedeFocus ();
		}

		protected override bool Commit (CurrencyManager dataSource, int rowNum)
		{
			Console.WriteLine ("Commit (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
			return base.Commit (dataSource, rowNum);
		}

		protected override void Abort (int rowNum)
		{
			Console.WriteLine ("Abort row {0}", rowNum);
			Console.WriteLine (Environment.StackTrace);
		}

		protected override void Edit (CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
		{
			Console.WriteLine ("Edit\n{0}", Environment.StackTrace);
			base.Edit (source, rowNum, bounds, readOnly, instantText, cellIsVisible);
		}

		protected override void EnterNullValue ()
		{
			Console.WriteLine ("EnterNullValue\n{0}", Environment.StackTrace);
			base.EnterNullValue ();
		}

		protected override object GetColumnValueAtRow (CurrencyManager source, int rowNum)
		{
			Console.WriteLine ("GetColumnValueAtRow (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
			return base.GetColumnValueAtRow (source, rowNum);
		}

		protected override void Invalidate ()
		{
			Console.WriteLine ("Invalidate\n{0}", Environment.StackTrace);
			base.Invalidate ();
		}

		protected override void UpdateUI (CurrencyManager source, int rowNum, string instantText)
		{
			Console.WriteLine ("UpdateUI ({0}, {1})\n{2}", rowNum, instantText, Environment.StackTrace);
			base.UpdateUI (source, rowNum, instantText);
		}
	}

	class MyDataGridTableStyle : DataGridTableStyle {
		public MyDataGridTableStyle ()
		{
			MappingName = "Users";
		}


		protected override DataGridColumnStyle CreateGridColumn (PropertyDescriptor prop,  bool isDefault)
		{
			if (prop.PropertyType == typeof (bool))
				return new MyDataGridBoolColumn (prop, isDefault);
			return new MyDataGridColumn (prop, isDefault);
		}

	}

	class MyDataGrid : DataGrid {
		protected override void ColumnStartedEditing (Control editingControl)
		{
			Console.WriteLine ("in ColumnStartedEditing {0} {1}", editingControl.GetType (), Environment.StackTrace);
			base.ColumnStartedEditing (editingControl);
		}

		protected override void ColumnStartedEditing (Rectangle bounds)
		{
			Console.WriteLine ("in ColumnStartedEditing {0} {1}", bounds, Environment.StackTrace);
			base.ColumnStartedEditing (bounds);
		}

		protected override string GetOutputTextDelimiter ()
		{
			Console.WriteLine ("GetOutputTextDelimiter {0}", Environment.StackTrace);
			return base.GetOutputTextDelimiter ();
		}

		protected override void CancelEditing ()
		{
			if (base.ListManager != null) {
				Console.WriteLine ("In CancelEditing, ListManager.Position = {0}",
				base.ListManager.Position);
				Console.WriteLine (Environment.StackTrace);
			}
			base.CancelEditing ();
		}

		public CurrencyManager GetListManager ()
		{
			return base.ListManager;
		}
	}

	class DataGridEditInfo : Form
	{
		private MyDataGrid dataGrid;
		private DataSet dsSource = new DataSet ();
		private DataTable programs;
		private DataTable applications;
		private DataTable utilities;

		public DataGridEditInfo ()
		{
			InitializeComponent ();
		}

		void InitializeComponent ()
		{
			SuspendLayout ();

			//
			// dataGrid
			//
			dataGrid = new MyDataGrid ();
			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new System.Drawing.Point (10, 10);
			dataGrid.Name = "dataGrid";
			dataGrid.Size = new System.Drawing.Size (500, 500);
			dataGrid.TableStyles.Add (new MyDataGridTableStyle ());
			dataGrid.CurrentCellChanged += current_cell_changed;

			Button test1 = new Button ();
			test1.Location = new System.Drawing.Point (430 + 100, 50);
			test1.Text = "Edit cell [1,1]";
			test1.Size = new Size (100, 30);
			test1.Click += new System.EventHandler (test1_clicked);
			Controls.Add (test1);

			Button test2 = new Button ();
			test2.Location = new System.Drawing.Point (430 + 220, 50);
			test2.Text = "Set Current";
			test2.Size = new Size (100, 30);
			test2.Click += new System.EventHandler (test2_clicked);
			Controls.Add (test2);

			//
			// MainForm
			//
			Text = "SWF-Datagrid Styles";
			ClientSize = new System.Drawing.Size (850, 650);
			Controls.Add(dataGrid);
			Load += new System.EventHandler(MainFormLoad);
			ResumeLayout (false);
		}

		void MainFormLoad (object sender, System.EventArgs e)
		{
			FillDataSet ();
			dataGrid.ReadOnly = false;
			dataGrid.Layout += new LayoutEventHandler (doing_layout);
			return;
		}

		private void FillDataSet ()
		{
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
			zipcodes.PrimaryKey = new DataColumn [] {zip_zipid};

			// Users
			users_id = users.Columns.Add ("userID", Type.GetType ("System.Int32"));
			users_id.AutoIncrement = true;
			users.Columns.Add ("name", Type.GetType	("System.String"));
			users.Columns.Add ("address", Type.GetType ("System.String"));
			users.Columns.Add ("zipcode", Type.GetType ("System.Int32"));
			users.Columns.Add ("useaddress", Type.GetType ("System.Boolean"));

			users.PrimaryKey = new DataColumn [] {users_id};


			DataRelation rel = new DataRelation ("relation",
				new DataColumn [] {zipcodes.Columns["zipID"]}, // parent
				new DataColumn [] {users.Columns["zipcode"]}); // child, consumer

			dsSource.Relations.Add (rel);

			// Zip codes
			DataRow	tempRow	= zipcodes.NewRow ();
			tempRow["area"]	= "Eixample";
			tempRow["zipcode"] = "08039";
			zipcodes.Rows.Add(tempRow);

			tempRow	= zipcodes.NewRow ();
			tempRow["area"]	= "Clot";
			tempRow["zipcode"] = "08026";
			zipcodes.Rows.Add(tempRow);

			// Users
			tempRow	= users.NewRow ();
			tempRow["name"]	= "Joan";
			tempRow["address"] = "Balmes 152";
			tempRow["zipcode"] = "1";
			tempRow["useaddress"] = true;
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Pere";
			tempRow["address"] = "Provenca 55";
			tempRow["zipcode"] = "1";
			tempRow["useaddress"] = false;
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Jordi";
			tempRow["address"] = "Londres 16";
			tempRow["zipcode"] = "1";
			tempRow["useaddress"] = false;
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Marta";
			tempRow["address"] = "Padilla 210";
			tempRow["zipcode"] = "0";
			tempRow["useaddress"] = false;
			users.Rows.Add(tempRow);

			// Countries
			tempRow	= countries.NewRow ();
			tempRow["name"]	= "France";
			countries.Rows.Add(tempRow);

			tempRow	= countries.NewRow ();
			tempRow["name"]	= "Spain";
			countries.Rows.Add(tempRow);

			tempRow	= countries.NewRow ();
			tempRow["name"]	= "Italy";
			countries.Rows.Add(tempRow);
			dataGrid.DataSource = dsSource;
			dataGrid.DataMember = "Users";

			dataGrid.GetListManager().ItemChanged += list_manager_item_changed;
			dataGrid.GetListManager().MetaDataChanged += list_manager_metadata_changed;
			dataGrid.GetListManager().PositionChanged += list_manager_position_changed;
			dataGrid.GetListManager().CurrentChanged += list_manager_current_changed;

			users.RowChanging += users_RowChanging;
			users.RowChanged += users_RowChanged;
			users.ColumnChanging += users_ColumnChanging;
			users.ColumnChanged += users_ColumnChanged;
		}

		void test1_clicked (object sender, EventArgs e)
		{
			//CurrencyManager mgr = (CurrencyManager)dataGrid.BindingContext[dsSource.Tables["Users"]];
			//mgr.Position=rowtoedit;
			Console.WriteLine ("there are {0} tablestyles", dataGrid.TableStyles.Count);
			Console.WriteLine ("there are {0} columns in the programes Users", dataGrid.TableStyles["Users"].GridColumnStyles.Count);
			DataGridTextBoxColumn dgc = (DataGridTextBoxColumn)dataGrid.TableStyles["Users"].GridColumnStyles[1];
			dataGrid.BeginEdit(dgc, 1);

			Console.WriteLine ("dgc.TextBox bounds = {0} and is {1}, parent = {2}", dgc.TextBox.Bounds, dgc.TextBox.Visible ? "visible" : "not visible", dgc.TextBox.Parent == null ? "null" : dgc.TextBox.Parent.GetType().ToString());

			dgc.TextBox.Text = "testing!";

			// Insert code to edit the value.
			dataGrid.EndEdit(dgc, 1, false);
		}

		void test2_clicked (object sender, EventArgs e)
		{
			/* just set the current cell's row/column to something large */
			dataGrid.CurrentCell = new DataGridCell (100, 100);
			Console.WriteLine ("DataGrid's current cell = {0}", dataGrid.CurrentCell);
		}

		void doing_layout (object sender, LayoutEventArgs a)
		{
			//Console.WriteLine ("laying out");
			//Console.WriteLine (Environment.StackTrace);
		}

		void list_manager_item_changed (object sender, ItemChangedEventArgs e)
		{
			Console.WriteLine ("list manager item changed (index = {0})", e.Index);
			Console.WriteLine (Environment.StackTrace);
		}

		void list_manager_metadata_changed (object sender, EventArgs e)
		{
			Console.WriteLine ("list manager metadata changed");
			Console.WriteLine (Environment.StackTrace);
		}

		void list_manager_position_changed (object sender, EventArgs e)
		{
			Console.WriteLine ("list manager position changed to {0}", dataGrid.GetListManager().Position);
			Console.WriteLine (Environment.StackTrace);
		}

		void list_manager_current_changed (object sender, EventArgs e)
		{
			Console.WriteLine ("list manager current changed, position = {0}", dataGrid.GetListManager().Position);
			Console.WriteLine (Environment.StackTrace);
		}

		void current_cell_changed (object sender, EventArgs e)
		{
			Console.WriteLine ("current cell = {0}", dataGrid.CurrentCell);
			Console.WriteLine (Environment.StackTrace);
		}

		void users_RowChanging (object sender, DataRowChangeEventArgs arg)
		{
			Console.WriteLine ("users_RowChanging, {0}", Environment.StackTrace);
		}

		void users_RowChanged (object sender, DataRowChangeEventArgs arg)
		{
			Console.WriteLine ("users_RowChanged, {0}", Environment.StackTrace);
		}

		void users_ColumnChanging (object sender, DataColumnChangeEventArgs arg)
		{
			Console.WriteLine ("users_ColumnChanging, {0}", Environment.StackTrace);
		}

		void users_ColumnChanged (object sender, DataColumnChangeEventArgs arg)
		{
			Console.WriteLine ("users_ColumnChanged, {0}", Environment.StackTrace);
		}
	}
}
