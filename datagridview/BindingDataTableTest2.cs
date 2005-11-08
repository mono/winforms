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
		DataSet ds = new DataSet();
		System.IO.FileStream fs = new System.IO.FileStream("programes.xml", System.IO.FileMode.Open);
		System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(fs);
		ds.ReadXml(reader);
		reader.Close();
		return ds.Tables["programes"];
	}

	public static void Main() {
		Application.Run(new Form1());
	}

}
