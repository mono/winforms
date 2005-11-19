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
        private Form form_three;
        
        public MainForm()
        {
                IsMdiContainer = true;
		Text = "I am the toplevel window";

		foreach (FormBorderStyle bs in Enum.GetValues (typeof (FormBorderStyle))) {
                        Form form = new Form ();
                        form.MdiParent = this;
                        form.Name = bs.ToString ();
			form.Text = bs.ToString ();
                        form.FormBorderStyle = bs;
		
			form.Top = 75;
			form.Left =75;
			form.Width = 200;
			form.Height = 100;
			form.BackColor = Color.Red;
                        form.Show ();
		}
        }

        public static void Main (string [] args)
        {
                Application.Run (new MainForm ());
        }
}
