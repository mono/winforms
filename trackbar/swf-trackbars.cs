//
// Sample that ilustrates the use of SWF TrackBars
//
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
// Autors:
//		Jordi Mas i Hernandez, jordi@ximian.com
//
// Copyright (C) Novell Inc., 2004
//


using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;		
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar35;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TrackBar trackBar4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBar45;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TrackBar trackBar5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar trackBar6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBar7;
		private System.Windows.Forms.Label label7;
		
		public MainForm()
		{
			InitializeComponent();
		}
	
		void InitializeComponent() 
		{
			this.components = new System.ComponentModel.Container ();
			this.trackBar1 = new System.Windows.Forms.TrackBar ();
			this.label1 = new System.Windows.Forms.Label ();
			this.trackBar2 = new System.Windows.Forms.TrackBar ();
			this.label2 = new System.Windows.Forms.Label ();
			this.trackBar3 = new System.Windows.Forms.TrackBar ();			
			this.label3 = new System.Windows.Forms.Label ();			
			this.trackBar35 = new System.Windows.Forms.TrackBar ();			
			this.label35 = new System.Windows.Forms.Label ();			
			this.trackBar4 = new System.Windows.Forms.TrackBar ();			
			this.label4 = new System.Windows.Forms.Label ();			
			this.trackBar45 = new System.Windows.Forms.TrackBar ();			
			this.label45 = new System.Windows.Forms.Label ();			
			this.trackBar5 = new System.Windows.Forms.TrackBar ();			
			this.label5 = new System.Windows.Forms.Label ();			
			this.trackBar6 = new System.Windows.Forms.TrackBar ();			
			this.label6 = new System.Windows.Forms.Label ();			
			this.trackBar7 = new System.Windows.Forms.TrackBar ();			
			this.label7 = new System.Windows.Forms.Label ();			
			this.SuspendLayout();
		
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point (10, 10);
			this.trackBar1.Name = "Trackbar1";
			this.trackBar1.Size = new System.Drawing.Size (200, 40);
			this.trackBar1.Scroll += new System.EventHandler (this.trackBar1Scroll);
			
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point (230, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (300, 20);			
			this.label1.Text = "Trackbar BottomRight";
			
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point (10, 60);
			this.trackBar2.Name = "Trackbar2";
			this.trackBar2.Size = new System.Drawing.Size (200, 40);
			this.trackBar2.Scroll += new System.EventHandler (this.trackBar2Scroll);
			this.trackBar2.Minimum = 20;
			this.trackBar2.Maximum = 180;
			this.trackBar2.Value = 40;			
			this.trackBar2.TickStyle = TickStyle.TopLeft;
			
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point (230, 70);
			this.label2.Name = "label";
			this.label2.Size = new System.Drawing.Size (300, 20);			
			this.label2.Text = "Trackbar TopLeft";
						
			
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point (10, 110);
			this.trackBar3.Name = "Trackbar3";
			this.trackBar3.Size = new System.Drawing.Size (200, 30);
			this.trackBar3.Scroll += new System.EventHandler (this.trackBar3Scroll);
			this.trackBar3.Minimum = 60;
			this.trackBar3.Maximum = 180;
			this.trackBar3.Value = 170;			
			this.trackBar3.SmallChange = 10;			
			this.trackBar3.LargeChange = 30;						
			
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point (230, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size (300, 20);			
			this.label3.Text = "Trackbar BottomRight";
			
			// 
			// trackBar35
			// 
			this.trackBar35.Location = new System.Drawing.Point (10, 170);
			this.trackBar35.Name = "Trackbar35";
			this.trackBar35.Size = new System.Drawing.Size (200, 30);			
			this.trackBar35.Minimum = 50;
			this.trackBar35.Maximum = 100;				
			this.trackBar35.SmallChange = 5;			
			this.trackBar35.LargeChange = 10;		
			this.trackBar35.TickStyle = TickStyle.Both;				
			
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point (230, 180);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size (300, 20);			
			this.label35.Text = "Trackbar Both";			
			
			// 
			// trackBar45
			// 			
			this.trackBar45.Location = new System.Drawing.Point (10, 220);
			this.trackBar45.Name = "Trackbar4";
			this.trackBar45.Size = new System.Drawing.Size (100, 50);			
			this.trackBar45.Minimum = 0;
			this.trackBar45.Maximum = 100;
			this.trackBar45.Value = 50;			
			this.trackBar45.TickFrequency = 10;
			this.trackBar45.TickStyle = TickStyle.None;			
						
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point (230, 220);
			this.label45.Name = "label4";
			this.label45.Size = new System.Drawing.Size (100, 20);			
			this.label45.Text = "TrackBar None";
			
			/* Vertical */
			
			// 
			// trackBar4
			// 
			this.trackBar4.Orientation = Orientation.Vertical;
			this.trackBar4.Location = new System.Drawing.Point (10, 280);
			this.trackBar4.Name = "Trackbar4";
			this.trackBar4.Size = new System.Drawing.Size (20, 50);			
			this.trackBar4.Minimum = 0;
			this.trackBar4.Maximum = 100;
			this.trackBar4.Value = 50;			
			this.trackBar4.TickFrequency = 10;			
			this.trackBar4.ValueChanged  += new System.EventHandler (this.trackBar4ValueChanged);
			
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point (10, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size (80, 60);			
			this.label4.Text = "Trackbar BottomRight";
			
			// 
			// trackBar5
			// 
			this.trackBar5.Location = new System.Drawing.Point (100, 280);
			this.trackBar5.Name = "Trackbar5";
			this.trackBar5.Size = new System.Drawing.Size (80, 50);			
			this.trackBar5.Minimum = 0;
			this.trackBar5.Maximum = 5;
			this.trackBar5.Value = 1;			
			this.trackBar5.Orientation = Orientation.Vertical;			
			this.trackBar5.ValueChanged  += new System.EventHandler (this.trackBar5ValueChanged);
			this.trackBar5.TickStyle = TickStyle.TopLeft;
			
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point (100, 360);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size (60, 60);			
			this.label5.Text = "Trackbar TopLeft";
			
			// 
			// trackBar6
			// 
			this.trackBar6.Location = new System.Drawing.Point (190, 280);
			this.trackBar6.Name = "Trackbar6";
			this.trackBar6.Size = new System.Drawing.Size (80, 50);			
			this.trackBar6.Minimum = 0;
			this.trackBar6.Maximum = 5;
			this.trackBar6.Value = 1;			
			this.trackBar6.Orientation = Orientation.Vertical;
			this.trackBar6.TickStyle = TickStyle.Both;
			
						
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point (190, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size (60, 60);			
			this.label6.Text = "Trackbar Both";
			
			// 
			// trackBar7
			// 
			this.trackBar7.Location = new System.Drawing.Point (280, 280);
			this.trackBar7.Name = "Trackbar7";
			this.trackBar7.Size = new System.Drawing.Size (80, 30);			
			this.trackBar7.Minimum = 0;
			this.trackBar7.Maximum = 5;
			this.trackBar7.Value = 1;			
			this.trackBar7.Orientation = Orientation.Vertical;
			this.trackBar7.TickStyle = TickStyle.None;			
			
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point (280, 360);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size (60, 60);			
			this.label7.Text = "Trackbar None";
		
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 14);
			this.ClientSize = new System.Drawing.Size (504, 440);
			this.Controls.Add (this.trackBar1);
			this.Controls.Add (this.trackBar2);			
			this.Controls.Add (this.label1);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.trackBar3);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.trackBar35);
			this.Controls.Add (this.label35);
			this.Controls.Add (this.trackBar4);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.trackBar45);
			this.Controls.Add (this.label45);
			this.Controls.Add (this.trackBar5);
			this.Controls.Add (this.label5);
			this.Controls.Add (this.trackBar6);
			this.Controls.Add (this.label6);
			this.Controls.Add (this.trackBar7);
			this.Controls.Add (this.label7);
		
			this.Name = "MainForm";
			this.Text = "swf-trackbars";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main (string[] args)
		{
			Application.Run(new MainForm());
		}
		
		void trackBar1Scroll (object sender, System.EventArgs e)
		{			
			label1.Text = "Trackbar - Pos: " + trackBar1.Value;			
		}
		
		void trackBar2Scroll (object sender, System.EventArgs e)
		{			
			label2.Text = "Trackbar - Pos: " + trackBar2.Value
			+ " Max.:" + trackBar2.Maximum + " Min.: " + 
			trackBar2.Minimum;			
			
			Console.WriteLine ("Event:trackBar2Scroll");
		}	
		
		void trackBar3Scroll (object sender, System.EventArgs e)
		{			
			label3.Text = "Trackbar - Pos: " + trackBar3.Value
			+ " Small:" + trackBar3.SmallChange + " Large: " + 
			trackBar3.LargeChange;			
		}	
		
		void trackBar4ValueChanged (object sender, System.EventArgs e)
		{			
			label4.Text = "Pos: " + trackBar4.Value + " (value chgd)";			
			Console.WriteLine ("Event: trackBar4ValueChanged");
		}			
		
		void trackBar5ValueChanged (object sender, System.EventArgs e)
		{			
			label5.Text = "Pos: " + trackBar5.Value;			
		}			
				
	}			
} 
