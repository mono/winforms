//
// swf-mainloop.cs
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

	public class MainLoopDemo : Form {

		private Label idle_label;
		private Label begininvoke_label;
		private Label timer_label;

		public MainLoopDemo ()
		{
			SuspendLayout ();

			idle_label = new Label ();
			idle_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			idle_label.TextAlign = ContentAlignment.MiddleCenter;
			idle_label.Text = "Idle";
			Controls.Add (idle_label);

			begininvoke_label = new Label ();
			begininvoke_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			begininvoke_label.Top = idle_label.Bottom + 10;
			begininvoke_label.TextAlign = ContentAlignment.MiddleCenter;
			begininvoke_label.Text = "begininvoke";
			Controls.Add (begininvoke_label);

			timer_label = new Label ();
			timer_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			timer_label.Top = begininvoke_label.Bottom + 10;
			timer_label.TextAlign = ContentAlignment.MiddleCenter;
			timer_label.Text = "timer";
			Controls.Add (timer_label);

			ResumeLayout ();
		}

		private delegate void updater ();

		private void UpdateLabel ()
		{
			while (true) {
				lock (this) {
					begininvoke_label.BeginInvoke (new updater (DateUpdater));
				}
				Thread.Sleep (500);
			}
		}

		private void DateUpdater ()
		{
			begininvoke_label.Text = "BeginInvoke:	" + DateTime.Now.ToLongTimeString ();
		}

		private void TimerUpdater (object sender, EventArgs e)
		{
			timer_label.Text = "Timer:  " + DateTime.Now.ToLongTimeString ();
		}

		private void IdleHandler (object sender, EventArgs e)
		{
			idle_label.Text = "Idle:  " + DateTime.Now.ToLongTimeString ();
		}

		public static void Main ()
		{
			MainLoopDemo demo = new MainLoopDemo ();

			ThreadStart thread_start = new ThreadStart (demo.UpdateLabel);	
			Thread worker = new Thread (thread_start);
			worker.IsBackground = true;
			worker.Start();

			Timer t = new Timer ();
			t.Interval = 250;
			t.Tick += new EventHandler (demo.TimerUpdater);
			t.Enabled = true;

			Application.Idle += new EventHandler (demo.IdleHandler);

			Application.Run (demo);
		}
	}
}

