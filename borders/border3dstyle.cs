using System;
using System.Drawing;
using System.Windows.Forms;

namespace bordertest
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel8;
		public MainForm()
		{
			InitializeComponent();
			
			panel1.Paint += new PaintEventHandler(OnPaintPanel1);
			panel2.Paint += new PaintEventHandler(OnPaintPanel2);
			panel3.Paint += new PaintEventHandler(OnPaintPanel3);
			panel4.Paint += new PaintEventHandler(OnPaintPanel4);
			panel5.Paint += new PaintEventHandler(OnPaintPanel5);
			panel6.Paint += new PaintEventHandler(OnPaintPanel6);
			panel7.Paint += new PaintEventHandler(OnPaintPanel7);
			panel8.Paint += new PaintEventHandler(OnPaintPanel8);
			panel9.Paint += new PaintEventHandler(OnPaintPanel9);
			panel10.Paint += new PaintEventHandler(OnPaintPanel10);
		}
		
		public void OnPaintPanel1(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Raised);
		}
		
		public void OnPaintPanel2(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Sunken);
		}
		
		public void OnPaintPanel3(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Etched);
		}
		
		public void OnPaintPanel4(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.RaisedInner);
		}
		
		public void OnPaintPanel5(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.RaisedOuter);
		}
		
		public void OnPaintPanel6(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.SunkenOuter);
		}
		
		public void OnPaintPanel7(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.SunkenInner);
		}
		
		public void OnPaintPanel8(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Flat);
		}
		
		public void OnPaintPanel9(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Adjust);
		}
		
		public void OnPaintPanel10(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Bump);
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		private void InitializeComponent() {
			this.panel8 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel8.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label8);
			this.panel8.Location = new System.Drawing.Point(432, 136);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(136, 96);
			this.panel8.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 16);
			this.label8.Name = "label8";
			this.label8.TabIndex = 0;
			this.label8.Text = "Flat";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 24);
			this.label9.Name = "label9";
			this.label9.TabIndex = 0;
			this.label9.Text = "Adjust";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(432, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(136, 96);
			this.panel4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 24);
			this.label4.Name = "label4";
			this.label4.TabIndex = 0;
			this.label4.Text = "RaisedInner";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 24);
			this.label5.Name = "label5";
			this.label5.TabIndex = 0;
			this.label5.Text = "RaisedOuter";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.TabIndex = 0;
			this.label6.Text = "SunkenOuter";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.TabIndex = 0;
			this.label7.Text = "SunkenInner";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 96);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Raised";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "Sunken";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "Etched";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(144, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(128, 96);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(288, 16);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(128, 96);
			this.panel3.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label6);
			this.panel6.Location = new System.Drawing.Point(144, 136);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(128, 96);
			this.panel6.TabIndex = 5;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label7);
			this.panel7.Location = new System.Drawing.Point(288, 136);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(128, 96);
			this.panel7.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label5);
			this.panel5.Location = new System.Drawing.Point(8, 136);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(120, 96);
			this.panel5.TabIndex = 4;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.label9);
			this.panel9.Location = new System.Drawing.Point(8, 256);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(120, 96);
			this.panel9.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 24);
			this.label10.Name = "label10";
			this.label10.TabIndex = 0;
			this.label10.Text = "Bump";
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.label10);
			this.panel10.Location = new System.Drawing.Point(144, 256);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(128, 96);
			this.panel10.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 389);
			this.Controls.Add(this.panel10);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panel8.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
