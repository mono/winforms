
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResourceTest {
	class ResourceTest : Form {
		public static Image img;
		public static Image img_res;
		public static Icon ico;
		public static Icon ico_res;

		protected override void OnPaint (PaintEventArgs e) {
			e.Graphics.DrawImage (img, 0, 0);
			e.Graphics.DrawIcon (ico, img.Width, 0);
			e.Graphics.DrawImage (img_res, 0, img.Height);
			e.Graphics.DrawIcon (ico_res, img.Width, img.Height);
		}

		public ResourceTest () {
			this.Width = img.Width * 4;
			this.Height = img.Height * 4;
		}

		static void Main () {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ResourceTest));
			img = Image.FromFile ("resources.bmp");
			img_res = ((System.Drawing.Image)(resources.GetObject("resources.bmp")));
			ico = new Icon ("resources.ico");
			ico_res = ((System.Drawing.Icon)(resources.GetObject("resources.ico")));
			Application.Run(new ResourceTest ());
		}
	}
}
