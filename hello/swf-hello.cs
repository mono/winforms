//
// Hello, SWF!
// 
//


// This application will produce a window 250x250 pixels in size
// It will display "My first System.Windows.Forms application(TM)" centered in it

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		public MainWindow() {
			Label label;

			ClientSize = new System.Drawing.Size (250, 250);

			label = new Label();
			label.Text = "My first System.Windows.Forms application(TM)";
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			this.Controls.Add(label);
			Text = "Hello, System.Windows.Forms";
			
		}
		
		public static void Main(string[] args) {
			Application.Run(new MainWindow());
		}
	}
}
