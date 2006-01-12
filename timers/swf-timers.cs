
using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Timers;
using System.Windows.Forms;

class Program {

	static void ShowStackTrace (object o, ElapsedEventArgs e)
	{
		Console.WriteLine (counter);
		Console.WriteLine ("Threads Equal:   {0}", System.Threading.Thread.CurrentThread == startup_thread);
		if (counter++ > 5) {
			t.AutoReset = false;
			t.Enabled = false;
		}
	}

	static System.Threading.Thread startup_thread;
	static System.Timers.Timer t;
	static int counter = 0;

	static void Main (string[] args)
	{
		bool so = (args.Length > 0);
		Label label = new Label ();

		Console.WriteLine ("STARTUP THREAD:   " + System.Threading.Thread.CurrentThread.GetHashCode ());
		startup_thread = System.Threading.Thread.CurrentThread;
		
		t = new System.Timers.Timer (500);
		if (so)
			t.SynchronizingObject = label;
		t.Elapsed += new ElapsedEventHandler (ShowStackTrace);
		t.AutoReset = true;
		t.Enabled = true;
		
		System.Threading.Thread.Sleep (5000);
	}
}

