//
// Right-click or left-click to move a label
// into background or foreground respectively
// Middle click to move it one up the chain
//


using System;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	struct CursorInfo {
		internal string	name;
		internal Cursor	cursor;
	}

	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static int		test_no		= 1;
		static int		failed		= 0;
		static int		debug		= 0;
		static int		verbose		= 0;
		static bool		visual		= false;
		static bool		exception	= false;

		Label[]			labels;
		const int		num_of_cursors	= 29;
		const int		size_of_label	= 60;
		const int		max_labels_row	= 5;

		private void GetCursor(int index, out CursorInfo ci) {
			switch(index) {
				case 0: {
					ci.name = "AppStarting";
					ci.cursor = Cursors.AppStarting;
					return;
				}

				case 1: {
					ci.name = "Arrow";
					ci.cursor = Cursors.Arrow;
					return;
				}

				case 2: {
					ci.name = "Cross";
					ci.cursor = Cursors.Cross;
					return;
				}

				case 3: {
					ci.name = "Default";
					ci.cursor = Cursors.Default;
					return;
				}

				case 4: {
					ci.name = "Hand";
					ci.cursor = Cursors.Hand;
					return;
				}

				case 5: {
					ci.name = "Help";
					ci.cursor = Cursors.Help;
					return;
				}

				case 6: {
					ci.name = "HSplit";
					ci.cursor = Cursors.HSplit;
					return;
				}

				case 7: {
					ci.name = "IBeam";
					ci.cursor = Cursors.IBeam;
					return;
				}

				case 8: {
					ci.name = "No";
					ci.cursor = Cursors.No;
					return;
				}

				case 9: {
					ci.name = "NoMove2D";
					ci.cursor = Cursors.NoMove2D;
					return;
				}

				case 10: {
					ci.name = "NoMoveHoriz";
					ci.cursor = Cursors.NoMoveHoriz;
					return;
				}

				case 11: {
					ci.name = "NoMoveVert";
					ci.cursor = Cursors.NoMoveVert;
					return;
				}

				case 12: {
					ci.name = "PanEast";
					ci.cursor = Cursors.PanEast;
					return;
				}

				case 13: {
					ci.name = "PanNorth";
					ci.cursor = Cursors.PanNorth;
					return;
				}

				case 14: {
					ci.name = "PanNE";
					ci.cursor = Cursors.PanNE;
					return;
				}

				case 15: {
					ci.name = "PanNW";
					ci.cursor = Cursors.PanNW;
					return;
				}

				case 16: {
					ci.name = "PanSE";
					ci.cursor = Cursors.PanSE;
					return;
				}

				case 17: {
					ci.name = "PanSouth";
					ci.cursor = Cursors.PanSouth;
					return;
				}

				case 18: {
					ci.name = "PanSW";
					ci.cursor = Cursors.PanSW;
					return;
				}

				case 19: {
					ci.name = "PanWest";
					ci.cursor = Cursors.PanWest;
					return;
				}

				case 20: {
					ci.name = "SizeAll";
					ci.cursor = Cursors.SizeAll;
					return;
				}

				case 21: {
					ci.name = "SizeNESW";
					ci.cursor = Cursors.SizeNESW;
					return;
				}

				case 22: {
					ci.name = "SizeNS";
					ci.cursor = Cursors.SizeNS;
					return;
				}

				case 23: {
					ci.name = "SizeNWSE";
					ci.cursor = Cursors.SizeNWSE;
					return;
				}

				case 24: {
					ci.name = "SizeWE";
					ci.cursor = Cursors.SizeWE;
					return;
				}

				case 25: {
					ci.name = "UpArrow";
					ci.cursor = Cursors.UpArrow;
					return;
				}

				case 26: {
					ci.name = "VSplit";
					ci.cursor = Cursors.VSplit;
					return;
				}

				case 27: {
					ci.name = "WaitCursor";
					ci.cursor = Cursors.WaitCursor;
					return;
				}

				case 28: {
					ci.name = "Application defined";
					ci.cursor = new Cursor("mycursor.cur");
					return;
				}

				default: {
					ci.name = "Default";
					ci.cursor = Cursors.Default;
					return;
				}
			}
		}

		public MainWindow() {
			int		X;
			int		Y;
			CursorInfo	ci;

			ClientSize = new System.Drawing.Size (max_labels_row * size_of_label, (((num_of_cursors + (max_labels_row - (num_of_cursors % max_labels_row))) * size_of_label) / (max_labels_row * size_of_label)) * size_of_label);
			Text = "SWF Cursor Test App";

			labels = new Label[num_of_cursors];

			ci = new CursorInfo();
			for (int i = 0; i < num_of_cursors; i++) {
				GetCursor(i, out ci);

				labels[i] = new Label();
				labels[i].Location = new Point((i * size_of_label) % (max_labels_row * size_of_label), ((i * size_of_label) / (max_labels_row * size_of_label)) * size_of_label);
				labels[i].Size = new Size(size_of_label, size_of_label);
				labels[i].Text = ci.name;
				labels[i].BackColor = Color.FromArgb(i * 9, i * 9, i * 9);
				labels[i].ForeColor = Color.Red;
				labels[i].Cursor = ci.cursor;
				labels[i].Paint += new PaintEventHandler(MainWindow_Paint);
				this.Controls.Add(labels[i]);

			}

			KeyDown += new KeyEventHandler(MainWindow_KeyDown);
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

		private void MainWindow_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyData == Keys.Escape) {
				Application.Exit();
			}
		}

		private void MainWindow_Paint(object sender, PaintEventArgs e) {
			((Label)sender).Cursor.Draw(e.Graphics, new Rectangle(new Point(10, 10), ((Label)sender).Cursor.Size));
		}
	}
}
