using System;
using System.Drawing;
using System.Windows.Forms;

namespace TabOrderTest {
	class MainWindow : System.Windows.Forms.Form {	
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

		void WalkControls(Control container, Control start, int count, bool forward) {
			Control ctl;

			Console.WriteLine("Walking inside {0},\n starting at control {0}", container.Text, start.Text);

			ctl = start;
			for (int i = 0; i < count; i++) {
				ctl = container.GetNextControl(ctl, forward);
				if (ctl != null) {
					Console.WriteLine("GetNextControl returned {0}", ctl.Text);
				} else {
					Console.WriteLine("GetNextControl returned NULL");
				}
			}
		}
		
		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "SWF Taborder Test App Form";

			Console.WriteLine("Group 1 and 2 are siblings, Group 3 is contained in Group 2");

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

			group1.TabIndex = 1;
			group2.TabIndex = 2;
			group3.TabIndex = 3;

			radio11.Text = "Radio 1-1 [Tab1]";
			radio12.Text = "Radio 1-2 [Tab2]";
			radio13.Text = "Radio 1-3 [Tab3]";
			radio14.Text = "Radio 1-4 [Tab4]";

			radio21.Text = "Radio 1-1 [Tab4]";
			radio22.Text = "Radio 1-2 [Tab3]";
			radio23.Text = "Radio 1-3 [Tab2]";
			radio24.Text = "Radio 1-4 [Tab1]";

			radio31.Text = "Radio 3-1 [Tab1]";
			radio32.Text = "Radio 3-2 [Tab3]";
			radio33.Text = "Radio 3-3 [Tab2]";
			radio34.Text = "Radio 3-4 [Tab4]";

			radio11.TabIndex = 1;
			radio11.TabIndex = 2;
			radio11.TabIndex = 3;
			radio11.TabIndex = 4;

			radio21.TabIndex = 4;
			radio21.TabIndex = 3;
			radio21.TabIndex = 2;
			radio21.TabIndex = 1;

			radio31.TabIndex = 1;
			radio31.TabIndex = 3;
			radio31.TabIndex = 2;
			radio31.TabIndex = 4;

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

			Console.WriteLine("Unselected radio buttons:");
			WalkControls(this, this, 19, true);
			WalkControls(this, label1, 10, true);
			WalkControls(group1, group1, 10, true);

			Console.WriteLine("With tabstops set for label and groupbox:");
			label1.TabIndex = 1;
			label2.TabIndex = 2;
			group1.TabIndex = 3;
			group2.TabIndex = 4;
			group3.TabIndex = 5;
			WalkControls(this, this, 10, true);

			Console.WriteLine("With selected radio buttons:");
			radio11.Checked = true;
			radio21.Checked = true;
			radio33.Checked = true;
			WalkControls(this, label1, 10, true);
		}		
		
		public static void Main(string[] args) {
			Application.Run(new MainWindow ());
		}
	}
}
