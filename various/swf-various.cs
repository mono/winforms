//
// Various tests that can be automated
// 
// 
//


using Accessibility;
using System;
using System.ComponentModel;
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

		static Control		active;

		Label		label1 = new Label();		// To test non-tabstop items as well
		Label		label2 = new Label();

		GroupBox	group1 = new GroupBox();
		GroupBox	group2 = new GroupBox();
		GroupBox	group3 = new GroupBox();

		TextBox		text1 = new TextBox();

		RadioButton	radio11 = new RadioButton();
		RadioButton	radio12 = new RadioButton();
		RadioButton	radio13 = new RadioButton();
		RadioButton	radio14 = new RadioButton();
		RadioButton	radio21 = new RadioButton();
		RadioButton	radio22 = new RadioButton();
		RadioButton	radio23 = new RadioButton();
		RadioButton	radio24 = new RadioButton();
		RadioButton	radio31 = new RadioButton();
		RadioButton	radio32 = new RadioButton();
		RadioButton	radio33 = new RadioButton();
		RadioButton	radio34 = new RadioButton();

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "SWF Various Tests";

			label1.Location = new Point(10, 10);
			label1.Text = "Label1";
			Controls.Add(label1);

			label2.Location = new Point(200, 10);
			label2.Text = "Label2";
			Controls.Add(label2);

			group1.Text = "Group1";
			group2.Text = "Group2";
			group3.Text = "Group3";

			group1.Size = new Size(200, 400);
			group2.Size = new Size(200, 400);
			group3.Size = new Size(180, 180);

			group1.Location = new Point(10, 40);
			group2.Location = new Point(220, 40);
			group3.Location = new Point(10, 210);

			group1.TabIndex = 30;
			group1.TabStop = true;

			group2.TabIndex = 2;
			group2.TabStop = true;

			group3.TabIndex = 35;
			group3.TabStop = true;

			text1.Text = "Edit Control";

			radio11.Text = "Radio 1-1 [Tab1]";
			radio12.Text = "Radio 1-2 [Tab2]";
			radio13.Text = "Radio 1-3 [Tab3]";
			radio14.Text = "Radio 1-4 [Tab4]";

			radio21.Text = "Radio 2-1 [Tab4]";
			radio22.Text = "Radio 2-2 [Tab3]";
			radio23.Text = "Radio 2-3 [Tab2]";
			radio24.Text = "Radio 2-4 [Tab1]";

			radio31.Text = "Radio 3-1 [Tab1]";
			radio32.Text = "Radio 3-2 [Tab3]";
			radio33.Text = "Radio 3-3 [Tab2]";
			radio34.Text = "Radio 3-4 [Tab4]";

			// We don't assign TabIndex for radio1X; test automatic assignment
			text1.TabStop = true;
			radio11.TabStop = true;

			radio21.TabIndex = 4;
			radio22.TabIndex = 3;
			radio23.TabIndex = 2;
			radio24.TabIndex = 1;
			radio24.TabStop = true;

			radio31.TabIndex = 11;
			radio31.TabStop = true;
			radio32.TabIndex = 13;
			radio33.TabIndex = 12;
			radio34.TabIndex = 14;

			text1.Location = new Point(10, 100);

			radio11.Location = new Point(10, 20);
			radio12.Location = new Point(10, 40);
			radio13.Location = new Point(10, 60);
			radio14.Location = new Point(10, 80);

			radio21.Location = new Point(10, 20);
			radio22.Location = new Point(10, 40);
			radio23.Location = new Point(10, 60);
			radio24.Location = new Point(10, 80);

			radio31.Location = new Point(10, 20);
			radio32.Location = new Point(10, 40);
			radio33.Location = new Point(10, 60);
			radio34.Location = new Point(10, 80);

			text1.Size = new Size(150, text1.PreferredHeight);

			radio11.Size = new Size(150, 20);
			radio12.Size = new Size(150, 20);
			radio13.Size = new Size(150, 20);
			radio14.Size = new Size(150, 20);

			radio21.Size = new Size(150, 20);
			radio22.Size = new Size(150, 20);
			radio23.Size = new Size(150, 20);
			radio24.Size = new Size(150, 20);

			radio31.Size = new Size(150, 20);
			radio32.Size = new Size(150, 20);
			radio33.Size = new Size(150, 20);
			radio34.Size = new Size(150, 20);

			group1.Controls.Add(text1);

			group1.Controls.Add(radio11);
			group1.Controls.Add(radio12);
			group1.Controls.Add(radio13);
			group1.Controls.Add(radio14);

			group2.Controls.Add(radio21);
			group2.Controls.Add(radio22);
			group2.Controls.Add(radio23);
			group2.Controls.Add(radio24);

			group3.Controls.Add(radio31);
			group3.Controls.Add(radio32);
			group3.Controls.Add(radio33);
			group3.Controls.Add(radio34);

			Controls.Add(group1);
			Controls.Add(group2);
			group2.Controls.Add(group3);

			label1.TabIndex = 5;
			label2.TabIndex = 4;
			group1.TabIndex = 3;
			group2.TabIndex = 1;

			// Test 1; verify Control.FindForm results
			if (this.FindForm() != this) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: main_window.FindForm returned {1}, expected {2}", test_no, main_window.FindForm(), this);
				}
				test_no++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed", test_no++);
				}
			}

			// Test 2; verify Control.FindForm results
			if (radio34.FindForm() != this) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: radio34.FindForm returned {1}, expected {2}", test_no, main_window.FindForm(), this);
				}
				test_no++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed", test_no++);
				}
			}

			// Test 3; verify Control.FindForm results
			if (radio12.FindForm() != this) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: radio12.FindForm returned {1}, expected {2}", test_no, main_window.FindForm(), this);
				}
				test_no++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed", test_no++);
				}
			}

			if (this.AccessibilityObject.ToString() != "ControlAccessibleObject: Owner = MWFTestApplication.MainWindow, Text: SWF Various Tests") {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: radio12.AccessibilityObject.ToString()\nreturned >{1}<\nexpected >ControlAccessibleObject: Owner = MWFTestApplication.MainWindow, Text: SWF Various Tests<", test_no, AccessibilityObject.ToString());
				}
				test_no++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed", test_no++);
				}
			}

			int pre_scale_width = this.ClientSize.Width;

			this.Scale(2);
			this.Scale(1);

			if (this.ClientSize.Width != (pre_scale_width * 2)) {
				failed++;
				if (verbose > 0) {
					Console.WriteLine("{0}: this.Scale(2); this.Scale(1) failed, width: {1}, expected {2}", test_no, this.ClientSize.Width, pre_scale_width * 2);
				}
				test_no++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed", test_no++);
				}
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
			active = main_window;

			// We don't want to run it, tests are already complete
			if (visual) {
				Application.Run(main_window);
			}

			if (failed == 0) {
				return 0;
			}

			return failed;
		}
	}
}
