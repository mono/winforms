// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//
// CheckedListBox sample that shows the basic properties and display attributes
//

using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private CheckedListBox listBox13;
		private CheckedListBox listBox12;
		private CheckedListBox listBox11;
		private CheckedListBox listBox10;
		private CheckedListBox listBox17;
		private CheckedListBox listBox16;
		private CheckedListBox listBox15;
		private CheckedListBox listBox14;
		private CheckedListBox listBox6;
		private CheckedListBox listBox7;
		private CheckedListBox listBox4;
		private CheckedListBox listBox5;
		private CheckedListBox listBox20;
		private CheckedListBox listBox8;
		private CheckedListBox listBox9;
		private CheckedListBox listBox23;
		private CheckedListBox listBox;
		private CheckedListBox listBox2;
		private CheckedListBox listBox3;
		private CheckedListBox listBox19;
		private CheckedListBox listBox18;
		private CheckedListBox listBox21;
		private CheckedListBox listBox22;
		
		public MainForm()
		{
			InitializeComponent();
		}
	

		void InitializeComponent() 
		{
			listBox22 = new CheckedListBox ();
			listBox21 = new CheckedListBox ();
			listBox18 = new CheckedListBox ();
			listBox19 = new CheckedListBox ();
			listBox3 = new CheckedListBox ();
			listBox2 = new CheckedListBox ();
			listBox = new CheckedListBox ();
			listBox23 = new CheckedListBox ();
			listBox9 = new CheckedListBox ();
			listBox8 = new CheckedListBox ();
			listBox20 = new CheckedListBox ();
			listBox5 = new CheckedListBox ();
			listBox4 = new CheckedListBox ();
			listBox7 = new CheckedListBox ();
			listBox6 = new CheckedListBox ();
			listBox14 = new CheckedListBox ();
			listBox15 = new CheckedListBox ();
			listBox16 = new CheckedListBox ();
			listBox17 = new CheckedListBox ();
			listBox10 = new CheckedListBox ();
			listBox11 = new CheckedListBox ();
			listBox12 = new CheckedListBox ();
			listBox13 = new CheckedListBox ();
			SuspendLayout();
			// 
			// listBox22
			// 
			listBox22.ColumnWidth = 200;
			listBox22.Items.AddRange(new object[] {
						"A ThreeDCheckBoxes listbox",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox22.Location = new System.Drawing.Point(5, 390);
			listBox22.MultiColumn = true;
			listBox22.ThreeDCheckBoxes = true;
			listBox22.Name = "listBox22";
			listBox22.Size = new System.Drawing.Size(530, 80);
			listBox22.TabIndex = 22;
			
			// 
			// listBox21
			// 
			listBox21.HorizontalScrollbar = true;
			listBox21.Items.AddRange(new object[] {
						"A normal listbox - HorizontalScrollbar=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net",
						"This is a very long item to test the horizontal scrollbar"});
			listBox21.Location = new System.Drawing.Point(280, 280);
			listBox21.Name = "listBox21";
			listBox21.Size = new System.Drawing.Size(256, 43);
			listBox21.TabIndex = 20;
			// 
			// listBox18
			// 
			listBox18.ForeColor = System.Drawing.Color.Red;
			listBox18.Items.AddRange(new object[] {
						"A normal listbox - ForeColor=Red",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox18.Location = new System.Drawing.Point(280, 185);
			listBox18.Name = "listBox18";
			listBox18.Size = new System.Drawing.Size(256, 30);
			listBox18.TabIndex = 17;
			// 
			// listBox19
			// 
			listBox19.HorizontalScrollbar = true;
			listBox19.IntegralHeight = false;
			listBox19.Items.AddRange(new object[] {
						"A normal listbox - IntegralHeight=False ; HorizontalScrollbar=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net",
						"This is a very long item to test the horizontal scrollbar"});
			listBox19.Location = new System.Drawing.Point(280, 330);
			listBox19.Name = "listBox19";
			listBox19.Size = new System.Drawing.Size(256, 48);
			listBox19.TabIndex = 21;
			// 
			// listBox3
			// 
			listBox3.Items.AddRange(new object[] {
						"A normal listbox - SelectionMode=MultiExtended",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox3.Location = new System.Drawing.Point(5, 110);
			listBox3.Name = "listBox3";
			//listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			listBox3.Size = new System.Drawing.Size(256, 30);
			listBox3.TabIndex = 2;
			// 
			// listBox2
			// 
			listBox2.Items.AddRange(new object[] {
						"A normal listbox - SelectionMode=MultiSimple",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox2.Location = new System.Drawing.Point(5, 75);
			listBox2.Name = "listBox2";
			//listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			listBox2.Size = new System.Drawing.Size(256, 30);
			listBox2.TabIndex = 1;
			// 
			// listBox
			// 
			listBox.Items.AddRange(new object[] {
						"A normal listbox",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox.Location = new System.Drawing.Point(5, 40);
			listBox.Name = "listBox";
			listBox.Size = new System.Drawing.Size(256, 30);
			listBox.TabIndex = 0;
			// 
			// listBox23
			// 
			listBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			listBox23.Items.AddRange(new object[] {
						"A normal listbox - Anchor=All",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox23.Location = new System.Drawing.Point(280, 425);
			listBox23.Name = "listBox23";
			listBox23.Size = new System.Drawing.Size(256, 30);
			listBox23.TabIndex = 24;
			// 
			// listBox9
			// 
			listBox9.BackColor = System.Drawing.Color.Red;
			listBox9.Items.AddRange(new object[] {
						"A normal listbox - BackColor=Red",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox9.Location = new System.Drawing.Point(5, 250);
			listBox9.Name = "listBox9";
			listBox9.Size = new System.Drawing.Size(256, 30);
			listBox9.TabIndex = 8;
			// 
			// listBox8
			// 
			listBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
			listBox8.Items.AddRange(new object[] {
						"A normal listbox - Dock=Bottom",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox8.Location = new System.Drawing.Point(0, 463);
			listBox8.Name = "listBox8";
			listBox8.Size = new System.Drawing.Size(544, 30);
			listBox8.TabIndex = 7;
			// 
			// listBox20
			// 
			listBox20.HorizontalScrollbar = true;
			listBox20.Items.AddRange(new object[] {
						"A normal listbox - HorizontalScrollbar=True ; ScrollAlwaysVisible=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox20.Location = new System.Drawing.Point(280, 220);
			listBox20.Name = "listBox20";
			listBox20.ScrollAlwaysVisible = true;
			listBox20.Size = new System.Drawing.Size(256, 56);
			listBox20.TabIndex = 19;
			// 
			// listBox5
			// 
			listBox5.Items.AddRange(new object[] {
						"A normal listbox - ScrollAlwaysVisible=True"});
			listBox5.Location = new System.Drawing.Point(5, 180);
			listBox5.Name = "listBox5";
			//listBox5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			listBox5.Size = new System.Drawing.Size(256, 30);
			listBox5.TabIndex = 4;
			// 
			// listBox4
			// 
			listBox4.Items.AddRange(new object[] {
						"A normal listbox - ScrollAlwaysVisible=True"});
			listBox4.Location = new System.Drawing.Point(5, 145);
			listBox4.Name = "listBox4";
			listBox4.ScrollAlwaysVisible = true;
			//listBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			listBox4.Size = new System.Drawing.Size(256, 30);
			listBox4.TabIndex = 3;
			// 
			// listBox7
			// 
			listBox7.Dock = System.Windows.Forms.DockStyle.Top;
			listBox7.Items.AddRange(new object[] {
						"A normal listbox - Dock=Top",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox7.Location = new System.Drawing.Point(0, 0);
			listBox7.Name = "listBox7";
			listBox7.Size = new System.Drawing.Size(544, 30);
			listBox7.TabIndex = 6;
			// 
			// listBox6
			// 
			listBox6.Items.AddRange(new object[] {
						"A normal listbox - Sorted=True",
						"http://quicksql.sf.net",
						"http://www.go-mono.com",
						"http://www.got-mono.com"});
			listBox6.Location = new System.Drawing.Point(5, 215);
			listBox6.Name = "listBox6";
			listBox6.Size = new System.Drawing.Size(256, 30);
			listBox6.Sorted = true;
			listBox6.TabIndex = 5;
			// 
			// listBox14
			// 
			listBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox14.Items.AddRange(new object[] {
						"A normal listbox - Font.Strikeout=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox14.Location = new System.Drawing.Point(280, 40);
			listBox14.Name = "listBox14";
			listBox14.Size = new System.Drawing.Size(256, 30);
			listBox14.TabIndex = 13;
			// 
			// listBox15
			// 
			listBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox15.Items.AddRange(new object[] {
						"A normal listbox - Font.Underline=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox15.Location = new System.Drawing.Point(280, 75);
			listBox15.Name = "listBox15";
			listBox15.Size = new System.Drawing.Size(256, 30);
			listBox15.TabIndex = 14;
			// 
			// listBox16
			// 
			listBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox16.ItemHeight = 16;
			listBox16.Items.AddRange(new object[] {
						"A normal listbox - Font.Size=10",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox16.Location = new System.Drawing.Point(280, 110);
			listBox16.Name = "listBox16";
			listBox16.Size = new System.Drawing.Size(256, 36);
			listBox16.TabIndex = 15;
			// 
			// listBox17
			// 
			listBox17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox17.Items.AddRange(new object[] {
						"A normal listbox - Font=Verdana; 8,25pt",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox17.Location = new System.Drawing.Point(280, 150);
			listBox17.Name = "listBox17";
			listBox17.Size = new System.Drawing.Size(256, 30);
			listBox17.TabIndex = 16;
			// 
			// listBox10
			// 
			listBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			listBox10.Items.AddRange(new object[] {
						"A normal listbox - BorderStyle=FixedSingle",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox10.Location = new System.Drawing.Point(5, 285);
			listBox10.Name = "listBox10";
			listBox10.Size = new System.Drawing.Size(256, 28);
			listBox10.TabIndex = 9;
			// 
			// listBox11
			// 
			listBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			listBox11.Items.AddRange(new object[] {
						"A normal listbox - BorderStyle=None",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox11.Location = new System.Drawing.Point(5, 320);
			listBox11.Name = "listBox11";
			listBox11.Size = new System.Drawing.Size(256, 26);
			listBox11.TabIndex = 10;
			// 
			// listBox12
			// 
			listBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox12.Items.AddRange(new object[] {
						"A normal listbox - Font.Bold=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox12.Location = new System.Drawing.Point(5, 355);
			listBox12.Name = "listBox12";
			listBox12.Size = new System.Drawing.Size(256, 30);
			listBox12.TabIndex = 11;
			// 
			// listBox13
			// 
			listBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			listBox13.Items.AddRange(new object[] {
						"A normal listbox - Font.Italic=True",
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://quicksql.sf.net"});
			listBox13.Location = new System.Drawing.Point(5, 425);
			listBox13.Name = "listBox13";
			listBox13.Size = new System.Drawing.Size(256, 30);
			listBox13.TabIndex = 12;

			// 
			// MainForm
			// 
			ClientSize = new System.Drawing.Size(544, 493);
			Controls.AddRange(new System.Windows.Forms.Control[] {
						listBox23,
						listBox22,
						listBox19,
						listBox21,
						listBox20,
						listBox18,
						listBox17,
						listBox16,
						listBox15,
						listBox14,
						listBox13,
						listBox12,
						listBox11,
						listBox10,
						listBox9,
						listBox8,
						listBox7,
						listBox6,
						listBox5,
						listBox4,
						listBox3,
						listBox2,
						listBox});
			Text = "SWF-Listboxes";
			ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}			
}
