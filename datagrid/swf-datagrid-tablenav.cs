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
using System.Data;

namespace DatagridSamples
{
	class DataGridTableNavigation :	Form
	{
		private	DataGrid dataGrid;
		private	DataSet	dsSource = new DataSet();

		public DataGridTableNavigation ()
		{
			InitializeComponent ();
		}

		void InitializeComponent ()
		{
			dataGrid = new DataGrid	();
			dataGrid.DataSource = dsSource;
			SuspendLayout ();


			//
			// dataGrid
			//
			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new	System.Drawing.Point (10, 10);
			dataGrid.Name =	"dataGrid";
			dataGrid.Size =	new System.Drawing.Size	(400, 400);

			//
			// MainForm
			//
			AutoScaleBaseSize = new	System.Drawing.Size (5,	13);
			ClientSize = new System.Drawing.Size (700, 600);
			Controls.Add (dataGrid);
			Name = "MainForm";
			Text = "SWF-Datagrid Table Navigation";
			Load +=	new System.EventHandler	(MainFormLoad);
			ResumeLayout(false);
		}

		/*
		public static void Main(string[] args)
		{
			Application.Run(new DatagridSample1());
		}*/

		void MainFormLoad (object sender, System.EventArgs e)
		{
			((System.ComponentModel.ISupportInitialize)(dataGrid)).BeginInit();
			FillDataSet ();
			((System.ComponentModel.ISupportInitialize)(dataGrid)).EndInit();
		}


		private	void FillDataSet ()
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

			for (int i = 0;	i < dsSource.Tables.Count; i++)	{
				Console.WriteLine ("table->{0} ChildRel	{1}, ParentRel {2}, Columns {3}", dsSource.Tables[i],
					dsSource.Tables[i].ChildRelations.Count,
					dsSource.Tables[i].ParentRelations.Count,
					dsSource.Tables[i].Columns.Count);
			}
		}

	}
}
