using System;
using System.Drawing;
using System.Windows.Forms;

class mainmenus
{
	private static MainMenu CreateMenu (string prefix)
	{
		MainMenu mnu = new MainMenu ();
		mnu.MenuItems.Add (prefix + "First");
		mnu.MenuItems.Add (prefix + "Second");
		mnu.MenuItems.Add (prefix + "Third");
		mnu.MenuItems [0].MenuItems.Add (prefix + "First-bis");
		mnu.MenuItems [1].MenuItems.Add (prefix + "Second-bis");
		mnu.MenuItems [2].MenuItems.Add (prefix + "Third-bis");
		return mnu;
	}

	public static void Main ()
	{
		int x = 25;

		foreach (FormBorderStyle style in Enum.GetValues (typeof(FormBorderStyle))) {
			Form f1 = new Form();
			f1.FormBorderStyle = style;
			f1.Location = new Point (x, 25);
			f1.Size = new Size (200, 200);
			f1.StartPosition = FormStartPosition.Manual;
			f1.Menu = CreateMenu ("");
			f1.Text = style.ToString ();
			
			f1.Show ();					
			
			x += f1.Width + 25;
		}
		
		Form mdi = new Form ();
		Form child = new Form ();
		mdi.IsMdiContainer = true;
		mdi.StartPosition = FormStartPosition.Manual;
		mdi.Location = new Point (25, 250);
		mdi.Size = new Size (600, 400);
		mdi.Menu = CreateMenu ("Main ");
		child.MdiParent = mdi;
		child.StartPosition = FormStartPosition.Manual;
		child.Location = new Point (25, 25);
		child.Size = new Size (200, 200);
		child.Menu = CreateMenu ("Child ");			
		child.Show ();
		Application.Run (mdi);
	}
}