// project created on 7/08/2003 at 19:48
using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox15;
		private System.Windows.Forms.ComboBox comboBox14;
		private System.Windows.Forms.ComboBox comboBox17;
		private System.Windows.Forms.ComboBox comboBox16;
		private System.Windows.Forms.ComboBox comboBox11;
		private System.Windows.Forms.ComboBox comboBox10;
		private System.Windows.Forms.ComboBox comboBox13;
		private System.Windows.Forms.ComboBox comboBox12;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.comboBox12 = new System.Windows.Forms.ComboBox();
			this.comboBox13 = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.comboBox11 = new System.Windows.Forms.ComboBox();
			this.comboBox16 = new System.Windows.Forms.ComboBox();
			this.comboBox17 = new System.Windows.Forms.ComboBox();
			this.comboBox14 = new System.Windows.Forms.ComboBox();
			this.comboBox15 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox12
			// 
			this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox12.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox12.Location = new System.Drawing.Point(288, 112);
			this.comboBox12.Name = "comboBox12";
			this.comboBox12.Size = new System.Drawing.Size(248, 21);
			this.comboBox12.TabIndex = 12;
			this.comboBox12.Text = "A normal ComboBox - Font.Italic=True";
			// 
			// comboBox13
			// 
			this.comboBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox13.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox13.Location = new System.Drawing.Point(288, 144);
			this.comboBox13.Name = "comboBox13";
			this.comboBox13.Size = new System.Drawing.Size(248, 21);
			this.comboBox13.TabIndex = 13;
			this.comboBox13.Text = "A normal ComboBox - Font.Strikeout=True";
			// 
			// comboBox10
			// 
			this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox10.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox10.Location = new System.Drawing.Point(288, 48);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(248, 21);
			this.comboBox10.TabIndex = 9;
			// 
			// comboBox11
			// 
			this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox11.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox11.Location = new System.Drawing.Point(288, 80);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Size = new System.Drawing.Size(248, 21);
			this.comboBox11.TabIndex = 11;
			this.comboBox11.Text = "A normal ComboBox - Font.Bold=True";
			// 
			// comboBox16
			// 
			this.comboBox16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox16.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox16.Location = new System.Drawing.Point(288, 240);
			this.comboBox16.Name = "comboBox16";
			this.comboBox16.Size = new System.Drawing.Size(320, 24);
			this.comboBox16.TabIndex = 16;
			this.comboBox16.Text = "A normal ComboBox - Font=Verdana; 9,75pt";
			// 
			// comboBox17
			// 
			this.comboBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox17.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox17.Location = new System.Drawing.Point(8, 256);
			this.comboBox17.Name = "comboBox17";
			this.comboBox17.Size = new System.Drawing.Size(248, 21);
			this.comboBox17.TabIndex = 19;
			this.comboBox17.Text = "A normal ComboBox - Anchor=All";
			// 
			// comboBox14
			// 
			this.comboBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox14.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox14.Location = new System.Drawing.Point(288, 176);
			this.comboBox14.Name = "comboBox14";
			this.comboBox14.Size = new System.Drawing.Size(248, 21);
			this.comboBox14.TabIndex = 14;
			this.comboBox14.Text = "A normal ComboBox - Font.Underline=True";
			// 
			// comboBox15
			// 
			this.comboBox15.ForeColor = System.Drawing.Color.Red;
			this.comboBox15.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox15.Location = new System.Drawing.Point(288, 208);
			this.comboBox15.Name = "comboBox15";
			this.comboBox15.Size = new System.Drawing.Size(248, 21);
			this.comboBox15.TabIndex = 15;
			this.comboBox15.Text = "A normal ComboBox - Font.ForeColor=Red";
			// 
			// comboBox3
			// 
			this.comboBox3.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox3.Location = new System.Drawing.Point(8, 96);
			this.comboBox3.MaxDropDownItems = 2;
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(248, 21);
			this.comboBox3.TabIndex = 2;
			this.comboBox3.Text = "A normal ComboBox - MaxDropDownItems=2";
			// 
			// comboBox2
			// 
			this.comboBox2.Enabled = false;
			this.comboBox2.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox2.Location = new System.Drawing.Point(8, 64);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(248, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "A normal ComboBox - Enabled=False";
			// 
			// comboBox7
			// 
			this.comboBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.comboBox7.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox7.Location = new System.Drawing.Point(0, 288);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(624, 21);
			this.comboBox7.TabIndex = 6;
			this.comboBox7.Text = "A normal ComboBox";
			// 
			// comboBox6
			// 
			this.comboBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBox6.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox6.Location = new System.Drawing.Point(0, 0);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(624, 21);
			this.comboBox6.TabIndex = 5;
			this.comboBox6.Text = "A normal ComboBox";
			// 
			// comboBox5
			// 
			this.comboBox5.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox5.Location = new System.Drawing.Point(8, 160);
			this.comboBox5.MaxLength = 5;
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(248, 21);
			this.comboBox5.TabIndex = 4;
			this.comboBox5.Text = "A normal ComboBox - MaxLength=5";
			// 
			// comboBox4
			// 
			this.comboBox4.Items.AddRange(new object[] {
						"http://sourceforge.net/projects/luckyhands",
						"http://www.go-mono.com",
						"http://www.got-mono.com"});
			this.comboBox4.Location = new System.Drawing.Point(8, 128);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(248, 21);
			this.comboBox4.Sorted = true;
			this.comboBox4.TabIndex = 3;
			this.comboBox4.Text = "A normal ComboBox - Sorted=True";
			// 
			// comboBox
			// 
			this.comboBox.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox.Location = new System.Drawing.Point(8, 32);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(248, 21);
			this.comboBox.TabIndex = 0;
			this.comboBox.Text = "A normal ComboBox";
			// 
			// comboBox9
			// 
			this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBox9.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox9.Location = new System.Drawing.Point(8, 224);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(248, 21);
			this.comboBox9.TabIndex = 8;
			this.comboBox9.Text = "A normal ComboBox - DropDownStyle=Simple";
			// 
			// comboBox8
			// 
			this.comboBox8.BackColor = System.Drawing.Color.Red;
			this.comboBox8.Items.AddRange(new object[] {
						"http://www.go-mono.com",
						"http://www.got-mono.com",
						"http://sourceforge.net/projects/luckyhands"});
			this.comboBox8.Location = new System.Drawing.Point(8, 192);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(248, 21);
			this.comboBox8.TabIndex = 7;
			this.comboBox8.Text = "A normal ComboBox - BackColor=Red";
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label.Location = new System.Drawing.Point(288, 32);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(280, 16);
			this.label.TabIndex = 10;
			this.label.Text = "A normal ComboBox - DropDownStyle=DropDownList";
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(624, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
						this.comboBox17,
						this.comboBox16,
						this.comboBox15,
						this.comboBox14,
						this.comboBox13,
						this.comboBox12,
						this.comboBox11,
						this.label,
						this.comboBox10,
						this.comboBox9,
						this.comboBox8,
						this.comboBox7,
						this.comboBox6,
						this.comboBox5,
						this.comboBox4,
						this.comboBox3,
						this.comboBox2,
						this.comboBox});
			this.Text = "SWF-ComboBoxes";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}			
}
