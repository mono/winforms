//
// Results from SystemInformation class
// 
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

		// Switch to PropertyGrid once it know show to scroll
		ListView		list1 = new ListView();

		public void AddItem(string property, string value) {
			ListViewItem	item;

			item = new ListViewItem(property);
			item.SubItems.Add(value);

			list1.Items.Add(item);
		}

		public MainWindow() {
			ListViewItem	item;

			ClientSize = new System.Drawing.Size (520, 520);
			Text = "SWF System Information";

			list1.Location = new Point(0, 0);
			list1.Dock = DockStyle.Fill;
			list1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			list1.GridLines = true;
			list1.View = View.Details;
			list1.FullRowSelect = true;
			list1.Sorting = SortOrder.None;

			list1.Columns.Add("Property", -2, HorizontalAlignment.Left);
			list1.Columns.Add("Value", -2, HorizontalAlignment.Left);

			this.Controls.Add(list1);

			list1.BeginUpdate();

			AddItem("ArrangeDirection", SystemInformation.ArrangeDirection.ToString());
			AddItem("ArrangeStartingPosition", SystemInformation.ArrangeStartingPosition.ToString());
			AddItem("BootMode", SystemInformation.BootMode.ToString());
			AddItem("Border3DSize", SystemInformation.Border3DSize.ToString());
			AddItem("BorderSize", SystemInformation.BorderSize.ToString());
			AddItem("CaptionButtonSize", SystemInformation.CaptionButtonSize.ToString());
			AddItem("CaptionHeight", SystemInformation.CaptionHeight.ToString());
			AddItem("ComputerName", SystemInformation.ComputerName.ToString());
			AddItem("CursorSize", SystemInformation.CursorSize.ToString());
			AddItem("DbcsEnabled", SystemInformation.DbcsEnabled.ToString());
			AddItem("DebugOS", SystemInformation.DebugOS.ToString());
			AddItem("DoubleClickSize", SystemInformation.DoubleClickSize.ToString());
			AddItem("DoubleClickTime", SystemInformation.DoubleClickTime.ToString());
			AddItem("DragFullWindows", SystemInformation.DragFullWindows.ToString());
			AddItem("DragSize", SystemInformation.DragSize.ToString());
			AddItem("FixedFrameBorderSize", SystemInformation.FixedFrameBorderSize.ToString());
			AddItem("FrameBorderSize", SystemInformation.FrameBorderSize.ToString());
			AddItem("HighContrast", SystemInformation.HighContrast.ToString());
			AddItem("HorizontalScrollBarArrowWidth", SystemInformation.HorizontalScrollBarArrowWidth.ToString());
			AddItem("HorizontalScrollBarHeight", SystemInformation.HorizontalScrollBarHeight.ToString());
			AddItem("HorizontalScrollBarThumbWidth", SystemInformation.HorizontalScrollBarThumbWidth.ToString());
			AddItem("IconSize", SystemInformation.IconSize.ToString());
			AddItem("IconSpacingSize", SystemInformation.IconSpacingSize.ToString());
			AddItem("KanjiWindowHeight", SystemInformation.KanjiWindowHeight.ToString());
			AddItem("MaxWindowTrackSize", SystemInformation.MaxWindowTrackSize.ToString());
			AddItem("MenuButtonSize", SystemInformation.MenuButtonSize.ToString());
			AddItem("MenuCheckSize", SystemInformation.MenuCheckSize.ToString());
			AddItem("MenuFont", SystemInformation.MenuFont.ToString());
			AddItem("MenuHeight", SystemInformation.MenuHeight.ToString());
			AddItem("MidEastEnabled", SystemInformation.MidEastEnabled.ToString());
			AddItem("MinimizedWindowSize", SystemInformation.MinimizedWindowSize.ToString());
			AddItem("MinimizedWindowSpacingSize", SystemInformation.MinimizedWindowSpacingSize.ToString());
			AddItem("MinimumWindowSize", SystemInformation.MinimumWindowSize.ToString());
			AddItem("MinWindowTrackSize", SystemInformation.MinWindowTrackSize.ToString());
			AddItem("MonitorCount", SystemInformation.MonitorCount.ToString());
			AddItem("MonitorsSameDisplayFormat", SystemInformation.MonitorsSameDisplayFormat.ToString());
			AddItem("MouseButtons", SystemInformation.MouseButtons.ToString());
			AddItem("MouseButtonsSwapped", SystemInformation.MouseButtonsSwapped.ToString());
			AddItem("MousePresent", SystemInformation.MousePresent.ToString());
			AddItem("MouseWheelPresent", SystemInformation.MouseWheelPresent.ToString());
			AddItem("MouseWheelScrollLines", SystemInformation.MouseWheelScrollLines.ToString());
			AddItem("NativeMouseWheelSupport", SystemInformation.NativeMouseWheelSupport.ToString());
			AddItem("Network", SystemInformation.Network.ToString());
			AddItem("PenWindows", SystemInformation.PenWindows.ToString());
			AddItem("PrimaryMonitorMaximizedWindowSize", SystemInformation.PrimaryMonitorMaximizedWindowSize.ToString());
			AddItem("PrimaryMonitorSize", SystemInformation.PrimaryMonitorSize.ToString());
			AddItem("RightAlignedMenus", SystemInformation.RightAlignedMenus.ToString());
			AddItem("Secure", SystemInformation.Secure.ToString());
			AddItem("ShowSounds", SystemInformation.ShowSounds.ToString());
			AddItem("SmallIconSize", SystemInformation.SmallIconSize.ToString());
			AddItem("ToolWindowCaptionButtonSize", SystemInformation.ToolWindowCaptionButtonSize.ToString());
			AddItem("ToolWindowCaptionHeight", SystemInformation.ToolWindowCaptionHeight.ToString());
			AddItem("UserDomainName", SystemInformation.UserDomainName.ToString());
			AddItem("UserInteractive", SystemInformation.UserInteractive.ToString());
			AddItem("UserName", SystemInformation.UserName.ToString());
			AddItem("VerticalScrollBarArrowHeight", SystemInformation.VerticalScrollBarArrowHeight.ToString());
			AddItem("VerticalScrollBarThumbHeight", SystemInformation.VerticalScrollBarThumbHeight.ToString());
			AddItem("VerticalScrollBarWidth", SystemInformation.VerticalScrollBarWidth.ToString());
			AddItem("VirtualScreen", SystemInformation.VirtualScreen.ToString());
			AddItem("WorkingArea", SystemInformation.WorkingArea.ToString());

			list1.EndUpdate();
			
			if (!visual) {
				for (int i = 0; i < list1.Items.Count; i++) {
					Console.WriteLine("{0} : {1}", list1.Items[i].Text, list1.Items[i].SubItems[1].Text);
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
