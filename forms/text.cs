
using System.Windows.Forms;
using System;

public class Foo {
  static Form f;
  
  public static void button_clicked (object sender, EventArgs ea) {
    if (f.Text == "")
	f.Text = "hi there!";
    else
	f.Text = "";
  }

  public static void Main (string[] args) {
    f = new Form ();
    Button b = new Button ();
    b.Text = "Click me to toggle title";
    b.Click += new EventHandler (button_clicked); 
    //f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    f.Controls.Add (b);
    f.ControlBox = false;
    f.MaximizeBox = false;
    f.MinimizeBox = false;
    f.Name = "";
    f.Text = "";

    Application.Run (f);
  }
}
