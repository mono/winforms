//
// swf-begininvoke.cs
//
// Author(s):
//  Jackson Harper (jackson@ximian.com)
//
// Copyright (c) 2004 Novell, Inc (http://www.novell.com)
//

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace System.Windows.Forms {

	public class BeginInvokeDemo : Form {

		private Label label;

		public BeginInvokeDemo ()
		{
			label = new Label ();
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Text = DateTime.Now.ToLongTimeString ();
			Controls.Add (label);
		}

		private delegate void updater ();

		private void UpdateLabel ()
		{
			while (true) {
				lock (this) {
					label.BeginInvoke (new updater (DateUpdater));
				}
				Thread.Sleep (500);
			}
		}

		private void DateUpdater ()
		{
			label.Text = DateTime.Now.ToLongTimeString ();
			label.Refresh ();
		}

		public static void Main ()
		{
			BeginInvokeDemo demo = new BeginInvokeDemo ();

			ThreadStart thread_start = new ThreadStart (demo.UpdateLabel);	
			Thread worker = new Thread (thread_start);
			worker.IsBackground = true;
			worker.Start();

			Application.Run (demo);
		}
	}
}

