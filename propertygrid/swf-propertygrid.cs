using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static Control		active;

		PropertyGrid		propertygrid;
		TextBox			textbox;

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "Property Grid Test";


			textbox = new TextBox();

			textbox.Location = new Point(0, 0);
			textbox.Width = this.Width;
			textbox.TabIndex = 1;

			this.Controls.Add(textbox);

			propertygrid = new PropertyGrid();
			propertygrid.CommandsVisibleIfAvailable = true;
			propertygrid.Location = new Point(0, textbox.PreferredHeight + 10);
			propertygrid.Dock = DockStyle.Fill;
			propertygrid.TabIndex = 2;
			propertygrid.Text = "Property Grid";

			this.Controls.Add(propertygrid);

			propertygrid.SelectedObject = textbox;

		}		
		
		public static int Main(string[] args) {
			main_window = new MainWindow();
			active = main_window;

			Application.Run(main_window);
			return 0;
		}
	}
}
