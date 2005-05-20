/*
 * radiobuttons.cs - Sample radio buttons program.
 *
 * Copyright (C) 2003  Southern Storm Software, Pty Ltd.
 * Copyright (C) 2003  Free Software Foundation, Inc.
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

public class RadioButtons : Form
{
	private RadioButton[] buttons = new RadioButton[6];
	private GroupBox[] boxes = new GroupBox[4];

	private RadioButtons()
	{
		// Force the entire form to repaint when it is resized.
		SetStyle(ControlStyles.ResizeRedraw, true);

		int x = 10;
		int y = 10;
		Size size = new Size(300, 20);
		String text;
		FlatStyle style;

		Appearance app = (Appearance)0;

		// First Button
		style = (FlatStyle)0;
		text = "Appearance Normal , No FlatStyle";
		buttons[0] = MakeButton(x, y, size, text, style, false, app, false);
		Controls.Add(buttons[0]);
		y += 30;

		// Second Button
		style = FlatStyle.Popup;
		text = "Apearance Normal , FlatStyle.Popup";
		buttons[1] = MakeButton(x, y, size, text, style, true, app, false);
		Controls.Add(buttons[1]);
		y += 30;

		// Third Button
		style = FlatStyle.Flat;
		text = "Appearance Normal , FlatStyle.Flat";
		buttons[2] = MakeButton(x, y, size, text, style, true, app, false);
		Controls.Add(buttons[2]);
		y += 30;

		// switch to button appearance
		app = Appearance.Button;

		// Fourth Button
		style = FlatStyle.Popup;
		text = "Apearance Button , FlatStyle.Popup";
		buttons[3] = MakeButton(x, y, size, text, style, true, app, true);
		Controls.Add(buttons[3]);
		y += 30;

		// Fifth Button
		style = FlatStyle.Flat;
		text = "Appearance Button , FlatStyle.Flat";
		buttons[4] = MakeButton(x, y, size, text, style, true, app, true);
		Controls.Add(buttons[4]);
		y += 30;

		// Sixth Button
		style = FlatStyle.Standard;
		text = "Appearance Button , FlatStyle.Standard";
		buttons[5] = MakeButton(x, y, size, text, style, true, app, true);
		Controls.Add(buttons[5]);
		y += 30;



		String[] msgs;
		size = new Size(200, 20);

		// First Group
		msgs = new String[] { "These", "are", "grouped." };
		style = FlatStyle.Standard;
		text = "FlatStyle.Standard";
		boxes[0] = MakeGroup(x, y, text, style, size, msgs);
		Controls.Add(boxes[0]);

		// Calculate the rest of the position information
		int x2 = x + boxes[0].Size.Width + 10;
		int y2 = y + boxes[0].Size.Height + 10;

		// Second Group
		msgs = new String[] { "As", "are", "these." };
		style = FlatStyle.Flat;
		text = "FlatStyle.Flat";
		boxes[1] = MakeGroup(x2, y, text, style, size, msgs);
		Controls.Add(boxes[1]);

		// Third Group
		msgs = new String[] { "Here's", "another", "group." };
		style = FlatStyle.Popup;
		text = "FlatStyle.Popup";
		boxes[2] = MakeGroup(x, y2, text, style, size, msgs);
		Controls.Add(boxes[2]);

		// Fourth Group
		msgs = new String[] { "Here's", "another", "group." };
		style = FlatStyle.System;
		text = "FlatStyle.System";
		boxes[3] = MakeGroup(x2, y2, text, style, size, msgs);
		Controls.Add(boxes[3]);
	}

	private static RadioButton MakeButton
		(int x, int y, Size size, String text, FlatStyle style,
		 bool setStyle, Appearance appearance, bool setAppearance)
	{
		RadioButton b = new RadioButton();
		b.Location = new Point(x, y);
		b.Size = size;
		b.Text = text;
		if(setAppearance)
		{
			b.Appearance = appearance;
		}
		if(setStyle)
		{
			b.FlatStyle = style;
		}

		return b;
	}

	private static GroupBox MakeGroup
		(int x, int y, String text, FlatStyle style,
		 Size buttonSize, String[] buttonStrings)
	{
		int bHeight = buttonSize.Height;
		int width = buttonSize.Width + 20;
		int height = ((bHeight+10)*buttonStrings.Length) + 40;

		GroupBox box = new GroupBox();
		box.Size = new Size(width, height);
		box.Location = new Point(x, y);
		box.Text = text;
		box.FlatStyle = style;

		x += 10;
		y += 40;

		FlatStyle sNone = (FlatStyle)0;
		Appearance aNone = (Appearance)0;

		for(int i = 0; i < buttonStrings.Length; ++i)
		{
			box.Controls.Add(MakeButton(x, y, buttonSize, buttonStrings[i],
			                            sNone, false, aNone, false));
			y += bHeight+10;
		}

		return box;
	}

	public static void Main(String[] args)
	{
		RadioButtons form = new RadioButtons();
		form.Width = 470;
		form.Height = 470;
		form.Text = "RadioButtons example";
		Application.Run(form);
	}
}
