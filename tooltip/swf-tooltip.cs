//
// This is a bit overboard for a test app, but I'm hoping it 
// can be gutted and used as a base for other test apps, trying
// to set a good example :-)
//


using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static Control		active;

		Label		label1 = new Label();		// To test non-tabstop items as well
		Label		label2 = new Label();
		ToolTip		tt1 = new ToolTip();
		ToolTip		tt2 = new ToolTip();

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 200);
			Text = "SWF ToolTip Test App";

			label1.Location = new Point(10, 10);
			label1.Text = "Hover over me";
			Controls.Add(label1);

			label2.Location = new Point(200, 10);
			label2.Text = "No, hover over me!";
			Controls.Add(label2);

			tt1.AutoPopDelay = 5000;
			tt1.InitialDelay = 1000;
			tt1.ReshowDelay = 500;
			tt1.ShowAlways = true;
			tt1.SetToolTip(this.label1, "Mmm, thanks for stopping by.");

			tt2.AutoPopDelay = 5000;
			tt2.InitialDelay = 500;
			tt2.ReshowDelay = 100;
			tt2.ShowAlways = false;
			tt2.SetToolTip(this.label2, "Hi There. I'm a ToolTip");
		}		
		
		public static int Main(string[] args) {
			main_window = new MainWindow();
			active = main_window;

			Application.Run(main_window);

			return 0;
		}

	}
}
