
using System;
using System.Windows.Forms;

public class SetPosTest : Form {

	private NumericUpDown left_pos;
	private NumericUpDown top_pos;
	private Form tool_window;
	
	public SetPosTest ()
	{
		left_pos = new NumericUpDown ();
		top_pos = new NumericUpDown ();

		tool_window = new Form ();
		tool_window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		tool_window.LocationChanged += new EventHandler (ToolWindowLocationChanged);

		Label xlabel = new Label ();
		xlabel.Text = "Left:";
		Label ylabel = new Label ();
		ylabel.Text = "Top:";

		xlabel.Width = 45;
		ylabel.Width = 45;

		xlabel.Left = 10;
		left_pos.Left = 55;
		ylabel.Left = 10;
		top_pos.Left = 55;
		ylabel.Top = left_pos.Bottom + 25;
		top_pos.Top = left_pos.Bottom + 25;

		left_pos.Minimum = top_pos.Minimum = Int32.MinValue;
		left_pos.Maximum = top_pos.Maximum = Int32.MaxValue;

		left_pos.ValueChanged += new EventHandler (LeftPosChanged);
		top_pos.ValueChanged += new EventHandler (TopPosChanged);

		Controls.Add (xlabel);
		Controls.Add (ylabel);
		Controls.Add (left_pos);
		Controls.Add (top_pos);

		tool_window.Show ();
	}

	private void LeftPosChanged (object sender, EventArgs e)
	{
		tool_window.Left = (int) left_pos.Value;
	}

	private void TopPosChanged (object sender, EventArgs e)
	{
		tool_window.Top = (int) top_pos.Value;
	}

	private void ToolWindowLocationChanged (object sender, EventArgs e)
	{
//		left_pos.Value = tool_window.Left;
//		top_pos.Value = tool_window.Top;
	}

	public static void Main ()
	{
		Application.Run (new SetPosTest ());
	}
}

