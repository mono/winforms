
#define notdef
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Threading;

namespace SWFTestClass {
	public class MainWindow : System.Windows.Forms.Form {
		public static Image	img_bmp1;
		public static Image	img_bmp16;
		public static Image	img_bmp256;
		public static Image	img_bmp;
		public static Image	img_tif;
		public static Image	img_gif;
		public static Image	img_jpg;
		public static Image	img_png;
		public static bool	multiple;

		protected override void OnPaint(PaintEventArgs e) {
			Console.WriteLine("Displaying image");
			if (multiple) {
				e.Graphics.DrawImage(img_bmp1, 0, 0);
				e.Graphics.DrawImage(img_bmp16, img_bmp.Width, 0);
				e.Graphics.DrawImage(img_bmp256, img_bmp.Width * 2, 0);
				e.Graphics.DrawImage(img_bmp, img_bmp.Width * 3, 0);
				e.Graphics.DrawImage(img_tif, 0, img_bmp.Height);
				e.Graphics.DrawImage(img_gif, img_bmp.Width, img_bmp.Height);
				e.Graphics.DrawImage(img_jpg, img_bmp.Width * 2, img_bmp.Height);
				e.Graphics.DrawImage(img_png, img_bmp.Width * 3, img_bmp.Height);
			} else {
				e.Graphics.DrawImage(img_bmp, 0, 0);
			}
		}

		public MainWindow() {
			if (multiple) {
				this.Width = img_bmp.Width * 4;
				this.Height = img_bmp.Height * 2;
			} else {
				this.Width = img_bmp.Width;
				this.Height = img_bmp.Height;
			}
		}

		public static int Main(string[] Args) {
			if (Args.Length > 0) {
				img_bmp = Image.FromFile(Args[0]);
				multiple = false;
			} else {
				img_bmp1 = Image.FromFile("test1.bmp");
				img_bmp16 = Image.FromFile("test16.bmp");
				img_bmp256 = Image.FromFile("test256.bmp");
				img_bmp = Image.FromFile("test.bmp");

				img_tif = Image.FromFile("test.tif");
				img_gif = Image.FromFile("test.gif");
				img_jpg = Image.FromFile("test.jpg");
				img_png = Image.FromFile("test.png");
				multiple = true;
			}
			Application.Run(new MainWindow());

			return 0;
		}
	}
}
