
using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox13;
		private System.Windows.Forms.ListBox listBox12;
		private System.Windows.Forms.ListBox listBox11;
		private System.Windows.Forms.ListBox listBox10;
		private System.Windows.Forms.ListBox listBox17;
		private System.Windows.Forms.ListBox listBox16;
		private System.Windows.Forms.ListBox listBox15;
		private System.Windows.Forms.ListBox listBox14;
		private System.Windows.Forms.ListBox listBox6;
		private System.Windows.Forms.ListBox listBox7;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.ListBox listBox20;
		private System.Windows.Forms.ListBox listBox8;
		private System.Windows.Forms.ListBox listBox9;
		private System.Windows.Forms.ListBox listBox23;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox19;
		private System.Windows.Forms.ListBox listBox18;
		private System.Windows.Forms.ListBox listBox21;
		private System.Windows.Forms.ListBox listBox22;
		
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.listBox22 = new System.Windows.Forms.ListBox();
			this.listBox21 = new System.Windows.Forms.ListBox();
			this.listBox18 = new System.Windows.Forms.ListBox();
			this.listBox19 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox = new System.Windows.Forms.ListBox();
			this.listBox23 = new System.Windows.Forms.ListBox();
			this.listBox9 = new System.Windows.Forms.ListBox();
			this.listBox8 = new System.Windows.Forms.ListBox();
			this.listBox20 = new System.Windows.Forms.ListBox();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox7 = new System.Windows.Forms.ListBox();
			this.listBox6 = new System.Windows.Forms.ListBox();
			this.listBox14 = new System.Windows.Forms.ListBox();
			this.listBox15 = new System.Windows.Forms.ListBox();
			this.listBox16 = new System.Windows.Forms.ListBox();
			this.listBox17 = new System.Windows.Forms.ListBox();
			this.listBox10 = new System.Windows.Forms.ListBox();
			this.listBox11 = new System.Windows.Forms.ListBox();
			this.listBox12 = new System.Windows.Forms.ListBox();
			this.listBox13 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox22
			// 
			this.listBox22.ColumnWidth = 200;
			this.listBox22.Items.AddRange(new object[] {
						"A normal listbox",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox22.Location = new System.Drawing.Point(5, 390);
			this.listBox22.MultiColumn = true;
			this.listBox22.Name = "listBox22";
			this.listBox22.Size = new System.Drawing.Size(530, 30);
			this.listBox22.TabIndex = 22;
			// 
			// listBox21
			// 
			this.listBox21.HorizontalScrollbar = true;
			this.listBox21.Items.AddRange(new object[] {
						"A normal listbox - HorizontalScrollbar=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net",
						"This is a very long item to test the horizontal scrollbar"});
			this.listBox21.Location = new System.Drawing.Point(280, 280);
			this.listBox21.Name = "listBox21";
			this.listBox21.Size = new System.Drawing.Size(256, 43);
			this.listBox21.TabIndex = 20;
			// 
			// listBox18
			// 
			this.listBox18.ForeColor = System.Drawing.Color.Red;
			this.listBox18.Items.AddRange(new object[] {
						"A normal listbox - ForeColor=Red",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox18.Location = new System.Drawing.Point(280, 185);
			this.listBox18.Name = "listBox18";
			this.listBox18.Size = new System.Drawing.Size(256, 30);
			this.listBox18.TabIndex = 17;
			// 
			// listBox19
			// 
			this.listBox19.HorizontalScrollbar = true;
			this.listBox19.IntegralHeight = false;
			this.listBox19.Items.AddRange(new object[] {
						"A normal listbox - IntegralHeight=False ; HorizontalScrollbar=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net",
						"This is a very long item to test the horizontal scrollbar"});
			this.listBox19.Location = new System.Drawing.Point(280, 330);
			this.listBox19.Name = "listBox19";
			this.listBox19.Size = new System.Drawing.Size(256, 48);
			this.listBox19.TabIndex = 21;
			// 
			// listBox3
			// 
			this.listBox3.Items.AddRange(new object[] {
						"A normal listbox - SelectionMode=MultiExtended",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox3.Location = new System.Drawing.Point(5, 110);
			this.listBox3.Name = "listBox3";
			this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox3.Size = new System.Drawing.Size(256, 30);
			this.listBox3.TabIndex = 2;
			// 
			// listBox2
			// 
			this.listBox2.Items.AddRange(new object[] {
						"A normal listbox - SelectionMode=MultiSimple",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox2.Location = new System.Drawing.Point(5, 75);
			this.listBox2.Name = "listBox2";
			this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox2.Size = new System.Drawing.Size(256, 30);
			this.listBox2.TabIndex = 1;
			// 
			// listBox
			// 
			this.listBox.Items.AddRange(new object[] {
						"A normal listbox",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox.Location = new System.Drawing.Point(5, 40);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(256, 30);
			this.listBox.TabIndex = 0;
			// 
			// listBox23
			// 
			this.listBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox23.Items.AddRange(new object[] {
						"A normal listbox - Anchor=All",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox23.Location = new System.Drawing.Point(280, 425);
			this.listBox23.Name = "listBox23";
			this.listBox23.Size = new System.Drawing.Size(256, 30);
			this.listBox23.TabIndex = 24;
			// 
			// listBox9
			// 
			this.listBox9.BackColor = System.Drawing.Color.Red;
			this.listBox9.Items.AddRange(new object[] {
						"A normal listbox - BackColor=Red",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox9.Location = new System.Drawing.Point(5, 250);
			this.listBox9.Name = "listBox9";
			this.listBox9.Size = new System.Drawing.Size(256, 30);
			this.listBox9.TabIndex = 8;
			// 
			// listBox8
			// 
			this.listBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listBox8.Items.AddRange(new object[] {
						"A normal listbox - Dock=Bottom",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox8.Location = new System.Drawing.Point(0, 463);
			this.listBox8.Name = "listBox8";
			this.listBox8.Size = new System.Drawing.Size(544, 30);
			this.listBox8.TabIndex = 7;
			// 
			// listBox20
			// 
			this.listBox20.HorizontalScrollbar = true;
			this.listBox20.Items.AddRange(new object[] {
						"A normal listbox - HorizontalScrollbar=True ; ScrollAlwaysVisible=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox20.Location = new System.Drawing.Point(280, 220);
			this.listBox20.Name = "listBox20";
			this.listBox20.ScrollAlwaysVisible = true;
			this.listBox20.Size = new System.Drawing.Size(256, 56);
			this.listBox20.TabIndex = 19;
			// 
			// listBox5
			// 
			this.listBox5.Items.AddRange(new object[] {
						"A normal listbox - ScrollAlwaysVisible=True"});
			this.listBox5.Location = new System.Drawing.Point(5, 180);
			this.listBox5.Name = "listBox5";
			this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox5.Size = new System.Drawing.Size(256, 30);
			this.listBox5.TabIndex = 4;
			// 
			// listBox4
			// 
			this.listBox4.Items.AddRange(new object[] {
						"A normal listbox - ScrollAlwaysVisible=True"});
			this.listBox4.Location = new System.Drawing.Point(5, 145);
			this.listBox4.Name = "listBox4";
			this.listBox4.ScrollAlwaysVisible = true;
			this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox4.Size = new System.Drawing.Size(256, 30);
			this.listBox4.TabIndex = 3;
			// 
			// listBox7
			// 
			this.listBox7.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBox7.Items.AddRange(new object[] {
						"A normal listbox - Dock=Top",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox7.Location = new System.Drawing.Point(0, 0);
			this.listBox7.Name = "listBox7";
			this.listBox7.Size = new System.Drawing.Size(544, 30);
			this.listBox7.TabIndex = 6;
			// 
			// listBox6
			// 
			this.listBox6.Items.AddRange(new object[] {
						"A normal listbox - Sorted=True",
						"http://quicksql.sf.net",
						"http://www.go-mono.com",
						"http://www.got-mono.com"});
			this.listBox6.Location = new System.Drawing.Point(5, 215);
			this.listBox6.Name = "listBox6";
			this.listBox6.Size = new System.Drawing.Size(256, 30);
			this.listBox6.Sorted = true;
			this.listBox6.TabIndex = 5;
			// 
			// listBox14
			// 
			this.listBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox14.Items.AddRange(new object[] {
						"A normal listbox - Font.Strikeout=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox14.Location = new System.Drawing.Point(280, 40);
			this.listBox14.Name = "listBox14";
			this.listBox14.Size = new System.Drawing.Size(256, 30);
			this.listBox14.TabIndex = 13;
			// 
			// listBox15
			// 
			this.listBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox15.Items.AddRange(new object[] {
						"A normal listbox - Font.Underline=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox15.Location = new System.Drawing.Point(280, 75);
			this.listBox15.Name = "listBox15";
			this.listBox15.Size = new System.Drawing.Size(256, 30);
			this.listBox15.TabIndex = 14;
			// 
			// listBox16
			// 
			this.listBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox16.ItemHeight = 16;
			this.listBox16.Items.AddRange(new object[] {
						"A normal listbox - Font.Size=10",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox16.Location = new System.Drawing.Point(280, 110);
			this.listBox16.Name = "listBox16";
			this.listBox16.Size = new System.Drawing.Size(256, 36);
			this.listBox16.TabIndex = 15;
			// 
			// listBox17
			// 
			this.listBox17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox17.Items.AddRange(new object[] {
						"A normal listbox - Font=Verdana; 8,25pt",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox17.Location = new System.Drawing.Point(280, 150);
			this.listBox17.Name = "listBox17";
			this.listBox17.Size = new System.Drawing.Size(256, 30);
			this.listBox17.TabIndex = 16;
			// 
			// listBox10
			// 
			this.listBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox10.Items.AddRange(new object[] {
						"A normal listbox - BorderStyle=FixedSingle",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox10.Location = new System.Drawing.Point(5, 285);
			this.listBox10.Name = "listBox10";
			this.listBox10.Size = new System.Drawing.Size(256, 28);
			this.listBox10.TabIndex = 9;
			// 
			// listBox11
			// 
			this.listBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox11.Items.AddRange(new object[] {
						"A normal listbox - BorderStyle=None",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox11.Location = new System.Drawing.Point(5, 320);
			this.listBox11.Name = "listBox11";
			this.listBox11.Size = new System.Drawing.Size(256, 26);
			this.listBox11.TabIndex = 10;
			// 
			// listBox12
			// 
			this.listBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox12.Items.AddRange(new object[] {
						"A normal listbox - Font.Bold=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox12.Location = new System.Drawing.Point(5, 355);
			this.listBox12.Name = "listBox12";
			this.listBox12.Size = new System.Drawing.Size(256, 30);
			this.listBox12.TabIndex = 11;
			// 
			// listBox13
			// 
			this.listBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox13.Items.AddRange(new object[] {
						"A normal listbox - Font.Italic=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			this.listBox13.Location = new System.Drawing.Point(5, 425);
			this.listBox13.Name = "listBox13";
			this.listBox13.Size = new System.Drawing.Size(256, 30);
			this.listBox13.TabIndex = 12;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(544, 493);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
						this.listBox23,
						this.listBox22,
						this.listBox19,
						this.listBox21,
						this.listBox20,
						this.listBox18,
						this.listBox17,
						this.listBox16,
						this.listBox15,
						this.listBox14,
						this.listBox13,
						this.listBox12,
						this.listBox11,
						this.listBox10,
						this.listBox9,
						this.listBox8,
						this.listBox7,
						this.listBox6,
						this.listBox5,
						this.listBox4,
						this.listBox3,
						this.listBox2,
						this.listBox});
			this.Text = "SWF-Listboxes";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}			
}
