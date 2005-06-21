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
using System.Drawing;
using System.ComponentModel;

namespace DatagridSamples
{
	class ourDataGrid : DataGrid
	{
		public ourDataGrid ()
		{
			RowHeaderClick  += new System.EventHandler (onrowheaderclick);
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

		private	void onrowheaderclick (object sender, System.EventArgs	e)
		{

		}

	}

	class DataGridStyles : Form
	{
		private ourDataGrid dataGrid;
		private DataSet dsSource = new DataSet ();
		private DataGridTableStyle tablestyles = new DataGridTableStyle ();
		private DataGridTableStyle tablestyles2 = new DataGridTableStyle ();
		private Label labelCurrentCell = new Label ();
		private DataTable programs;
		private DataTable applications;
		private DataTable utilities;
		Button buttonLoadStyles;

		public DataGridStyles ()
		{
			InitializeComponent ();
		}

		public void eventhandler (object sender, CollectionChangeEventArgs e)
		{
			Console.WriteLine ("TableStyles Collection Changed");
		}

		void InitializeComponent ()
		{
			SuspendLayout ();

			//
			// dataGrid
			//
			dataGrid = new ourDataGrid ();
			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new System.Drawing.Point (10, 10);
			dataGrid.Name = "dataGrid";
			dataGrid.Size = new System.Drawing.Size (600, 600);

			buttonLoadStyles = new Button ();
			buttonLoadStyles.Location = new Point (650, 30);
			buttonLoadStyles.Text = "Load table styles";
			buttonLoadStyles.Size = new Size (150, 23);
			buttonLoadStyles.Click += new System.EventHandler (buttonLoadStylesClick);
			Controls.Add (buttonLoadStyles);

			Label labelLoadStyles = new Label ();
			labelLoadStyles.Location = new Point (650, 60);
			labelLoadStyles.Text = "Load table styles settings";
			labelLoadStyles.AutoSize = true;
			Controls.Add (labelLoadStyles);

			Button buttonApplications = new Button ();
			buttonApplications.Location =	new Point (650,	90);
			buttonApplications.Text = "Table: applications";
			buttonApplications.Size = new	Size (150, 23);
			buttonApplications.Click += new System.EventHandler (buttonApplicationsClick);
			Controls.Add (buttonApplications);

			Label labelApplications = new Label ();
			labelApplications.Location = new Point (650, 120);
			labelApplications.Text = "Does not use styles";
			labelApplications.AutoSize = true;
			Controls.Add (labelApplications);

			Button buttonPrograms = new Button ();
			buttonPrograms.Location = new Point (650, 150);
			buttonPrograms.Text = "Table: programs";
			buttonPrograms.Size = new Size (150, 23);
			buttonPrograms.Click += new System.EventHandler (buttonProgramsClick);
			Controls.Add (buttonPrograms);

			Label labelPrograms = new Label ();
			labelPrograms.Location = new Point (650, 180);
			labelPrograms.Text = "Data column's with to 200, header's text for column nom changes...";
			labelPrograms.Size = new Size (200, 30);
			Controls.Add (labelPrograms);

			Button buttonUtilities = new Button ();
			buttonUtilities.Location = new Point (650, 220);
			buttonUtilities.Text = "Table: utilities";
			buttonUtilities.Size = new Size (100, 23);
			buttonUtilities.Click += new System.EventHandler (buttonUtilitiesClick);
			Controls.Add (buttonUtilities);

			Label labelUtilities = new Label ();
			labelUtilities.Location = new Point (650, 250);
			labelUtilities.Text = "Use table styles to show a column only and setting its width";
			labelUtilities.Size = new Size (200, 30);
			Controls.Add (labelUtilities);


			//
			// MainForm
			//
			Text = "SWF-Datagrid Styles";
			ClientSize = new System.Drawing.Size (850, 650);
			Controls.Add(dataGrid);
			Load += new System.EventHandler(MainFormLoad);
			ResumeLayout (false);
		}
		private	void buttonLoadStylesClick (object sender, System.EventArgs e)
		{
			tablestyles.MappingName = "Programes";
			dataGrid.TableStyles.Add (tablestyles);
			tablestyles.SelectionBackColor = Color.Black;
			tablestyles.SelectionForeColor = Color.White;
			tablestyles.ReadOnly = false;

			// Column styles
			tablestyles.AllowSorting = false;

			dataGrid.CaptionText = "This is sample Caption";

			tablestyles.GridColumnStyles["ID"].ReadOnly = true;
			tablestyles.GridColumnStyles["Data"].Width = 200;
			tablestyles.GridColumnStyles["Versio"].Alignment = HorizontalAlignment.Right;
			tablestyles.GridColumnStyles["nom"].HeaderText = "HeaderText: nom";

			DataGridColumnStyle latCol = new DataGridTextBoxColumn();
			latCol.MappingName = "Nom";
			latCol.Width = 200;
			tablestyles2.GridColumnStyles.Add (latCol);

			tablestyles2.MappingName = "utilities";
			dataGrid.TableStyles.Add (tablestyles2);

			Console.WriteLine ("Text Header for Data {0}",
				((DataGridTextBoxColumn)tablestyles.GridColumnStyles["Data"]).Format);

			Console.WriteLine ("Text Header for Vilaweb {0}",
				((DataGridTextBoxColumn)tablestyles.GridColumnStyles["Vilaweb"]).Format);

				Console.WriteLine ("DataMember HorizScrollBar Visible {0}, Max {1}, Min {2}, Large {3}, Small {4}, Value {5}",
				dataGrid._HorizScrollBar.Visible,
				dataGrid._HorizScrollBar.Maximum,
				dataGrid._HorizScrollBar.Minimum,
				dataGrid._HorizScrollBar.LargeChange,
				dataGrid._HorizScrollBar.SmallChange,
				dataGrid._HorizScrollBar.Value);

			Console.WriteLine ("DataMember VertScrollBar Visible {0}, Max {1}, Min {2}, Large {3}, Small {4}, Value {5}",
				dataGrid._VertScrollBar.Visible,
				dataGrid._VertScrollBar.Maximum,
				dataGrid._VertScrollBar.Minimum,
				dataGrid._VertScrollBar.LargeChange,
				dataGrid._VertScrollBar.SmallChange,
				dataGrid._VertScrollBar.Value);

			dataGrid.CurrentCell = new DataGridCell (10, 3);
			buttonLoadStyles.Enabled = false;
		}

		private	void buttonApplicationsClick (object sender, System.EventArgs e)
		{
			dataGrid.DataMember = "applications";
		}

		private	void buttonProgramsClick (object sender, System.EventArgs e)
		{
			dataGrid.DataMember = "programes";
		}

		private	void buttonUtilitiesClick (object sender, System.EventArgs e)
		{
			dataGrid.DataMember = "Utilities";
		}

		/*
		public static void Main(string[] args)
		{
			Application.Run(new DatagridSample1());
		}*/

		void MainFormLoad (object sender, System.EventArgs e)
		{

			FillDataSet ();
			dataGrid.HeaderFont = new Font ("Arial", 16);
			dataGrid.GridLineColor = Color.Yellow;
			dataGrid.ReadOnly = false;
			dataGrid.HeaderBackColor  = Color.Pink;
			return;
		}

		private void FillDataSet ()
		{
			// Create a FileStream object with the file path and name.
   			System.IO.FileStream myFileStream = new System.IO.FileStream ("programes.xsd",System.IO.FileMode.Open);
			System.Xml.XmlTextReader myXmlTextReader = new System.Xml.XmlTextReader (myFileStream);
   			dsSource.ReadXmlSchema (myXmlTextReader);
   			myXmlTextReader.Close ();

			// Read the XML document back in.
			System.IO.FileStream fsReadXml = new System.IO.FileStream ("programes.xml", System.IO.FileMode.Open);

			System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			dsSource.ReadXml (myXmlReader);
			myXmlReader.Close ();

			programs = dsSource.Tables["programes"].Copy ();

			applications = dsSource.Tables["programes"].Copy ();
			applications.TableName = "applications";
			applications.Columns.RemoveAt (0);

			utilities = dsSource.Tables["programes"].Copy ();
			utilities.TableName = "utilities";
			utilities.Columns.RemoveAt (2);
			utilities.Columns.RemoveAt (3);
			utilities.Columns.RemoveAt (4);

			DataSet dataset = new DataSet ();
			dataset.Tables.Add (applications);
			dataset.Tables.Add (utilities);
			dataset.Tables.Add (programs);
			dataGrid.DataSource = dataset;
			dataGrid.DataMember = "programes";
		}

	}
}
