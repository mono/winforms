using System;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ProgressBar progressBar9;
		private System.Windows.Forms.ProgressBar progressBar8;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;		
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar7;
		private System.Windows.Forms.ProgressBar progressBar6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar6 = new System.Windows.Forms.ProgressBar();
			this.progressBar7 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.button = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();			
			this.progressBar8 = new System.Windows.Forms.ProgressBar();
			this.progressBar9 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(5, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(415, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Moving ProgressBar - Minimum = 0 ; Maximum = 100 ; Step = 10";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(5, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(415, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Moving ProgressBar - Minimum = 0 ; Maximum = 100 ; Step = 15";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(5, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(415, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Moving ProgressBar - Minimum = 0 ; Maximum = 50 ; Step = 10";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 310);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(415, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Moving ProgressBar - Minimum = 0 ; Maximum = 50 ; Step = 10 ; Anchor = All";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(5, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(415, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "ProgressBar - Minimum = 0 ; Maximum = 100 ; Step = 10 ; Value = 35";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(415, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "ProgressBar - Minimum = 0 ; Maximum = 100 ; Height = 30 ";
			// 
			// progressBar6
			// 
			this.progressBar6.Location = new System.Drawing.Point(5, 280);
			this.progressBar6.Name = "progressBar6";
			this.progressBar6.Size = new System.Drawing.Size(415, 20);
			this.progressBar6.TabIndex = 10;
			// 
			// progressBar7
			// 
			this.progressBar7.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBar7.Location = new System.Drawing.Point(0, 0);
			this.progressBar7.Name = "progressBar7";
			this.progressBar7.Size = new System.Drawing.Size(504, 20);
			this.progressBar7.TabIndex = 12;
			this.progressBar7.Value = 50;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(5, 190);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(415, 20);
			this.progressBar4.TabIndex = 7;
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(5, 235);
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(415, 20);
			this.progressBar5.Step = 15;
			this.progressBar5.TabIndex = 8;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(5, 95);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(415, 20);
			this.progressBar2.TabIndex = 3;
			this.progressBar2.Value = 35;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(5, 135);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(415, 30);
			this.progressBar3.TabIndex = 5;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(425, 170);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(75, 25);
			this.button.TabIndex = 17;
			this.button.Text = "Start Timer";
			this.button.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button 3
			// 
			this.button3.Location = new System.Drawing.Point(425, 30);
			this.button3.Name = "button";
			this.button3.Size = new System.Drawing.Size(75, 25);			
			this.button3.Text = "Inc. 1";
			this.button3.Click += new System.EventHandler(this.Button3Click);
			
			// 
			// button 4
			// 
			this.button4.Location = new System.Drawing.Point(425, 60);
			this.button4.Name = "button";
			this.button4.Size = new System.Drawing.Size(75, 25);			
			this.button4.Text = "Dec. 1";
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button 5
			// 
			this.button5.Location = new System.Drawing.Point(425, 90);
			this.button5.Name = "button";
			this.button5.Size = new System.Drawing.Size(75, 25);			
			this.button5.Text = "Inc. Step";
			this.button5.Click += new System.EventHandler(this.Button5Click);
			
			
			// 
			// progressBar8
			// 
			this.progressBar8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar8.Location = new System.Drawing.Point(0, 355);
			this.progressBar8.Name = "progressBar8";
			this.progressBar8.Size = new System.Drawing.Size(504, 23);
			this.progressBar8.TabIndex = 13;
			this.progressBar8.Value = 50;
			// 
			// progressBar9
			// 
			this.progressBar9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar9.Location = new System.Drawing.Point(5, 325);
			this.progressBar9.Name = "progressBar9";
			this.progressBar9.Size = new System.Drawing.Size(415, 20);
			this.progressBar9.TabIndex = 16;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(425, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 20);
			this.button2.TabIndex = 18;
			this.button2.Text = "Stop Timer";
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// timer
			// 
			this.timer.Interval = 200;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(5, 50);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(415, 20);
			this.progressBar.TabIndex = 0;
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(5, 35);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(415, 15);
			this.label.TabIndex = 1;
			this.label.Text = "ProgressBar - Minimum = 0 ; Maximum = 100 ; Step = 10";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(504, 378);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.progressBar9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.progressBar8);
			this.Controls.Add(this.progressBar7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.progressBar6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.progressBar5);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label);
			this.Controls.Add(this.progressBar);
			this.Name = "MainForm";
			this.Text = "swf-scrollbars";
			this.ResumeLayout(false);
		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		void TimerTick(object sender, System.EventArgs e)
		{
			/* We just handle every progressBar one by one, 
			 * there are better solutions of course */
			 			 
			  progressBar4.Value = (progressBar4.Value < progressBar4.Maximum ? progressBar4.Value + 1 : 0);
			  progressBar5.Value = (progressBar5.Value < progressBar5.Maximum ? progressBar5.Value + 1 : 0);
			  progressBar6.Value = (progressBar6.Value < progressBar6.Maximum ? progressBar6.Value + 1 : 0);
			  progressBar9.Value = (progressBar9.Value < progressBar9.Maximum ? progressBar4.Value + 1 : 0);			
		}
		
		void ButtonClick(object sender, System.EventArgs e)
		{ 			
			this.timer.Enabled = true;
		}
		
		void Button2Click(object sender, System.EventArgs e)
		{			
			this.timer.Enabled = false;
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{			
			progressBar.Increment (1);						
		}
		
		void Button4Click(object sender, System.EventArgs e)
		{			
			progressBar.Value = progressBar.Value - 1;						
		}
		
		void Button5Click(object sender, System.EventArgs e)
		{			
			progressBar.PerformStep ();						
		}
		
	}			
}
