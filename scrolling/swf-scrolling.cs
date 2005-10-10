//
// Simple test of our scrolling behavoir
//
// Author(s):
//  Jackson Harper
//
// Copyright (c) 2005 Novell, Inc.
// 


using System;
using System.Drawing;
using System.Windows.Forms;


public class ScrollingTest : Form {

	private ScrollableControl scrollable;
	private int paint_count;
	private Button paint_count_button;
	
	public ScrollingTest ()
	{
		paint_count_button = new Button ();
		paint_count_button.Text = "Print Paint Count (stdout)";
		paint_count_button.Dock = DockStyle.Bottom;
		paint_count_button.Click += new EventHandler (PrintPaintCount);
		
		scrollable = new ScrollableControl ();
		scrollable.Dock = DockStyle.Fill;
		scrollable.BackColor = Color.Red;
		scrollable.Paint += new PaintEventHandler (PaintArea);

		Controls.Add (paint_count_button);
		Controls.Add (scrollable);
	}

	private void PaintArea (object sender, PaintEventArgs pe)
	{
		pe.Graphics.FillRectangle (new SolidBrush (Color.Blue), pe.ClipRectangle);
		paint_count++;
	}

	private void PrintPaintCount (object sender, EventArgs e)
	{
		Console.WriteLine ("Paint Count:  {0}", paint_count);
	}

	public static void Main ()
	{
		Application.Run (new ScrollingTest ());
	}
}

