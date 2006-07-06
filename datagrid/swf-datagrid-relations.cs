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
//	Chris Toshok <toshok@ximian.com>
//
//
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

namespace DatagridSamples
{
	class DataGridTestRelations : Form
	{
		private DataGrid dataGrid;		
		private Label label_backcolor;
		private Label label_altbackcolor;
		private Label label_backgroundcolor;

		public DataGridTestRelations ()
		{
			InitializeComponent ();
		}

		private void parentrowsvisibleChecked (object sender, System.EventArgs e)
		{
			dataGrid.ParentRowsVisible  = !dataGrid.ParentRowsVisible ;
		}

		private void allowNavigateChecked (object sender, System.EventArgs e)
		{
			dataGrid.AllowNavigation = !dataGrid.AllowNavigation;
		}

		private void rowshdrsvisibleChecked (object sender, System.EventArgs e)
		{
			dataGrid.RowHeadersVisible = !dataGrid.RowHeadersVisible;
		}

		private void button_navigateClicked (object sender, System.EventArgs e)
		{
			dataGrid.NavigateTo (3, "Customer_Addresses");

			Console.WriteLine ("dataGrid.DataMember = {0}", dataGrid.DataMember);
		}

		private void button_navigate2Clicked (object sender, System.EventArgs e)
		{
			dataGrid.NavigateTo (3, "Address_Orders");

			Console.WriteLine ("dataGrid.DataMember = {0}", dataGrid.DataMember);
		}

		private void button_toggleexpansionClicked (object sender, System.EventArgs e)
		{
			if (dataGrid.IsExpanded (3))
				dataGrid.Collapse (3);
			else
				dataGrid.Expand (3);
		}

		private void button_navigateBackClicked (object sender, System.EventArgs e)
		{
			dataGrid.NavigateBack ();
		}

		void InitializeComponent ()
		{			
			dataGrid = new DataGrid ();

			SuspendLayout ();

			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new System.Drawing.Point (10, 50);
			dataGrid.Name = "dataGrid";
			dataGrid.Size = new System.Drawing.Size (500, 500);

			CheckBox checkbox_parentrowsvisible  = new CheckBox ();
			checkbox_parentrowsvisible.Location = new System.Drawing.Point (430 + 100, 190);
			checkbox_parentrowsvisible.Text = "ParentRowsVisible";
			checkbox_parentrowsvisible.Size = new Size (140, 20);
			checkbox_parentrowsvisible.Click += new System.EventHandler (parentrowsvisibleChecked);
			checkbox_parentrowsvisible.Checked = dataGrid.ParentRowsVisible;
			Controls.Add (checkbox_parentrowsvisible);

			CheckBox checkbox_allownavigate = new CheckBox ();
			checkbox_allownavigate.Location = new System.Drawing.Point (430 + 240, 190);
			checkbox_allownavigate.Text = "AllowNavigation";
			checkbox_allownavigate.Click += new System.EventHandler (allowNavigateChecked);
			checkbox_allownavigate.Checked = dataGrid.AllowNavigation;
			Controls.Add (checkbox_allownavigate);

			CheckBox checkbox_rowshdrsvisible  = new CheckBox ();
			checkbox_rowshdrsvisible.Location = new System.Drawing.Point (430 + 100, 220);
			checkbox_rowshdrsvisible.Text = "RowHeadersVisible";
			checkbox_rowshdrsvisible.Size = new Size (140, 20);
			checkbox_rowshdrsvisible.Click += new System.EventHandler (rowshdrsvisibleChecked);
			checkbox_rowshdrsvisible.Checked = dataGrid.RowHeadersVisible;
			Controls.Add (checkbox_rowshdrsvisible);

			Button button_navigate = new Button ();
			button_navigate.Location = new System.Drawing.Point (430 + 100, 300);
			button_navigate.Text = "Navigate to Address";
			button_navigate.Size = new Size (100, 30);
			button_navigate.Click += new System.EventHandler (button_navigateClicked);
			Controls.Add (button_navigate);

			Button button_navigate2 = new Button ();
			button_navigate2.Location = new System.Drawing.Point (430 + 220, 300);
			button_navigate2.Text = "Navigate to Order";
			button_navigate2.Size = new Size (100, 30);
			button_navigate2.Click += new System.EventHandler (button_navigate2Clicked);
			Controls.Add (button_navigate2);

			Button button_navigateBack = new Button ();
			button_navigateBack.Location = new System.Drawing.Point (430 + 100, 340);
			button_navigateBack.Text = "Navigate Back";
			button_navigateBack.Size = new Size (100, 30);
			button_navigateBack.Click += new System.EventHandler (button_navigateBackClicked);
			Controls.Add (button_navigateBack);

			Button button_toggleexpansion = new Button ();
			button_toggleexpansion.Location = new System.Drawing.Point (430 + 100, 380);
			button_toggleexpansion.Text = "Toggle Row 3 Expanded";
			button_toggleexpansion.Size = new Size (100, 30);
			button_toggleexpansion.Click += new System.EventHandler (button_toggleexpansionClicked);
			Controls.Add (button_toggleexpansion);

			//
			// MainForm
			//
			AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			ClientSize = new System.Drawing.Size (800, 700);
			Controls.Add (dataGrid);
			Text = "DataGridTestProperties";
			Load += new System.EventHandler(MainFormLoad);
			ResumeLayout (false);
		}


		void MainFormLoad (object sender, System.EventArgs e)
		{
			((System.ComponentModel.ISupportInitialize)(dataGrid)).BeginInit();
			FillDataSetLarge ();
			((System.ComponentModel.ISupportInitialize)(dataGrid)).EndInit();
		}

		private void FillDataSetLarge ()
		{		
			DataSet dataset = new DataSet ("CustomerSet");
			DataTable dt1 = new DataTable ("Customers");
			DataTable dt2 = new DataTable ("Orders");
			DataTable dt3 = new DataTable ("Addresses");
			DataColumn column;

			// customer table
			column = new DataColumn ("CustomerID");
			column.DataType = typeof (int);
			column.Unique = true;
			dt1.Columns.Add (column);

			column = new DataColumn ("CustomerName");
			column.DataType = typeof (string);
			column.Unique = false;
			dt1.Columns.Add (column);

			// order table
			column = new DataColumn ("OrderID");
			column.DataType = typeof (int);
			column.Unique = true;
			dt2.Columns.Add (column);

			column = new DataColumn ("ItemName");
			column.DataType = typeof (string);
			column.Unique = false;
			dt2.Columns.Add (column);

			column = new DataColumn ("CustomerID");
			column.DataType = typeof (int);
			column.Unique = false;
			dt2.Columns.Add (column);

			column = new DataColumn ("AddressID");
			column.DataType = typeof (int);
			column.Unique = false;
			dt2.Columns.Add (column);

			// address table
			column = new DataColumn ("AddressID");
			column.DataType = typeof (int);
			column.Unique = true;
			dt3.Columns.Add (column);

			column = new DataColumn ("AddressString");
			column.DataType = typeof (string);
			column.Unique = false;
			dt3.Columns.Add (column);

			column = new DataColumn ("CustomerID");
			column.DataType = typeof (int);
			column.Unique = false;
			dt3.Columns.Add (column);

			for (int i = 0; i < 10; i ++) {
				DataRow row = dt1.NewRow ();
				row["CustomerID"] = i;
				row["CustomerName"] = String.Format ("Customer Name #{0}", i);
				dt1.Rows.Add (row);
			}

			int ordernum = 0;
			for (int i = 0; i < 10; i ++) {
				for (int j = 0; j < 4; j ++) {
					DataRow row = dt2.NewRow ();
					row["OrderID"] = ordernum++;
					row["ItemName"] = String.Format ("Item order #{0}", j);
					row["CustomerID"] = 9-i;
					row["AddressID"] = j;
					dt2.Rows.Add (row);
				}
			}

			int addressid = 0;
			for (int i = 0; i < 4; i ++) {
				for (int j = 0; j < 4; j ++) {
					DataRow row = dt3.NewRow ();
					row["AddressID"] = addressid++;
					row["AddressString"] = String.Format ("Customer Address {0}", j);
					row["CustomerID"] = i;
					dt3.Rows.Add (row);
				}
			}

			dataset.Tables.Add (dt1);
			dataset.Tables.Add (dt2);
			dataset.Tables.Add (dt3);
			dataset.Relations.Add ("Customer_Orders", dt1.Columns["CustomerID"], dt2.Columns["CustomerID"]);
			dataset.Relations.Add ("Customer_Addresses", dt1.Columns["CustomerID"], dt3.Columns["CustomerID"]);
			dataset.Relations.Add ("Address_Orders", dt3.Columns["AddressID"], dt2.Columns["AddressID"]);

			dataGrid.DataSource = dataset;
			dataGrid.DataMember = "Customers";
			dataGrid.AllowNavigation = true;
		}

	}
}
