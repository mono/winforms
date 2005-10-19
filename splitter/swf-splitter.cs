
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

public class SplitterTest : Form {

	TreeView treeView1;
	Label label;
	Label label2;
	Splitter splitter;

        public SplitterTest ()
        {
		DockStyle teststyle;

		treeView1 = new TreeView ();
		label = new Label ();
		label2 = new Label ();

		teststyle = DockStyle.Left;

                splitter = new Splitter ();
                splitter.Dock = teststyle;
                splitter.MinExtra = 0;
                splitter.MinSize = 0;
		splitter.BorderStyle = BorderStyle.Fixed3D;
		splitter.BackColor = Color.Red;
		splitter.SplitterMoving += new SplitterEventHandler(splithandler);
		splitter.SplitterMoved += new SplitterEventHandler(splittermoved);
		splitter.MouseUp += new MouseEventHandler(mouseup);

                treeView1.Dock = teststyle;
		treeView1.BorderStyle = BorderStyle.Fixed3D;
                label.Dock = teststyle;
                treeView1.Nodes.Add ("TreeView Node");
                label.Text = "Click to trigger resize of TreeView Node";
		label.Click += new EventHandler(clickhandler);

                label2.Dock = DockStyle.Fill;
		label2.Text = "Filler";

                Controls.AddRange (new Control [] { label2, label, splitter, treeView1});

		this.ClientSize = new Size(500, 500);
		this.CreateControl();

		#if not
                Console.WriteLine ("treeview right:   " + treeView1.Right + "Width: " + treeView1.Width);
                Console.WriteLine ("splitter right:   " + splitter.Right + "Width: " + splitter.Width);
                Console.WriteLine ("listView left:    " + label.Left + "Width: " + label.Width);
                Console.WriteLine ("filler left:    " + label2.Left + "Width: " + label2.Width);

		Console.WriteLine("treeView child index: {0}", Controls.GetChildIndex(treeView1));
		Console.WriteLine("Splitter child index: {0}", Controls.GetChildIndex(splitter));
		Console.WriteLine("ListView child index: {0}", Controls.GetChildIndex(label));
		Console.WriteLine("filler child index: {0}", Controls.GetChildIndex(label2));
		#endif

	}

	public void splithandler(object sender, SplitterEventArgs e) {
		Console.WriteLine("SplitterMoving: SplitPosition: {0} (Event: split: {1},{2} mouse: {3},{4})", ((Splitter)sender).SplitPosition, e.SplitX, e.SplitY, e.X, e.Y);

		if (((Splitter)sender).SplitPosition==16) {
			((Splitter)sender).SplitPosition = 150;
		}
	}

	public void splittermoved(object sender, SplitterEventArgs e) {
		Console.WriteLine("SplitterMoved:  SplitPosition: {0} (Event: split: {1},{2} mouse: {3},{4})", ((Splitter)sender).SplitPosition, e.SplitX, e.SplitY, e.X, e.Y);
	}

	public void mouseup(object sender, MouseEventArgs e) {
		Console.WriteLine("Got mouseup event");
	}

	public void clickhandler(object sender, EventArgs e) {
//		splitter.SplitPosition = 150;
	}

        public static void Main ()
        {
                Application.Run (new SplitterTest ());
        }
}

