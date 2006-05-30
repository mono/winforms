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

		private void readonlyChecked (object sender, System.EventArgs e)
		{
			dataGrid.ReadOnly = !dataGrid.ReadOnly;
		}

		private void rowshdrsvisibleChecked (object sender, System.EventArgs e)
		{
			dataGrid.RowHeadersVisible = !dataGrid.RowHeadersVisible;
		}

		private void button_backcolorClick (object sender, System.EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog ();

			if (DialogResult.OK == colorDialog.ShowDialog ()) {
				dataGrid.BackColor = colorDialog.Color;
				label_backcolor.Text = "Back color: " + dataGrid.BackColor;
			}
		}

		private void button_altbackcolorClick (object sender, System.EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog ();

			if (DialogResult.OK == colorDialog.ShowDialog ()) {
				dataGrid.AlternatingBackColor = colorDialog.Color;
				label_altbackcolor.Text = "Alt Background color: " + dataGrid.AlternatingBackColor;
			}
		}

		private void button_backgroundcolorClick (object sender, System.EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog ();

			if (DialogResult.OK == colorDialog.ShowDialog ()) {
				dataGrid.BackgroundColor = colorDialog.Color;
				label_backgroundcolor.Text = "Background color: " + dataGrid.BackgroundColor;
			}
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

			CheckBox checkbox_readonly = new CheckBox ();
			checkbox_readonly.Location = new System.Drawing.Point (430 + 240, 190);
			checkbox_readonly.Text = "ReadOnly";
			checkbox_readonly.Click += new System.EventHandler (readonlyChecked);
			checkbox_readonly.Checked = dataGrid.ReadOnly;
			Controls.Add (checkbox_readonly);

			CheckBox checkbox_rowshdrsvisible  = new CheckBox ();
			checkbox_rowshdrsvisible.Location = new System.Drawing.Point (430 + 100, 220);
			checkbox_rowshdrsvisible.Text = "RowHeadersVisible";
			checkbox_rowshdrsvisible.Size = new Size (140, 20);
			checkbox_rowshdrsvisible.Click += new System.EventHandler (rowshdrsvisibleChecked);
			checkbox_rowshdrsvisible.Checked = dataGrid.RowHeadersVisible;
			Controls.Add (checkbox_rowshdrsvisible);

			label_backcolor = new Label ();
			label_backcolor.Location = new System.Drawing.Point (430 + 210, 300);
			label_backcolor.Text = "Back color: " + dataGrid.BackColor;
			label_backcolor.Size = new Size (160, 30);
			Controls.Add (label_backcolor);

			Button button_backcolor = new Button ();
			button_backcolor.Location = new System.Drawing.Point (430 + 100, 300);
			button_backcolor.Text = "Set Back Color";
			button_backcolor.Size = new Size (100, 30);
			button_backcolor.Click += new System.EventHandler (button_backcolorClick);
			Controls.Add (button_backcolor);

			label_altbackcolor = new Label ();
			label_altbackcolor.Location = new System.Drawing.Point (430 + 210, 340);
			label_altbackcolor.Text = "Alt Background color: " + dataGrid.BackColor;
			label_altbackcolor.Size = new Size (160, 30);
			Controls.Add (label_altbackcolor);

			Button button_altbackcolor = new Button ();
			button_altbackcolor.Location = new System.Drawing.Point (430 + 100, 340);
			button_altbackcolor.Text = "Set Alt Back Color";
			button_altbackcolor.Size = new Size (100, 30);
			button_altbackcolor.Click += new System.EventHandler (button_altbackcolorClick);
			Controls.Add (button_altbackcolor);

			label_backgroundcolor = new Label ();
			label_backgroundcolor.Location = new System.Drawing.Point (430 + 210, 380);
			label_backgroundcolor.Text = "Background color: " + dataGrid.BackColor;
			label_backgroundcolor.Size = new Size (160, 30);
			Controls.Add (label_backgroundcolor);

			Button button_backgroundcolor = new Button ();
			button_backgroundcolor.Location = new System.Drawing.Point (430 + 100, 380);
			button_backgroundcolor.Text = "Set Background Color";
			button_backgroundcolor.Size = new Size (100, 30);
			button_backgroundcolor.Click += new System.EventHandler (button_backgroundcolorClick);
			Controls.Add (button_backgroundcolor);


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


		/*
		public static void Main(string[] args)
		{
			Application.Run(new DatagridSample1());
		}*/

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
			DataColumn column;

			column = new DataColumn ("CustomerID");
			column.DataType = typeof (int);
			column.Unique = true;
			dt1.Columns.Add (column);

			column = new DataColumn ("CustomerName");
			column.DataType = typeof (string);
			column.Unique = false;
			dt1.Columns.Add (column);

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
					dt2.Rows.Add (row);
				}
			}

			dataset.Tables.Add (dt1);
			dataset.Tables.Add (dt2);
			dataset.Relations.Add ("Customer_Order", dt1.Columns["CustomerID"], dt2.Columns["CustomerID"]);

			dataGrid.DataSource = dataset;
			dataGrid.DataMember = "Customers";
			dataGrid.AllowNavigation = true;
		}

	}
}
