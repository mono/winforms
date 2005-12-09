//

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace testwin
{
	public class MainForm : Form
	{
		private Button button;
		private Label label;
		public MainForm()
		{
			button = new Button();
			SuspendLayout();
			button.Location = new System.Drawing.Point(40, 32);
			button.Text = "Push me to cause an exception";
			button.Click += new System.EventHandler(OnClick);
			button.Size = new Size(100, 28);
			AutoScaleBaseSize = new Size(5, 13);
			ClientSize = new System.Drawing.Size(292, 266);
			Controls.Add(button);
			Text = "Exception test";
			label = new Label();
			ResumeLayout(false);
		}
		
		[STAThread]
		public static void Main(string[] args)
		{

			Application.Run(new MainForm());
		}
		
		void OnClick(object sender, System.EventArgs e)
		{
			label.BorderStyle = (BorderStyle)1234;
		}
	}
}

