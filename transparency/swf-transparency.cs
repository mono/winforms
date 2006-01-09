using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace transparency
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		static int i = 0;

		public MainForm()
		{
			InitializeComponent();
			
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 96);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Click me";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Form";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.ResumeLayout(false);

		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			i++;
			if (i == 1)
				this.Opacity = 0.75;
			else if (i ==2 )
				this.TransparencyKey = System.Drawing.Color.Red;
			else if (i ==3 )
				this.TransparencyKey = System.Drawing.Color.Green;
			else if (i ==4 )
				this.TransparencyKey = System.Drawing.Color.Blue;
			else if (i ==5 )
				this.TransparencyKey = System.Drawing.Color.Empty;
			else if (i ==6 )
				this.Opacity = 1;

			if (i >= 6)
				i = 0;
		}

		private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			e.Graphics.FillRectangle(Brushes.Red, 0,0,50,50);
			e.Graphics.FillRectangle(Brushes.Green, 0,50,50,50);
			e.Graphics.FillRectangle(Brushes.Blue, 0,100,50,50);
		}
	}
}
