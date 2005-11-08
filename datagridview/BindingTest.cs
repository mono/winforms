using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

public class DataElement {

	private string name;
	private int val;

	public DataElement () {
	}

	public string Name {
		get { return name; }
		set { name = value; }
	}

	public int Val {
		get { return val; }
		set { val = value; }
	}

}

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
		dgv.DataSource = GetList();
	}

	public IList GetList () {
		ArrayList result = new ArrayList();
		for (int i = 0; i < 10; i++) {
			DataElement element = new DataElement();
			element.Name = "Name " + i.ToString();
			element.Val = i;
			result.Add(element);
		}
		return result;
	}

	public static void Main() {
		Application.Run(new Form1());
	}

}
