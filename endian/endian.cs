
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

		public static Image	saved_img_bmp1;
		public static Image	saved_img_bmp16;
		public static Image	saved_img_bmp256;
		public static Image	saved_img_bmp;
		public static Image	saved_img_tif;
		public static Image	saved_img_gif;
		public static Image	saved_img_jpg;
		public static Image	saved_img_png;

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

				e.Graphics.DrawImage(saved_img_bmp1, 0, img_bmp.Height * 2);
				e.Graphics.DrawImage(saved_img_bmp16, img_bmp.Width, img_bmp.Height * 2);
				e.Graphics.DrawImage(saved_img_bmp256, img_bmp.Width * 2, img_bmp.Height * 2);
				e.Graphics.DrawImage(saved_img_bmp, img_bmp.Width * 3, img_bmp.Height * 2);
				e.Graphics.DrawImage(saved_img_tif, 0, img_bmp.Height * 3);
				e.Graphics.DrawImage(saved_img_gif, img_bmp.Width, img_bmp.Height * 3);
				e.Graphics.DrawImage(saved_img_jpg, img_bmp.Width * 2, img_bmp.Height * 3);
				e.Graphics.DrawImage(saved_img_png, img_bmp.Width * 3, img_bmp.Height * 3);
			} else {
				e.Graphics.DrawImage(img_bmp, 0, 0);
			}
		}

		public MainWindow() {
			if (multiple) {
				this.Width = img_bmp.Width * 4;
				this.Height = img_bmp.Height * 4;
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

				img_bmp1.Save("saved_test1.bmp", ImageFormat.Bmp);
				img_bmp16.Save("saved_test16.bmp", ImageFormat.Bmp);
				img_bmp256.Save("saved_test256.bmp", ImageFormat.Bmp);
				img_bmp.Save("saved_test.bmp", ImageFormat.Bmp);
				img_tif.Save("saved_test.tif", ImageFormat.Tiff);
				img_gif.Save("saved_test.gif", ImageFormat.Gif);
				img_jpg.Save("saved_test.jpg", ImageFormat.Jpeg);
				img_png.Save("saved_test.png", ImageFormat.Png);

				saved_img_bmp1 = Image.FromFile("saved_test1.bmp");
				saved_img_bmp16 = Image.FromFile("saved_test16.bmp");
				saved_img_bmp256 = Image.FromFile("saved_test256.bmp");
				saved_img_bmp = Image.FromFile("saved_test.bmp");

				saved_img_tif = Image.FromFile("saved_test.tif");
				saved_img_gif = Image.FromFile("saved_test.gif");
				saved_img_jpg = Image.FromFile("saved_test.jpg");
				saved_img_png = Image.FromFile("saved_test.png");
			}
			Application.Run(new MainWindow());

			return 0;
		}
	}
}
