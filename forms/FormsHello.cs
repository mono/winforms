/*
 * FormsHello.cs - Sample program for Forms.
 *
 * Copyright (C) 2003  Southern Storm Software, Pty Ltd.
 *
 * This program is free software, you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY, without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program, if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class FormsHello : Form
{
	private Button button;
	private ProgressBar progress;
	private int msgNum;
	private ToolBar toolbar;
	private ScrollBar scrollbar;
	private CheckBox checkbox;
	
	private FormsHello()
	{
		// Force the entire form to repaint when it is resized.
		SetStyle(ControlStyles.ResizeRedraw, true);

		// Set some initial form properties.
		Size = new Size(400, 270);
		Text = "Forms Hello";

		// Create a button control on the form.
		button = new Button();
		button.Text = "Click Me!";
		button.Location = new Point(30, 130);
		Controls.Add(button);
		
		// Create a progress bar control
		progress = new ProgressBar();
		progress.Location = new Point(30, 175);
		progress.Anchor = AnchorStyles.Top |
						  AnchorStyles.Left |
						  AnchorStyles.Right;
		Controls.Add(progress);

		// Create a label and dock it to the bottom.
		Label label = new Label();
		label.Text = "This is a label, docked to the bottom ...";
		label.BackColor = Color.White;
		label.Dock = DockStyle.Bottom;
		Controls.Add(label);

		// Hook up interesting events.
		Paint += new PaintEventHandler(HandlePaint);
		button.Click += new EventHandler(HandleClick);

		// Create a scrollbar control.
		scrollbar = new HScrollBar();
		scrollbar.Dock = DockStyle.Bottom;
		Controls.Add(scrollbar);
		scrollbar = new VScrollBar();
		scrollbar.Dock = DockStyle.Right;
		Controls.Add(scrollbar);

		// Create a toolbar control and some toolbar buttons.
		toolbar = new ToolBar();
		toolbar.Buttons.Add("Hello");
		ToolBarButton tbb = new ToolBarButton();
		tbb.Style = ToolBarButtonStyle.Separator;
		toolbar.Buttons.Add(tbb);
		tbb = new ToolBarButton("World!");
		toolbar.Buttons.Add(tbb);
		toolbar.Appearance = ToolBarAppearance.Flat;
		toolbar.BorderStyle = BorderStyle.FixedSingle;
		Controls.Add(toolbar);

		// Create another toolbar.
		// This reveals some layout bugs, so
		// the Controls.Add is commented out
		// to keep the sample looking good
		toolbar = new ToolBar();
		toolbar.Buttons.Add("This one's");
		tbb = new ToolBarButton();
		tbb.Style = ToolBarButtonStyle.Separator;
		toolbar.Buttons.Add(tbb);
		tbb = new ToolBarButton("left docked.");
		tbb.Style = ToolBarButtonStyle.DropDownButton;
		toolbar.Buttons.Add(tbb);
		toolbar.BorderStyle = BorderStyle.Fixed3D;
		toolbar.Dock = DockStyle.Left;
		//toolbar.DropDownArrows = false;
		//Controls.Add(toolbar);

		checkbox=new CheckBox();
		checkbox.Location=new Point(70,95);
		checkbox.Text="Any Good ?";
		checkbox.Checked=true;
		checkbox.CheckStateChanged += new EventHandler(HandleCheck);
		Controls.Add(checkbox);
	}

	private void HandlePaint(Object sender, PaintEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Form form = (sender as Form);
		Rectangle bounds = form.ClientRectangle;

		Pen pen = new Pen(Color.Black, 1.0f);
		graphics.DrawLine(pen, 0, 0, bounds.Width, bounds.Height - 23);
		pen.Dispose();

		pen = new Pen(Color.Red, 2.0f);
		graphics.DrawRectangle
			(pen, 10, 10, bounds.Width - 20, bounds.Height - 40);
		pen.Dispose();

		ControlPaint.DrawFocusRectangle
			(graphics,
			 new Rectangle(15, 15, bounds.Width - 30, bounds.Height - 50));

		Brush brush = new SolidBrush(Color.Yellow);
		graphics.FillPie(brush, 20, 20, 60, 60, 30.0f, 70.0f);
		brush.Dispose();

		Font font = new Font("Arial", 12);
		brush = new SolidBrush(Color.Blue);
		graphics.DrawString("Hello", font, brush, 30, 100);
		brush.Dispose();
		font.Dispose();

		brush = new HatchBrush
			(HatchStyle.BackwardDiagonal, Color.Black, Color.White);
		graphics.FillEllipse(brush, 200, 40, 100, 100);
		brush.Dispose();
	}

	private static readonly String[] Messages = {
		"I've been clicked!",
		"Oww! That hurts!",
		"Stop it!",
		"Thank you sir! May I have another?"
	};

	private void HandleClick(Object sender, EventArgs e)
	{
		Console.WriteLine(Messages[msgNum]);
		msgNum = (msgNum + 1) % Messages.Length;
		progress.PerformStep();
	}

	private void HandleCheck(Object sender, EventArgs e)
	{
		bool check=(sender as CheckBox).Checked;
		Console.WriteLine(check ? "You changed your mind ? , Good.." :
								"Naaw , didn't think so..");
					
	}

	public static void Main(String[] args)
	{
		FormsHello form = new FormsHello();
		Application.Run(form);
	}
}
