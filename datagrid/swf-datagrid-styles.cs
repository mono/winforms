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

namespace DatagridSamples
{
	class DataGridStyles : Form
	{
		private DataGrid dataGrid;
		private DataSet dsSource = new DataSet ();

		public DataGridStyles ()
		{
			InitializeComponent ();
		}


		void InitializeComponent ()
		{
			SuspendLayout ();

			//
			// dataGrid
			//
			dataGrid = new DataGrid();
			dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			dataGrid.Location = new System.Drawing.Point (10, 10);
			dataGrid.Name = "dataGrid";
			dataGrid.Size = new System.Drawing.Size (600, 600);


			//
			// MainForm
			//
			Text = "SWF-Datagrid Styles";
			ClientSize = new System.Drawing.Size (700, 600);
			Controls.Add(dataGrid);
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
			FillDataSet ();

			// Tick used by many apps to get the table's styles
			DataGridTableStyle tablestyles = new DataGridTableStyle ();
			tablestyles.MappingName = "Programes";
			dataGrid.TableStyles.Add (tablestyles);

			Console.WriteLine ("Table Styles {0}", tablestyles.GridColumnStyles.Count);

			tablestyles.SelectionBackColor = Color.Black;
			tablestyles.SelectionForeColor = Color.White;

			for (int i = 0; i < tablestyles.GridColumnStyles.Count; i++)
				Console.WriteLine ("  Styles {0}", tablestyles.GridColumnStyles[i].MappingName);

			// Column styles
			tablestyles.GridColumnStyles["ID"].Width = 30;
			tablestyles.GridColumnStyles["ID"].ReadOnly = true;
			tablestyles.GridColumnStyles["vilaweb"].Width = 30;
			tablestyles.GridColumnStyles["versio"].Alignment = HorizontalAlignment.Right;
			tablestyles.GridColumnStyles["versio"].HeaderText = "HeaderText: version";

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
			dataGrid.DataSource = dsSource.Tables["programes"];
		}

	}
}
