// project created on 13/10/2003 at 10:13
using System;
using System.Collections;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel linkLabel18;
		private System.Windows.Forms.LinkLabel linkLabel19;
		private System.Windows.Forms.LinkLabel linkLabel12;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.LinkLabel linkLabel14;
		private System.Windows.Forms.LinkLabel linkLabel13;
		private System.Windows.Forms.LinkLabel linkLabel15;
		private System.Windows.Forms.LinkLabel linkLabel21;
		private System.Windows.Forms.LinkLabel linkLabel23;
		private System.Windows.Forms.LinkLabel linkLabel22;
		private System.Windows.Forms.LinkLabel linkLabel25;
		private System.Windows.Forms.LinkLabel linkLabel24;
		private System.Windows.Forms.LinkLabel linkLabel26;
		private System.Windows.Forms.LinkLabel linkLabel20;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel linkLabel16;
		private System.Windows.Forms.LinkLabel linkLabel17;
		private System.Windows.Forms.LinkLabel linkLabel9;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.LinkLabel linkLabel11;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.linkLabel11 = new System.Windows.Forms.LinkLabel();
			this.linkLabel10 = new System.Windows.Forms.LinkLabel();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.linkLabel9 = new System.Windows.Forms.LinkLabel();
			this.linkLabel17 = new System.Windows.Forms.LinkLabel();
			this.linkLabel16 = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel20 = new System.Windows.Forms.LinkLabel();
			this.linkLabel26 = new System.Windows.Forms.LinkLabel();
			this.linkLabel24 = new System.Windows.Forms.LinkLabel();
			this.linkLabel25 = new System.Windows.Forms.LinkLabel();
			this.linkLabel22 = new System.Windows.Forms.LinkLabel();
			this.linkLabel23 = new System.Windows.Forms.LinkLabel();
			this.linkLabel21 = new System.Windows.Forms.LinkLabel();
			this.linkLabel15 = new System.Windows.Forms.LinkLabel();
			this.linkLabel13 = new System.Windows.Forms.LinkLabel();
			this.linkLabel14 = new System.Windows.Forms.LinkLabel();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.linkLabel12 = new System.Windows.Forms.LinkLabel();
			this.linkLabel19 = new System.Windows.Forms.LinkLabel();
			this.linkLabel18 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();

			// 
			// linkLabel10
			// 
			this.linkLabel10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.linkLabel10.Location = new System.Drawing.Point(8, 200);
			this.linkLabel10.Name = "linkLabel10";
			this.linkLabel10.Size = new System.Drawing.Size(300, 16);
			this.linkLabel10.TabIndex = 2;
			this.linkLabel10.TabStop = true;
			this.linkLabel10.Text = "A normal LinkLabel - Font.Bold = true";
			this.linkLabel10.Links.Add (0,6, "http://www.novell.com");
			(this.linkLabel10.Links.Add (14,6, "http://www.ximian.com")).Enabled = false;
			this.linkLabel10.Links.Add (42,4, "http://www.mono-project.com");
			this.linkLabel10.Text = "Novell bought Ximian and now sponsors the Mono project";
			this.linkLabel10.LinkClicked += new LinkLabelLinkClickedEventHandler (linkLabel10Clicked);
			this.linkLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;

			// 
			// linkLabel8
			// 
			this.linkLabel8.BackColor = System.Drawing.Color.Red;
			this.linkLabel8.Location = new System.Drawing.Point(8, 152);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(280, 16);
			this.linkLabel8.TabIndex = 7;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "A normal LinkLabel - BackColor : Red";
			// 
			// linkLabel9
			// 
			this.linkLabel9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel9.Location = new System.Drawing.Point(8, 176);
			this.linkLabel9.Name = "linkLabel9";
			this.linkLabel9.Size = new System.Drawing.Size(280, 16);
			this.linkLabel9.TabIndex = 8;
			this.linkLabel9.TabStop = true;
			this.linkLabel9.Text = "A normal LinkLabel - Font : Times New Roman; 9pt";
			// 
			// linkLabel17
			// 
			this.linkLabel17.Location = new System.Drawing.Point(296, 128);
			this.linkLabel17.Name = "linkLabel17";
			this.linkLabel17.Size = new System.Drawing.Size(280, 16);
			this.linkLabel17.TabIndex = 16;
			this.linkLabel17.TabStop = true;
			this.linkLabel17.Text = "A normal LinkLabel - TextAlign = TopRight";
			this.linkLabel17.TextAlign = System.Drawing.ContentAlignment.TopRight;

			// 
			// linkLabel16
			// 
			this.linkLabel16.Location = new System.Drawing.Point(296, 104);
			this.linkLabel16.Name = "linkLabel16";
			this.linkLabel16.Size = new System.Drawing.Size(280, 16);
			this.linkLabel16.TabIndex = 15;
			this.linkLabel16.TabStop = true;
			this.linkLabel16.Text = "A normal LinkLabel - TextAlign = TopCenter";
			this.linkLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLabel4
			// 
			this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel4.Location = new System.Drawing.Point(8, 104);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(280, 16);
			this.linkLabel4.TabIndex = 3;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "A normal LinkLabel - LinkBehavior :  NeverUnderline";
			// 
			// linkLabel5
			// 
			this.linkLabel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.linkLabel5.Location = new System.Drawing.Point(0, 0);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(584, 16);
			this.linkLabel5.TabIndex = 4;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "A normal LinkLabel - Dock = Top";
			// 
			// linkLabel6
			// 
			this.linkLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.linkLabel6.Location = new System.Drawing.Point(0, 325);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(584, 16);
			this.linkLabel6.TabIndex = 5;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "A normal LinkLabel - Dock = Bottom";
			// 
			// linkLabel7
			// 
			this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.linkLabel7.Location = new System.Drawing.Point(8, 128);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(280, 16);
			this.linkLabel7.TabIndex = 6;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "A normal LinkLabel - ActiveLinkColor : 0;192;0 (Green)";
			// 
			// linkLabel2
			// 
			this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.linkLabel2.Location = new System.Drawing.Point(8, 56);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(280, 16);
			this.linkLabel2.TabIndex = 1;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "A normal LinkLabel - LinkBehavior : AlwaysUnderline";
			// 
			// linkLabel3
			// 
			this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel3.Location = new System.Drawing.Point(8, 80);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(280, 16);
			this.linkLabel3.TabIndex = 2;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "A normal LinkLabel - LinkBehavior : HoverUnderline";
			// 
			// linkLabel20
			// 
			this.linkLabel20.Location = new System.Drawing.Point(296, 200);
			this.linkLabel20.Name = "linkLabel20";
			this.linkLabel20.Size = new System.Drawing.Size(280, 16);
			this.linkLabel20.TabIndex = 19;
			this.linkLabel20.TabStop = true;
			this.linkLabel20.Text = "A normal LinkLabel - TextAlign = MiddleRight";
			this.linkLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel26
			// 
			this.linkLabel26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel26.Location = new System.Drawing.Point(296, 296);
			this.linkLabel26.Name = "linkLabel26";
			this.linkLabel26.Size = new System.Drawing.Size(280, 16);
			this.linkLabel26.TabIndex = 26;
			this.linkLabel26.TabStop = true;
			this.linkLabel26.Text = "A normal LinkLabel - Anchor : All";
			// 
			// linkLabel24
			// 
			this.linkLabel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.linkLabel24.Location = new System.Drawing.Point(8, 248);
			this.linkLabel24.Name = "linkLabel24";
			this.linkLabel24.Size = new System.Drawing.Size(280, 16);
			this.linkLabel24.TabIndex = 23;
			this.linkLabel24.TabStop = true;
			this.linkLabel24.Text = "A normal LinkLabel - BorderStyle : FixedSingle";
			// 
			// linkLabel25
			// 
			this.linkLabel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.linkLabel25.Location = new System.Drawing.Point(8, 272);
			this.linkLabel25.Name = "linkLabel25";
			this.linkLabel25.Size = new System.Drawing.Size(280, 16);
			this.linkLabel25.TabIndex = 24;
			this.linkLabel25.TabStop = true;
			this.linkLabel25.Text = "A normal LinkLabel - BorderStyle = Fixed3D";
			// 
			// linkLabel22
			// 
			this.linkLabel22.Location = new System.Drawing.Point(296, 248);
			this.linkLabel22.Name = "linkLabel22";
			this.linkLabel22.Size = new System.Drawing.Size(280, 16);
			this.linkLabel22.TabIndex = 21;
			this.linkLabel22.TabStop = true;
			this.linkLabel22.Text = "A normal LinkLabel - TextAlign = BottomCenter";
			this.linkLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel23
			// 
			this.linkLabel23.Location = new System.Drawing.Point(296, 272);
			this.linkLabel23.Name = "linkLabel23";
			this.linkLabel23.Size = new System.Drawing.Size(280, 16);
			this.linkLabel23.TabIndex = 22;
			this.linkLabel23.TabStop = true;
			this.linkLabel23.Text = "A normal LinkLabel - TextAlign = BottomRight";
			this.linkLabel23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// linkLabel21
			// 
			this.linkLabel21.Location = new System.Drawing.Point(296, 224);
			this.linkLabel21.Name = "linkLabel21";
			this.linkLabel21.Size = new System.Drawing.Size(280, 16);
			this.linkLabel21.TabIndex = 20;
			this.linkLabel21.TabStop = true;
			this.linkLabel21.Text = "A normal LinkLabel - TextAlign = BottomLeft";
			this.linkLabel21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// linkLabel15
			// 
			this.linkLabel15.LinkVisited = true;
			this.linkLabel15.Location = new System.Drawing.Point(296, 80);
			this.linkLabel15.Name = "linkLabel15";
			this.linkLabel15.Size = new System.Drawing.Size(280, 16);
			this.linkLabel15.TabIndex = 14;
			this.linkLabel15.TabStop = true;
			this.linkLabel15.Text = "A normal LinkLabel - LinkVisited = true";
			// 
			// linkLabel13
			// 
			this.linkLabel13.Location = new System.Drawing.Point(296, 32);
			this.linkLabel13.Name = "linkLabel13";
			this.linkLabel13.Size = new System.Drawing.Size(280, 16);
			this.linkLabel13.TabIndex = 12;
			this.linkLabel13.TabStop = true;
			this.linkLabel13.Text = "A normal LinkLabel - Font.Underline = true";
			// 
			// linkLabel14
			// 
			this.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.linkLabel14.Location = new System.Drawing.Point(296, 56);
			this.linkLabel14.Name = "linkLabel14";
			this.linkLabel14.Size = new System.Drawing.Size(280, 16);
			this.linkLabel14.TabIndex = 13;
			this.linkLabel14.TabStop = true;
			this.linkLabel14.Text = "A normal LinkLabel - LinkColor = 255; 128; 0";
			// 
			// linkLabel
			// 
			this.linkLabel.Location = new System.Drawing.Point(8, 32);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Size = new System.Drawing.Size(280, 16);
			this.linkLabel.TabIndex = 0;
			this.linkLabel.TabStop = true;
			this.linkLabel.Text = "A normal LinkLabel";
			// 
			// linkLabel12
			// 
			this.linkLabel12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.World);
			this.linkLabel12.Location = new System.Drawing.Point(8, 296);
			this.linkLabel12.Name = "linkLabel12";
			this.linkLabel12.Size = new System.Drawing.Size(280, 16);
			this.linkLabel12.TabIndex = 11;
			this.linkLabel12.TabStop = true;
			this.linkLabel12.Text = "A normal LinkLabel - Font.Strikeout = true";
			// 
			// linkLabel19
			// 
			this.linkLabel19.Location = new System.Drawing.Point(296, 176);
			this.linkLabel19.Name = "linkLabel19";
			this.linkLabel19.Size = new System.Drawing.Size(280, 16);
			this.linkLabel19.TabIndex = 18;
			this.linkLabel19.TabStop = true;
			this.linkLabel19.Text = "A normal LinkLabel - TextAlign = MiddleCenter";
			this.linkLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel18
			// 
			this.linkLabel18.Location = new System.Drawing.Point(296, 152);
			this.linkLabel18.Name = "linkLabel18";
			this.linkLabel18.Size = new System.Drawing.Size(280, 16);
			this.linkLabel18.TabIndex = 17;
			this.linkLabel18.TabStop = true;
			this.linkLabel18.Text = "A normal LinkLabel - TextAlign = MiddleLeft";
			this.linkLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			
			// 
			// linkLabel30
			// 
			LinkLabel linkLabel30 = new LinkLabel ();
			linkLabel30.Location = new System.Drawing.Point (600, 30);
			linkLabel30.Size = new System.Drawing.Size(280, 40);
			linkLabel30.Text = "Us\ners need not fear making the switch to Linux";
			linkLabel30.Links.Add (0,6, "http://link1");
			linkLabel30.Links.Add (32,6, "http://link2");
			linkLabel30.Links.Add (42,6, "http://www.linux.org");				
			Controls.Add (linkLabel30);
			
			// 
			// linkLabel31
			// 
			LinkLabel linkLabel31 = new LinkLabel ();
			linkLabel31.Location = new System.Drawing.Point (600, 90);
			linkLabel31.Size = new System.Drawing.Size(280, 16);
			linkLabel31.Text = "Users need not fear making the switch to Linux";
			linkLabel31.Links.Add (6,9, "http://link1");
			linkLabel31.Links.Add (31,6, "http://link2");
			linkLabel31.Links.Add (41,6, "http://www.linux.org");				
			linkLabel31.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			Controls.Add (linkLabel31);
			
			// 
			// linkLabel32
			// 
			LinkLabel linkLabel32 = new LinkLabel ();
			linkLabel32.Location = new System.Drawing.Point (600, 120);
			linkLabel32.Size = new System.Drawing.Size (250, 16);
			linkLabel32.Text = "Many Linux distros have Firefox or Mozilla";
			linkLabel32.Links.Add (5,5, "http://www.linux.org");
			linkLabel32.Links.Add (24,7, "http://www.firefox.com");
			LinkLabel.Link last_link = linkLabel32.Links.Add (35,7, "http://www.mozilla.org");
			linkLabel32.TextAlign = System.Drawing.ContentAlignment.TopRight;			
			Controls.Add (linkLabel32);
			
			// Some operations with Ilist
			IList ilist = linkLabel32.Links;
			ilist.Remove (last_link);			
			last_link.Start = 35;
			last_link.Length = 3;
			ilist.Add (last_link);
			
			

			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size (850, 341);
			this.Controls.Add(this.linkLabel26);
			this.Controls.Add(this.linkLabel25);
			this.Controls.Add(this.linkLabel24);
			this.Controls.Add(this.linkLabel23);
			this.Controls.Add(this.linkLabel22);
			this.Controls.Add(this.linkLabel21);
			this.Controls.Add(this.linkLabel20);
			this.Controls.Add(this.linkLabel19);
			this.Controls.Add(this.linkLabel18);			
			this.Controls.Add(this.linkLabel16);
			this.Controls.Add(this.linkLabel15);
			this.Controls.Add(this.linkLabel14);
			this.Controls.Add(this.linkLabel13);
			this.Controls.Add(this.linkLabel12);
			this.Controls.Add(this.linkLabel11);
			this.Controls.Add(this.linkLabel10);
			this.Controls.Add(this.linkLabel8);
			this.Controls.Add(this.linkLabel9);
			this.Controls.Add(this.linkLabel17);			
			this.Controls.Add(this.linkLabel7);
			this.Controls.Add(this.linkLabel6);
			this.Controls.Add(this.linkLabel5);
			this.Controls.Add(this.linkLabel4);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel);
			this.Name = "MainForm";
			this.Text = "This is my form";
			this.ResumeLayout(false);
		}
		
		private	void linkLabel10Clicked (object sender, LinkLabelLinkClickedEventArgs e)
		{
			Console.WriteLine ("LinkLabel10 Clicked Visited:{0} Enabled:{1} Start {2} Len {3}", e.Link.Visited, 
				e.Link.Enabled, e.Link.Start, e.Link.Length);
		}
		
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}			
}
