// project created on 19/11/2003 at 15:13
using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblValue4;
		private System.Windows.Forms.Label lblValue5;
		private System.Windows.Forms.Label lblValue7;
		private System.Windows.Forms.Label lblValue1;
		private System.Windows.Forms.Label lblValue2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.HScrollBar hScrollBar5;
		private System.Windows.Forms.HScrollBar hScrollBar4;
		private System.Windows.Forms.HScrollBar hScrollBar7;
		private System.Windows.Forms.HScrollBar hScrollBar6;
		private System.Windows.Forms.Label lblValue3;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label lblDescription1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.Label lblDescription3;
		private System.Windows.Forms.Label lblDescription2;
		private System.Windows.Forms.Label lblDescription5;
		private System.Windows.Forms.Label lblDescription4;
		private System.Windows.Forms.Label lblDescription7;
		private System.Windows.Forms.HScrollBar hScrollBar8;
		private System.Windows.Forms.Label lblDescription8;
		private System.Windows.Forms.Label lblDescription6;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.lblDescription6 = new System.Windows.Forms.Label();
			this.lblDescription8 = new System.Windows.Forms.Label();
			this.hScrollBar8 = new System.Windows.Forms.HScrollBar();
			this.lblDescription7 = new System.Windows.Forms.Label();
			this.lblDescription4 = new System.Windows.Forms.Label();
			this.lblDescription5 = new System.Windows.Forms.Label();
			this.lblDescription2 = new System.Windows.Forms.Label();
			this.lblDescription3 = new System.Windows.Forms.Label();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.lblDescription1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.lblValue3 = new System.Windows.Forms.Label();
			this.hScrollBar6 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar7 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.lblValue2 = new System.Windows.Forms.Label();
			this.lblValue1 = new System.Windows.Forms.Label();
			this.lblValue7 = new System.Windows.Forms.Label();
			this.lblValue5 = new System.Windows.Forms.Label();
			this.lblValue4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDescription6
			// 
			this.lblDescription6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDescription6.Location = new System.Drawing.Point(0, 293);
			this.lblDescription6.Name = "lblDescription6";
			this.lblDescription6.Size = new System.Drawing.Size(448, 16);
			this.lblDescription6.TabIndex = 16;
			this.lblDescription6.Text = "A normal HScrollBar - Dock: Bottom";
			// 
			// lblDescription8
			// 
			this.lblDescription8.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDescription8.Location = new System.Drawing.Point(0, 16);
			this.lblDescription8.Name = "lblDescription8";
			this.lblDescription8.Size = new System.Drawing.Size(448, 16);
			this.lblDescription8.TabIndex = 18;
			this.lblDescription8.Text = "A normal HScrollBar - Dock: Top";
			// 
			// hScrollBar8
			// 
			this.hScrollBar8.Dock = System.Windows.Forms.DockStyle.Top;
			this.hScrollBar8.Location = new System.Drawing.Point(0, 0);
			this.hScrollBar8.Name = "hScrollBar8";
			this.hScrollBar8.Size = new System.Drawing.Size(448, 16);
			this.hScrollBar8.TabIndex = 17;
			// 
			// lblDescription7
			// 
			this.lblDescription7.Location = new System.Drawing.Point(8, 248);
			this.lblDescription7.Name = "lblDescription7";
			this.lblDescription7.Size = new System.Drawing.Size(320, 16);
			this.lblDescription7.TabIndex = 20;
			this.lblDescription7.Text = "A normal HScrollBar - Anchor: All";
			// 
			// lblDescription4
			// 
			this.lblDescription4.Location = new System.Drawing.Point(8, 168);
			this.lblDescription4.Name = "lblDescription4";
			this.lblDescription4.Size = new System.Drawing.Size(320, 16);
			this.lblDescription4.TabIndex = 10;
			this.lblDescription4.Text = "A normal HScrollBar - SmallChange: 5 ; LargeChange: 20";
			// 
			// lblDescription5
			// 
			this.lblDescription5.Location = new System.Drawing.Point(8, 208);
			this.lblDescription5.Name = "lblDescription5";
			this.lblDescription5.Size = new System.Drawing.Size(320, 16);
			this.lblDescription5.TabIndex = 13;
			this.lblDescription5.Text = "A normal HScrollBar - Enabled: false";
			// 
			// lblDescription2
			// 
			this.lblDescription2.Location = new System.Drawing.Point(8, 88);
			this.lblDescription2.Name = "lblDescription2";
			this.lblDescription2.Size = new System.Drawing.Size(320, 16);
			this.lblDescription2.TabIndex = 4;
			this.lblDescription2.Text = "A normal HScrollBar - Maximum: 900 - Minimum 200";
			// 
			// lblDescription3
			// 
			this.lblDescription3.Location = new System.Drawing.Point(8, 128);
			this.lblDescription3.Name = "lblDescription3";
			this.lblDescription3.Size = new System.Drawing.Size(320, 16);
			this.lblDescription3.TabIndex = 7;
			this.lblDescription3.Text = "A normal HScrollBar - Value: 50";
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(8, 104);
			this.hScrollBar2.Maximum = 900;
			this.hScrollBar2.Minimum = 200;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar2.TabIndex = 3;
			this.hScrollBar2.Value = 200;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarScroll);
			// 
			// lblDescription1
			// 
			this.lblDescription1.Location = new System.Drawing.Point(8, 48);
			this.lblDescription1.Name = "lblDescription1";
			this.lblDescription1.Size = new System.Drawing.Size(320, 16);
			this.lblDescription1.TabIndex = 1;
			this.lblDescription1.Text = "A normal HScrollBar";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(8, 64);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1Scroll);
			// 
			// lblValue3
			// 
			this.lblValue3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue3.Location = new System.Drawing.Point(328, 128);
			this.lblValue3.Name = "lblValue3";
			this.lblValue3.Size = new System.Drawing.Size(112, 16);
			this.lblValue3.TabIndex = 8;
			this.lblValue3.Text = "Value: 50";
			// 
			// hScrollBar6
			// 
			this.hScrollBar6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.hScrollBar6.Location = new System.Drawing.Point(0, 309);
			this.hScrollBar6.Name = "hScrollBar6";
			this.hScrollBar6.Size = new System.Drawing.Size(448, 16);
			this.hScrollBar6.TabIndex = 15;
			// 
			// hScrollBar7
			// 
			this.hScrollBar7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.hScrollBar7.Location = new System.Drawing.Point(8, 264);
			this.hScrollBar7.Name = "hScrollBar7";
			this.hScrollBar7.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar7.TabIndex = 19;
			this.hScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar7Scroll);
			// 
			// hScrollBar4
			// 
			this.hScrollBar4.LargeChange = 20;
			this.hScrollBar4.Location = new System.Drawing.Point(8, 184);
			this.hScrollBar4.Name = "hScrollBar4";
			this.hScrollBar4.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar4.SmallChange = 5;
			this.hScrollBar4.TabIndex = 9;
			this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar4Scroll);
			// 
			// hScrollBar5
			// 
			this.hScrollBar5.Enabled = false;
			this.hScrollBar5.Location = new System.Drawing.Point(8, 224);
			this.hScrollBar5.Name = "hScrollBar5";
			this.hScrollBar5.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar5.TabIndex = 12;
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(8, 144);
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(432, 16);
			this.hScrollBar3.TabIndex = 6;
			this.hScrollBar3.Value = 50;
			this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar3Scroll);
			// 
			// lblValue2
			// 
			this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue2.Location = new System.Drawing.Point(328, 88);
			this.lblValue2.Name = "lblValue2";
			this.lblValue2.Size = new System.Drawing.Size(112, 16);
			this.lblValue2.TabIndex = 5;
			this.lblValue2.Text = "Value: 200";
			// 
			// lblValue1
			// 
			this.lblValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue1.Location = new System.Drawing.Point(328, 48);
			this.lblValue1.Name = "lblValue1";
			this.lblValue1.Size = new System.Drawing.Size(112, 16);
			this.lblValue1.TabIndex = 2;
			this.lblValue1.Text = "Value: 0";
			// 
			// lblValue7
			// 
			this.lblValue7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue7.Location = new System.Drawing.Point(328, 248);
			this.lblValue7.Name = "lblValue7";
			this.lblValue7.Size = new System.Drawing.Size(112, 16);
			this.lblValue7.TabIndex = 21;
			this.lblValue7.Text = "Value: 0";
			// 
			// lblValue5
			// 
			this.lblValue5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue5.Location = new System.Drawing.Point(328, 208);
			this.lblValue5.Name = "lblValue5";
			this.lblValue5.Size = new System.Drawing.Size(112, 16);
			this.lblValue5.TabIndex = 14;
			this.lblValue5.Text = "Value: 0";
			// 
			// lblValue4
			// 
			this.lblValue4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue4.Location = new System.Drawing.Point(328, 168);
			this.lblValue4.Name = "lblValue4";
			this.lblValue4.Size = new System.Drawing.Size(112, 16);
			this.lblValue4.TabIndex = 11;
			this.lblValue4.Text = "Value: 0";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(448, 325);
			this.Controls.Add(this.lblValue7);
			this.Controls.Add(this.lblDescription7);
			this.Controls.Add(this.hScrollBar7);
			this.Controls.Add(this.lblDescription8);
			this.Controls.Add(this.hScrollBar8);
			this.Controls.Add(this.lblDescription6);
			this.Controls.Add(this.hScrollBar6);
			this.Controls.Add(this.lblValue5);
			this.Controls.Add(this.lblDescription5);
			this.Controls.Add(this.hScrollBar5);
			this.Controls.Add(this.lblValue4);
			this.Controls.Add(this.lblDescription4);
			this.Controls.Add(this.hScrollBar4);
			this.Controls.Add(this.lblValue3);
			this.Controls.Add(this.lblDescription3);
			this.Controls.Add(this.hScrollBar3);
			this.Controls.Add(this.lblValue2);
			this.Controls.Add(this.lblDescription2);
			this.Controls.Add(this.hScrollBar2);
			this.Controls.Add(this.lblValue1);
			this.Controls.Add(this.lblDescription1);
			this.Controls.Add(this.hScrollBar1);
			this.Name = "MainForm";
			this.Text = "SWF-HorizontalScrollbar";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		void HScrollBar1Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue1.Text = String.Concat("Value: ",this.hScrollBar1.Value.ToString());
		}
		
		void HScrollBarScroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue2.Text = String.Concat("Value: ",this.hScrollBar2.Value.ToString());
		}
		
		void HScrollBar3Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue3.Text = String.Concat("Value: ",this.hScrollBar3.Value.ToString());
		}
		
		void HScrollBar4Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue4.Text = String.Concat("Value: ",this.hScrollBar4.Value.ToString());
		}
		
		void HScrollBar7Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue7.Text = String.Concat("Value: ",this.hScrollBar7.Value.ToString());
		}
		
	}			
}
