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
		static int		test_no		= 1;
		static int		failed		= 0;
		static int		debug		= 0;
		static int		verbose		= 0;
		static bool		visual		= false;
		static bool		exception	= false;

		static Control		active;

		Label		label1 = new Label();		// To test non-tabstop items as well
		Label		label3 = new Label();
		TextBox		text1 = new TextBox();
		Label		label2 = new Label();
		TextBox		text2 = new TextBox();

		GroupBox	group1 = new GroupBox();
		GroupBox	group2 = new GroupBox();
		GroupBox	group3 = new GroupBox();


		Button		button11 = new Button();
		RadioButton	radio12 = new RadioButton();
		CheckBox	check13 = new CheckBox();
		CheckBox	check14 = new CheckBox();
		Button		button21 = new Button();
		Button		button22 = new Button();
		RadioButton	radio23 = new RadioButton();
		RadioButton	radio24 = new RadioButton();
		CheckBox	check31 = new CheckBox();
		CheckBox	check32 = new CheckBox();
		RadioButton	radio33 = new RadioButton();
		RadioButton	radio34 = new RadioButton();

		public MainWindow() {
			ClientSize = new System.Drawing.Size (200, 200);
			Text = "SWF ScrollableControl Test App";
			AutoScroll = true;

			label1.Location = new Point(10, 10);
			label1.Text = "&Label1";
			label1.Width = 69;
			label1.TabIndex = 1;
			Controls.Add(label1);

			label3.Location = new Point(79, 10);
			label3.Text = "&Y";
			label3.Width = 20;
			label3.TabIndex = 2;
			Controls.Add(label3);

			text1.Text = "text control 1";
			text1.Location = new Point(100, 10);
			text1.TabStop = true;
			Controls.Add(text1);

			label2.Location = new Point(200, 10);
			label2.Text = "La&bel2";
			label2.Width = 89;
			Controls.Add(label2);

			text2.Text = "Text control 2";
			text2.Location = new Point(300, 10);
			text2.TabStop = true;
			Controls.Add(text2);

			group1.Text = "&Group1";
			group2.Text = "Gr&oup2";
			group3.Text = "Grou&p3";

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
			button11.Text = "Radio 1-&1 [Tab1]";
			radio12.Text = "Radio 1-&2 [Tab2]";
			check13.Text = "Radio 1-&3 [Tab3]";
			check14.Text = "Radio 1-&4 [Tab4]";

			button21.Text = "R&adio 2-1 [Tab4]";
			button22.Text = "Ra&dio 2-2 [Tab3]";
			radio23.Text = "Rad&io 2-3 [Tab2]";
			radio24.Text = "Radi&o 2-4 [Tab1]";

			check31.Text = "&Radio 3-1 [Tab1]";
			check32.Text = "Radio 3&-2 [Tab3]";
			radio33.Text = "Radio 3-3 [&Tab2]";
			radio34.Text = "Radio &x 3-4 [Tab4]";

			button11.Click +=new EventHandler(cbClick);
			button21.Click +=new EventHandler(cbClick);

			button11.TabStop = true;

			button21.TabIndex = 4;
			button21.TabStop = true;
			button22.TabIndex = 3;
			button22.TabStop = true;
			radio23.TabIndex = 2;
			radio24.TabIndex = 1;
			radio24.TabStop = true;

			check31.TabIndex = 11;
			check31.TabStop = true;
			check32.TabIndex = 13;
			radio33.TabIndex = 12;
			radio34.TabIndex = 14;

			button11.Location = new Point(50, 50);
			radio12.Location = new Point(10, 40);
			check13.Location = new Point(10, 60);
			check14.Location = new Point(10, 80);

			button21.Location = new Point(10, 20);
			button22.Location = new Point(10, 40);
			radio23.Location = new Point(10, 60);
			radio24.Location = new Point(10, 80);

			check31.Location = new Point(10, 20);
			check32.Location = new Point(10, 40);
			radio33.Location = new Point(10, 60);
			radio34.Location = new Point(10, 80);

			button11.Size = new Size(150, 20);
			radio12.Size = new Size(150, 20);
			check13.Size = new Size(150, 20);
			check14.Size = new Size(150, 20);

			button21.Size = new Size(150, 20);
			button22.Size = new Size(150, 20);
			radio23.Size = new Size(150, 20);
			radio24.Size = new Size(150, 20);

			check31.Size = new Size(150, 20);
			check32.Size = new Size(150, 20);
			radio33.Size = new Size(150, 20);
			radio34.Size = new Size(150, 20);

			//group1.Controls.Add(button11);
			Controls.Add(button11);
			group1.Controls.Add(radio12);
			group1.Controls.Add(check13);
			group1.Controls.Add(check14);

			group2.Controls.Add(button21);
			group2.Controls.Add(button22);
			group2.Controls.Add(radio23);
			group2.Controls.Add(radio24);

			group3.Controls.Add(check31);
			group3.Controls.Add(check32);
			group3.Controls.Add(radio33);
			group3.Controls.Add(radio34);

			Controls.Add(group1);
			Controls.Add(group2);
			group2.Controls.Add(group3);

			label1.TabIndex = 1;
			label3.TabIndex = 2;
			text1.TabIndex = 3;
			label2.TabIndex = 4;
			text2.TabIndex = 5;
			group1.TabIndex = 6;
			group2.TabIndex = 7;

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

		private void cbEnter(object sender, EventArgs e) {
			Console.WriteLine("Enter called on object {0}", ((Control)sender).Text);
		}

		private void cbLeave(object sender, EventArgs e) {
			Console.WriteLine("Leave called on object {0}", ((Control)sender).Text);
		}

		private void cbGotFocus(object sender, EventArgs e) {
			Console.WriteLine("GotFocus called on object {0}", ((Control)sender).Text);
		}

		private void cbLostFocus(object sender, EventArgs e) {
			Console.WriteLine("LostFocus called on object {0}", ((Control)sender).Text);
		}

		private void cbValidating(object sender, CancelEventArgs e) {
			Console.WriteLine("Validating called on object {0}", ((Control)sender).Text);
		}

		private void cbValidated(object sender, EventArgs e) {
			Console.WriteLine("Validated called on object {0}", ((Control)sender).Text);
		}

		private void cbActivated(object sender, EventArgs e) {
			Console.WriteLine("Activated called on object {0}", ((Control)sender).Text);
//			Console.WriteLine("Currently active control: {0}", main_window.ActiveControl.Text);
		}

		private void cbDeactivate(object sender, EventArgs e) {
			Console.WriteLine("Deactivate called on object {0}", ((Control)sender).Text);
		}

		private void cbClick(object sender, EventArgs e) {
			Console.WriteLine("Click called on object {0}", ((Control)sender).Text);
this.AutoScrollPosition = new Point(50, 50);
		}
	}
}
