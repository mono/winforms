// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
// This sample to resize scrollbars during runtime to see how they behave
// at different sizes (thumbsize, buttons size, etc)
//

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	class MainForm : Form
	{
		private Label hLabel;
		private HScrollBar hScrollBar;		
		private Button hButtonInc;
		private Button hButtonDec;
		
		private Label vLabel;
		private VScrollBar vScrollBar;		
		private Button vButtonInc;
		private Button vButtonDec;

		public MainForm ()
		{
			InitializeComponent();
		}

		void InitializeComponent()
		{
			hScrollBar = new HScrollBar ();
			hLabel = new Label ();
			hButtonInc = new Button ();
			hButtonDec = new Button ();			
			
			vScrollBar = new VScrollBar ();
			vLabel = new Label ();
			vButtonInc = new Button ();
			vButtonDec = new Button ();			
			
			SuspendLayout ();

			/* Horizontal */
			hScrollBar.Location = new Point (10, 10);
			hScrollBar.Size = new Size (50, 16);
			hScrollBar.Maximum = 10;
			hScrollBar.LargeChange = 5;
			hScrollBar.Scroll += new ScrollEventHandler (hScrollBarScroll);

			hLabel.Location = new Point (300, 10);
			hLabel.Name = "hLabel6";
			hLabel.Size = new Size (448, 16);
			hLabel.Text = "Current Size " + hScrollBar.Size;

			hButtonInc.Location = new Point (200, 10);
			hButtonInc.Name = "button";
			hButtonInc.Size = new System.Drawing.Size (75, 25);			
			hButtonInc.Text = "Inc Size";
			hButtonInc.Click += new System.EventHandler (hButtonIncClick);

			hButtonDec.Location = new Point (200, 40);
			hButtonDec.Name = "button";
			hButtonDec.Size = new System.Drawing.Size (75, 25);			
			hButtonDec.Text = "Dec Size";
			hButtonDec.Click += new System.EventHandler (hButtonDecClick);			
			
			/* Vertical */
			vScrollBar.Location = new Point (10, 100);
			vScrollBar.Size = new Size (16, 50);
			vScrollBar.Maximum = 10;
			vScrollBar.LargeChange = 5;
			vScrollBar.Scroll += new ScrollEventHandler (vScrollBarScroll);

			vLabel.Location = new Point (300, 110);
			vLabel.Name = "hLabel6";
			vLabel.Size = new Size (448, 16);
			vLabel.Text = "Current Size " + hScrollBar.Size;

			vButtonInc.Location = new Point (200, 100);
			vButtonInc.Name = "button";
			vButtonInc.Size = new System.Drawing.Size (75, 25);			
			vButtonInc.Text = "Inc Size";
			vButtonInc.Click += new System.EventHandler (vButtonIncClick);

			vButtonDec.Location = new Point (200, 130);
			vButtonDec.Name = "button";
			vButtonDec.Size = new System.Drawing.Size (75, 25);			
			vButtonDec.Text = "Dec Size";
			vButtonDec.Click += new System.EventHandler (vButtonDecClick);


			//
			// MainForm
			//
			AutoScaleBaseSize = new System.Drawing.Size (5, 14);
			ClientSize = new System.Drawing.Size (550, 325);
			Controls.Add (hLabel);
			Controls.Add (hScrollBar);
			Controls.Add (hButtonInc);
			Controls.Add (hButtonDec);
			Controls.Add (vLabel);
			Controls.Add (vScrollBar);
			Controls.Add (vButtonInc);
			Controls.Add (vButtonDec);

			Name = "MainForm";
			Text = "SWF-HorizontalScrollbar";
			ResumeLayout (false);
		}

		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}

		void hScrollBarScroll (object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			hLabel.Text = "Current Size" + hScrollBar.Size + " Value: " + hScrollBar.Value;
		}
			
		void hButtonIncClick (object sender, System.EventArgs e)
		{
			hScrollBar.Width++;
			hLabel.Text = "Current Size" + hScrollBar.Size + " Value: " + hScrollBar.Value;
		}

		void hButtonDecClick (object sender, System.EventArgs e)
		{
			hScrollBar.Width--;
			hLabel.Text = "Current Size" + hScrollBar.Size + " Value: " + hScrollBar.Value;
		}
		
		void vScrollBarScroll (object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			vLabel.Text = "Current Size" + vScrollBar.Size + " Value: " + vScrollBar.Value;
		}
			
		void vButtonIncClick (object sender, System.EventArgs e)
		{
			vScrollBar.Width++;
			vLabel.Text = "Current Size" + vScrollBar.Size + " Value: " + vScrollBar.Value;
		}

		void vButtonDecClick (object sender, System.EventArgs e)
		{
			vScrollBar.Width--;
			vLabel.Text = "Current Size" + vScrollBar.Size + " Value: " + vScrollBar.Value;
		}
	}
}
