using System;
using System.Windows.Forms;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		// Calendar
		private System.Windows.Forms.MonthCalendar monthcal1;

		private System.Windows.Forms.Label label1;

		public MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.monthcal1 = new System.Windows.Forms.MonthCalendar();

			this.label1 = new System.Windows.Forms.Label();
			// 
			// monthcal1
			// 
			this.monthcal1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			this.monthcal1.Location = new System.Drawing.Point(0, 25);
			this.monthcal1.Name = "monthcalendar1";
			this.monthcal1.TabIndex = 1;

			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "MonthCalendar";

			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 382);

			this.Controls.Add(this.monthcal1);
			this.Controls.Add(this.label1);

			this.Name = "MainForm";
			this.Text = "SWF-MonthCalendar";
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
	}
}
