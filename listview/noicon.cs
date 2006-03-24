using System;
using System.Windows.Forms;
using System.Drawing;

namespace MonoSamples
{
	public class ListViewTest : Form
	{
		private ListView view;
		private ImageList small_images;
		private ImageList large_images;

		int last_item = 0;
		int last_image = 0;

		string[] names = {
				"abiword_48.png",
				"bmp.png",
				"disks.png",
				"evolution.png",
			};

		public ListViewTest ()
		{
			InitializeComponent ();
		}

		public static void Main (string[] args)
		{
			Application.Run(new ListViewTest());
		}

		private void InitializeComponent ()
		{

			ClientSize = new System.Drawing.Size (800, 600);
			Text = "ListView-NoIcons";

			view = new ListView ();
			view.Location = new System.Drawing.Point (350, 10);
			view.CheckBoxes = true;
			view.Size = new System.Drawing.Size (400, 300);
			view.Anchor |= AnchorStyles.Right | AnchorStyles.Bottom;
			view.View = View.LargeIcon;

			/* Small images */
			small_images = new ImageList ();
                	small_images.ColorDepth = ColorDepth.Depth32Bit;
                	small_images.ImageSize = new Size (32, 32);
                	for (int i = 0; i < names.Length; i++)
                		small_images.Images.Add (Image.FromFile ("listview-items-icons/32x32/" + names[i]));

                	/* Small images */
			large_images = new ImageList ();
                	large_images.ColorDepth = ColorDepth.Depth32Bit;
                	large_images.ImageSize = new Size (64, 64);

                	for (int i = 0; i < names.Length; i++)
                		large_images.Images.Add (Image.FromFile ("listview-items-icons/64x64/" + names[i]));

			Controls.Add (view);

			for (int i = 0; i < 10; i++) {
				ListViewItem item = new ListViewItem ();
				item.Text = "Item " + last_item;
				item.ImageIndex = last_image - 1;
				view.Items.Add (item);
				last_item++;
				last_image = (last_image + 1) % 5;
			}

			Button button = new Button ();
			button.Text = "Change Icon Size";
			button.Click += new EventHandler (ButtonClicked);
			button.Location = new Point (10, 10);
			button.Size = new Size (150, 40);
			Controls.Add (button);
			CheckBox chkbox = new CheckBox ();
			chkbox.Text = "Large icons set";
			chkbox.Click += new EventHandler (LgIconsClicked);
			chkbox.Location = new Point (10, 80);
			Controls.Add (chkbox);
			chkbox = new CheckBox ();
			chkbox.Text = "Small icons set";
			chkbox.Click += new EventHandler (SmIconsClicked);
			chkbox.Location = new Point (10, 120);
			Controls.Add (chkbox);
		}

		void ButtonClicked (object o, EventArgs args)
		{
			if (view.View == View.LargeIcon)
				view.View = View.SmallIcon;
			else
				view.View = View.LargeIcon;
		}

		void LgIconsClicked (object o, EventArgs args)
		{
			if ((o as CheckBox).Checked)
				view.LargeImageList = large_images;
			else
				view.LargeImageList = null;
		}

		void SmIconsClicked (object o, EventArgs args)
		{
			if ((o as CheckBox).Checked)
				view.SmallImageList = small_images;
			else
				view.SmallImageList = null;
		}
	}
}
