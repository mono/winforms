//
// Test drawing of imagelist. Output in image.bmp
//


using System;
using System.Drawing;
using System.Windows.Forms;


public class T {

        public static void Main ()
        {
                Bitmap b = new Bitmap (250, 20);
                ImageList il = new ImageList ();

                il.ColorDepth = ColorDepth.Depth32Bit;
                il.ImageSize = new Size (15, 15);

                il.Images.Add (Image.FromFile ("a.png"));
                il.Images.Add (Image.FromFile ("b.png"));

                Graphics g = Graphics.FromImage (b);
                il.Draw (g, 5, 3, 0);
                g.DrawString ("aaa", new Font ("arial", 15), new SolidBrush (Color.Red), new Point (20, 5));
                il.Draw (g, 50, 3, 1);

                b.Save ("image.bmp");
        }
}

