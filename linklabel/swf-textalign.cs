using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace MyLinkLabelProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		private const int label_width = 300;
		private const int label_height = 130;
		
		public MainForm()
		{
			CreateLinkLabel (1, ContentAlignment.TopLeft);
			CreateLinkLabel (2, ContentAlignment.TopCenter);
			CreateLinkLabel (3, ContentAlignment.TopRight);
			CreateLinkLabel (4, ContentAlignment.MiddleLeft);
			CreateLinkLabel (5, ContentAlignment.MiddleCenter);
			CreateLinkLabel (6, ContentAlignment.MiddleRight);
			CreateLinkLabel (7, ContentAlignment.BottomLeft);
			CreateLinkLabel (8, ContentAlignment.BottomCenter);
			CreateLinkLabel (9, ContentAlignment.BottomRight);

			this.ClientSize = new System.Drawing.Size ((label_width*3)+16, (label_height*3)+16);
			this.Name = "MainForm";
			this.Text = "LinkLabel Test App";
		}

		private LinkLabel CreateLinkLabel (int id, System.Drawing.ContentAlignment align)
		{
			LinkLabel label = new LinkLabel ();
			label.Name = String.Format ("LinkLabel{0}", id);
			label.Size = new Size(label_width, label_height);
			label.TabIndex = id;
			label.BackColor = Color.Silver;
			label.TabStop = true;
			label.TextAlign = align;
			label.LinkBehavior = LinkBehavior.HoverUnderline;
			label.LinkClicked += new LinkLabelLinkClickedEventHandler (LinkLabelClicked);

			label.Font = new Font (label.Font.FontFamily, label.Font.Size + 1, label.Font.Style);

			label.Text = "Mono provides the necessary software to develop and run .NET client and server " +
						"applications on Linux, Solaris, Mac OS X, Windows, and Unix. Sponsored by Novell, " +
						"the Mono open source project has an active and enthusiastic contributing community " +
						"and is positioned to become the leading choice for development of Linux applications.";
			
			string [,] links = {
						{"develop and run .NET client and server", "none"},
						{"active and enthusiastic contributing community and is positioned", "none"},
						{"Novell" , "http://www.novell.com"},
						{"Mono", "http://www.mono-project.com"},
						{"Linux", "http://www.linux.org/"},
						{"Mac OS X", "http://www.apple.com/br/macosx/"}
						};


			for (int i = 0; i < (links.Length/2); i++) {			
				LinkLabel.Link link = label.Links.Add (label.Text.IndexOf(links[i,0]), links[i,0].Length, links[i,1]);
				
				if (i == 0)
					link.Enabled = false;
					
				if (i == 1)
					link.Visited = false;
			}
			
			
			int magic = (id + 2); 
			label.Location = new System.Drawing.Point( 
					5+((magic%3)*(label.Size.Width+3)), 
					5+(((magic/3)-1)*(label.Size.Height+3)));
			
			this.Controls.Add(label);
			
			return label;
		}
		
		private	void LinkLabelClicked (object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("You have clicked in link!");
		}
	}			
}
