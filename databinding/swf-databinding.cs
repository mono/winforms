using System;
using System.Windows.Forms;
using System.Data;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGrid dataGrid;
		private DataSet dsSource = new DataSet();
		
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.dataGrid = new System.Windows.Forms.DataGrid();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			
			// 
			// dataGrid
			// 
			this.dataGrid.DataMember = "";
			this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid.Location = new System.Drawing.Point(10, 170);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(395, 80);
			this.dataGrid.TabIndex = 6;
			
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(10, 320);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(395, 20);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "";
			
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(10, 275);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(395, 20);
			this.textBox.TabIndex = 10;
			this.textBox.Text = "";
			
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(8, 8);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(162, 16);
			this.label.TabIndex = 2;
			this.label.Text = "A ListBox - Binding: DataTable";
			
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(175, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(230, 21);
			this.comboBox1.TabIndex = 4;
			
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "A DataGrid - Binding: DataSet";
			
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(175, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "A DataGrid - Binding: DataTable";
			
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(235, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "A TextBox - Binding: Column[\"name\"]";
			
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(175, 65);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(230, 80);
			this.dataGrid2.TabIndex = 9;
			
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(10, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(160, 121);
			this.listBox1.TabIndex = 0;
			
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 305);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 15);
			this.label2.TabIndex = 13;
			this.label2.Text = "A TextBox - Binding: Column[\"name\"]";
			
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(175, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "A ComboBox - Binding: DataTable";
			
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(412, 348);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "SWF-Databinding";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		void MainFormLoad(object sender, System.EventArgs e)
		{
			//Fill the DataSet
			this.FillDataSet();
			
			//Bind the controls
			this.BindControls();
			
		}
		
		private void FillDataSet()
		{
			//Create a new DataTable in the DataSet
			dsSource.Tables.Add("sites");
			dsSource.Tables["sites"].Columns.Add("url",Type.GetType("System.String"));
			dsSource.Tables["sites"].Columns.Add("name",Type.GetType("System.String"));
			
			//Create a few rows and add them to the DataTable
			DataRow tempRow = dsSource.Tables["sites"].NewRow();
			tempRow["url"] = "http://www.gotmono.com";
			tempRow["name"] = "Mono Community Page";
			dsSource.Tables["sites"].Rows.Add(tempRow);
			
			tempRow = dsSource.Tables["sites"].NewRow();
			tempRow["url"] = "http://www.go-mono.com/tutorial";
			tempRow["name"] = "The Mono Handbook";
			dsSource.Tables["sites"].Rows.Add(tempRow);
			
			tempRow = dsSource.Tables["sites"].NewRow();
			tempRow["url"] = "http://www.go-mono.com";
			tempRow["name"] = "Mono Homepage";
			dsSource.Tables["sites"].Rows.Add(tempRow);
			
			tempRow = dsSource.Tables["sites"].NewRow();
			tempRow["url"] = "http://www.nullenvoid.com/mono/wiki/index.php/WineSamples";
			tempRow["name"] = "Mono WineSamples";
			dsSource.Tables["sites"].Rows.Add(tempRow);
		}
		
		private void BindControls()
		{
			//Bind the listBox
			listBox1.DataSource = dsSource.Tables["sites"];
			listBox1.DisplayMember = "name";
			listBox1.ValueMember = "url";
			
			//Bind the ComboBox
			comboBox1.DataSource = dsSource.Tables["sites"];
			comboBox1.DisplayMember = "name";
			comboBox1.ValueMember = "url";
			
			//Bind the DataGrid to the DataSet
			dataGrid.DataSource = dsSource;
			
			//Bind the second DataGrid to the DataSet
			dataGrid2.DataSource = dsSource.Tables["sites"];
			
			//Bind the Textboxes to the selected row
			textBox.DataBindings.Add("text",dsSource.Tables["sites"],"name");
			textBox2.DataBindings.Add("text",dsSource.Tables["sites"],"url");
			
		}		
	}			
}
