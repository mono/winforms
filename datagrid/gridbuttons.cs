
namespace DataGridButton
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using System.Data.OleDb;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(32, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(568, 192);
			this.dataGrid1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dataGrid1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			#region create our fake _dataSet
			DataSet _dataSet = new DataSet ("CustomerSet");
			DataTable dt1 = new DataTable ("customers");
			DataTable dt2 = new DataTable ("orders");
			DataTable dt3 = new DataTable ("addresses");
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

			_dataSet.Tables.Add (dt1);
			_dataSet.Tables.Add (dt2);
			_dataSet.Tables.Add (dt3);
			//			_dataSet.Relations.Add ("Customer_Orders", dt1.Columns["CustomerID"], dt2.Columns["CustomerID"]);
			//			_dataSet.Relations.Add ("Customer_Addresses", dt1.Columns["CustomerID"], dt3.Columns["CustomerID"]);
			//			_dataSet.Relations.Add ("Address_Orders", dt3.Columns["AddressID"], dt2.Columns["AddressID"]);

			#endregion

			#region create tablestyle & add custom columnstyles

			// Create a table style that will hold the new column style 
			// that we set and also tie it to our customer's table from our DB
			DataGridTableStyle tableStyle = new DataGridTableStyle();
			tableStyle.MappingName = "customers";

			// since the dataset has things like field name and number of columns,
			// we will use those to create new columnstyles for the columns in our DB table
			int numCols = _dataSet.Tables["customers"].Columns.Count;

			//	//add an extra column at the end of our customers table
			//	_dataSet.Tables["customers"].Columns.Add("Button");

			DataGridTextBoxColumn aColumnTextColumn = null;
			DataGridButtonColumn buttonColStyle = null;
			DataGridTextButtonColumn textButtonColStyle = null;

			for(int i = 0; i < numCols; ++i)
			{
				//add 2 button columns
				if( i == numCols - 1)
				{
					if ( false )
					{
						textButtonColStyle = new DataGridTextButtonColumn(i); //pass the column#
						textButtonColStyle.HeaderText =  _dataSet.Tables["customers"].Columns[i].ColumnName;
						textButtonColStyle.MappingName =  _dataSet.Tables["customers"].Columns[i].ColumnName;

						//hookup our cellbutton handler...
						textButtonColStyle.CellButtonClicked += 
							new DataGridCellButtonClickEventHandler(HandleCellButtonClick);

						tableStyle.GridColumnStyles.Add(textButtonColStyle);

						//hook the mouse handlers
						dataGrid1.MouseDown += new MouseEventHandler(textButtonColStyle.HandleMouseDown);
						dataGrid1.MouseUp += new MouseEventHandler(textButtonColStyle.HandleMouseUp);
					}
					else
					{
						buttonColStyle = new DataGridButtonColumn(i); //pass the column#
						buttonColStyle.HeaderText =  _dataSet.Tables["customers"].Columns[i].ColumnName;
						buttonColStyle.MappingName =  _dataSet.Tables["customers"].Columns[i].ColumnName;

						//hookup our cellbutton handler...
						buttonColStyle.CellButtonClicked += 
							new DataGridCellButtonClickEventHandler(HandleCellButtonClick);

						tableStyle.GridColumnStyles.Add(buttonColStyle);

						//hook the mouse handlers
						dataGrid1.MouseDown += new MouseEventHandler(buttonColStyle.HandleMouseDown);
						dataGrid1.MouseUp += new MouseEventHandler(buttonColStyle.HandleMouseUp);
					}
				}
				else
				{	// add standard textbox columns for the other columns
					aColumnTextColumn = new DataGridTextBoxColumn();
					aColumnTextColumn.HeaderText = _dataSet.Tables["customers"].Columns[i].ColumnName;
					aColumnTextColumn.MappingName = _dataSet.Tables["customers"].Columns[i].ColumnName;
					tableStyle.GridColumnStyles.Add(aColumnTextColumn);
				}
			}
			
			// make the dataGrid use our new tablestyle and bind it to our table
			dataGrid1.TableStyles.Clear();
			dataGrid1.TableStyles.Add(tableStyle);

			#endregion

			//bind the table to the datagrid
			dataGrid1.DataSource = _dataSet.Tables["customers"];
		}

		// handler for a click on one of the gridcell buttons
		private void HandleCellButtonClick(object sender, DataGridCellButtonClickEventArgs e)
		{
			MessageBox.Show("row " + e.RowIndex.ToString() + "  col " + e.ColIndex.ToString() + " clicked.");
		}
	}

	#region derived columnstyle that shows Text & Button

	public class DataGridTextButtonColumn : DataGridTextBoxColumn
	{
		public event DataGridCellButtonClickEventHandler CellButtonClicked;

		private Bitmap _buttonFace;
		private Bitmap _buttonFacePressed;
		private int _columnNum;
		private int _pressedRow;

		public DataGridTextButtonColumn(int colNum)
		{
			_columnNum = colNum;
			_pressedRow = -1;

			try
			{
				System.IO.Stream strm = this.GetType().Assembly.GetManifestResourceStream("DataGridButton.buttonface.bmp");
				_buttonFace = new Bitmap(strm);
				strm = this.GetType().Assembly.GetManifestResourceStream("DataGridButton.buttonfacepressed.bmp");
				_buttonFacePressed = new Bitmap(strm);
			}
			catch{}
		}

		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible) 
		{ 
			// dont call the baseclass so no editing done...
			//	base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible); 
		} 

		public void HandleMouseUp(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = hti.Column == this._columnNum && hti.Row > -1;

			_pressedRow = -1;

			Rectangle rect = new Rectangle(0,0,0,0);

			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._buttonFace.Width);
			}
			if(isClickInCell)
			{
				Graphics g = Graphics.FromHwnd(dg.Handle);
				g.DrawImage(this._buttonFace, rect.Right - this._buttonFace.Width, rect.Y);
						
				g.Dispose();
				if(CellButtonClicked != null)
					CellButtonClicked(this, new DataGridCellButtonClickEventArgs(hti.Row, hti.Column));
			}
		}

		public void HandleMouseDown(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = hti.Column == this._columnNum && hti.Row > -1;
			Rectangle rect = new Rectangle(0,0,0,0);
			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._buttonFace.Width);
			}

			if(isClickInCell)
			{
				//Console.WriteLine("HandleMouseDown " + hti.Row.ToString());
				Graphics g = Graphics.FromHwnd(dg.Handle);
				g.DrawImage(this._buttonFacePressed, rect.Right - this._buttonFacePressed.Width, rect.Y);
				g.Dispose();
				_pressedRow = hti.Row;
			}
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
			//base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
	
			DataGrid parent = this.DataGridTableStyle.DataGrid;
			bool current = parent.IsSelected(rowNum) ||
							( parent.CurrentRowIndex == rowNum && 
							parent.CurrentCell.ColumnNumber == this._columnNum);

			Color BackColor = current ? parent.SelectionBackColor : parent.BackColor;
			Color ForeColor = current ? parent.SelectionForeColor : parent.ForeColor;
			
			//clear the cell
			g.FillRectangle(new SolidBrush(BackColor), bounds);

			//draw the value
			string s = this.GetColumnValueAtRow(source, rowNum).ToString();//parent[rowNum, 0].ToString() + ((parent[rowNum, 1].ToString())+ "  ").Substring(0,2);
			//Font font = new Font("Arial", 8.25f);
			//g.DrawString(s, font, new SolidBrush(Color.Black), bounds);
		
			g.DrawString(s, parent.Font, new SolidBrush(ForeColor), bounds);

			//draw the button
			Bitmap bm = _pressedRow == rowNum ? this._buttonFacePressed : this._buttonFace;
			g.DrawImage(bm, bounds.Right - bm.Width, bounds.Y);
			//font.Dispose();
		
		}
	
	
	}
	#endregion

	#region derived columnstyle that shows Button only

	public class DataGridButtonColumn : DataGridTextBoxColumn
	{
		public event DataGridCellButtonClickEventHandler CellButtonClicked;

		private Bitmap _buttonFace;
		private Bitmap _buttonFacePressed;
		private int _columnNum;
		private int _pressedRow;

		public DataGridButtonColumn(int colNum)
		{
			_columnNum = colNum;
			_pressedRow = -1;

			try
			{
				System.IO.Stream strm = this.GetType().Assembly.GetManifestResourceStream("DataGridButton.fullbuttonface.bmp");
				_buttonFace = new Bitmap(strm);
				strm = this.GetType().Assembly.GetManifestResourceStream("DataGridButton.fullbuttonfacepressed.bmp");
				_buttonFacePressed = new Bitmap(strm);
			}
			catch{}
		}

		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible) 
		{ 
			// dont call the baseclass so no editing done...
			//	base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible); 
		} 

		private void DrawButton(Graphics g, Bitmap bm, Rectangle bounds, int row)
		{

			DataGrid dg = this.DataGridTableStyle.DataGrid;
			string s = dg[row, this._columnNum].ToString();

			SizeF sz = g.MeasureString(s, dg.Font, bounds.Width - 4, StringFormat.GenericTypographic);

			int x = bounds.Left + Math.Max(0, (bounds.Width - (int)sz.Width)/2);
			g.DrawImage(bm, bounds, 0, 0, bm.Width, bm.Height,GraphicsUnit.Pixel);
			
			if(sz.Height < bounds.Height)
			{
				int y = bounds.Top + (bounds.Height - (int) sz.Height) / 2;
				if(_buttonFacePressed == bm)
				{
					x++;
				}

				g.DrawString(s, dg.Font, new SolidBrush(dg.ForeColor), x, y);
			}

		}

		public void HandleMouseUp(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = (hti.Column == this._columnNum
						&& hti.Row > -1);

			_pressedRow = -1;

			Rectangle rect = new Rectangle(0,0,0,0);

			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._buttonFace.Width);
			}
			if(isClickInCell)
			{
				Graphics g = Graphics.FromHwnd(dg.Handle);
			//	g.DrawImage(this._buttonFace, rect.Right - this._buttonFace.Width, rect.Y);
				DrawButton(g, this._buttonFace, rect, hti.Row);
				g.Dispose();
				if(CellButtonClicked != null)
					CellButtonClicked(this, new DataGridCellButtonClickEventArgs(hti.Row, hti.Column));
			}
		}

		public void HandleMouseDown(object sender, MouseEventArgs e)
		{
			DataGrid dg = this.DataGridTableStyle.DataGrid;
			DataGrid.HitTestInfo hti = dg.HitTest(new Point(e.X, e.Y));
			bool isClickInCell = (hti.Column == this._columnNum
						&& hti.Row > -1);

			Rectangle rect = new Rectangle(0,0,0,0);
			if(isClickInCell)
			{
				rect = dg.GetCellBounds(hti.Row, hti.Column);
				isClickInCell = (e.X > rect.Right - this._buttonFace.Width);
			}

			if(isClickInCell)
			{
				//Console.WriteLine("HandleMouseDown " + hti.Row.ToString());
				Graphics g = Graphics.FromHwnd(dg.Handle);
				//g.DrawImage(this._buttonFacePressed, rect.Right - this._buttonFacePressed.Width, rect.Y);
				DrawButton(g, _buttonFacePressed, rect, hti.Row);
				g.Dispose();
				_pressedRow = hti.Row;
			}
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
			//base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
	
			DataGrid parent = this.DataGridTableStyle.DataGrid;
			bool current = parent.IsSelected(rowNum) ||
				( parent.CurrentRowIndex == rowNum && 
				parent.CurrentCell.ColumnNumber == this._columnNum);

			
		
			//draw the button
			Bitmap bm = _pressedRow == rowNum ? this._buttonFacePressed : this._buttonFace;
			this.DrawButton(g, bm, bounds, rowNum);
			
			//font.Dispose();
		
		}
	
	
	}
	#endregion

	#region GridCellButton click event
	public delegate void DataGridCellButtonClickEventHandler(object sender, DataGridCellButtonClickEventArgs e);

	public class DataGridCellButtonClickEventArgs : EventArgs
	{
		private int _row;
		private int _col;

		public DataGridCellButtonClickEventArgs(int row, int col)
		{
			_row = row;
			_col = col;
		}

		public int RowIndex	{get{return _row;}}
		public int ColIndex	{get{return _col;}}
	}
	#endregion

}
