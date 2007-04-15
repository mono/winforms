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

	public class TabControlDemo2 : Form {

		public TabControlDemo2 () {

			Controls.Add (MakeTab(0, 0, TabAlignment.Top, TabAppearance.Normal));
			Controls.Add (MakeTab(250, 0, TabAlignment.Bottom, TabAppearance.Normal));
			Controls.Add (MakeTab(500, 0, TabAlignment.Left, TabAppearance.Normal));
			Controls.Add (MakeTab(750, 0, TabAlignment.Right, TabAppearance.Normal));

			Controls.Add (MakeTab(0, 250, TabAlignment.Top, TabAppearance.FlatButtons));
			Controls.Add (MakeTab(250, 250, TabAlignment.Bottom, TabAppearance.FlatButtons));
			Controls.Add (MakeTab(500, 250, TabAlignment.Left, TabAppearance.FlatButtons));
			Controls.Add (MakeTab(750, 250, TabAlignment.Right, TabAppearance.FlatButtons));

			Controls.Add (MakeTab(0, 500, TabAlignment.Top, TabAppearance.Buttons));
			Controls.Add (MakeTab(250, 500, TabAlignment.Bottom, TabAppearance.Buttons));
			Controls.Add (MakeTab(500, 500, TabAlignment.Left, TabAppearance.Buttons));
			Controls.Add (MakeTab(750, 500, TabAlignment.Right, TabAppearance.Buttons));
			
			this.Size = new System.Drawing.Size(1000, 750);
		}

		private TabControl MakeTab(int x, int y, TabAlignment a, TabAppearance ap) {
			TabControl tab = new TabControl();
//			tab.Padding = new Point(20, 3);
			tab.Location = new Point (x, y);
			tab.Alignment = a;
			tab.Appearance = ap;
			tab.Controls.Add (CreateTabPage ("Red", Color.FromArgb (255, 255, 0, 0)));
			tab.Controls.Add (CreateTabPage ("Orange", Color.FromArgb (255, 255, 153, 0)));
			tab.Controls.Add (CreateTabPage ("Yellow", Color.FromArgb (255, 255, 255, 0)));
			tab.Controls.Add (CreateTabPage ("Green", Color.Green));
			tab.Controls.Add (CreateTabPage ("Blue", Color.FromArgb (255, 0, 0, 255)));
			tab.Controls.Add (CreateTabPage ("Purple", Color.FromArgb (255, 197, 0, 148)));

			tab.Height = 200;
			tab.Width = 200;
			tab.SelectedIndex = 3;
			return tab;
		}

		private TabPage CreateTabPage (string label, Color c)
		{
			TabPage res = new TabPage (label);
			res.BackColor = c;
			return res;
		}

		private void InitializeComponent() {
			// 
			// TabControlDemo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.Size = new System.Drawing.Size(1000, 1000);
			this.Name = "TabControlDemo";

		}

		public static void Main ()
		{
			Application.Run (new TabControlDemo2 ());
		}
	}
}

