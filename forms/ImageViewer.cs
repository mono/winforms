/*
 * ImageViewer.cs - Simple MDI-based image viewer.
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
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ImageViewer : Form
{
	private ImageViewer()
	{
		MenuItem openMenuItem = new MenuItem("Open");
		MenuItem quitMenuItem = new MenuItem("Quit");
		MenuItem fileMenuItem =
			new MenuItem("File", new MenuItem[]
				{openMenuItem, quitMenuItem});
		MainMenu mainMenu = new MainMenu(new MenuItem[] { fileMenuItem });
		Menu = mainMenu;

		Size = new Size(600, 500);
		Text = "DotGNU Image Viewer";
		IsMdiContainer = true;

		openMenuItem.Click += new EventHandler(OpenClicked);
		quitMenuItem.Click += new EventHandler(QuitClicked);
	}

	private void OpenClicked(Object sender, EventArgs e)
	{
		OpenFileDialog dialog = new OpenFileDialog();
		dialog.Filter =
			"All image files (*.bmp, *.jpg, *.png, *.gif, *.ico, *.cur)" +
			"|*.bmp;*.jpg;*.png;*.gif;*.ico;*.cur" +
			"|BMP files (*.bmp)|*.bmp" +
			"|JPEG files (*.jpg)|*.jpg" +
			"|PNG files (*.png)|*.png" +
			"|GIF files (*.gif)|*.gif" +
			"|Icon files (*.ico)|*.ico" +
			"|Cursor files (*.cur)|*.cur" +
			"|All files (*.*)|*.*";
		if(dialog.ShowDialog(this) == DialogResult.OK)
		{
			Bitmap image;
			try
			{
				image = new Bitmap(dialog.FileName);
			}
			catch(Exception)
			{
				MessageBox.Show
					(String.Format("Unknown image format for \"{0}\"",
								   dialog.FileName),
					 "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				image = null;
			}
			if(image != null)
			{
				ImageWindow window = new ImageWindow
					(dialog.FileName, image);
				window.MdiParent = this;
				window.Visible = true;
			}
		}
	}

	private void QuitClicked(Object sender, EventArgs e)
	{
		Close();
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		if(keyData == (Keys.Control | Keys.O))
		{
			OpenClicked(this, EventArgs.Empty);
			return true;
		}
		return base.ProcessDialogKey(keyData);
	}

	public static void Main(String[] args)
	{
		ImageViewer form = new ImageViewer();
		Application.Run(form);
	}

}

internal class ImageWindow : Form
{
	private Image image;

	public ImageWindow(String filename, Image image)
	{
		this.image = image;
		ClientSize = image.Size;
		Text = Path.GetFileName(filename);
	}

	protected override void OnPaint(PaintEventArgs args)
	{
		args.Graphics.DrawImage(image, 0, 0);
	}

}
