using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		static Control		active;

		PropertyGrid		propertygrid;

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "Property Grid Array Test";

			int[] testarray = new int[10];
			for (int i = 0; i < testarray.Length; i ++)
				testarray[i] = 10-i;


			TypeConverter cvt = TypeDescriptor.GetConverter (testarray);
			PropertyDescriptorCollection props = cvt.GetProperties (testarray);
			PropertyDescriptorCollection tdprops = TypeDescriptor.GetProperties (testarray); 
			Console.WriteLine ("Converter is {0}", cvt.GetType());
			Console.WriteLine ("converter properties length = {0}", props.Count);
			Console.WriteLine ("typedescriptor properties length = {0}", tdprops.Count);
			foreach (PropertyDescriptor prop in props) {
				Console.WriteLine ("{0} : {1}", prop.Name, prop.GetType());
				Console.WriteLine (" + {0} {1} {2} {3}", prop.PropertyType, prop.ComponentType, prop.CanResetValue (testarray), prop.ShouldSerializeValue (testarray));
			}

			Console.WriteLine (testarray[5]);

			propertygrid = new PropertyGrid();
			propertygrid.CommandsVisibleIfAvailable = true;
			propertygrid.Dock = DockStyle.Fill;
			propertygrid.TabIndex = 2;
			propertygrid.Text = "Property Grid";
			propertygrid.Dock = DockStyle.Fill;

			this.Controls.Add(propertygrid);

			propertygrid.SelectedObject = testarray;

			propertygrid.PropertyValueChanged += delegate (object o, PropertyValueChangedEventArgs e) {
				//Console.WriteLine (Environment.StackTrace);
			};

			propertygrid.SelectedGridItemChanged += delegate (object o, SelectedGridItemChangedEventArgs e) {
				//Console.WriteLine (Environment.StackTrace);
			};
		}		
		
		public static int Main(string[] args) {
			main_window = new MainWindow();
			active = main_window;

			Application.Run(main_window);
			return 0;
		}
	}
}
