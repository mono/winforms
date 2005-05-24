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
			this.button1.Text = "Click me for ShowHelp(parent, url)";
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
			this.Text = "SWF-Help";
		}

		[STAThread]
		static void Main() 
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo( "de-DE", false );
			Application.Run(new MainForm());
		}

		private void button1_Click(object sender, EventArgs e) {
			switch (count) {
				case 0: {
					Help.ShowHelp(this, "swf-help.chm");
					this.button1.Text = "Click me for ShowHelp(parent, url, HelpNavigator.KeywordIndex, \"Page 2\")";
					break;
				}

				case 1: {
					Help.ShowHelp(this, "swf-help.chm", HelpNavigator.KeywordIndex, "Page 2");
					this.button1.Text = "Click me for ShowHelp(parent, url, HelpNavigator.Keyword, \"swf-help.chm::/page1.htm\")";
					break;
				}

				case 2: {
					Help.ShowHelp(this, "swf-help.chm", HelpNavigator.Topic, "swf-help.chm::/page1.htm");
					this.button1.Text = "Click me for ShowHelp(parent, url, \"swf-help.chm::/topic1\"";
					break;
				}

				case 3: {
					Help.ShowHelp(this, "swf-help.chm", "swf-help.chm::/topic1");
					this.button1.Text = "Click me for ShowHelpIndex(parent, url)";
					break;
				}

				case 4: {
					Help.ShowHelpIndex(this, "swf-help.chm");
					this.button1.Text = "Click me for ShowHelpPopup(parent, url, Control.MousePosition)";
					break;
				}

				case 5: {
					Help.ShowPopup(this, "swf-help.chm", Control.MousePosition);
					this.button1.Text = "Click me to exit";
					break;
				}

				case 6: {
					Application.Exit();
					break;
				}
			}

			count++;
		}
	}
}
