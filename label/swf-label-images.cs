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
// Copyright (c) 2005 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//	Sample Label with images
//

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	class MainForm : Form
	{
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;		
		private ImageList il;

		public MainForm ()
		{
			InitializeComponent();
		}

		void InitializeComponent ()
		{
			label1 = new Label ();
			label2 = new Label ();
			label3 = new Label ();
			label4 = new Label ();
						il = new ImageList ();
                	il.ColorDepth = ColorDepth.Depth32Bit;
                	il.ImageSize = new Size (15, 15);
                	il.Images.Add (Image.FromFile ("a.png"));
                	il.Images.Add (Image.FromFile ("b.png"));

			SuspendLayout ();

			label1.Location = new System.Drawing.Point (10, 10);
			label1.Name = "label";
			label1.Size = new System.Drawing.Size (300, 16);
			label1.Text = "A normal label1";
			label1.ImageList = il;
			label1.ImageIndex = 1;
			label1.ImageAlign  = ContentAlignment.BottomCenter;

			label2.Location = new System.Drawing.Point (10, 50);
			label2.Name = "label";
			label2.Size = new System.Drawing.Size (200, 16);
			label2.Text = "A normal label2";
			label2.Image = new Bitmap ("a.png");
			label2.ImageAlign  = ContentAlignment.MiddleCenter;

			label3.Location = new System.Drawing.Point (10, 100);
			label3.Name = "label";
			label3.Size = new System.Drawing.Size (100, 16);
			label3.Text = "A normal label3";
			label3.ImageList = il;
			label3.ImageIndex = 1;
			label3.ImageAlign  = ContentAlignment.MiddleLeft;

			label4.Location = new System.Drawing.Point (10, 150);
			label4.Name = "label";
			label4.Size = new System.Drawing.Size (200, 16);
			label4.BackColor = Color.Red;
			label4.Text = "A normal label4";
			label4.ImageList = il;
			label4.ImageIndex = 1;
			label4.ImageAlign  = ContentAlignment.MiddleCenter;

			Console.WriteLine ("label4 {0}:", label4);


			//
			// MainForm
			//
			ClientSize = new System.Drawing.Size (300, 300);
			Controls.AddRange (new Control[] {label1, label2, label3,label4});
			Text = "SWF-Labels with images";
			ResumeLayout (false);
		}

		public static void Main (string[] args)
		{
			Application.Run (new MainForm ());
		}
	}
}
