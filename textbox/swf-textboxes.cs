// SWF-TextBoxes, a sample SWF Application.
// Copyright (C) 2003 Timothy Parez (tpsoftware@users.sourceforge.net)
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox19;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox19
			// 
			this.textBox19.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox19.Location = new System.Drawing.Point(0, 0);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(627, 20);
			this.textBox19.TabIndex = 19;
			this.textBox19.Text = "A normal textbox - MS Sans Serif : Dock=Top";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(8, 95);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(608, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "A normal textbox - MS Sans Serif : BorderStyle=FixedSingle";
			// 
			// textBox20
			// 
			this.textBox20.Enabled = false;
			this.textBox20.Location = new System.Drawing.Point(10, 390);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(608, 20);
			this.textBox20.TabIndex = 20;
			this.textBox20.Text = "A normal textbox - MS Sans Serif : Enabled=false";
			// 
			// textBox18
			// 
			this.textBox18.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox18.Location = new System.Drawing.Point(0, 518);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(627, 20);
			this.textBox18.TabIndex = 18;
			this.textBox18.Text = "A normal textbox - MS Sans Serif : Dock=Bottom";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(8, 70);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(608, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "A normal textbox - MS Sans Serif : TextAlign=Center";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(608, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "A normal textbox - MS Sans Serif : TextAlign=Right";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Serifa BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(10, 190);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(608, 20);
			this.textBox6.TabIndex = 6;
			this.textBox6.Text = "A normal textbox - Serifa BT";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(8, 215);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(608, 20);
			this.textBox7.TabIndex = 7;
			this.textBox7.Text = "A normal textbox - MS Sans Serif : Font.Bold=true";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(8, 120);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox4.Size = new System.Drawing.Size(608, 40);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "A MultiLine textbox - MS Sans Serif : ScrollBars=Both, Height=40";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(10, 165);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(608, 21);
			this.textBox5.TabIndex = 5;
			this.textBox5.Text = "A normal textbox - Arial; 9pt";
			// 
			// textBox10
			// 
			this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
			this.textBox10.Location = new System.Drawing.Point(10, 290);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(608, 20);
			this.textBox10.TabIndex = 10;
			this.textBox10.Text = "A normal textbox - MS Sans Serif : Font.Underline=true";
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
			this.textBox8.Location = new System.Drawing.Point(10, 240);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(608, 20);
			this.textBox8.TabIndex = 8;
			this.textBox8.Text = "A normal textbox - MS Sans Serif : Font.Italic=true";
			// 
			// textBox9
			// 
			this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout);
			this.textBox9.Location = new System.Drawing.Point(10, 265);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(608, 20);
			this.textBox9.TabIndex = 9;
			this.textBox9.Text = "A normal textbox - MS Sans Serif : Font.StrikeOut=true";
			// 
			// textBox13
			// 
			this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.textBox13.Location = new System.Drawing.Point(10, 365);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(608, 20);
			this.textBox13.TabIndex = 13;
			this.textBox13.Text = "A normal textbox - MS Sans Serif : ReadOnly=true";
			// 
			// textBox12
			// 
			this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.textBox12.Location = new System.Drawing.Point(10, 340);
			this.textBox12.Name = "textBox12";
			this.textBox12.PasswordChar = '*';
			this.textBox12.Size = new System.Drawing.Size(608, 20);
			this.textBox12.TabIndex = 12;
			this.textBox12.Text = "A normal textbox - MS Sans Serif : PasswordChar=*";
			// 
			// textBox11
			// 
			this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.textBox11.ForeColor = System.Drawing.Color.Red;
			this.textBox11.Location = new System.Drawing.Point(10, 315);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(608, 20);
			this.textBox11.TabIndex = 11;
			this.textBox11.Text = "A normal textbox - MS Sans Serif : ForeColor=red";
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(8, 25);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(608, 20);
			this.textBox.TabIndex = 1;
			this.textBox.Text = "A normal textbox - MS Sans Serif";
			// 
			// textBox17
			// 
			this.textBox17.AcceptsTab = true;
			this.textBox17.Location = new System.Drawing.Point(10, 490);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(608, 20);
			this.textBox17.TabIndex = 17;
			this.textBox17.Text = "A normal textbox - MS Sans Serif : AllowTab=true";
			// 
			// textBox16
			// 
			this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox16.Location = new System.Drawing.Point(10, 465);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(610, 20);
			this.textBox16.TabIndex = 16;
			this.textBox16.Text = "A normal textbox - MS Sans Serif : Anchor=All";
			// 
			// textBox15
			// 
			this.textBox15.BackColor = System.Drawing.Color.Red;
			this.textBox15.Location = new System.Drawing.Point(10, 440);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(608, 20);
			this.textBox15.TabIndex = 15;
			this.textBox15.Text = "A normal textbox - MS Sans Serif : BackColor=Red";
			// 
			// textBox14
			// 
			this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.textBox14.Location = new System.Drawing.Point(10, 415);
			this.textBox14.MaxLength = 50;
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(608, 20);
			this.textBox14.TabIndex = 14;
			this.textBox14.Text = "A normal textbox - MS Sans Serif : MaxLength=50";
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(627, 538);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
						this.textBox20,
						this.textBox19,
						this.textBox18,
						this.textBox17,
						this.textBox16,
						this.textBox15,
						this.textBox14,
						this.textBox13,
						this.textBox12,
						this.textBox11,
						this.textBox10,
						this.textBox9,
						this.textBox8,
						this.textBox7,
						this.textBox6,
						this.textBox5,
						this.textBox4,
						this.textBox3,
						this.textBox2,
						this.textBox,
						this.textBox1});
			this.Text = "SWF-Textboxes";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}			
}
