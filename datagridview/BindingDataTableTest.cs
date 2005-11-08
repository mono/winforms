using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data;

public class Form1 : Form {

	public Form1 () {
		//this.AutoSize = true;
		DataGridView dgv = new DataGridView();
		//dgv.Size = new Size(500,250);
		dgv.Location = new Point(10,10);
		dgv.EnableHeadersVisualStyles = false;
		dgv.AutoSize = true;
		this.Controls.Add(dgv);
		this.Text = "DataGridView advanced border styles demo";
		dgv.DataSource = GetDataTable();
	}

	public DataTable GetDataTable () {
		DataTable result = new DataTable();
		result.Columns.Add(new DataColumn("NAME"));
		result.Columns.Add(new DataColumn("NUMBER"));
		for (int i = 0; i < 10; i++) {
			DataRow row = result.NewRow();
			row["NAME"] = "Name " + i.ToString();
			row["NUMBER"] = i.ToString();
			result.Rows.Add(row);
		}
		return result;
	}

	public static void Main() {
		Application.Run(new Form1());
	}

}
