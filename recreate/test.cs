using System;
using System.Drawing;
using System.Windows.Forms;

public class TortureControl : Control {
	public void DoRecreateHandle ()
	{
		RecreateHandle ();
	}
	public void DoCreateHandle ()
	{
		CreateHandle ();
	}
}

public class TortureMdiChild : Form {
	public void DoRecreateHandle ()
	{
		RecreateHandle ();
	}
	public void DoCreateHandle ()
	{
		CreateHandle ();
	}
}

public class TortureMdiContainer : Form {
	public TortureMdiContainer ()
	{
		IsMdiContainer = true;
	}
}

public class TortureForm : Form {

	public TortureForm ()
	{
		Size = new Size (100, 50);
		Button b = new Button ();
		b.Text = "Run Tests";
		b.Click += new EventHandler (RunTests);
		b.Dock = DockStyle.Fill;
		Controls.Add (b);
	}

	void RunTests (object o, EventArgs e) {
		for (int i = 0; i < 10; i ++) {
			TestNesting (i);
		}

		TestMdi ();
		TestMdi2 ();
		TestToplevel ();
		TestToplevel2 ();

		Application.Exit ();
	}

	void TestToplevel ()
	{
		Timer timer = new Timer ();

		Console.Write ("toplevel test 1:");

		TortureMdiChild child = new TortureMdiChild ();
		Button b = new Button ();
		b.Text = "Click me if you see me";
		b.Click += delegate (object sender, EventArgs e) { Console.WriteLine ("PASS"); timer.Stop (); child.Close(); };
		b.Dock = DockStyle.Fill;
		child.ClientSize = new Size (100, 50);
		child.Controls.Add (b);

		timer.Interval = 5000;
		timer.Tick += delegate (object sender, EventArgs e) { Console.WriteLine ("FAIL (timer)"); timer.Stop (); child.Close(); };
		timer.Start ();

		child.ShowDialog (this);
	}

	void TestToplevel2 ()
	{
		Timer timer = new Timer ();

		Console.Write ("toplevel test 2:");

		TortureMdiChild child = new TortureMdiChild ();
		Button b = new Button ();
		b.Text = "Click me if you see me";
		b.Click += delegate (object sender, EventArgs e) { Console.WriteLine ("PASS"); timer.Stop (); child.Close(); };
		b.Dock = DockStyle.Fill;
		child.ClientSize = new Size (100, 50);
		child.Controls.Add (b);

		timer.Interval = 5000;
		timer.Tick += delegate (object sender, EventArgs e) { Console.WriteLine ("FAIL (timer)"); timer.Stop (); child.Close(); };
		timer.Start ();

		child.ShowDialog (this);
	}

	void TestMdi ()
	{
		TortureMdiContainer container = new TortureMdiContainer ();
		Timer timer = new Timer ();

		Console.Write ("mdi test 1:");

		TortureMdiChild child = new TortureMdiChild ();
		Button b = new Button ();
		b.Text = "Click me if you see me";
		b.Click += delegate (object sender, EventArgs e) { Console.WriteLine ("PASS"); timer.Stop (); container.Close(); };
		b.Dock = DockStyle.Fill;
		child.ClientSize = new Size (100, 50);
		child.Controls.Add (b);
		child.MdiParent = container;
		child.Show ();

		timer.Interval = 5000;
		timer.Tick += delegate (object sender, EventArgs e) { Console.WriteLine ("FAIL (timer)"); timer.Stop (); container.Close(); };
		timer.Start ();

		container.ShowDialog (this);
	}

	void TestMdi2 ()
	{
		TortureMdiContainer container = new TortureMdiContainer ();
		Timer timer = new Timer ();

		Console.Write ("mdi test 2:");

		TortureMdiChild child = new TortureMdiChild ();
		Button b = new Button ();
		b.Text = "Click me if you see me";
		b.Click += delegate (object sender, EventArgs e) { Console.WriteLine ("PASS"); timer.Stop (); container.Close(); };
		b.Dock = DockStyle.Fill;
		child.ClientSize = new Size (100, 50);
		child.Controls.Add (b);
		child.Show ();
		child.MdiParent = container;
		child.Show ();

		timer.Interval = 5000;
		timer.Tick += delegate (object sender, EventArgs e) { Console.WriteLine ("FAIL (timer)"); timer.Stop (); container.Close(); };
		timer.Start ();

		container.ShowDialog (this);
	}

	void TestNesting (int level)
	{
		IntPtr h1, h2;
		Console.Write ("test to see if RecreateHandle gives us a new handle {0} levels down:", level + 1);
		TortureControl root = new TortureControl ();
		TortureControl nest = root;

		for (int i = 0; i < level; i ++) {
			TortureControl c = new TortureControl ();
			nest.Controls.Add (c);
			nest = c;
		}

		root.DoCreateHandle ();
		h1 = nest.Handle;
		root.DoRecreateHandle ();
		h2 = nest.Handle;
		if (h1 != h2) {
			Console.WriteLine ("PASS");
		}
		else {
			Console.WriteLine ("FAIL {0}", h1);
		}
	}

	public static void Main (string[] args) {
		Application.Run (new TortureForm ());
	}

}
