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
			tab.Dock = DockStyle.Fill;
			// tab.Appearance = TabAppearance.FlatButtons;
			// tab.Multiline = true;

			tab.Controls.Add (CreateTabPage ("Red", Color.FromArgb (255, 255, 0, 0)));
			tab.Controls.Add (CreateTabPage ("Orange", Color.FromArgb (255, 255, 153, 0)));
			tab.Controls.Add (CreateTabPage ("Yellow", Color.FromArgb (255, 255, 255, 0)));
			tab.Controls.Add (CreateTabPage ("Green", Color.FromArgb (255, 0, 153, 0)));
			tab.Controls.Add (CreateTabPage ("Blue", Color.FromArgb (255, 0, 0, 255)));
			tab.Controls.Add (CreateTabPage ("Purple", Color.FromArgb (255, 197, 0, 148)));

			tab.Height = 200;
			tab.SelectedIndex = 3;
			Controls.Add (tab);

		}

		private TabPage CreateTabPage (string label, Color c)
		{
			TabPage res = new TabPage (label);
			res.BackColor = c;
			return res;
		}

		public static void Main ()
		{
			Application.Run (new TabControlDemo ());
		}
	}
}

