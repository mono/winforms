using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		static int		count;
		private DomainUpDown	upDown1;
		private DomainUpDown	upDown2;
		private DomainUpDown	upDown1ro;
		private DomainUpDown	upDown2ro;
		private string		upDownString1 = "Test 1";
		private string		upDownString2 = "Test 2";
		private string		upDownString3 = "Test 3";
		private string		upDownString4 = "Test 4";
		private NumericUpDown	upDown3;
		private NumericUpDown	upDown4;
		private NumericUpDown	upDown3ro;
		private NumericUpDown	upDown4ro;

		// Calendar
		private System.Windows.Forms.Button updown1;

		public MainForm()
		{
			InitializeComponent();
			
		}

		private void InitializeComponent()
		{
			count = 0;

			upDown1 = new DomainUpDown();	
			upDown1.Location = new Point(10, 10);
			upDown2 = new DomainUpDown();	
			upDown2.Location = new Point(10, 50);
			upDown2.UpDownAlign = LeftRightAlignment.Left;
			upDown3 = new NumericUpDown();	

			upDown3.Location = new Point(10, 90);
			upDown3.Value = 3m;
			upDown3.Increment = 0.3m;
			upDown3.DecimalPlaces = 0;
			upDown3.ValueChanged += new EventHandler(MainForm_ValueChanged);
			upDown3.Visible = false;

			upDown4 = new NumericUpDown();	
			upDown4.Location = new Point(10, 130);
			upDown4.UpDownAlign = LeftRightAlignment.Left;

			upDown1ro = new DomainUpDown();	
			upDown1ro.Location = new Point(150, 10);
			upDown1ro.ReadOnly = true;
			upDown2ro = new DomainUpDown();	
			upDown2ro.Location = new Point(150, 50);
			upDown2ro.UpDownAlign = LeftRightAlignment.Left;
			upDown2ro.ReadOnly = true;
			upDown3ro = new NumericUpDown();	
			upDown3ro.Location = new Point(150, 90);
			upDown3ro.ReadOnly = true;
			upDown4ro = new NumericUpDown();	
			upDown4ro.Location = new Point(150, 130);
			upDown4ro.UpDownAlign = LeftRightAlignment.Left;
			upDown4ro.ReadOnly = true;

			upDown1.TabIndex  = 0;
			upDown2.TabIndex  = 1;
			upDown3.TabIndex  = 2;
			upDown4.TabIndex  = 2;
			upDown1ro.TabIndex  = 3;
			upDown2ro.TabIndex  = 4;
			upDown3ro.TabIndex  = 5;
			upDown4ro.TabIndex  = 6;

			this.Controls.AddRange(new Control[] {upDown1, upDown1ro, upDown2, upDown2ro
								  , upDown3, upDown3ro, upDown4, upDown4ro});
			upDown1.Items.Add(upDownString1);
			upDown1.Items.Add(upDownString2);
			upDown1.Items.Add(upDownString3);
			upDown1.Items.Add(upDownString4);
			upDown2.Items.Add(upDownString1);
			upDown2.Items.Add(upDownString2);
			upDown2.Items.Add(upDownString3);
			upDown2.Items.Add(upDownString4);
			upDown1ro.Items.Add(upDownString1);
			upDown1ro.Items.Add(upDownString2);
			upDown1ro.Items.Add(upDownString3);
			upDown1ro.Items.Add(upDownString4);
			upDown2ro.Items.Add(upDownString1);
			upDown2ro.Items.Add(upDownString2);
			upDown2ro.Items.Add(upDownString3);
			upDown2ro.Items.Add(upDownString4);

			Console.WriteLine("upDown1.ToString: {0}", upDown1.ToString());
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(472, 382);

			this.Name = "MainForm";
			this.Text = "SWF-UpDown";
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		void MainForm_ValueChanged(object sender, EventArgs e) {
			Console.WriteLine("value changed {0}", upDown3.Value);
			upDown3.Visible = true;
		}
	}
}
