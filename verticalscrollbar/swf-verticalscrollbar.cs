using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblValue8;
		private System.Windows.Forms.Label lblValue4;
		private System.Windows.Forms.Label lblValue5;
		private System.Windows.Forms.Label lblValue6;
		private System.Windows.Forms.Label lblValue7;
		private System.Windows.Forms.Label lblValue3;
		private System.Windows.Forms.VScrollBar vScrollBar2;
		private System.Windows.Forms.VScrollBar vScrollBar8;
		private System.Windows.Forms.VScrollBar vScrollBar7;
		private System.Windows.Forms.VScrollBar vScrollBar6;
		private System.Windows.Forms.VScrollBar vScrollBar5;
		private System.Windows.Forms.VScrollBar vScrollBar4;
		private System.Windows.Forms.VScrollBar vScrollBar3;
		private System.Windows.Forms.Label lblDescription1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.Label lblDescription3;
		private System.Windows.Forms.Label lblDescription2;
		private System.Windows.Forms.Label lblDescription5;
		private System.Windows.Forms.Label lblDescription4;
		private System.Windows.Forms.Label lblDescription7;
		private System.Windows.Forms.Label lblDescription6;
		private System.Windows.Forms.Label lblDescription8;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.lblDescription8 = new System.Windows.Forms.Label();
			this.lblDescription6 = new System.Windows.Forms.Label();
			this.lblDescription7 = new System.Windows.Forms.Label();
			this.lblDescription4 = new System.Windows.Forms.Label();
			this.lblDescription5 = new System.Windows.Forms.Label();
			this.lblDescription2 = new System.Windows.Forms.Label();
			this.lblDescription3 = new System.Windows.Forms.Label();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.lblDescription1 = new System.Windows.Forms.Label();
			this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar5 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar6 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar7 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar8 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.lblValue3 = new System.Windows.Forms.Label();
			this.lblValue7 = new System.Windows.Forms.Label();
			this.lblValue6 = new System.Windows.Forms.Label();
			this.lblValue5 = new System.Windows.Forms.Label();
			this.lblValue4 = new System.Windows.Forms.Label();
			this.lblValue8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDescription8
			// 
			this.lblDescription8.Location = new System.Drawing.Point(144, 144);
			this.lblDescription8.Name = "lblDescription8";
			this.lblDescription8.Size = new System.Drawing.Size(264, 16);
			this.lblDescription8.TabIndex = 14;
			this.lblDescription8.Text = "A normal VScrollBar - Anchor: All";
			// 
			// lblDescription6
			// 
			this.lblDescription6.Location = new System.Drawing.Point(96, 96);
			this.lblDescription6.Name = "lblDescription6";
			this.lblDescription6.Size = new System.Drawing.Size(312, 16);
			this.lblDescription6.TabIndex = 11;
			this.lblDescription6.Text = "A normal VScrollBar - SmallChange: 5 ; LargeChange: 20";
			// 
			// lblDescription7
			// 
			this.lblDescription7.Location = new System.Drawing.Point(120, 120);
			this.lblDescription7.Name = "lblDescription7";
			this.lblDescription7.Size = new System.Drawing.Size(288, 16);
			this.lblDescription7.TabIndex = 13;
			this.lblDescription7.Text = "A normal VScrollBar - Enabled: false";
			// 
			// lblDescription4
			// 
			this.lblDescription4.Location = new System.Drawing.Point(48, 48);
			this.lblDescription4.Name = "lblDescription4";
			this.lblDescription4.Size = new System.Drawing.Size(360, 16);
			this.lblDescription4.TabIndex = 7;
			this.lblDescription4.Text = "A normal VSrollBar - Maximum: 900 - Minimum: 200";
			// 
			// lblDescription5
			// 
			this.lblDescription5.Location = new System.Drawing.Point(72, 72);
			this.lblDescription5.Name = "lblDescription5";
			this.lblDescription5.Size = new System.Drawing.Size(336, 16);
			this.lblDescription5.TabIndex = 9;
			this.lblDescription5.Text = "A normal VScrollBar - Value: 50";
			// 
			// lblDescription2
			// 
			this.lblDescription2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDescription2.Location = new System.Drawing.Point(16, 389);
			this.lblDescription2.Name = "lblDescription2";
			this.lblDescription2.Size = new System.Drawing.Size(504, 16);
			this.lblDescription2.TabIndex = 3;
			this.lblDescription2.Text = "A normal VScrollBar - Dock: Right";
			this.lblDescription2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lblDescription3
			// 
			this.lblDescription3.Location = new System.Drawing.Point(24, 24);
			this.lblDescription3.Name = "lblDescription3";
			this.lblDescription3.Size = new System.Drawing.Size(384, 16);
			this.lblDescription3.TabIndex = 5;
			this.lblDescription3.Text = "A normal VScrollBar";
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(16, 405);
			this.vScrollBar1.TabIndex = 0;
			// 
			// lblDescription1
			// 
			this.lblDescription1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDescription1.Location = new System.Drawing.Point(16, 0);
			this.lblDescription1.Name = "lblDescription1";
			this.lblDescription1.Size = new System.Drawing.Size(504, 16);
			this.lblDescription1.TabIndex = 2;
			this.lblDescription1.Text = "A normal VScrollBar - Dock: Left";
			// 
			// vScrollBar3
			// 
			this.vScrollBar3.Location = new System.Drawing.Point(24, 40);
			this.vScrollBar3.Name = "vScrollBar3";
			this.vScrollBar3.Size = new System.Drawing.Size(16, 344);
			this.vScrollBar3.TabIndex = 4;
			this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar3Scroll);
			// 
			// vScrollBar4
			// 
			this.vScrollBar4.Location = new System.Drawing.Point(48, 64);
			this.vScrollBar4.Maximum = 900;
			this.vScrollBar4.Minimum = 200;
			this.vScrollBar4.Name = "vScrollBar4";
			this.vScrollBar4.Size = new System.Drawing.Size(16, 320);
			this.vScrollBar4.TabIndex = 6;
			this.vScrollBar4.Value = 200;
			this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar4Scroll);
			// 
			// vScrollBar5
			// 
			this.vScrollBar5.Location = new System.Drawing.Point(72, 88);
			this.vScrollBar5.Name = "vScrollBar5";
			this.vScrollBar5.Size = new System.Drawing.Size(16, 296);
			this.vScrollBar5.TabIndex = 8;
			this.vScrollBar5.Value = 50;
			this.vScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar5Scroll);
			// 
			// vScrollBar6
			// 
			this.vScrollBar6.LargeChange = 20;
			this.vScrollBar6.Location = new System.Drawing.Point(96, 112);
			this.vScrollBar6.Name = "vScrollBar6";
			this.vScrollBar6.Size = new System.Drawing.Size(16, 272);
			this.vScrollBar6.SmallChange = 5;
			this.vScrollBar6.TabIndex = 10;
			this.vScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar6Scroll);
			// 
			// vScrollBar7
			// 
			this.vScrollBar7.Enabled = false;
			this.vScrollBar7.Location = new System.Drawing.Point(120, 136);
			this.vScrollBar7.Name = "vScrollBar7";
			this.vScrollBar7.Size = new System.Drawing.Size(16, 248);
			this.vScrollBar7.TabIndex = 12;
			this.vScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar7Scroll);
			// 
			// vScrollBar8
			// 
			this.vScrollBar8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.vScrollBar8.Location = new System.Drawing.Point(144, 160);
			this.vScrollBar8.Name = "vScrollBar8";
			this.vScrollBar8.Size = new System.Drawing.Size(16, 224);
			this.vScrollBar8.TabIndex = 15;
			this.vScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar8Scroll);
			// 
			// vScrollBar2
			// 
			this.vScrollBar2.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar2.Location = new System.Drawing.Point(520, 0);
			this.vScrollBar2.Name = "vScrollBar2";
			this.vScrollBar2.Size = new System.Drawing.Size(16, 405);
			this.vScrollBar2.TabIndex = 1;
			// 
			// lblValue3
			// 
			this.lblValue3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue3.Location = new System.Drawing.Point(408, 24);
			this.lblValue3.Name = "lblValue3";
			this.lblValue3.Size = new System.Drawing.Size(104, 16);
			this.lblValue3.TabIndex = 16;
			this.lblValue3.Text = "Value: 0";
			// 
			// lblValue7
			// 
			this.lblValue7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue7.Location = new System.Drawing.Point(408, 120);
			this.lblValue7.Name = "lblValue7";
			this.lblValue7.Size = new System.Drawing.Size(104, 16);
			this.lblValue7.TabIndex = 20;
			this.lblValue7.Text = "Value: 0";
			// 
			// lblValue6
			// 
			this.lblValue6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue6.Location = new System.Drawing.Point(408, 96);
			this.lblValue6.Name = "lblValue6";
			this.lblValue6.Size = new System.Drawing.Size(104, 16);
			this.lblValue6.TabIndex = 19;
			this.lblValue6.Text = "Value: 0";
			// 
			// lblValue5
			// 
			this.lblValue5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue5.Location = new System.Drawing.Point(408, 72);
			this.lblValue5.Name = "lblValue5";
			this.lblValue5.Size = new System.Drawing.Size(104, 16);
			this.lblValue5.TabIndex = 18;
			this.lblValue5.Text = "Value: 50";
			// 
			// lblValue4
			// 
			this.lblValue4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue4.Location = new System.Drawing.Point(408, 48);
			this.lblValue4.Name = "lblValue4";
			this.lblValue4.Size = new System.Drawing.Size(104, 16);
			this.lblValue4.TabIndex = 17;
			this.lblValue4.Text = "Value: 200";
			// 
			// lblValue8
			// 
			this.lblValue8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue8.Location = new System.Drawing.Point(408, 144);
			this.lblValue8.Name = "lblValue8";
			this.lblValue8.Size = new System.Drawing.Size(104, 16);
			this.lblValue8.TabIndex = 21;
			this.lblValue8.Text = "Value: 0";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 405);
			this.Controls.Add(this.lblValue8);
			this.Controls.Add(this.lblValue7);
			this.Controls.Add(this.lblValue6);
			this.Controls.Add(this.lblValue5);
			this.Controls.Add(this.lblValue4);
			this.Controls.Add(this.lblValue3);
			this.Controls.Add(this.vScrollBar8);
			this.Controls.Add(this.lblDescription8);
			this.Controls.Add(this.lblDescription7);
			this.Controls.Add(this.vScrollBar7);
			this.Controls.Add(this.lblDescription6);
			this.Controls.Add(this.vScrollBar6);
			this.Controls.Add(this.lblDescription5);
			this.Controls.Add(this.vScrollBar5);
			this.Controls.Add(this.lblDescription4);
			this.Controls.Add(this.vScrollBar4);
			this.Controls.Add(this.lblDescription3);
			this.Controls.Add(this.vScrollBar3);
			this.Controls.Add(this.lblDescription2);
			this.Controls.Add(this.lblDescription1);
			this.Controls.Add(this.vScrollBar2);
			this.Controls.Add(this.vScrollBar1);
			this.Name = "MainForm";
			this.Text = "swf-verticalscrollbar";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}

		
		void VScrollBar3Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue3.Text = String.Concat("Value: ",this.vScrollBar3.Value.ToString());
		}		
		void VScrollBar4Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			 this.lblValue4.Text = String.Concat("Value: ",this.vScrollBar4.Value.ToString());
		}
		
		void VScrollBar5Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue5.Text = String.Concat("Value: ",this.vScrollBar5.Value.ToString());
		}
		
		void VScrollBar6Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue6.Text = String.Concat("Value: ",this.vScrollBar6.Value.ToString());
		}
		
		void VScrollBar7Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue7.Text = String.Concat("Value: ",this.vScrollBar7.Value.ToString());
		}
		
		void VScrollBar8Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.lblValue8.Text = String.Concat("Value: ",this.vScrollBar8.Value.ToString());
		}
		
	}			
}
