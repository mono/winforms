//
// swf-idle.cs
//
// Author(s):
//  Jackson Harper (jackson@ximian.com)
//
// Copyright (c) 2004 Novell, Inc (http://www.novell.com)
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace System.Windows.Forms {

	public class IdleDemo : Form {

		private Label label;

		public IdleDemo ()
		{
			label = new Label ();
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add (label);
		}

		private void IdleHandler (object sender, EventArgs e)
		{
			label.Text = "Last Idle: " + DateTime.Now.Ticks;
		}

		public static void Main ()
		{
			IdleDemo demo = new IdleDemo ();

			Application.Idle += new EventHandler (demo.IdleHandler);
			Application.Run (demo);
		}
	}
}

