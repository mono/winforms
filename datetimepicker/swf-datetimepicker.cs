using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		// datetimepicker
		private System.Windows.Forms.DateTimePicker dtp1;
		private System.Windows.Forms.DateTimePicker dtp2;

		private System.Windows.Forms.Label label1;

		public MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();


			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DateTimePicker";

			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 382);

			this.dtp1 = new System.Windows.Forms.DateTimePicker();
			this.dtp1.Location = new System.Drawing.Point(10, 50);
			this.dtp1.Name = "dtp1";
			this.dtp1.TabIndex = 1;
			
			this.dtp2 = new System.Windows.Forms.DateTimePicker();
			this.dtp2.Location = new System.Drawing.Point(10, 150);
			this.dtp2.Name = "dtp2";
			this.dtp2.DropDownAlign = LeftRightAlignment.Right;
			this.dtp2.TabIndex = 2;

			this.Controls.Add(this.dtp1);
			this.Controls.Add(this.dtp2);
			this.Controls.Add(this.label1);
			

			this.Name = "MainForm";
			this.Text = "SWF-DateTimePicker";
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
			MessageBox.Show("hello world");
		}
	}
}
