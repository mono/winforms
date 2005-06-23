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
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Xml;

namespace DatagridSamples
{
	class DataGridTableNavigation :	Form
	{
		class ourDataGrid : DataGrid
		{
			public ourDataGrid ()
			{

			}

			public CurrencyManager Manager {
				get {
					return ListManager;
				}
			}

			public ScrollBar _HorizScrollBar {
				get {
					return HorizScrollBar;
				}
			}

			public ScrollBar _VertScrollBar {
				get {
					return VertScrollBar;
				}
			}

			public CurrencyManager CurrencyManager ()
			{

				return (CurrencyManager) BindingContext [DataSource, DataMember];
			}
		}

		// Data	container
		public class Simbols
		{
			private	string simbol;
			private	string descripcio;

			public Simbols (string descripcio, string simbol)
			{
				this.simbol = simbol;
				this.descripcio	= descripcio;
			}

			public string Simbol {
				get { return simbol;}
			}

			public string Descripcio {
				get { return descripcio; }
			}


			public override	string ToString	()
			{
				return descripcio + " /	" + simbol;
			}
		}


		private	ourDataGrid dataGrid;
		private	ComboBox comboBox;
		private	TreeView treeView;
		private	Label label;
		private Timer timer = new Timer ();

		public DataGridTableNavigation ()
		{
			InitializeComponent ();
		}

		void InitializeComponent ()
		{
			dataGrid = new ourDataGrid ();
			SuspendLayout ();

			// timer
			timer.Tick += new EventHandler (OnTimer);
			timer.Enabled = false;
			timer.Interval = 200;
			timer.Enabled = true;


			//
			// dataGrid
			//
			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new	System.Drawing.Point (10, 10);
			dataGrid.Name =	"dataGrid";
			dataGrid.Size =	new System.Drawing.Size	(400, 400);
			//dataGrid.Font = new Font ("Arial", 16);


			comboBox = new ComboBox	();
			comboBox.Location = new	System.Drawing.Point (450, 30);
			comboBox.Items.AddRange	(new object[] {"Array",	"Table Navigation", "Several Tables", "Single Table"});
			comboBox.SelectionChangeCommitted += new System.EventHandler (comboSelectionChanged);
			comboBox.SelectedIndex = 1;

			treeView = new TreeView	();
			treeView.Location = new	Point (450, 100);
			treeView.Size =	new Size (350, 400);

			Button buttonUpdate = new Button ();
			buttonUpdate.Location =	new Point (450,	60);
			buttonUpdate.Text = "Update";
			buttonUpdate.Size = new	Size (100, 23);
			buttonUpdate.Click += new System.EventHandler (buttonUpdateClick);

			label = new Label ();
			label.Location = new Point (450, 510);
			label.Size = new Size (300, 400);

			Controls.Add (label);
			Controls.Add (buttonUpdate);
			Controls.Add (dataGrid);
			Controls.Add (comboBox);
			Controls.Add (treeView);


			//
			// MainForm
			//
			AutoScaleBaseSize = new	System.Drawing.Size (5,	13);
			ClientSize = new System.Drawing.Size (850, 600);
			Name = "MainForm";
			Text = "SWF-Datagrid Table Navigation";
			Load +=	new System.EventHandler	(MainFormLoad);
			ResumeLayout (false);
		}

		private	void comboSelectionChanged (object sender, System.EventArgs e)
		{
			Console.WriteLine ("comboSelectionChanged");

			if (((string)comboBox.SelectedItem) == "Array") {
				FillDataSetArray ();
			} else {
				if (((string)comboBox.SelectedItem) == "Table Navigation") {
					FillDataSetTable ();
				} else {
					if (((string)comboBox.SelectedItem) == "Single Table") {
						FillDataSetSingleTable ();
					} else {
						if (((string)comboBox.SelectedItem) == "Several Tables") {
							FillDataSetSeveralTables ();
						}
					}
				}
			}
		}

		private void OnTimer (Object source, EventArgs e)
		{
			label.Text = "Visible rows:" + dataGrid.VisibleRowCount +
				" Visible Columns:" + dataGrid.VisibleColumnCount + " Current Cell:" +
				dataGrid.CurrentCell;
		}

		private	void FillDataSetSingleTable ()
		{
			DataSet	dsSource = new DataSet ();
			dataGrid.DataSource = dsSource;

			System.IO.FileStream myFileStream = new	System.IO.FileStream ("programes.xsd",System.IO.FileMode.Open);


			System.Xml.XmlTextReader myXmlTextReader = new System.Xml.XmlTextReader(myFileStream);
			dsSource.ReadXmlSchema(myXmlTextReader);
			myXmlTextReader.Close ();

			System.IO.FileStream fsReadXml = new System.IO.FileStream
			("programes.xml", System.IO.FileMode.Open);

			System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			dsSource.ReadXml (myXmlReader);
			myXmlReader.Close();

			dataGrid.DataSource = dsSource.Tables["programes"];
			Console.WriteLine ("DataSource {0}", dataGrid.DataSource);
			Console.WriteLine ("DataMember {0}", dataGrid.DataMember);
			FillTree ();
			dataGrid.CurrentCell = new DataGridCell (5, 10);
		}


		private	void FillTree ()
		{
			CurrencyManager	manager	= (CurrencyManager) dataGrid.BindingContext
				[dataGrid.DataSource, dataGrid.DataMember];

			treeView.Nodes.Clear ();
			treeView.Nodes.Add (new	TreeNode ("DataMember: " + dataGrid.DataMember));

			TreeNode node_propcol =	new TreeNode ("ListManager");
			treeView.Nodes.Add (node_propcol);

			PropertyDescriptorCollection propcol = manager.GetItemProperties ();

			for (int i = 0;	i < propcol.Count; i++)	{

				TreeNode subNode = new TreeNode	("object:" + propcol[i]);
				node_propcol.Nodes.Add (subNode);
				subNode.Nodes.Add (new TreeNode	("ComponentType:" + propcol[i].ComponentType));
				subNode.Nodes.Add (new TreeNode	("DisplayName:"	+ propcol[i].DisplayName));
				subNode.Nodes.Add (new TreeNode	("Name:" + propcol[i].Name));
				subNode.Nodes.Add (new TreeNode	("PropertyType:" +  propcol[i].PropertyType));


			}
			treeView.ExpandAll ();

			Console.WriteLine ("DataMember HorizScrollBar Visible {0}, Max {1}, Min {2}, Value {3}",
				dataGrid._HorizScrollBar.Visible,
				dataGrid._HorizScrollBar.Maximum,
				dataGrid._HorizScrollBar.Minimum,
				dataGrid._HorizScrollBar.Value);

			Console.WriteLine ("DataMember VertScrollBar Visible {0}, Max {1}, Min {2}, Value {3}",
				dataGrid._VertScrollBar.Visible,
				dataGrid._VertScrollBar.Maximum,
				dataGrid._VertScrollBar.Minimum,
				dataGrid._VertScrollBar.Value);


		}

		private void FillDataSetSeveralTables ()
		{
			DataSet	dsSource = new DataSet ();

			System.IO.FileStream myFileStream = new System.IO.FileStream ("factures.xsd",System.IO.FileMode.Open);

			// Create a new XmlTextReader object with the FileStream.
			System.Xml.XmlTextReader myXmlTextReader=
			new System.Xml.XmlTextReader(myFileStream);
   			// Read the schema into the DataSet and close the reader.
   			dsSource.ReadXmlSchema(myXmlTextReader);
   			myXmlTextReader.Close();

			// Read the XML document back in.
			// Create new FileStream to read schema with.
			System.IO.FileStream fsReadXml = new System.IO.FileStream
			("factures.xml", System.IO.FileMode.Open);

			System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			dsSource.ReadXml (myXmlReader);
			myXmlReader.Close();

			myFileStream = new System.IO.FileStream ("clients.xsd",System.IO.FileMode.Open);

			// Create a new XmlTextReader object with the FileStream.
			myXmlTextReader=
			new System.Xml.XmlTextReader(myFileStream);
   			// Read the schema into the DataSet and close the reader.
   			dsSource.ReadXmlSchema(myXmlTextReader);
   			myXmlTextReader.Close();

			fsReadXml = new System.IO.FileStream
			("clients.xml", System.IO.FileMode.Open);

			myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			dsSource.ReadXml (myXmlReader);
			myXmlReader.Close();

			DataTable factures = dsSource.Tables["Factures"];
			DataTable clients = dsSource.Tables["Clients"];

			DataRelation rel = new DataRelation (null,
				new DataColumn [] {clients.Columns["Id"]}, // parent
				new DataColumn [] {factures.Columns["cliente"]}); // child, consumer

			dsSource.Relations.Add (rel);

			dataGrid.DataSource = dsSource;//;.Tables["programes"];
			FillTree ();
		}

		// http://support.microsoft.com/kb/q315786/
		private	void FillDataSetArray ()
		{

			ArrayList simbols = new	ArrayList ();
			simbols.Add (new  Simbols ("Fons Monetari Internacional", "FMI"));
			simbols.Add (new  Simbols ("Centimetre", "cm"))	 ;
			simbols.Add (new  Simbols ("Ferrocarril", "FC"));
			simbols.Add (new  Simbols ("Megahertz",	"MHz"))	;
			simbols.Add (new  Simbols ("pesseta", "PTA"));
			simbols.Add (new  Simbols ("quilogram",	"kg"));
			simbols.Add (new  Simbols ("watt", "W"));
			dataGrid.DataSource = simbols;

			FillTree ();


		}

		private	void FillDataSetTable ()
		{
			Console.WriteLine ("FillDataSetTable");

			DataSet	dsSource = new DataSet ();
			dataGrid.DataSource = dsSource;
			DataTable users	= dsSource.Tables.Add ("Users");
			DataTable zipcodes = dsSource.Tables.Add ("ZipCodes");
			DataTable countries = dsSource.Tables.Add ("Countries");
			DataColumn users_id, zip_zipid,	col;
			//dataGrid.DataMember =	"Users";


			// Countries
			col = countries.Columns.Add ("name", Type.GetType ("System.String"));
			col.Caption = "Available Countries";

			// Zipcodes
			zip_zipid = zipcodes.Columns.Add ("zipID", Type.GetType	("System.Int32"));
			zip_zipid.AutoIncrement	= true;
			zipcodes.Columns.Add ("area", Type.GetType ("System.String"));
			zipcodes.Columns.Add ("zipcode", Type.GetType ("System.String"));
			zipcodes.PrimaryKey = new DataColumn []	{zip_zipid};

			// Users
			users_id = users.Columns.Add ("userID",	Type.GetType ("System.Int32"));
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

			FillTree ();
		}


		private	void buttonUpdateClick (object sender, System.EventArgs	e)
		{
			FillTree ();

			//return;
			Console.WriteLine ("---------------------------------------------");

			//CurrencyManager  manager = dataGrid.Manager;
			CurrencyManager	manager	= (CurrencyManager) dataGrid.BindingContext
				[dataGrid.DataSource, dataGrid.DataMember];

			Console.WriteLine ("DataGrid.ListManager (CurrencyManager) cnt {0} [rows]", manager.Count);

			for (int i = 0;	i < manager.Count; i++)	{
				Console.WriteLine ("  {0}", manager.List[i]);
				DataRowView row = (DataRowView) manager.List[i];
				//Console.WriteLine ("	Item: {0}", row.Row[1]);
				//DataTablePropertyDescriptor data =  (DataTablePropertyDescriptor) manager.List[i];
			}
			//return;

			PropertyDescriptorCollection propcol = manager.GetItemProperties ();
			Console.WriteLine ("  DataGrid.ListManager.PropertyDescriptorCollection	cnt {0}	[columns]", propcol.Count);

			for (int i = 0;	i < propcol.Count; i++)	{
				Console.WriteLine ("	{0}", propcol[i].DisplayName);

				Console.WriteLine ("	    object: {0}", propcol[i]);
				Console.WriteLine ("	    ComponentType:{0}",	propcol[i].ComponentType);
				Console.WriteLine ("	    DisplayName:{0}", propcol[i].DisplayName);
				Console.WriteLine ("	    Name:{0}", propcol[i].Name);
				Console.WriteLine ("	    PropertyType:{0}", propcol[i].PropertyType);

				//Console.WriteLine ("	      {0}", propcol[i].GetValue	(propcol[i].ComponentType));
				//DataRowView

			}

			Console.WriteLine ("Table Styles Count {0}", dataGrid.TableStyles.Count);
			//Console.WriteLine ("Table Styles List.Count {0}", dataGrid.TableStyles.List.Count);
			DataGridTableStyle tablestyles = new DataGridTableStyle	();
			tablestyles.MappingName	= "Users";
			dataGrid.TableStyles.Add (tablestyles);

			//GridTableStylesCollection TableStyles	= dataGrid.TableStyles;
			//Console.WriteLine ("GridTableStylesCollection.Count:{0}", TableStyles.Count);


			//Console.WriteLine ("Table Styles {0}", tablestyles.GridColumnStyles.Count);
			//return;


			Console.WriteLine ("Table Styles [trick	]{0}", tablestyles.GridColumnStyles.Count);
			for (int i = 0;	i < tablestyles.GridColumnStyles.Count;	i++)
				Console.WriteLine ("  Styles {0}", tablestyles.GridColumnStyles[i].MappingName);

#if _KK_
			BindingContext	bincnt = dataGrid.BindingContext;
			ICollection list = (ICollection) bincnt;
			int cnt	= list.Count;

			Console.WriteLine ("DataGrid.BindingContext cnt	{0}", cnt);
			for (int i = 0;	i < cnt; i++) {
				Console.WriteLine ("  {0}->{1}", i, bincnt[i]);
				{
					/*PropertyDescriptorCollection propcol2	= bincnt[i].GetItemProperties ();
					Console.WriteLine ("	PropertyDescriptorCollection cnt {0}", propcol2.Count);

					for (int x = 0;	x < propcol2.Count; i++)
						Console.WriteLine ("	  {0}",	propcol2[x].DisplayName);*/
				}
			}
#endif //_KK_

		}

		/*
		public static void Main(string[] args)
		{
			Application.Run(new DatagridSample1());
		}*/

		void MainFormLoad (object sender, System.EventArgs e)
		{

		}

		void ShowMappingName(object src)
		{
			string mapping_name;
		     IList list	= null;
		     Type type = null;
		     if(src is Array)
		     {
			  type = src.GetType();
			  list = src as	IList;
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
		     if(list is	ITypedList)
			  mapping_name = (list as ITypedList).GetListName(null);
		     else
			  mapping_name = type.Name;

		     Console.WriteLine ("SourceData={0}", mapping_name);
		}

		private	void FillDataSet ()
		{


#if _COMPLEX
			DataTable users	= dsSource.Tables.Add ("Users");
			//dataGrid.DataMember =	"Users";
			DataTable zipcodes = dsSource.Tables.Add ("ZipCodes");
			DataTable countries = dsSource.Tables.Add ("Countries");
			DataColumn users_id, zip_zipid,	col;


			// Countries
			col = countries.Columns.Add ("name", Type.GetType ("System.String"));
			col.Caption = "Available Countries";

			// Zipcodes
			zip_zipid = zipcodes.Columns.Add ("zipID", Type.GetType	("System.Int32"));
			zip_zipid.AutoIncrement	= true;
			zipcodes.Columns.Add ("area", Type.GetType ("System.String"));
			zipcodes.Columns.Add ("zipcode", Type.GetType ("System.String"));
			zipcodes.PrimaryKey = new DataColumn []	{zip_zipid};

			// Users
			users_id = users.Columns.Add ("userID",	Type.GetType ("System.Int32"));
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
#endif // complex

		}

	}
}
