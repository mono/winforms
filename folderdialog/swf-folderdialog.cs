
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace testwin
{
	public class MainForm : Form
	{
		private Button button;

		public MainForm ()
		{
			button = new Button();
			SuspendLayout ();
			button.Location = new System.Drawing.Point (40, 32);
			button.Text = "Folder Dialog";
			button.Click += new System.EventHandler (OnClick);
			AutoScaleBaseSize = new Size (5, 13);
			ClientSize = new System.Drawing.Size (292, 266);
			Controls.Add (button);
			Text = "Folder Dialog Test";
			ResumeLayout (false);
		}
		
		public static void Main (string [] args)
		{
			Application.Run (new MainForm ());
		}
		
		private void OnClick (object sender, System.EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog ();

			fbd.SelectedPath = Directory.GetCurrentDirectory ();
			fbd.ShowDialog ();
		}
	}
}
