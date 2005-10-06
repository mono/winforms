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

		// Labels within panels; describe options
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
		public MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
