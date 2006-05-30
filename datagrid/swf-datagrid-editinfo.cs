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
	class MyDataGridColumn : DataGridTextBoxColumn
	{
		public MyDataGridColumn (PropertyDescriptor prop,  bool isDefault)
			: base (prop, isDefault)
		{
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
			//			Console.WriteLine ("Commit (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
			return base.Commit (dataSource, rowNum);
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
			//			Console.WriteLine ("GetColumnValueAtRow (rowNum = {0})\n{1}", rowNum, Environment.StackTrace);
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
			MappingName = "programes";
		}


		protected override DataGridColumnStyle CreateGridColumn (PropertyDescriptor prop,  bool isDefault)
		{
			if (prop.PropertyType == typeof (bool))
				return new DataGridBoolColumn (prop, isDefault);
			return new MyDataGridColumn (prop, isDefault);
		}

	}

	class MyDataGrid : DataGrid {
		protected override void CancelEditing ()
		{
			//			Console.WriteLine ("in CancelEditing {0}", Environment.StackTrace);
			base.CancelEditing ();
		}

		protected override void ColumnStartedEditing (Control editingControl)
		{
			//			Console.WriteLine ("in ColumnStartedEditing {0} {1}", editingControl.GetType (), Environment.StackTrace);
			base.ColumnStartedEditing (editingControl);
		}

		protected override void ColumnStartedEditing (Rectangle bounds)
		{
			//			Console.WriteLine ("in ColumnStartedEditing {0} {1}", bounds, Environment.StackTrace);
			base.ColumnStartedEditing (bounds);
		}

		protected override string GetOutputTextDelimiter ()
		{
			//			Console.WriteLine ("GetOutputTextDelimiter {0}", Environment.StackTrace);
			return base.GetOutputTextDelimiter ();
		}
	}

	class DataGridEditInfo : Form
	{
		private DataGrid dataGrid;
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
			dataGrid.Size = new System.Drawing.Size (600, 600);
			dataGrid.TableStyles.Add (new MyDataGridTableStyle ());
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

		void doing_layout (object sender, LayoutEventArgs a)
		{
			Console.WriteLine ("laying out");
		}
	}
}
