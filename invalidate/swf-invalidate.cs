
using System;
using System.Drawing;
using System.Windows.Forms;



public class InvalidateForm : Form {

	private Timer timer;
	private int width;
	private bool region;

	public InvalidateForm ()
	{
		timer = new Timer ();
		timer.Interval = 500;
		timer.Tick += new EventHandler (TimerTick);
		timer.Enabled = true;

		BackColor = Color.Blue;

		Paint += new PaintEventHandler (PaintHandler);
		Click += new EventHandler (ClickHandler);
	}

	private void TimerTick (object sender, EventArgs e)
	{
		width += 10;
		if (width > Width + 11) {
			width = 0;
			Refresh ();
			region = !region;
			return;
		}

		if (!region) {
			Invalidate (new Rectangle (0, 0, width, Height));
		} else {
			int half = width / 2;
			int xmiddle = Width / 2;
			int ymiddle = Height / 2;
			Rectangle rect = new Rectangle (xmiddle - half, ymiddle - half, width, width);
			Invalidate (new Region (rect));
		}
	}

	private void ClickHandler (object sender, EventArgs e)
	{
		timer.Enabled = !timer.Enabled;
	}

	private void PaintHandler (object sender, PaintEventArgs pe)
	{
		if (pe.ClipRectangle.Width == Width && pe.ClipRectangle.Height == Height) {
			Console.WriteLine ("Clearing Form");
			pe.Graphics.FillRectangle (new SolidBrush (BackColor), pe.ClipRectangle);
			return;
		}
			
		Console.WriteLine ("Filling:  " + pe.ClipRectangle);
		pe.Graphics.FillRectangle (new SolidBrush (Color.Red), pe.ClipRectangle);
	}

	public static void Main ()
	{
		Application.Run (new InvalidateForm ());
	}
}

