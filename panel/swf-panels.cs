using System;
using System.Windows.Forms;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		// Panels
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;

		// Labels within panels; describe panel options
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		
		public MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			// 
			// panel1, label1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(472, 32);
			this.panel1.TabIndex = 14;
			this.label1.Location = new System.Drawing.Point(172, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Panel.Dock = Top";
			// 
			// panel2, label2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(36, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 24);
			this.panel2.TabIndex = 2;
			this.label2.Location = new System.Drawing.Point(117, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Panel.BorderStyle=FixedSingle";
			// 
			// panel3, label3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(36, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(400, 24);
			this.panel3.TabIndex = 4;
			this.label3.Location = new System.Drawing.Point(123, -1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Panel.BorderStyle=Fixed3D";
			// 
			// panel4, label4
			// 
			this.panel4.BackColor = System.Drawing.Color.Red;
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(36, 112);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(400, 24);
			this.panel4.TabIndex = 0;
			this.label4.Location = new System.Drawing.Point(144, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Panel.BackColor=red";
			// 
			// panel5, label5
			// 
			this.panel5.Controls.Add(this.label5);
			this.panel5.ForeColor = System.Drawing.Color.Red;
			this.panel5.Location = new System.Drawing.Point(36, 152);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(400, 24);
			this.panel5.TabIndex = 6;
			this.label5.Location = new System.Drawing.Point(144, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Panel.ForeColor=red";
			// 
			// panel6, label6
			// 
			this.panel6.Controls.Add(this.label6);
			this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(36, 184);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(400, 24);
			this.panel6.TabIndex = 8;
			this.label6.Location = new System.Drawing.Point(88, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(224, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Panel.Font=Verdana, 12pt";
			// 
			// panel7, label7
			// 
			this.panel7.Controls.Add(this.label7);
			this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel7.Location = new System.Drawing.Point(36, 224);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(400, 24);
			this.panel7.TabIndex = 10;
			this.label7.Location = new System.Drawing.Point(144, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Panel.Cursor = Hand";
			// 
			// panel8, label8
			// 
			this.panel8.AutoScroll = true;
			this.panel8.Controls.Add(this.label8);
			this.panel8.Location = new System.Drawing.Point(36, 264);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(400, 24);
			this.panel8.TabIndex = 15;
			this.label8.Location = new System.Drawing.Point(131, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(121, 40);
			this.label8.TabIndex = 17;
			this.label8.Text = "Panel.AutoScroll=true";
			// 
			// panel9, label9
			// 
			this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel9.Controls.Add(this.label9);
			this.panel9.Location = new System.Drawing.Point(36, 304);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(404, 24);
			this.panel9.TabIndex = 17;
			this.label9.Location = new System.Drawing.Point(152, 1);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Panel.Anchor=All";
			// 
			// panel10, label10
			// 
			this.panel10.Controls.Add(this.label10);
			this.panel10.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel10.Location = new System.Drawing.Point(0, 350);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(472, 32);
			this.panel10.TabIndex = 12;
			this.label10.Location = new System.Drawing.Point(172, 5);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "Panel.Dock = Bottom";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 382);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel10);
			this.Name = "MainForm";
			this.Text = "SWF-Panels";
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
	}
}
