

#define _A

using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Imaging;


public class TreeViewTest : Form {

	private TreeView tree_view;
	private ToolBar tool_bar;
	private ToolBarButton show_plus_minus;
	private ToolBarButton show_root_lines;
	private ToolBarButton show_lines;
	private ToolBarButton show_checkboxes;
	private ToolBarButton sort;
	private ToolBarButton expand_odd;
	private Timer timer;
	
	public TreeViewTest ()
	{
		tool_bar = new ToolBar ();
		show_plus_minus = new ToolBarButton ("Show Plus Minus");
		show_root_lines = new ToolBarButton ("Show Root Lines");
		show_lines = new ToolBarButton ("Show Lines");
		show_checkboxes = new ToolBarButton ("Show Check Boxes");
		sort = new ToolBarButton ("Sort Tree");
		expand_odd = new ToolBarButton ("Expand Every Other Node");
		
		tool_bar.Buttons.Add (show_plus_minus);
		tool_bar.Buttons.Add (show_root_lines);
		tool_bar.Buttons.Add (show_lines);
		tool_bar.Buttons.Add (show_checkboxes);
		tool_bar.Buttons.Add (sort);
		tool_bar.Buttons.Add (expand_odd);
		
		tool_bar.ButtonClick += new ToolBarButtonClickEventHandler (ToolBarButtonClick);


		tree_view = new TreeView ();
		tree_view.Anchor = AnchorStyles.Top | AnchorStyles.Left;
		tree_view.Width = Width;
//		tree_view.CheckBoxes = true;
		tree_view.LabelEdit = true;
		
		tree_view.Top = tool_bar.Bottom + 25;
		tree_view.Height = Height - tool_bar.Height - 50;
		tree_view.Width = Width - 25;
		tree_view.Dock = DockStyle.Fill;
		tree_view.BeforeSelect += new TreeViewCancelEventHandler (BeforeSelectHandler);
		tree_view.BeforeCheck += new TreeViewCancelEventHandler (BeforeCheckHandler);
		
		tree_view.ImageList = new ImageList ();
		
		SetupImageList (tree_view.ImageList);

		FillMyTreeView ();


		Controls.Add (tree_view);
		Controls.Add (tool_bar);

		tree_view.Nodes [0].Expand ();
/*
		timer = new Timer ();
		timer.Interval = 250;
		timer.Tick += new EventHandler (AddNodeHandler);
		timer.Enabled = true;
*/
	}

	private void AddNodeHandler (object sender, EventArgs e)
	{
		tree_view.Nodes.Add (new TreeNode (DateTime.Now.ToString ()));
	}

	private void BeforeSelectHandler (object sender, TreeViewCancelEventArgs te)
	{
		te.Node.Checked = true;
	}

	private void BeforeCheckHandler (object sender, TreeViewCancelEventArgs te)
	{
		Console.WriteLine ("CHECK HANDLER");
	}

	private void ToolBarButtonClick (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
	{
		if (e.Button == show_plus_minus)
			tree_view.ShowPlusMinus = !tree_view.ShowPlusMinus;
		else if (e.Button == show_root_lines)
			tree_view.ShowRootLines = !tree_view.ShowRootLines;
		else if (e.Button == show_lines)
			tree_view.ShowLines = !tree_view.ShowLines;
		else if (e.Button == show_checkboxes)
			tree_view.CheckBoxes = !tree_view.CheckBoxes;
		else if (e.Button == sort)
			tree_view.Sorted = true;
		else if (e.Button == expand_odd) {
			Console.WriteLine ("EXPANDING ODD");
			bool odd = false;
			foreach (TreeNode n in tree_view.Nodes [0].Nodes) {
				if (odd)
					n.Expand ();
				odd = !odd;
			}
		}
	}

	public static void Main ()
	{
		Application.Run (new TreeViewTest ());
	}

	// Create a new ArrayList to hold the Customer objects.
	private ArrayList customerArray = new ArrayList(); 

#if _A
	int ind = 0;
	private void FillMyTreeView()
	{
		string [] letters = new string [] { "file a", "file b", "file c", "file d" };
		string [] nums = new string [] { "1", "3", "5", "2", "4" };
		for (int i = 0; i < 1; i++) {
			TreeNode parent = new TreeNode (nums [i]);
			parent.ImageIndex = 0;

			for (int n = 0; n < 4; n++) {
				TreeNode node = new TreeNode ("Node - " + ind++);
				node.ImageIndex = 1;
				parent.Nodes.Add (node);

				for (int j = 0; j < 4; j++) {
					TreeNode jnode = new TreeNode ("Node ~ " + ind++);
					jnode.ImageIndex = 2;
					node.Nodes.Add (jnode);
				}
			}
			tree_view.Nodes.Add (parent);
		}
	}
#endif
	
#if _B
	private int node_count = 0;

	private void FillMyTreeView ()
	{
		Assembly a = typeof (Control).Assembly;
		
		
		foreach (Type t in a.GetTypes ()) {
			TreeNode node = new TreeNode (t.FullName);
			node.ImageIndex = ImageIndexForType (t);
			tree_view.Nodes.Add (node);
			node_count++;
			
			foreach (MemberInfo mi in t.GetMembers ()) {
				TreeNode member = new TreeNode (mi.Name);
				member.ImageIndex = ImageIndexForMember (mi);
				node.Nodes.Add (member);
				node_count++;
			}

		}
		
		Console.WriteLine ("NODE COUNT:	 " + node_count);
	}

	private void AddType (Type t, TreeNode parent)
	{
		TreeNode node = new TreeNode (t.FullName);
		node.ImageIndex = 1;
		parent.Nodes.Add (node);

		foreach (Type nt in t.GetNestedTypes ()) {
			AddType (nt, node);
		}
	}

	private int ImageIndexForType (Type t)
	{
		if (t.IsEnum)
			return 2;
		if (t.IsInterface)
			return 3;
		if (t.IsAbstract)
			return 1;
		// class
		return 0;
	}

	private int ImageIndexForMember (MemberInfo mi)
	{
		if (mi is EventInfo)
			return 4;
		if (mi is FieldInfo)
			return 5;
		if (mi is MethodBase)
			return 6;
		// property
		return 7;
	}

#endif
	private void SetupImageList (ImageList il)
	{
		il.ColorDepth = ColorDepth.Depth32Bit;
		il.ImageSize = new Size (15, 15);
		il.Images.Add (Image.FromFile ("class.png"));
		il.Images.Add (Image.FromFile ("abstract.png"));
		il.Images.Add (Image.FromFile ("enum.png"));
		il.Images.Add (Image.FromFile ("interface.png"));
		il.Images.Add (Image.FromFile ("event.png"));
		il.Images.Add (Image.FromFile ("field.png"));
		il.Images.Add (Image.FromFile ("method.png"));
		il.Images.Add (Image.FromFile ("prop-read-write.png"));
	}
	
}

