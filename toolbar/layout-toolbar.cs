using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToolbarLayoutTest {

        public class ToolbarLayout : Form {

		ToolBar toolbar;
		CheckBox chkbox_appearance;
		CheckBox chkbox_btnsize;
		TextBox txt_width;
		TextBox txt_height;
		CheckBox chkbox_images;
		CheckBox chkbox_align;
		ImageList images = new ImageList ();

                public ToolbarLayout ()
                {
                        toolbar = new ToolBar();
                        toolbar.Appearance = ToolBarAppearance.Flat;
                        //toolbar.ButtonSize = new Size(8, 8);
                        toolbar.Buttons.Add("New");
                        toolbar.Buttons.Add("Open");
                        toolbar.Buttons.Add("Blahblahblah");
                        Controls.Add (toolbar);
			chkbox_appearance = new CheckBox ();
			chkbox_appearance.Text = "Flat";
			chkbox_appearance.Checked = true;
			chkbox_appearance.CheckedChanged += new EventHandler (AppearanceChanged);
			chkbox_appearance.Location = new Point (10, 100);
			chkbox_appearance.Size = new Size (100, 20);
                        Controls.Add (chkbox_appearance);
			chkbox_btnsize = new CheckBox ();
			chkbox_btnsize.Text = "Button Size";
			chkbox_btnsize.Checked = false;
			chkbox_btnsize.CheckedChanged += new EventHandler (ButtonSizeChanged);
			chkbox_btnsize.Location = new Point (10, 130);
			chkbox_btnsize.Size = new Size (100, 20);
                        Controls.Add (chkbox_btnsize);
			txt_width = new TextBox ();
			txt_width.Location = new Point (110, 130);
			txt_width.Size = new Size (50, 20);
                        Controls.Add (txt_width);
			txt_height = new TextBox ();
			txt_height.Location = new Point (170, 130);
			txt_height.Size = new Size (50, 20);
                        Controls.Add (txt_height);
			chkbox_images = new CheckBox ();
			chkbox_images.Text = "Show Images";
			chkbox_images.Checked = false;
			chkbox_images.CheckedChanged += new EventHandler (ImagesChanged);
			chkbox_images.Location = new Point (10, 160);
			chkbox_images.Size = new Size (100, 20);
                        Controls.Add (chkbox_images);
			chkbox_align = new CheckBox ();
			chkbox_align.Text = "Text Underneath";
			chkbox_align.Checked = true;
			chkbox_align.CheckedChanged += new EventHandler (AlignmentChanged);
			chkbox_align.Location = new Point (10, 190);
			chkbox_align.Size = new Size (150, 20);
                        Controls.Add (chkbox_align);
			images.ColorDepth = ColorDepth.Depth32Bit;
			images.Images.Add (new Bitmap ("image1.bmp"));
			images.ImageSize = new Size (40, 40);
                }

		void AlignmentChanged (object o, EventArgs args)
		{
			if (chkbox_align.Checked)
				toolbar.TextAlign = ToolBarTextAlign.Underneath;
			else
				toolbar.TextAlign = ToolBarTextAlign.Right;
		}

		void AppearanceChanged (object o, EventArgs args)
		{
			if (chkbox_appearance.Checked)
				toolbar.Appearance = ToolBarAppearance.Flat;
			else
				toolbar.Appearance = ToolBarAppearance.Normal;
		}

		void ButtonSizeChanged (object o, EventArgs args)
		{
			if (chkbox_btnsize.Checked) {
				int width = Int32.Parse (txt_width.Text);
				int height = Int32.Parse (txt_height.Text);
				toolbar.ButtonSize = new Size (width, height);
			} else
				toolbar.ButtonSize = Size.Empty;
		}

		void ImagesChanged (object o, EventArgs args)
		{
			if (chkbox_images.Checked) {
				toolbar.ImageList = images;
				foreach (ToolBarButton btn in toolbar.Buttons)
					btn.ImageIndex = 0;
			} else {
				foreach (ToolBarButton btn in toolbar.Buttons)
					btn.ImageIndex = -1;
				toolbar.ImageList = null;
			}
		}

                public static void Main(string[] args)
		{
                        Application.Run(new ToolbarLayout ());
                }
        }
}
