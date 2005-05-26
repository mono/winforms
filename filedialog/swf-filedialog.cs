//
// Testapp by Alexander Olk
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace testwin
{
	public class MainForm : Form
	{
		private Button button;
		public MainForm()
		{
			button = new Button();
			SuspendLayout();
			button.Location = new System.Drawing.Point(40, 32);
			button.Text = "FileDialog";
			button.Click += new System.EventHandler(OnClick);
			AutoScaleBaseSize = new Size(5, 13);
			ClientSize = new System.Drawing.Size(292, 266);
			Controls.Add(button);
			Text = "FileDialogTest";
			ResumeLayout(false);
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		void OnClick(object sender, System.EventArgs e)
		{
			  OpenFileDialog myFileDialog = new OpenFileDialog();
			  myFileDialog.Filter = "All Files (*.*)|*.*";
			  myFileDialog.Multiselect = false;
			  myFileDialog.RestoreDirectory = false;
			  myFileDialog.ShowDialog();

			  if (myFileDialog.FileName.Trim() != string.Empty)
			  {
			   this.button.Text = myFileDialog.FileName.Trim();
			  }

			  myFileDialog.Dispose();
			  myFileDialog = null;
		}
	}
}
