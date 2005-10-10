using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
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
			form1.Show();

			label12.Text = "FormBorderStyle.FixedDialog";
			label12.Dock = DockStyle.Fill;
			form2.FormBorderStyle = FormBorderStyle.FixedDialog;
			form2.Controls.Add(this.label12);
			form2.Show();

			label13.Text = "FormBorderStyle.FixedSingle";
			label13.Dock = DockStyle.Fill;
			form3.FormBorderStyle = FormBorderStyle.FixedSingle;
			form3.Controls.Add(this.label13);
			form3.Show();

			label14.Text = "FormBorderStyle.FixedToolWindow";
			label14.Dock = DockStyle.Fill;
			form4.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			form4.Controls.Add(this.label14);
			form4.Show();

			label15.Text = "FormBorderStyle.Sizable";
			label15.Dock = DockStyle.Fill;
			form5.FormBorderStyle = FormBorderStyle.Sizable;
			form5.Controls.Add(this.label15);
			form5.Show();

			label16.Text = "FormBorderStyle.SizableToolWindow";
			label16.Dock = DockStyle.Fill;
			form6.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			form6.Controls.Add(this.label16);
			form6.Show();

			// Position on screen
			this.Location = new Point(10, 10);

			form1.Location = new Point(10, 200);
			form1.Size = new Size(200, 50);

			form2.Location = new Point(10, 280);
			form2.Size = new Size(200, 50);

			form3.Location = new Point(10, 360);
			form3.Size = new Size(200, 50);

			form4.Location = new Point(10, 440);
			form4.Size = new Size(200, 50);

			form5.Location = new Point(10, 520);
			form5.Size = new Size(200, 50);

			form6.Location = new Point(10, 600);
			form6.Size = new Size(200, 50);
			

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
			Application.Run(new MainForm());
		}
	}
}
