//
// Various tests that can be automated
// 
// 
//


using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.IsolatedStorage;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace MWFTestApplication {
	class MainWindow : System.Windows.Forms.Form {	
		static MainWindow	main_window;
		Brush			brush;
		Brush			backbrush;
		StringFormat		format;
		int			DisplayMode	= 1;
		const int		MaxDisplayModes = 5;
		int			XOffset;
		int			YOffset;
		DateTime		target;
		DateTime		evening;
		Timer			timer;
		NumberFormatInfo	nfi = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
		Configuration		configuration;

		[Serializable]
		public class Configuration {
			private Point	location;
			private Size	size;
			private int	mode;

			public Configuration() {
				size = new Size(200, 100);
				location = new Point(10, 10);
				mode = 0;
			}

			public Point Location {
				get { return location; }
				set { location = value; }
			}

			public Size Size {
				get { return size; }
				set { size = value; }
			}

			public int Mode {
				get { return mode; }
				set { mode = value; }
			}

		}

		public void SaveConfig(Configuration config) {
			IsolatedStorageFile	isoFile;

			isoFile = IsolatedStorageFile.GetUserStoreForDomain();

			try {
				using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("rente", FileMode.OpenOrCreate, FileAccess.Write, isoFile)) {
					BinaryFormatter formatter;

					formatter = new BinaryFormatter();
					formatter.Serialize(isoStream, config);
				}
			}

			catch (Exception ex) {
				//MessageBox.Show(ex.Message, "Exception");
			}
		}

		public Configuration LoadConfig() {
			Configuration		config;
			IsolatedStorageFile	isoFile;

			isoFile = IsolatedStorageFile.GetUserStoreForDomain();

			try {
				using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("rente", FileMode.Open, FileAccess.Read, isoFile)) {
					BinaryFormatter formatter;

					formatter = new BinaryFormatter();
					config = (Configuration)formatter.Deserialize(isoStream);
					return config;
				}
			}

			catch (Exception ex) {
				//MessageBox.Show(ex.Message, "Exception");
			}
			return new Configuration();
		}

		protected override CreateParams CreateParams {
			get {
				CreateParams	cp;
				Size		size;
				Point		location;

				cp = base.CreateParams;

				cp.Style = 0x16070000;
				return cp;
			}
		}

		protected override void OnPaint(PaintEventArgs e) {
			this.TopMost = true;
			e.Graphics.FillRectangle(backbrush, e.ClipRectangle);
			e.Graphics.DrawString(Text, this.Font, brush, ClientSize.Width/2, ClientSize.Height/2, format);
		}

		private void ResetEvening() {
			evening = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 45, 0, 0);
		}

		public MainWindow() {
			configuration = LoadConfig();


			Text = "SWF Various Tests";
			DisplayMode = 0;

			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);


			//this.TransparencyKey = BackColor;
			this.ControlBox = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.Manual;
			this.Location = configuration.Location;
			this.ClientSize = configuration.Size;
			this.MouseDown +=new MouseEventHandler(MainWindow_MouseDown);
			this.MouseMove +=new MouseEventHandler(MainWindow_MouseMove);
			this.MouseUp +=new MouseEventHandler(MainWindow_MouseUp);
			this.Resize += new EventHandler(MainWindow_Resize);
			this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
			this.Font = new Font("tahoma", 20);
			this.TopMost = true;
			Application.ApplicationExit +=new EventHandler(Application_ApplicationExit);
			this.Location = new Point(1000,1000);

			brush = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Blue, 45, true);
			backbrush = new SolidBrush(BackColor);

			format = new StringFormat();
			format.Alignment = StringAlignment.Center;
			format.LineAlignment = StringAlignment.Center;

			timer = new Timer();
			timer.Interval = 100;
			timer.Enabled = true;
			timer.Tick += new EventHandler(timer_Tick);

			target = new DateTime(2007, 7, 31, 15, 45, 0, 0);

			nfi.NumberDecimalDigits = 0;

			this.CreateControl();
			ResetEvening();
		}
		
		public static int Main(string[] args) {
			main_window = new MainWindow();
			Application.Run(main_window);
			return 0;
		}

		private void MainWindow_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				DisplayMode++;
				if (DisplayMode >= MaxDisplayModes) {
					DisplayMode = 0;
				}
			} else if (e.Button == MouseButtons.Left) {
				Capture = true;
				XOffset = e.X;
				YOffset = e.Y;
			}
		}

		private void MainWindow_MouseMove(object sender, MouseEventArgs e) {
			Point	pt;

			if (!Capture || e.Button != MouseButtons.Left) {
				return;
			}

			pt = PointToScreen(new Point(e.X - XOffset, e.Y - YOffset));
			this.Location = pt;

		}

		private void MainWindow_MouseUp(object sender, MouseEventArgs e) {
			if (Capture) {
				Capture = false;
			}
		}

		private void MainWindow_Resize(object sender, EventArgs e) {
			brush.Dispose();
			brush = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Blue, 45, true);
			Invalidate();
		}

		private void MainWindow_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyData == Keys.Escape) {
				Application.Exit();
			}
		}

		private void timer_Tick(object sender, EventArgs e) {
			TimeSpan result;

			result = target.Subtract(DateTime.Now);

			switch(DisplayMode) {
				case 0: {
					long	diff;

					diff = target.ToFileTime() - DateTime.Now.ToFileTime();
					this.Text = diff.ToString("N", nfi) + " ms";
					break;
				}

				case 1: {
					this.Text = result.Days.ToString() + " T " + result.Hours.ToString("D2") + ":" + result.Minutes.ToString("D2") + ":" +result.Seconds.ToString("D2");
					break;
				}

				case 2: {
					this.Text = result.Days.ToString() + " T " + result.Hours.ToString("D2") + ":" + result.Minutes.ToString("D2");
					break;
				}

				case 3: {
					this.Text = "Rente: " + result.Days.ToString() + " T " + result.Hours.ToString("D2") + ":" + result.Minutes.ToString("D2");
					if (DateTime.Now.ToFileTimeUtc() > evening.ToFileTimeUtc()) {
						ResetEvening();
					}
					result = evening.Subtract(DateTime.Now);
					this.Text += "\nFeierabend: " + result.Hours.ToString("D2") + ":" + result.Minutes.ToString("D2");
					break;
				}

				case 4: {
					this.Text = result.Days.ToString() + " Tage";
					break;
				}
			}
			Invalidate();
		}

		private void Application_ApplicationExit(object sender, EventArgs e) {
			configuration.Location = Location;
			configuration.Size = Size;
			configuration.Mode = DisplayMode;
			SaveConfig(configuration);
		}
	}
}
