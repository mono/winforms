//
// swf-tabcontrol.cs
//
// Author(s):
//  Jackson Harper (jackson@ximian.com)
//
// Copyright (C) Novell, Inc (http://www.novell.com)
//

using System;
using System.Drawing;
using System.Windows.Forms;


namespace System.Windows.Forms {

	public class TabControlDemo : Form {

		public TabControlDemo ()
		{
			TabControl tab = new TabControl ();
			tab.Alignment = TabAlignment.Top;
			// tab.Appearance = TabAppearance.FlatButtons;
			// tab.Multiline = true;

			tab.Controls.Add (new TabPage ("Tab A"));
			tab.Controls.Add (new TabPage ("Tab B"));
			tab.Controls.Add (new TabPage ("Tab C"));
			tab.Controls.Add (new TabPage ("Tab D"));
			tab.Controls.Add (new TabPage ("Tab E"));
			
			tab.Controls.Add (new TabPage ("Tab F"));
			tab.Controls.Add (new TabPage ("Tab G"));
			tab.Controls.Add (new TabPage ("Tab H"));
			tab.Controls.Add (new TabPage ("Tab I"));
			tab.Controls.Add (new TabPage ("Tab J"));
			tab.Controls.Add (new TabPage ("Tab K"));
			
			tab.Height = 200;
			tab.SelectedIndex = 3;
			Controls.Add (tab);

		}

		public static void Main ()
		{
			Application.Run (new TabControlDemo ());
		}
	}
}

