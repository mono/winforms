//
// This is a bit overboard for a test app, but I'm hoping it 
// can be gutted and used as a base for other test apps, trying
// to set a good example :-)
//


using System;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static int		test_no		= 1;
		static int		failed		= 0;
		static int		debug		= 0;
		static int		verbose		= 0;
		static bool		visual		= false;
		static bool		exception	= false;

		Label[]		labels;
		int		num_of_labels = 10;

		private Color LabelColor(int index) {
			switch(index) {
				case 0: return(Color.Red);
				case 1: return(Color.Green);
				case 2: return(Color.Blue);
				case 3: return(Color.Yellow);
				case 4: return(Color.Black);
				case 5: return(Color.White);
				case 6: return(Color.Magenta);
				case 7: return(Color.Cyan);
				case 8: return(Color.Teal);
				case 9: return(Color.Brown);
				case 10: return(Color.Aqua);
				default: return(Color.DarkSlateGray);
			}
		}

		private void MouseClick(object sender, MouseEventArgs e) {
			Control child;
			Point	p;

			p = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
			p = main_window.PointToClient(p);

			child = GetChildAtPoint(p);

			if (child != null) {
				if (child.Parent != null) {
					if (verbose > 0) {
						Console.WriteLine("Clicked on Label '{0}', moving to {1} of Z-Order", child.Text, e.Button == MouseButtons.Left ? "Bottom" : "Top");
					}
					if (e.Button == MouseButtons.Left) {
						main_window.Controls.SetChildIndex(child, main_window.Controls.Count);
					} else {
						main_window.Controls.SetChildIndex(child, 0);
					}
				}
			} else {
				if (verbose > 0) {
					Console.WriteLine("No control found at point");
				}
			}
		}

		public MainWindow() {
			ClientSize = new System.Drawing.Size (220, 220);
			Text = "SWF Z-Order Test App Form";

			labels = new Label[num_of_labels];

			for (int i = 0; i < num_of_labels; i++) {
				labels[i] = new Label();
				labels[i].Location = new Point(i * 10, i * 10);
				labels[i].Size = new Size(100, 100 + (num_of_labels - i) * 10);
				labels[i].Text = "Label " + i;
				labels[i].BackColor = LabelColor(i);
				labels[i].MouseDown += new MouseEventHandler(MouseClick);
				this.Controls.Add(labels[i]);
			}

			if (visual) {
				if (failed == 0) {
					MessageBox.Show("All Tests Passed!", "Success");
				} else {
					MessageBox.Show(failed + "tests failed, check the log", "Failure");
				}
			}
		}		
		
		public static int Main(string[] args) {
			if (args.Length > 0) {
				for (int i=0; i< args.Length; i++) {
					if ((args[i] == "-d") || (args[i] == "--debug")) {
						debug++;
						continue;
					}

					if ((args[i] == "-v") || (args[i] == "--verbose")) {
						verbose++;
						continue;
					}

					if ((args[i] == "-g") || (args[i] == "--gui")) {
						visual = true;
						continue;
					}

					if ((args[i] == "-e") || (args[i] == "--exception")) {
						exception = true;
						continue;
					}

					if ((args[i] == "-?") || (args[i] == "-h") || (args[i] == "--help")) {
						Console.WriteLine("Usage: <cmd> [-d | --debug] [-v | --verbose] [-g | --gui] [e | --exception]");
						return 0;
					}
				}
			}

			main_window = new MainWindow();
			Application.Run(main_window);

			if (failed == 0) {
				return 0;
			}

			return failed;
		}
	}
}
