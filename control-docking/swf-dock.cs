using System;
using System.Windows.Forms;

namespace MonoSamples
{
	public class DockForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnTop;
		private System.Windows.Forms.Button btnTop2;
		private System.Windows.Forms.Button btnBottom;
		private System.Windows.Forms.Button btnBottom2;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnLeft2;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnRight2;
		private System.Windows.Forms.Button btnFill;

		public DockForm()
		{
			InitializeComponent();
		}

		public static void Main(string[] args)
		{
			Application.Run(new DockForm());
		}

		private void InitializeComponent()
		{
			this.btnTop = new System.Windows.Forms.Button();
			this.btnTop2 = new System.Windows.Forms.Button();
			this.btnBottom = new System.Windows.Forms.Button();
			this.btnBottom2 = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnLeft2 = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnRight2 = new System.Windows.Forms.Button();
			this.btnFill = new System.Windows.Forms.Button();
			// 
			// btnTop
			// 
			this.btnTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTop.Location = new System.Drawing.Point(0, 0);
			this.btnTop.Name = "btnTop";
			this.btnTop.Size = new System.Drawing.Size(528, 23);
			this.btnTop.TabIndex = 0;
			this.btnTop.Text = "Dock=Top";
			// 
			// btnTop2
			// 
			this.btnTop2.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTop2.Location = new System.Drawing.Point(0, 23);
			this.btnTop2.Name = "btnTop2";
			this.btnTop2.Size = new System.Drawing.Size(528, 23);
			this.btnTop2.TabIndex = 1;
			this.btnTop2.Text = "Dock=Top (2)";
			// 
			// btnBottom
			// 
			this.btnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnBottom.Location = new System.Drawing.Point(0, 302);
			this.btnBottom.Name = "btnBottom";
			this.btnBottom.Size = new System.Drawing.Size(528, 23);
			this.btnBottom.TabIndex = 2;
			this.btnBottom.Text = "Dock=Bottom";
			// 
			// btnBottom2
			// 
			this.btnBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnBottom2.Location = new System.Drawing.Point(0, 279);
			this.btnBottom2.Name = "btnBottom2";
			this.btnBottom2.Size = new System.Drawing.Size(528, 23);
			this.btnBottom2.TabIndex = 3;
			this.btnBottom2.Text = "Dock=Bottom (2)";
			// 
			// btnLeft
			// 
			this.btnLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnLeft.Location = new System.Drawing.Point(0, 46);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(75, 233);
			this.btnLeft.TabIndex = 4;
			this.btnLeft.Text = "Dock=Left";
			// 
			// btnLeft2
			// 
			this.btnLeft2.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnLeft2.Location = new System.Drawing.Point(75, 46);
			this.btnLeft2.Name = "btnLeft2";
			this.btnLeft2.Size = new System.Drawing.Size(75, 233);
			this.btnLeft2.TabIndex = 5;
			this.btnLeft2.Text = "Dock=Left (2)";
			// 
			// btnRight
			// 
			this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRight.Location = new System.Drawing.Point(453, 46);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(75, 233);
			this.btnRight.TabIndex = 6;
			this.btnRight.Text = "Dock=Right";
			// 
			// btnRight2
			// 
			this.btnRight2.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRight2.Location = new System.Drawing.Point(378, 46);
			this.btnRight2.Name = "btnRight2";
			this.btnRight2.Size = new System.Drawing.Size(75, 233);
			this.btnRight2.TabIndex = 7;
			this.btnRight2.Text = "Dock=Right (2)";
			// 
			// btnFill
			// 
			this.btnFill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnFill.Location = new System.Drawing.Point(150, 46);
			this.btnFill.Name = "btnFill";
			this.btnFill.Size = new System.Drawing.Size(228, 233);
			this.btnFill.TabIndex = 8;
			this.btnFill.Text = "Dock=Fill";
			// 
			// DockForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 325);
			this.Controls.Add(this.btnFill);
			this.Controls.Add(this.btnRight2);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft2);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnBottom2);
			this.Controls.Add(this.btnBottom);
			this.Controls.Add(this.btnTop2);
			this.Controls.Add(this.btnTop);
			this.Name = "DockForm";
			this.Text = "SWF-Dock";
			this.ResumeLayout(false);

		}
	}
}
