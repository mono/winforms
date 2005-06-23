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
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace DatagridSamples
{
	class DataGridTestProperties : Form
	{
		private DataGrid dataGrid;		
		private Label label_backcolor;
		private Label label_altbackcolor;
		private Label label_backgroundcolor;

		public DataGridTestProperties ()
		{
			InitializeComponent ();
		}

		private void checkbox_allownavChecked (object sender, System.EventArgs e)
		{
			dataGrid.AllowNavigation = !dataGrid.AllowNavigation;
		}

		private void checkbox_allowsortingChecked (object sender, System.EventArgs e)
		{
			dataGrid.AllowSorting = !dataGrid.AllowSorting;
		}

		private void checkbox_columnvisibileChecked (object sender, System.EventArgs e)
		{
			dataGrid.ColumnHeadersVisible = !dataGrid.ColumnHeadersVisible;
		}

		private void checkbox_captionvisibleChecked (object sender, System.EventArgs e)
		{
			dataGrid.CaptionVisible = !dataGrid.CaptionVisible;
		}

		private void checkbox_gridlinestyleChecked (object sender, System.EventArgs e)
		{
			if (dataGrid.GridLineStyle == DataGridLineStyle.None) {
				dataGrid.GridLineStyle = DataGridLineStyle.Solid;
			} else {
				dataGrid.GridLineStyle = DataGridLineStyle.None;
			}
		}

		private void checkbox_flatmodeChecked (object sender, System.EventArgs e)
		{
			dataGrid.FlatMode = !dataGrid.FlatMode;
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

		private void button_smallDataSourceClick (object sender, System.EventArgs e)
		{
			FillDataSetSmall ();
		}
		
		private void button_largeDataSourceClick (object sender, System.EventArgs e)
		{
			FillDataSetLarge ();
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

			Button button_smalldatasrc = new Button ();
			button_smalldatasrc.Location = new System.Drawing.Point (430 + 100, 50);
			button_smalldatasrc.Text = "Small DataSource";
			button_smalldatasrc.Size = new Size (100, 30);
			button_smalldatasrc.Click += new System.EventHandler (button_smallDataSourceClick);
			Controls.Add (button_smalldatasrc);

			Button button_largedatasrc = new Button ();
			button_largedatasrc.Location = new System.Drawing.Point (430 + 220, 50);
			button_largedatasrc.Text = "Large DataSource";
			button_largedatasrc.Size = new Size (100, 30);
			button_largedatasrc.Click += new System.EventHandler (button_largeDataSourceClick);
			Controls.Add (button_largedatasrc);

			CheckBox checkbox_allownav = new CheckBox ();
			checkbox_allownav.Location = new System.Drawing.Point (430 + 100, 100);
			checkbox_allownav.Text = "AllowNavigation";
			checkbox_allownav.Click += new System.EventHandler (checkbox_allownavChecked);
			checkbox_allownav.Checked = dataGrid.AllowNavigation;
			Controls.Add (checkbox_allownav);

			CheckBox checkbox_allowsorting = new CheckBox ();
			checkbox_allowsorting.Location = new System.Drawing.Point (430 + 240, 100);
			checkbox_allowsorting.Text = "AllowSorting";
			checkbox_allowsorting.Click += new System.EventHandler (checkbox_allowsortingChecked);
			checkbox_allowsorting.Checked = dataGrid.AllowSorting;
			Controls.Add (checkbox_allowsorting);

			CheckBox checkbox_captionvisible = new CheckBox ();
			checkbox_captionvisible.Location = new System.Drawing.Point (430 + 100, 130);
			checkbox_captionvisible.Text = "CaptionVisible";
			checkbox_captionvisible.Click += new System.EventHandler (checkbox_captionvisibleChecked);
			checkbox_captionvisible.Checked = dataGrid.CaptionVisible;
			Controls.Add (checkbox_captionvisible);

			CheckBox checkbox_columnvisibile = new CheckBox ();
			checkbox_columnvisibile.Location = new System.Drawing.Point (430 + 240, 130);
			checkbox_columnvisibile.Text = "ColHdrVisible";
			checkbox_columnvisibile.Click += new System.EventHandler (checkbox_columnvisibileChecked);
			checkbox_columnvisibile.Checked = dataGrid.ColumnHeadersVisible;
			Controls.Add (checkbox_columnvisibile);

			CheckBox checkbox_flatmode = new CheckBox ();
			checkbox_flatmode.Location = new System.Drawing.Point (430 + 100, 160);
			checkbox_flatmode.Text = "FlatMode";
			checkbox_flatmode.Click += new System.EventHandler (checkbox_flatmodeChecked);
			checkbox_flatmode.Checked = dataGrid.FlatMode;
			Controls.Add (checkbox_flatmode);

			CheckBox checkbox_gridlinestyle = new CheckBox ();
			checkbox_gridlinestyle.Location = new System.Drawing.Point (430 + 240, 160);
			checkbox_gridlinestyle.Text = "GridLineStyle";
			checkbox_gridlinestyle.Click += new System.EventHandler (checkbox_gridlinestyleChecked);
			Controls.Add (checkbox_gridlinestyle);

			if (dataGrid.GridLineStyle == DataGridLineStyle.None) {
				checkbox_gridlinestyle.Checked = false;
			} else {
				checkbox_gridlinestyle.Checked = true;
			}


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
			FillDataSetSmall ();
			((System.ComponentModel.ISupportInitialize)(dataGrid)).EndInit();
		}

		private void FillDataSetSmall ()
		{
			DataSet dsSource = new DataSet ();
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
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Pere";
			tempRow["address"] = "Provenca 55";
			tempRow["zipcode"] = "1";
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Jordi";
			tempRow["address"] = "Londres 16";
			tempRow["zipcode"] = "1";
			users.Rows.Add(tempRow);

			tempRow	= users.NewRow ();
			tempRow["name"]	= "Marta";
			tempRow["address"] = "Padilla 210";
			tempRow["zipcode"] = "0";
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
		}
		
		private void FillDataSetLarge ()
		{		
			DataSet dsSource = new DataSet ();
   			// Create a FileStream object with the file path and name.
   			System.IO.FileStream myFileStream = new System.IO.FileStream ("programes.xsd",System.IO.FileMode.Open);

			// Create a new XmlTextReader object with the FileStream.
			System.Xml.XmlTextReader myXmlTextReader=
			new System.Xml.XmlTextReader(myFileStream);
   			// Read the schema into the DataSet and close the reader.
   			dsSource.ReadXmlSchema(myXmlTextReader);
   			myXmlTextReader.Close();


			// Read the XML document back in.
			// Create new FileStream to read schema with.
			System.IO.FileStream fsReadXml = new System.IO.FileStream
			("programes.xml", System.IO.FileMode.Open);

			System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			dsSource.ReadXml (myXmlReader);
			myXmlReader.Close();

			dataGrid.DataSource = dsSource.Tables["programes"];
		}

	}
}
