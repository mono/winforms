//
// Test app for testing scroll and expose behaviour of XplatUI.ScrollWindow
//
// This will not run with SWF unless XplatUI and XplatUI.ScrollWindow is
// marked as public!
//

#undef window_scroll
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollTest {
	class MainWindow : System.Windows.Forms.Form {	
                protected override void OnPaint(PaintEventArgs e) {
                        Graphics        g = e.Graphics;
                        Font            f = new Font("Bitstream Vera Sans Mono", 20);
                        SolidBrush      b = new SolidBrush(Color.Red);
			Pen		gp = new Pen(Color.Green, 2);
			Pen		bp = new Pen(Color.Blue, 2);

                        g.FillRectangle(SystemBrushes.Window, ClientRectangle);
                        g.DrawString("TestString", f, b, 0, 0);

			g.DrawLine(gp , 1, 1, 500, 500);
			g.DrawLine(gp , 500, 1, 1, 500);

			for (int i = 0; i < 500; i += 20) {
				g.DrawLine(bp, 0, i, 500, i);
			}
			

			Console.WriteLine("Received Expose area {0}", e.ClipRectangle);
                }

		private void MainWindow_MouseDown(object sender, MouseEventArgs e) {
			Console.WriteLine("MouseUp received, clicks: {0}", e.Clicks);
#if window_scroll
			XplatUI.ScrollWindow(Handle, -111, 0, false);
#else
			XplatUI.ScrollWindow(Handle, new Rectangle(e.X, e.Y, 75, 75), 0, -5, true);
#endif
		}

		public MainWindow() {
			ClientSize = new System.Drawing.Size (520, 520);
			Text = "ScrollWindow Test app";

			this.MouseDown += new MouseEventHandler(MainWindow_MouseDown);
		}		
		
		public static void Main(string[] args) {
			Application.Run(new MainWindow ());
		}
	}
}
