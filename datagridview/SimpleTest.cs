using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
	public static void Main() {
		Application.EnableVisualStyles();
		Application.Run(new Form1());
	}

	public Form1() {
		//this.AutoSize = true;
		DataGridView dgv = new DataGridView();
		//dgv.Size = new Size(500,250);
		dgv.Location = new Point(10,10);
		dgv.RowTemplate = new DataGridViewRow();
		DataGridViewColumn col = new DataGridViewColumn();
		col.CellTemplate = new DataGridViewTextBoxCell();
		dgv.Columns.Add(col.Clone() as DataGridViewColumn);
		dgv.Columns.Add(col.Clone() as DataGridViewColumn);
		dgv.Columns.Add(col.Clone() as DataGridViewColumn);
		dgv.RowCount = 4;
		dgv.EnableHeadersVisualStyles = false;
		dgv.AutoSize = true;
		this.Controls.Add(dgv);
		this.Text = "DataGridView advanced border styles demo";
	}

}
