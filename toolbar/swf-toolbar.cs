//
// Sample that ilustrates the use of SWF ToolBar
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
// Author:
//	Ravindra (rkumar@novell.com)
//
// Copyright (C) Novell Inc., 2004
//

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SWFToolBar
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBar toolBar2;

		public MainForm ()
		{
			InitializeComponent ();
		}

		private void InitializeComponent ()
		{
			this.SuspendLayout ();

			this.toolBar1 = new System.Windows.Forms.ToolBar ();
			this.toolBar2 = new System.Windows.Forms.ToolBar ();

			ToolBarButton b11 = new ToolBarButton ("button11");
			ToolBarButton b12 = new ToolBarButton ("button12");
			ToolBarButton b13 = new ToolBarButton ("button13");
			ToolBarButton b14 = new ToolBarButton ("button14");

			ToolBarButton b21 = new ToolBarButton ("button21");
			ToolBarButton b22 = new ToolBarButton ("button22");
			ToolBarButton b23 = new ToolBarButton ("button23");
			ToolBarButton b24 = new ToolBarButton ("button24");

			MenuItem item1 = new MenuItem ("Item1");
			MenuItem item2 = new MenuItem ("Item2");
			MenuItem item3 = new MenuItem ("Item3");
			ContextMenu menu = new ContextMenu (new MenuItem [] {item1, item2, item3});

			ImageList il = new ImageList ();

			// 
			// toolBar1
			// 
			this.toolBar1.Text = "toolbar1";
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Location = new System.Drawing.Point (0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size (576, 42);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ImageList = il;
			this.toolBar1.Divider = false;
			this.toolBar1.TextAlign = ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new ToolBarButtonClickEventHandler (this.toolBar1_ButtonClick);
			this.toolBar1.ButtonDropDown += new ToolBarButtonClickEventHandler(this.toolBar1_ButtonDropDown);

			// 
			// toolBar2
			// 
			this.toolBar2.Text = "toolbar2";
			this.toolBar2.Appearance = ToolBarAppearance.Flat;
			this.toolBar2.DropDownArrows = true;
			this.toolBar2.Location = new System.Drawing.Point (0, 100);
			//this.toolBar2.Dock = DockStyle.Bottom;
			this.toolBar2.Name = "toolBar2";
			this.toolBar2.ShowToolTips = true;
			this.toolBar2.Size = new System.Drawing.Size (576, 42);
			this.toolBar2.TabIndex = 1;
			this.toolBar2.ImageList = il;
			this.toolBar2.Divider = false;
			this.toolBar2.ButtonClick += new ToolBarButtonClickEventHandler (this.toolBar2_ButtonClick);
			this.toolBar2.ButtonDropDown += new ToolBarButtonClickEventHandler(this.toolBar2_ButtonDropDown);

			//il.ColorDepth = ColorDepth.Depth32Bit;
			//il.Images.Add (new Bitmap ("Sunset.jpg"));
			//il.Images.Add (new Bitmap ("Bluehills.jpg"));
			//il.Images.Add (new Bitmap ("Water.jpg"));
			//il.Images.Add (new Bitmap ("Winter.jpg"));
			//il.ImageSize = new Size (40, 40);

			b11.Style = ToolBarButtonStyle.DropDownButton;
			b11.ImageIndex = 0;
			b11.DropDownMenu = menu;
			b11.ToolTipText = "DropDownButton with menu";

			b12.Style = ToolBarButtonStyle.Separator;
			b12.ImageIndex = 1;
			b12.ToolTipText = "Separator";

			b13.Style = ToolBarButtonStyle.ToggleButton;
			b13.ImageIndex = 2;
			b13.ToolTipText = "ToggleButton";
			
			b14.Style = ToolBarButtonStyle.PushButton;
			b14.ImageIndex = 3;
			b14.ToolTipText = "PushButton";

			b21.Style = ToolBarButtonStyle.DropDownButton;
			b21.ImageIndex = 0;
			b21.ToolTipText = "DropDownButton without menu";
			
			b22.Style = ToolBarButtonStyle.Separator;
			b22.ImageIndex = 1;
			b22.ToolTipText = "Separator";
			
			b23.Style = ToolBarButtonStyle.ToggleButton;
			b23.ImageIndex = 2;
			b23.ToolTipText = "ToggleButton";

			b24.Style = ToolBarButtonStyle.PushButton;
			b24.ImageIndex = 3;
			b24.ToolTipText = "PushButton";

			this.toolBar1.Buttons.Add (b11);
			this.toolBar1.Buttons.Add (b12);
			this.toolBar1.Buttons.Add (b13);
			this.toolBar1.Buttons.Add (b14);

			
			this.toolBar2.Buttons.Add (b21);
			this.toolBar2.Buttons.Add (b22);
			this.toolBar2.Buttons.Add (b23);
			this.toolBar2.Buttons.Add (b24);
			
			this.Controls.Add (this.toolBar2);
			this.Controls.Add (this.toolBar1);
			this.ResumeLayout (false);

			this.Name = "MainForm";
			this.Text = "MainForm";
		}

		private void toolBar1_ButtonClick (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			Console.WriteLine ("button clicked: {0}, rect: {1}", e.Button.Text, e.Button.Rectangle);
		}

		private void toolBar1_ButtonDropDown (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			Console.WriteLine ("button dropdown clicked: {0}, rect: {1}", e.Button.Text, e.Button.Rectangle);
		}

		private void toolBar2_ButtonClick (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			Console.WriteLine ("button clicked: {0}, rect: {1}", e.Button.Text, e.Button.Rectangle);
		}

		private void toolBar2_ButtonDropDown (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			Console.WriteLine ("button dropdown clicked: {0}, rect: {1}", e.Button.Text, e.Button.Rectangle);
		}

		static void Main () 
		{
			Application.Run (new MainForm ());
		}
	}
}
