using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace DickPadding {
	public class Form1 : System.Windows.Forms.Form {
		private Panel p;
		private Button b;

		public Form1() {
			InitializeComponent();
		}

		int myCounter = 0;
		private void SetDockPadding() {
			b.Dock = System.Windows.Forms.DockStyle.Fill;
    
			if (myCounter > 5) {
				myCounter = 0;
			}
 
			switch (myCounter) {
				case 0:
					p.DockPadding.All = 0;
					b.Text = "Start";
					break;
				case 1:
					p.DockPadding.Top = 10;
					b.Text = "Top";
					break;
				case 2:
					p.DockPadding.Bottom = 10;
					b.Text = "Bottom";
					break;
				case 3:
					p.DockPadding.Left = 10;
					b.Text = "Left";
					break;
				case 4:
					p.DockPadding.Right = 10;
					b.Text = "Right";
					break;
				case 5:
					p.DockPadding.All = 20;
					b.Text = "All";
					break;
			}
    
			myCounter += 1;
		}

		private void InitializeComponent() {
			p = new Panel();
			b = new Button();

			this.SuspendLayout();

			p.Location = new System.Drawing.Point(8, 40);
			p.Name = "panel";
			p.Size = new System.Drawing.Size(272, 152);
			p.BackColor = Color.SkyBlue;
			p.DockPadding.All = 10;

			b.Location = new Point(8, 8);
			b.Text = "Start";
			b.Click += new EventHandler(b_Click);

			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			Controls.Add(this.p);
			p.Controls.Add(this.b);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}

		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private void b_Click(object sender, EventArgs e) {
			SetDockPadding();
		}
	}
}
