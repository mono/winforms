using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace MyFormProject
{
	public class MainForm : System.Windows.Forms.Form
	{
		static int	count;

		// Calendar
		private System.Windows.Forms.Button button1;

		public MainForm()
		{
			InitializeComponent();
			
		}

		private void InitializeComponent()
		{
			count = 0;

			this.button1 = new Button();

			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "label1";
			this.button1.Size = new System.Drawing.Size(472, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Click me for OK MessageBox";
			this.button1.Dock = DockStyle.Fill;
			this.button1.TextAlign = ContentAlignment.MiddleCenter;

			this.button1.Click +=new EventHandler(button1_Click);

			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 382);

			this.Controls.Add(this.button1);

			this.Name = "MainForm";
			this.Text = "SWF-MessageBox";
		}

		[STAThread]
		static void Main() 
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo( "de-DE", false );
			Application.Run(new MainForm());
		}

		private void button1_Click(object sender, EventArgs e) {
			DialogResult	result;

			switch (count) {
				case 0: {
					result = MessageBox.Show("Please click a button and verify that the proper result is reported in the main window.", "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.button1.Text = "Last result was " + result + "\nClick to get OK/Cancel MessageBox";
					break;
				}

				case 1: {
					result = MessageBox.Show("Please click a button and verify that the proper result is reported in the main window.", "MessageBox Test", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
					this.button1.Text = "Last result was " + result + "\nClick me for Yes/No MessageBox";
					break;
				}

				case 2: {
					result = MessageBox.Show("Please click a button and verify that the proper result is reported in the main window.", "MessageBox Test", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
					this.button1.Text = "Last result was " + result + "\nClick to exit the test application";
					break;
				}

				case 3: {
					result = MessageBox.Show("Please click a button and verify that the proper result is reported in the main window.", "MessageBox Test", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
					this.button1.Text = "Last result was " + result + "\nClick to exit the test application";
					break;
				}

				case 4: {
					result = MessageBox.Show("Please click a button and verify that the proper result is reported in the main window.", "MessageBox Test", MessageBoxButtons.AbortRetryIgnore);
					this.button1.Text = "Last result was " + result + "\nClick to exit the test application";
					break;
				}

				case 5: {
					Application.Exit();
					break;
				}
			}

			count++;
		}
	}
}
