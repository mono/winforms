

using System;
using System.Drawing;
using System.Windows.Forms;


namespace System.Windows.Forms {

        public class PictureBoxDemo : Form {

                public PictureBoxDemo ()
                {
                        PictureBox box = null;

                        for (int r = 0; r < 3; r++) {
                                for (int c = 0; c < 3; c++) {
                                        box = new PictureBox ();
                                        box.SizeMode = PictureBoxSizeMode.AutoSize;
                                        box.Image = Image.FromFile ("roxy.jpg");
                                        box.Left = 10 + c * box.Image.Width + (c * 10);
                                        box.Top = 10 + r * box.Image.Height + (r * 10);
                                        Controls.Add (box);
                                }
                        }
                        Width = box.Right + 10;
                        Height = box.Bottom + 10;
                }

                public static void Main ()
                {
                        System.Threading.Thread.CurrentThread.Name = "Main Thread";
                        Application.Run (new PictureBoxDemo ());
                }
        }
}

