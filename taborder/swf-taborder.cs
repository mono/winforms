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

		Label		label1 = new Label();		// To test non-tabstop items as well
		Label		label2 = new Label();

		GroupBox	group1 = new GroupBox();
		GroupBox	group2 = new GroupBox();
		GroupBox	group3 = new GroupBox();

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

		private void MouseClick(object sender, MouseEventArgs e) {
			Control child;
			Point	p;

			p = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
			p = main_window.PointToClient(p);

			child = GetChildAtPoint(p);

			if (child != null) {
				if (child.Parent != null) {
					WalkControls(child.Parent, child, 14, true);
				}

				WalkControls(child, child, 14, true);
			} else {
				Console.WriteLine("No control found at point");
			}
		}

		void WalkControls(Control container, Control start, int count, bool forward) {
			Control ctl;

			Console.WriteLine("Walking inside {0},\n starting at control {1}", container.Text, start.Text);

			ctl = start;
			for (int i = 0; i < count; i++) {
				ctl = container.GetNextControl(ctl, forward);
				if (ctl != null) {
					Console.WriteLine("{1} GetNextControl returned {0}, Tabindex: {2}", ctl.Text, i+1, ctl.TabIndex);
				} else {
					Console.WriteLine("{0} GetNextControl returned NULL", i+1);
				}
			}
		}

		bool TestTabIndex(Control ctl, int expected) {
			if (ctl.TabIndex != expected) {
				if (verbose > 0) {
					Console.WriteLine("Test {0} failed (TabIndex):\n   Control: {1}\n   Expected : {2}\n   Got: {3}",
						test_no, ctl.Text, expected, ctl.TabIndex);
				}

				if (exception) {
					throw new Exception("Test " + test_no + " failed (TabIndex)");
				}
				test_no++;
				return false;
			}

			if (verbose > 0) {
				Console.WriteLine("Test {0} passed (TabIndex)", test_no++);
			}
			return true;
		}
		
		bool TestControl(Control container, Control start, bool forward, string expected) {
			bool	result;
			Control	ctl;

			ctl = container.GetNextControl(start, forward);

			if (ctl == null && expected == null) {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed (GetNextControl)", test_no++);
				}
				return true;
			}

				

			if (ctl == null || ctl.Text != expected) {
				result = false;
				if (verbose > 0) {
					Console.WriteLine("Test {0} failed (GetNextControl):\n   Container: {1}\n   Start: {2}\n   Forward: {3}\n   Expected: {4}\n   Got: {5}",
						test_no, container.Text, start.Text, forward, expected, ctl != null ? ctl.Text : "null");
				}

				if (exception) {
					throw new Exception("Test " + test_no + " failed (GetNextControl)");
				}

				test_no++;
				failed++;
			} else {
				if (verbose > 0) {
					Console.WriteLine("Test {0} passed (GetNextControl)", test_no++);
				}
				result = true;
			}

			return result;
		}

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "SWF Taborder Test App Form";

			if (debug > 1) {
				this.MouseDown += new MouseEventHandler(MouseClick);

				label1.MouseDown += new MouseEventHandler(MouseClick);
				label2.MouseDown += new MouseEventHandler(MouseClick);

				group1.MouseDown += new MouseEventHandler(MouseClick);
				group2.MouseDown += new MouseEventHandler(MouseClick);
				group3.MouseDown += new MouseEventHandler(MouseClick);

				radio11.MouseDown += new MouseEventHandler(MouseClick);
				radio12.MouseDown += new MouseEventHandler(MouseClick);
				radio13.MouseDown += new MouseEventHandler(MouseClick);
				radio14.MouseDown += new MouseEventHandler(MouseClick);

				radio21.MouseDown += new MouseEventHandler(MouseClick);
				radio22.MouseDown += new MouseEventHandler(MouseClick);
				radio23.MouseDown += new MouseEventHandler(MouseClick);
				radio24.MouseDown += new MouseEventHandler(MouseClick);

				radio31.MouseDown += new MouseEventHandler(MouseClick);
				radio32.MouseDown += new MouseEventHandler(MouseClick);
				radio33.MouseDown += new MouseEventHandler(MouseClick);
				radio34.MouseDown += new MouseEventHandler(MouseClick);
			}

			if (debug > 0) {
				Console.WriteLine("Group 1 and 2 are siblings, Group 3 is contained in Group 2");
			}

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

			// Don't assign, test automatic assignment
			//group2.TabIndex = 2;
			group2.TabStop = true;

			group3.TabIndex = 35;
			group3.TabStop = true;

			// Test default tab index
			TestTabIndex(radio11, 0);				// Test 1

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

			if (debug > 0) {
				// Dump all controls
				Console.WriteLine("Starting from Toplevel form");
				WalkControls(this, this, 20, true);

				// Show the behaviour inside a single container
				Console.WriteLine("Starting from a container that contains no other containers");
				WalkControls(group1, group1, 14, true);

				// Show the behaviour inside a single container
				Console.WriteLine("Starting from a container that contains one other container");
				WalkControls(group2, group2, 14, true);

				// Bogus args, test sanity checking
				Console.WriteLine("Sanity check testing, container is non-container control, starting at sibling");
				WalkControls(radio11, radio12, 14, true);

				// Bogus args, test sanity checking
				Console.WriteLine("Sanity check testing, container is non-container control, starting at sibling in different container");
				WalkControls(radio11, radio21, 14, true);

				// Bogus args, test sanity checking
				Console.WriteLine("Sanity check testing, container is non-container control, starting is same as container");
				WalkControls(label1, label1, 14, true);

				Console.WriteLine("Sanity check testing, container is aunt of start");
				WalkControls(group1, radio21, 14, true);

				Console.WriteLine("Sanity check testing, container is child of start");
				WalkControls(group1, this, 14, true);
			}

			// Perform some tests, the TabIndex stuff below will alter the outcome
			TestControl(group2, radio34, true, null);		// Test 2
			TestTabIndex(group2, 31);				// Test 3

			// Does the taborder of containers and non-selectable things change behaviour?
			label1.TabIndex = 5;
			label2.TabIndex = 4;
			group1.TabIndex = 3;
			group2.TabIndex = 1;

			if (debug > 0) {
				Console.WriteLine("With selected radio buttons, starting from Toplevel form");
				WalkControls(this, this, 14, true);

				Console.WriteLine("Sanity check testing, reverse walk");
				WalkControls(this, this, 20, false);
			}

			// Start verification
			TestControl(group2, radio34, true, null);		// Test 4
			TestControl(group2, group2, true, radio24.Text);	// Test 5
			TestControl(group2, group3, true, radio31.Text);	// Test 6
			TestControl(group1, radio14, true, null);		// Test 7
			TestControl(group2, radio24, true, radio23.Text);	// Test 8
			TestControl(group2, radio21, true, group3.Text);	// Test 9
			TestControl(this, radio12, true, radio13.Text);		// Test 10
			TestControl(this, radio14, true, label2.Text);		// Test 11
			TestControl(this, radio34, true, group1.Text);		// Test 12
			TestControl(group2, radio24, true, radio23.Text);	// Test 13

			// Sanity checks
			TestControl(radio11, radio21, true, null);		// Test 14
			TestControl(group1, radio21, true, radio11.Text);	// Test 15

			TestControl(this, label2, false, radio14.Text);		// Test 16
			TestControl(group2, group3, false, radio21.Text);	// Test 17

			TestTabIndex(radio21, 4);				// Test 18
			TestTabIndex(radio11, 0);				// Test 19
			TestTabIndex(radio13, 2);				// Test 20
			TestTabIndex(group3, 35);				// Test 21
			TestTabIndex(group2, 1);				// Test 22

			TestControl(this, this, false, label1.Text);		// Test 23
			TestControl(group1, group1, false, radio14.Text);	// Test 24
			TestControl(group3, group3, false, radio34.Text);	// Test 25

			TestControl(label1, label1, false, null);		// Test 26
			TestControl(radio11, radio21, false, null);		// Test 27

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
