
using System;
using System.Windows.Forms;

public class SplitterTest : Form {

        public SplitterTest ()
        {
                TreeView treeView1 = new TreeView ();
                ListView listView1 = new ListView ();

                Splitter splitter = new Splitter ();
                splitter.Dock = DockStyle.Left;
                splitter.MinExtra = 100;
                splitter.MinSize = 75;

                treeView1.Dock = DockStyle.Left;             
                listView1.Dock = DockStyle.Fill;
                treeView1.Nodes.Add ("TreeView Node");
                listView1.Items.Add ("ListView Item");

                Controls.AddRange (new Control [] { listView1, splitter, treeView1});

                Console.WriteLine ("treeview right:   " + treeView1.Right);
                Console.WriteLine ("splitter left:    " + splitter.Left);
                Console.WriteLine ("splitter right:   " + splitter.Right);
                Console.WriteLine ("listView left:    " + listView1.Left);

		Console.WriteLine("ListView child index: {0}", Controls.GetChildIndex(listView1));
		Console.WriteLine("Splitter child index: {0}", Controls.GetChildIndex(splitter));
		Console.WriteLine("treeView child index: {0}", Controls.GetChildIndex(treeView1));
	}

        public static void Main ()
        {
                Application.Run (new SplitterTest ());
        }
}

