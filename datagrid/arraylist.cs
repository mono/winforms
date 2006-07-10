/* sample from the winforms faq: http://www.syncfusion.com/faq/windowsforms/Default.aspx */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGridArrayList
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private ArrayList arrayList1;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.Button buttonDeleteCurrent;
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
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.buttonDeleteCurrent = new System.Windows.Forms.Button();
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
			// buttonAddNew
			// 
			this.buttonAddNew.Location = new System.Drawing.Point(56, 264);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(88, 23);
			this.buttonAddNew.TabIndex = 1;
			this.buttonAddNew.Text = "AddNew";
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// buttonDeleteCurrent
			// 
			this.buttonDeleteCurrent.Location = new System.Drawing.Point(168, 264);
			this.buttonDeleteCurrent.Name = "buttonDeleteCurrent";
			this.buttonDeleteCurrent.Size = new System.Drawing.Size(88, 23);
			this.buttonDeleteCurrent.TabIndex = 2;
			this.buttonDeleteCurrent.Text = "DeleteCurrent";
			this.buttonDeleteCurrent.Click += new System.EventHandler(this.buttonDeleteCurrent_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 317);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonDeleteCurrent,
																		  this.buttonAddNew,
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
		static void Main() 
		{
		Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			CreateArrayList();
			BindArrayListToGrid();
		}

		void CurrencyManager_ItemChanged (object sender, ItemChangedEventArgs args)
		{
			Console.WriteLine ("ItemChanged ({0})\n{1}", args.Index, Environment.StackTrace);
		}

		private void BindArrayListToGrid()
		{
			dataGrid1.DataSource = arrayList1;

			CurrencyManager cm = (CurrencyManager) this.dataGrid1.BindingContext[arrayList1];
			cm.ItemChanged += new ItemChangedEventHandler (CurrencyManager_ItemChanged);

			//create a custom tablestyle and add two columnstyles
			DataGridTableStyle ts = new DataGridTableStyle();
			ts.MappingName = "ArrayList";

			int colwidth = (dataGrid1.ClientSize.Width - ts.RowHeaderWidth - SystemInformation.VerticalScrollBarWidth - 5) / 2;

			//create a column for the value property
			DataGridTextBoxColumn cs = new DataGridTextBoxColumn();
			cs.MappingName = "value"; //public property name
			cs.HeaderText = "Random Number";
			cs.Format = "f4";
			cs.Width = colwidth;
			ts.GridColumnStyles.Add(cs);

			//create a column for the sqrt property
			cs = new DataGridTextBoxColumn();
			cs.MappingName = "sqrt";  //public property name
			cs.HeaderText = "Square Root";
			cs.Format = "f4";
			cs.Width = colwidth;
			ts.GridColumnStyles.Add(cs);

			dataGrid1.TableStyles.Clear();
			dataGrid1.TableStyles.Add(ts);
		}

		private void CreateArrayList()
		{
			arrayList1 = new ArrayList();

			//add some items
			Random r = new Random();
			for (int i = 0; i < 20; ++i)
				arrayList1.Add(new RandomNumber(r.NextDouble()));

		}

		//create a struct or class that defines what you want in each row
		//the different columns in the row must be public properties
		public struct RandomNumber
		{
			private double number;

			public RandomNumber(double d)
			{
				number = d;
			}

			public double value 
			{
				get{ return number; }
				set{ number = value;}
			}

			public double sqrt
			{
				get {return Math.Sqrt(this.value);}
			}
		}
		
		private void buttonAddNew_Click(object sender, System.EventArgs e)
		{
			Random r = new Random();
			arrayList1.Add(new RandomNumber(r.NextDouble()));

			CurrencyManager cm = (CurrencyManager) this.dataGrid1.BindingContext[arrayList1];
			if (cm != null)
				cm.Refresh();

		}

		private void buttonDeleteCurrent_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[dataGrid1.DataSource];

			if(cm.Count <= 1)
				return; // dont allow empty datagrid

			int removeAt = cm.Position;
			Console.WriteLine ("removing from row {0}", removeAt);

			if(removeAt > 0)
			{
				cm.Position = removeAt - 1;
			}

			arrayList1.RemoveAt(removeAt);

			if (cm != null)
				cm.Refresh();
		}
	}
}
