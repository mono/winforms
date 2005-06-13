using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFormProject
{
        class MainForm : System.Windows.Forms.Form
        {

                public MainForm()
                {

                        Icon icon;

                        icon = new Icon("notify.ico");
                        this.Icon = icon;
                }

                [STAThread]
                public static void Main(string[] args)
                {
                        Application.Run(new MainForm());
                }
	}
}
