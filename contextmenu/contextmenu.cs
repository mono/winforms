using System;
using System.Drawing;
using System.Windows.Forms;

namespace winforms {

  public class form : Form {

    public static void Main () {
      Application.Run (new form ());
    }

    public form () {

      TreeView tree = new TreeView ();
      ContextMenu popupmenu = new ContextMenu ( new MenuItem [] {
	  new MenuItem ("Menu 1"),
	  new MenuItem ("Menu 2"),
	  new MenuItem ("Menu 3")
      });

      TreeNode t;
      t = tree.Nodes.Add ("Node 1");
      t.ContextMenu = popupmenu;
      t = tree.Nodes.Add ("Node 2");
      t.ContextMenu = popupmenu;
      t = tree.Nodes.Add ("Node 3");
      t.ContextMenu = popupmenu;

      tree.Dock = DockStyle.Fill;
      this.Controls.Add (tree);
      
    }
  }
}