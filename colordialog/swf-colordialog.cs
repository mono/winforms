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
		private ColorDialog colorDialog;
		public MainForm()
		{
			colorDialog = new ColorDialog();
			button = new Button();
			SuspendLayout();
			button.Location = new System.Drawing.Point(40, 32);
			button.Text = "ColorDialog";
			button.Click += new System.EventHandler(OnClick);
			AutoScaleBaseSize = new Size(5, 13);
			ClientSize = new System.Drawing.Size(292, 266);
			Controls.Add(button);
			Text = "ColorDialogTest";
			ResumeLayout(false);
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		void OnClick(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == colorDialog.ShowDialog())
				Console.WriteLine(colorDialog.Color);
		}
	}
}

