using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		// Calendar
		private System.Windows.Forms.MonthCalendar monthcal1;
		private System.Windows.Forms.MonthCalendar monthcal2;
		private System.Windows.Forms.MonthCalendar monthcal3;

		private System.Windows.Forms.Label label1;

		public MainForm()
		{
			InitializeComponent();
			
			// set up some bolded dates
			monthcal1.BoldedDates = new DateTime [] {DateTime.Now, DateTime.Now.AddDays (2)};
			monthcal2.AddMonthlyBoldedDate (DateTime.Now);
			monthcal2.AddMonthlyBoldedDate (DateTime.Now.AddDays (2));
			monthcal2.AddMonthlyBoldedDate (DateTime.Now.AddDays (5));
			monthcal2.UpdateBoldedDates();
			
			monthcal3.AddAnnuallyBoldedDate (DateTime.Now.AddDays (-2));
			monthcal3.AddAnnuallyBoldedDate (DateTime.Now.AddDays (-5));
			monthcal3.UpdateBoldedDates();
			monthcal2.RemoveMonthlyBoldedDate (DateTime.Now.AddDays (2));
			monthcal2.UpdateBoldedDates();
			
			// test the scroll change property
			monthcal2.ScrollChange = 2;
		}

		private void InitializeComponent()
		{
			this.monthcal1 = new System.Windows.Forms.MonthCalendar();
			this.monthcal2 = new System.Windows.Forms.MonthCalendar();
			this.monthcal3 = new System.Windows.Forms.MonthCalendar();

			this.label1 = new System.Windows.Forms.Label();
			// 
			// monthcal1
			// 
			this.monthcal1.CalendarDimensions = new Size(1, 1);
			this.monthcal1.SelectionStart = new DateTime (2004, 11, 10);
			this.monthcal1.SelectionEnd = new DateTime (2004, 11, 13);
			this.monthcal1.FirstDayOfWeek = Day.Monday;
			this.monthcal1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			this.monthcal1.Location = new System.Drawing.Point(0, 25);
			this.monthcal1.Name = "monthcalendar1";
			this.monthcal1.TabIndex = 1;

			this.monthcal2.ShowWeekNumbers = true;
			this.monthcal2.ShowToday = false;
			this.monthcal2.CalendarDimensions = new Size(3, 1);
			this.monthcal2.SelectionStart = new DateTime (2004, 11, 10);
			this.monthcal2.SelectionEnd = new DateTime (2004, 11, 13);
			this.monthcal2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			this.monthcal2.Location = new System.Drawing.Point(0, 230);
			this.monthcal2.Name = "monthcalendar2";
			this.monthcal2.TabIndex = 2;
			this.monthcal2.MaxSelectionCount = 200;


//			this.monthcal3.ShowWeekNumbers = true;
			this.monthcal3.ShowTodayCircle = false;			
			this.monthcal3.CalendarDimensions = new Size(2, 1);
			this.monthcal3.SelectionStart = new DateTime (2004, 11, 10);
			this.monthcal3.SelectionEnd = new DateTime (2004, 11, 13);
			this.monthcal3.FirstDayOfWeek = Day.Wednesday;
			this.monthcal3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			this.monthcal3.Location = new System.Drawing.Point(0, 460);
			this.monthcal3.Name = "monthcalendar3";
			this.monthcal3.TabIndex = 3;
			this.monthcal1.ShowWeekNumbers = true;


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
			this.Controls.Add(this.monthcal2);
			this.Controls.Add(this.monthcal3);
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
