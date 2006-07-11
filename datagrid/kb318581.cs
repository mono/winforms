/* C# ported form the VB at http://support.microsoft.com/default.aspx?scid=kb;en-us;Q318581 */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class Form1 : System.Windows.Forms.Form
{
	DataSet ds = new DataSet ();
	DataGrid dataGrid1;

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
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(264, 216);
			this.dataGrid1.TabIndex = 0;

			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 317);
			this.Controls.Add (this.dataGrid1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}

	void Form1_Load (object sender, EventArgs e)
	{
		/* Generate sample data
		   Two columns:
		      Decimal - uses CRTextBoxColumn for column style.
		      Integer - uses standard DataGridTextBoxColumn for column style.
		*/

		DataTable dt = new DataTable ();
		dt.TableName = "TestTable";
		dt.Columns.Add ("Amount", typeof(Decimal));
		dt.Columns.Add ("ColB", typeof (Int32));
		ds.Tables.Add(dt);
		dt.Rows.Add(new object[] {2, 4});
		dt.Rows.Add(new object[] {-3.45, 5});
		dt.Rows.Add(new object[] {4.25, 6});
		dt.Rows.Add(new object[] {-1.33, 7});

		/*
		 * Create DataGridTableStyle and DataGridColumnStyle objects
		 * and add them the the DataGrid.
		 */
		DataGridTableStyle ts = new DataGridTableStyle ();
		DataGridColumnStyle cs;

		/* Add the custom column style. */
		cs = new CRTextBoxColumn();
		cs.Width = 120;
		cs.MappingName = "Amount"; /* Map to decimal column. */
		cs.HeaderText = "Charge/Payment";
		ts.GridColumnStyles.Add(cs);

		/* Add the standard column style. */
		cs = new DataGridTextBoxColumn();
		cs.Width = 100;
		cs.MappingName = "ColB"; /* Map to integer column. */
		cs.HeaderText = "Integer Col";
		ts.GridColumnStyles.Add(cs);

		ts.MappingName = "TestTable"; /* Map table style to TestTable. */
		dataGrid1.TableStyles.Add(ts);

		dataGrid1.DataSource = ds;
		dataGrid1.DataMember = "TestTable";
	}


	class CRTextBoxColumn : DataGridTextBoxColumn {

		protected override object GetColumnValueAtRow (CurrencyManager cm, int RowNum)
		{
			/*
			 * Get data from the underlying record and format for display.
			 */
			object oVal = base.GetColumnValueAtRow(cm, RowNum);

			if (oVal is DBNull) {
				return ""; /* String to display for DBNull. */
			}
			else {
				/* CDec on next statement will throw an exception if this
				   column style is bound to a column containing non-numeric data. */
				Decimal Temp = (Decimal)oVal;
				if (Temp >= 0)
					return Temp.ToString ("0.00");
				else
					return (-Temp).ToString("0.00") + "CR";
			}
		}

		protected override bool Commit (CurrencyManager cm, int RowNum)
		{
			/*
			 * Parse the data and write to underlying record.
			 */

			HideEditBox();   /* return focus to the DataGrid control */
			DataGridTextBox box = (DataGridTextBox)TextBox;
			Decimal Value;

			/* Do not write data if not editing. */
			if (box.IsInEditOrNavigateMode)
				return true;

			if (TextBox.Text == "") {
				/* in this example, "" maps to DBNull */
				SetColumnValueAtRow(cm, RowNum, DBNull.Value);
			}
			else {
				/* Parse the data. */
				try {
					if (TextBox.Text.ToUpper().EndsWith("CR"))
						Value = -Decimal.Parse(TextBox.Text.Substring(0, TextBox.Text.Length - 2));
					else					
						Value = Decimal.Parse(TextBox.Text);
				} catch {
					return false;
				}
				SetColumnValueAtRow(cm, RowNum, Value);   /* Write new value. */
			}

			EndEdit();   /* Let the DataGrid know that processing is completed. */
			return true;
		}
	}

	[STAThread]
	static void Main() 
	{
		Application.Run(new Form1());
	}
}
