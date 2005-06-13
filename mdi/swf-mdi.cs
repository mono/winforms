//
// swf-mdi.cs
//
// Author(s):
//      Jackson Harper (jackson@ximian.com)
//
// Copyright (c) 2005 Novell, Inc. (http://www.novell.com)
//

using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form {

        private Form form_one;
        private Form form_two;
		
        public MainForm()
        {
                IsMdiContainer = true;
			
                form_one = new Form();
                form_one.MdiParent = this;
                form_one.Name = "One";
                form_one.Text = "One";
                form_one.BackColor = Color.Red;
                form_one.Show ();

                form_two = new System.Windows.Forms.Form();
                form_two.Left = form_one.Right + 10;
                form_two.MdiParent = this;
                form_two.Name = "Two";
                form_two.Text = "Two";
                form_two.BackColor = Color.Black;
                form_two.Show ();

                Width = form_one.Width * 2;
                Height = form_one.Height * 2;
        }

        public static void Main (string [] args)
        {
                Application.Run (new MainForm ());
        }
}
