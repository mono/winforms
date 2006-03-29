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
#if NET_2_0
			CheckForIllegalCrossThreadCalls = true;
#endif

			label = new Label ();
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Text = DateTime.Now.ToLongTimeString ();
			Controls.Add (label);
		}

		private delegate void updater ();

		private void UpdateLabel ()
		{
			// BeginInvoke may not be called on a window that doesn't
			// yet have a handle
			while (!label.IsHandleCreated) {
				Thread.Sleep(250);
			}


			while (true) {
#if NET_2_0
				Console.WriteLine("Handle:{0:X}", this.Handle.ToInt23());
#endif
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

			demo.CreateHandle();
			ThreadStart thread_start = new ThreadStart (demo.UpdateLabel);	
			Thread worker = new Thread (thread_start);
			worker.IsBackground = true;
			worker.Start();

			Application.Run (demo);
		}
	}
}

