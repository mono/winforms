using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		static MainForm main;
		// Panels
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;

		private System.Windows.Forms.Form form1;
		private System.Windows.Forms.Form form2;
		private System.Windows.Forms.Form form3;
		private System.Windows.Forms.Form form4;
		private System.Windows.Forms.Form form5;
		private System.Windows.Forms.Form form6;

		// Labels within panels; describe options
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;

		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;

		private System.Windows.Forms.Timer t;
		
		public MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();

			this.form1 = new System.Windows.Forms.Form();
			this.form2 = new System.Windows.Forms.Form();
			this.form3 = new System.Windows.Forms.Form();
			this.form4 = new System.Windows.Forms.Form();
			this.form5 = new System.Windows.Forms.Form();
			this.form6 = new System.Windows.Forms.Form();

			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();

			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			// 
			// panel1, label1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Location = new System.Drawing.Point(36, 16);
			this.panel1.Name = "BorderStyle.None";
			this.panel1.Size = new System.Drawing.Size(400, 24);
			this.panel1.TabIndex = 14;
			this.label1.Location = new System.Drawing.Point(100, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "BorderStyle.None";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;

			// 
			// panel2, label2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(36, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 24);
			this.panel2.TabIndex = 2;
			this.panel2.ForeColor = Color.Green;
			this.label2.Location = new System.Drawing.Point(100, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "BorderStyle=FixedSingle";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;

			// 
			// panel3, label3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(36, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(400, 24);
			this.panel3.TabIndex = 4;
			this.label3.Location = new System.Drawing.Point(100, -1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "BorderStyle=Fixed3D";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;


			label11.Text = "FormBorderStyle.Fixed3D";
			label11.Dock = DockStyle.Fill;
			form1.FormBorderStyle = FormBorderStyle.Fixed3D;
			form1.Controls.Add(this.label11);
			form1.BackColor = Color.SeaShell;
			form1.Show();

			label12.Text = "FormBorderStyle.FixedDialog (owning FixedDialog)";
			label12.Dock = DockStyle.Fill;
			form2.FormBorderStyle = FormBorderStyle.FixedDialog;
			form2.Controls.Add(this.label12);
			form2.BackColor = Color.SeaShell;
			form2.Show();

			label13.Text = "FormBorderStyle.FixedSingle";
			label13.Dock = DockStyle.Fill;
			form3.FormBorderStyle = FormBorderStyle.FixedSingle;
			form3.Controls.Add(this.label13);
			form3.BackColor = Color.SeaShell;
			form3.Show();

			label14.Text = "FormBorderStyle.FixedToolWindow";
			label14.Dock = DockStyle.Fill;
			form4.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			form4.Controls.Add(this.label14);
			form4.BackColor = Color.SeaShell;
			form4.Show();

			label15.Text = "FormBorderStyle.Sizable";
			label15.Dock = DockStyle.Fill;
			form5.FormBorderStyle = FormBorderStyle.Sizable;
			form5.Controls.Add(this.label15);
			form5.BackColor = Color.SeaShell;
			form5.Show();

			label16.Text = "FormBorderStyle.SizableToolWindow";
			label16.Dock = DockStyle.Fill;
			form6.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			form6.Controls.Add(this.label16);
			form6.BackColor = Color.SeaShell;
			form6.Show();

			// Position on screen
			this.Location = new Point(10, 10);

			form1.Location = new Point(10, 200);
			form1.Size = new Size(200, 50);

			form2.Location = new Point(10, 280);
			form2.Size = new Size(200, 50);

			form3.Location = new Point(10, 360);
			form3.Size = new Size(200, 50);
			form3.Owner = form2;

			form4.Location = new Point(10, 440);
			form4.Size = new Size(200, 50);

			form5.Location = new Point(10, 520);
			form5.Size = new Size(200, 50);

			form6.Location = new Point(10, 600);
			form6.Size = new Size(200, 50);

			// Start off timer

			t = new Timer();
			t.Interval = 2500;
			t.Tick += new EventHandler(t_Tick);	
			t.Start();

			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 120);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);

			this.Name = "MainForm";
			this.Text = "Borders";
		}

		[STAThread]
		static void Main() 
		{
			ApplicationContext ctx;

			main = new MainForm();
			ctx = new ApplicationContext(main.form1);
			Application.Run(ctx);

			MessageBox.Show("Past first Application.Run(), main.Form1 disposed=" + main.form1.IsDisposed.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

			main.Visible = true;
			Application.Run();
			MessageBox.Show("Past second Application.Run()", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void t_Tick(object sender, EventArgs e) {
			Form	f;
			Label	l;
			Button	b;

			t.Stop();

			l = new Label();
			f = new Form();
			b = new Button();

			l.Text = "Modal Form";
			l.Dock = DockStyle.Fill;

			b.Text = "New modal";
			b.Click += new EventHandler(b_Click);

			f.FormBorderStyle = FormBorderStyle.FixedDialog;
			f.Controls.Add(b);
			f.Controls.Add(l);
			f.BackColor = Color.SeaShell;
			f.ShowDialog();
			MessageBox.Show("Past ShowDialog()", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

			t.Interval = 5000;
			t.Start();
			t.Tick -= new EventHandler(t_Tick);
			t.Tick += new EventHandler(t_Tick2);
		}

		private void t_Tick2(object sender, EventArgs e) {
			MessageBox.Show("Click OK to call Close() on main (invisible) form", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			main.Close();
			t.Stop();
		}

		private void b_Click(object sender, EventArgs e) {
			Form	f;
			Label	l;

			l = new Label();
			f = new Form();

			l.Text = "Modal Form created by Modal Form";
			l.Dock = DockStyle.Fill;

			f.FormBorderStyle = FormBorderStyle.FixedDialog;
			f.Controls.Add(l);
			f.BackColor = Color.Plum;
			f.ShowDialog();
			MessageBox.Show("Past ShowDialog() inside ShowDialog", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
