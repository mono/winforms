// 
// 
//


using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MWFTestApplication {
	class MainWindow : Form {
		public static MainWindow	main_window;
		public static NotifyIcon	notify;
		public static ContextMenu	menu;
		public static Bitmap		icon_bitmap;

		private void MainWindow_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawImage(icon_bitmap, 0, 0);
		}

		public MainWindow() {

			this.StartPosition = FormStartPosition.CenterScreen;

			BackColor = Color.Green;
			Paint += new PaintEventHandler(MainWindow_Paint);
		}

		public static void Main(string[] args) {
			Stream		s;
			MenuItem	item1;
			MenuItem	item2;
			MenuItem[]	items;

			s = null;
			notify = new NotifyIcon();
			try {
				s = File.OpenRead("notify.ico");

				notify.Icon = new Icon(s);

			}

			catch {
				MessageBox.Show("File 'notify.ico' cannot be found", "Error");
				Console.WriteLine("File 'notify.ico' cannot be found");
				return;
			}

			finally {
				if (s != null) {
					s.Close();
				}
			}

			icon_bitmap = notify.Icon.ToBitmap();

			item1 = new MenuItem("Open");
			item1.Click += new EventHandler(notify_menuOpen);

			item2 = new MenuItem("Exit");
			item2.Click += new EventHandler(notify_menuExit);

			items = new MenuItem[] {item1, item2};

			menu = new ContextMenu(items);

			notify.Text = "Tester tooltip text";
			notify.Visible = true;
			notify.ContextMenu = menu;
			notify.Click +=new EventHandler(notify_Click);
			notify.DoubleClick +=new EventHandler(notify_DoubleClick);
			notify.MouseDown +=new MouseEventHandler(notify_MouseDown);
			notify.MouseMove += new MouseEventHandler(notify_MouseMove);
			notify.MouseUp +=new MouseEventHandler(notify_MouseUp);

			main_window = new MainWindow();

			Application.Run(main_window);
		}

		private static void notify_menuOpen(object sender, EventArgs e) {
			Console.WriteLine("User selected menu item 'open'");
		}

		private static void notify_menuExit(object sender, EventArgs e) {
			Console.WriteLine("User selected menu item 'Exit'");
			notify.Visible = false;
			notify.Dispose();
			Application.Exit();
		}

		private static void notify_Click(object sender, EventArgs e) {
			Console.WriteLine("swf-notifyicon: User clicked");
		}

		private static void notify_DoubleClick(object sender, EventArgs e) {
			Console.WriteLine("swf-notifyicon: User double-clicked");
							     }

		private static void notify_MouseDown(object sender, MouseEventArgs e) {
			Console.WriteLine("swf-notifyicon: MouseDown event");
		}

		private static void notify_MouseMove(object sender, MouseEventArgs e) {
			Console.WriteLine("swf-notifyicon: MouseMove event");
		}

		private static void notify_MouseUp(object sender, MouseEventArgs e) {
			Console.WriteLine("swf-notifyicon: MouseUp event");
		}
	}
}
