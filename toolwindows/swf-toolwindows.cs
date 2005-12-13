
using System;
using System.Windows.Forms;


public class ToolWindowTest : Form {

	private bool sizable;
	private Button button;

	public ToolWindowTest ()
	{
		button = new Button ();
		button.Text = "Gimme a Sizable Tool Window";

		button.Dock = DockStyle.Fill;
		button.Click += new EventHandler (ClickHandler);

		Controls.Add (button);
	}

	public void ClickHandler (object sender, EventArgs e)
	{
		Form form = new Form ();
		form.Text = "tool window";
		if (sizable) {
			form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			button.Text = "Gimme a Fixed Tool Window";
		} else {
			form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			button.Text = "Gimme a Sizable Tool Window";
		}
		sizable = !sizable;
		
		form.Show ();
	}

	public static void Main ()
	{
		Application.Run (new ToolWindowTest ());
	}
}

