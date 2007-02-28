using System;
using System.Windows.Forms;

public class ExitTest {
	public static void Main (string[] args) {
		int arg = Int32.Parse (args[0]);

		switch (arg) {
			// single threaded
			//   the noform varieties
		case 0:
			Application_Exit_NoForm ();
			break;
		case 1:
			Application_ExitThread_NoForm ();
			break;
		case 2:
			Context_ExitThread_NoForm ();
			break;
		case 3:
			Context_Dispose_NoForm ();
			break;

		case 4:
			//   the form varieties
			Application_Exit_Form ();
			break;

		case 5:
			Application_ExitThread_Form ();
			break;

		case 6:
			Context_ExitThread_Form ();
			break;

		case 7:
			Context_Dispose_Form ();
			break;

		case 8:
			// form closure
			Application_Form_Close ();
			break;

		case 9:
			Application_Form_Dispose ();
			break;

		case 10:
			Context_Form_Close ();
			break;

		case 11:
			Context_Form_Dispose ();
			break;
		}
	}

	static void Context_ExitThread_NoForm ()
	{
		Console.WriteLine ("Context_ExitThread_NoForm");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		ApplicationContext ctx = new ApplicationContext ();

		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { ctx.ExitThread (); };

		t.Enabled = true;

		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Context_Dispose_NoForm ()
	{
		Console.WriteLine ("Context_Dispose_NoForm");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		ApplicationContext ctx = new ApplicationContext ();

		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();
		Timer t2 = new Timer ();

		t2.Interval = 500;
		t2.Tick += delegate (object sender, EventArgs e) { Application.Exit (); };
		t.Tick += delegate (object sender, EventArgs e) { ctx.Dispose (); };

		t.Enabled = true;
		t2.Enabled = true;
		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_Exit_NoForm ()
	{
		Console.WriteLine ("Application_Exit_NoForm");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { Application.Exit (); };

		t.Enabled = true;

		Application.Run ();

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_ExitThread_NoForm ()
	{
		Console.WriteLine ("Application_ExitThread_NoForm");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { Application.ExitThread (); };

		t.Enabled = true;

		Application.Run ();

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}


	static void Context_ExitThread_Form ()
	{
		Console.WriteLine ("Context_ExitThread_Form");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		ApplicationContext ctx = new ApplicationContext (f);

		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { ctx.ExitThread (); };

		t.Enabled = true;

		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Context_Dispose_Form ()
	{
		Console.WriteLine ("Context_Dispose_Form");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		ApplicationContext ctx = new ApplicationContext (f);

		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();
		Timer t2 = new Timer ();

		t2.Interval = 500;
		t2.Tick += delegate (object sender, EventArgs e) { Application.Exit (); };
		t.Tick += delegate (object sender, EventArgs e) { ctx.Dispose (); };

		t.Enabled = true;
		t2.Enabled = true;
		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_Exit_Form ()
	{
		Console.WriteLine ("Application_Exit_Form");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { Application.Exit (); };

		t.Enabled = true;

		Application.Run (f);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_ExitThread_Form ()
	{
		Console.WriteLine ("Application_ExitThread_Form");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { Application.ExitThread (); };

		t.Enabled = true;

		Application.Run (f);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_Form_Close ()
	{
		Console.WriteLine ("Application_Form_Close");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		Timer t = new Timer ();

		t.Interval = 500;
		t.Tick += delegate (object sender, EventArgs e) { f.Close (); };

		t.Enabled = true;

		Application.Run (f);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Context_Form_Close ()
	{
		Console.WriteLine ("Context_Form_Close");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		ApplicationContext ctx = new ApplicationContext (f);
		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();

		t.Tick += delegate (object sender, EventArgs e) { f.Close (); };

		t.Enabled = true;

		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Application_Form_Dispose ()
	{
		Console.WriteLine ("Application_Form_Dispose");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		Timer t = new Timer ();

		t.Interval = 500;
		t.Tick += delegate (object sender, EventArgs e) { f.Dispose (); };

		t.Enabled = true;

		Application.Run (f);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void Context_Form_Dispose ()
	{
		Console.WriteLine ("Context_Form_Dispose");
		Console.WriteLine ("*******************************");

		Application.ApplicationExit += application_applicationexit;
		Application.ThreadExit += application_threadexit;

		Form f = new Form ();
		f.HandleDestroyed += form_handle_destroyed;
		f.Closed += form_closed;

		ApplicationContext ctx = new ApplicationContext (f);
		ctx.ThreadExit += applicationcontext_threadexit;

		Timer t = new Timer ();

		t.Interval = 500;
		t.Tick += delegate (object sender, EventArgs e) { f.Dispose (); };

		t.Enabled = true;

		Application.Run (ctx);

		Application.ApplicationExit -= application_applicationexit;
		Application.ThreadExit -= application_threadexit;
	}

	static void application_applicationexit (object sender, EventArgs e)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	static void application_threadexit (object sender, EventArgs e)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	static void applicationcontext_threadexit (object sender, EventArgs e)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	static void form_handle_destroyed (object sender, EventArgs e)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	static void form_closed (object sender, EventArgs e)
	{
		Console.WriteLine (Environment.StackTrace);
	}
}
