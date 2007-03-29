using System;
using System.Drawing;
using System.Windows.Forms;

class TestForm : Form 
{
    static void Main() 
    {
        Application.Run(new TestForm());
    }
    
    NotifyIcon notify_icon;
    
    public TestForm() {
    	notify_icon = new NotifyIcon();
		notify_icon.Icon = Icon;
		notify_icon.Text = "NotifyIcon Text";
		notify_icon.BalloonTipTitle = "Balloon Tip Title";
		notify_icon.BalloonTipText = "Mono has both an optimizing just-in-time (JIT) runtime and a interpreter runtime. The interpreter runtime is far less complex and is primarly used in the early stages before a JIT version for that architecture is constructed. The interpreter is not supported on architectures where the JIT has been ported.";
		notify_icon.BalloonTipIcon = ToolTipIcon.Error;
		notify_icon.Visible = true;
		
		notify_icon.BalloonTipClicked += new EventHandler (TestForm_BalloonTipClicked);
		notify_icon.BalloonTipClosed += new EventHandler (TestForm_BalloonTipClosed);
		notify_icon.BalloonTipShown += new EventHandler (TestForm_BalloonTipShown);

		Button btnicon = new Button ();
		btnicon.Text = "Show/Hide Icon";
		btnicon.Top = 30;
		btnicon.Width = 120;
		btnicon.Left = (Width - btnicon.Width) / 2;
		btnicon.Click += new EventHandler (btnicon_Click);
		Controls.Add (btnicon);

		Button btnballoon = new Button ();
		btnballoon.Text = "Show Balloon";
		btnballoon.Top = 60;
		btnballoon.Left = btnicon.Left;
		btnballoon.Width = btnicon.Width;
		btnballoon.Click += new EventHandler (btnballoon_Click);
		Controls.Add (btnballoon);

		Text = "NotifyIcon Balloon Sample";
		StartPosition = FormStartPosition.CenterScreen;
    }
    
	private void btnicon_Click (object sender, EventArgs e) 
	{
		notify_icon.Visible = ! notify_icon.Visible;
	}

	private void btnballoon_Click (object sender, EventArgs e) 
	{
		notify_icon.Visible = true;
		notify_icon.ShowBalloonTip (1000);
	}
	
	private void TestForm_BalloonTipClicked (object sender, EventArgs e)
	{
		Console.WriteLine ("Clicked");
	}
	
	private void TestForm_BalloonTipClosed (object sender, EventArgs e)
	{
		Console.WriteLine ("Closed");
	}
	
	private void TestForm_BalloonTipShown (object sender, EventArgs e)
	{
		Console.WriteLine ("Show");
	}
}
