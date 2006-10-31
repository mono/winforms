using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Text;

namespace ToolStripDemo
{
	public class ToolStripDemo : Form
	{
		[STAThread]
		static void Main ()
		{
		        Application.EnableVisualStyles ();
		        Application.Run (new ToolStripDemo ());
		}

		private ToolStrip ts;
		private TextBox rtb;
		private string image_path;
		private ToolStripComboBox tscb;
		private ToolStripComboBox font_combo;
		private MenuStrip ms;
		
		public ToolStripDemo ()
		{
			this.Text = "ToolStrip Notepad Sample";
			this.Size = new Size (750, 450);
			this.StartPosition = FormStartPosition.CenterScreen;

			image_path = Path.Combine (Path.GetDirectoryName (Application.ExecutablePath), "images");

			rtb = new TextBox ();
			rtb.Multiline = true;
			rtb.Dock = DockStyle.Fill;
			rtb.BorderStyle = BorderStyle.FixedSingle;
			rtb.MouseUp += new MouseEventHandler (rtb_MouseUp);
			this.Controls.Add (rtb);

			ts = new ToolStrip ();
			this.Controls.Add (ts);

			Image image1 = Image.FromFile (Path.Combine (image_path, "document-new.png"));
			ToolStripButton tb1 = new ToolStripButton ("&New Document", image1, new EventHandler (New_Document_Clicked));
			tb1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb1);

			Image image2 = Image.FromFile (Path.Combine (image_path, "document-open.png"));
			ToolStripButton tb2 = new ToolStripButton ("&Open Document", image2, new EventHandler (Open_Document_Clicked));
			tb2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb2);

			Image image3 = Image.FromFile (Path.Combine (image_path, "document-save.png"));
			ToolStripButton tb3 = new ToolStripButton ("&Save Document", image3, new EventHandler (Save_Document_Clicked));
			tb3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb3);

			ts.Items.Add (new ToolStripSeparator ());

			Image image5 = Image.FromFile (Path.Combine (image_path, "edit-cut.png"));
			ToolStripButton tb5 = new ToolStripButton ("Cut", image5, new EventHandler (Cut_Clicked), "Cut");
			tb5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tb5.Enabled = false;
			ts.Items.Add (tb5);

			Image image6 = Image.FromFile (Path.Combine (image_path, "edit-copy.png"));
			ToolStripButton tb6 = new ToolStripButton ("Copy", image6, new EventHandler (Copy_Clicked), "Copy");
			tb6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb6);

			Image image7 = Image.FromFile (Path.Combine (image_path, "edit-paste.png"));
			ToolStripButton tb7 = new ToolStripButton ("Paste", image7, new EventHandler (Paste_Clicked));
			tb7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb7);

			ts.Items.Add (new ToolStripSeparator ());

			ToolStripLabel tsl = new ToolStripLabel ("Font:");
			ts.Items.Add (tsl);

			font_combo = new ToolStripComboBox ();
			font_combo.DropDownStyle = ComboBoxStyle.DropDownList;
			font_combo.AutoSize = false;
			font_combo.Width = 150;
			InstalledFontCollection ifc = new InstalledFontCollection ();

			foreach (FontFamily f in ifc.Families) {
				if (f.IsStyleAvailable (FontStyle.Regular))
					font_combo.Items.Add (f.Name);
			}

			font_combo.SelectedIndexChanged += new EventHandler (font_combo_SelectedIndexChanged);
			ts.Items.Add (font_combo);

			tscb = new ToolStripComboBox ();
			tscb.DropDownStyle = ComboBoxStyle.DropDownList;
			tscb.Items.Add ("6");
			tscb.Items.Add ("8");
			tscb.Items.Add ("10");
			tscb.Items.Add ("12");
			tscb.Items.Add ("14");
			tscb.Items.Add ("16");
			tscb.Items.Add ("18");
			tscb.SelectedIndexChanged += new EventHandler (tscb_SelectedIndexChanged);
			tscb.AutoSize = false;
			tscb.Width = 45;

			ts.Items.Add (tscb);

			Image image10 = Image.FromFile (Path.Combine (image_path, "image-x-generic.png"));

			font_combo.SelectedIndex = font_combo.FindStringExact (rtb.Font.Name);
			tscb.SelectedIndex = tscb.FindStringExact (rtb.Font.Size.ToString ());

			ms = new MenuStrip ();
			ms.Dock = DockStyle.Top;
			this.Controls.Add (ms);

			// Top level menu
			ToolStripMenuItem mi = new ToolStripMenuItem ("File");
			ToolStripMenuItem mi2 = new ToolStripMenuItem ("Edit");
			ToolStripMenuItem mi3 = new ToolStripMenuItem ("View");
			ToolStripMenuItem mi4 = new ToolStripMenuItem ("Tools");
			ToolStripMenuItem mi5 = new ToolStripMenuItem ("Help");
			ms.Items.Add (mi);
			ms.Items.Add (mi2);
			ms.Items.Add (mi3);
			ms.Items.Add (mi4);
			ms.Items.Add (mi5);

			// File menu items
			mi.DropDownItems.Add ("New", image1, new EventHandler (New_Document_Clicked));
			mi.DropDownItems.Add ("Open", image2, new EventHandler (Open_Document_Clicked));
			mi.DropDownItems.Add ("Save", image3, new EventHandler (Save_Document_Clicked));
			mi.DropDownItems.Add ("-");
			mi.DropDownItems.Add ("Exit", null, new EventHandler (Exit_Clicked));

			// Edit menu items
			mi2.DropDownItems.Add ("Undo", null, new EventHandler (Undo_Clicked));
			mi2.DropDownItems.Add ("-");
			mi2.DropDownItems.Add ("Cut", image5, new EventHandler (Cut_Clicked)).Name = "Cut";
			mi2.DropDownItems.Add ("Copy", image6, new EventHandler (Copy_Clicked)).Name = "Copy";
			mi2.DropDownItems.Add ("Paste", image7, new EventHandler (Paste_Clicked));
			
			// View menu items
			ToolStripMenuItem WordWrapMenuItem = (ToolStripMenuItem)mi3.DropDownItems.Add ("Word Wrap");
			WordWrapMenuItem.CheckOnClick = true;
			WordWrapMenuItem.CheckedChanged += new EventHandler (WordWrap_CheckStateChanged);
			WordWrapMenuItem.Checked = true;

			ToolStripMenuItem ToolStripStyleMenuItem = (ToolStripMenuItem)mi3.DropDownItems.Add ("ToolStrip Style", image10);
			
			// ToolStripStyle sub menu items
			ToolStripStyleMenuItem.DropDownItems.Add ("Image", null, new EventHandler (Change_Style_Clicked));
			ToolStripStyleMenuItem.DropDownItems.Add ("Image and Text", null, new EventHandler (Change_Style_Clicked));
			ToolStripStyleMenuItem.DropDownItems.Add ("Text", null, new EventHandler (Change_Style_Clicked));
			ToolStripStyleMenuItem.DropDownItems.Add ("None", null, new EventHandler (Change_Style_Clicked));
			
			(ToolStripStyleMenuItem.DropDownItems[0] as ToolStripMenuItem).Checked = true;
			
			// Help menu items
			mi5.DropDownItems.Add ("Contents", null, new EventHandler (NotImplemented));
			mi5.DropDownItems.Add ("Search", null, new EventHandler (NotImplemented));
			mi5.DropDownItems.Add ("-");
			mi5.DropDownItems.Add ("About", null, new EventHandler (NotImplemented));
			
			rtb_MouseUp (null, null);
		}

		void rtb_MouseUp (object sender, MouseEventArgs e)
		{
			bool enabled = rtb.SelectionLength > 0;

			ts.Items["Cut"].Enabled = enabled;
			ts.Items["Copy"].Enabled = enabled;
			(ms.Items[1] as ToolStripMenuItem).DropDownItems["Cut"].Enabled = enabled;
			(ms.Items[1] as ToolStripMenuItem).DropDownItems["Copy"].Enabled = enabled;
		}

		void WordWrap_CheckStateChanged (object sender, EventArgs e)
		{
			rtb.WordWrap = (sender as ToolStripMenuItem).Checked;
		}

		void Exit_Clicked (object sender, EventArgs e)
		{
			this.Close();
		}

		void font_combo_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (font_combo.SelectedIndex >= 0)
				rtb.Font = new Font ((string)font_combo.SelectedItem, rtb.Font.Size);
		}

		void tscb_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (tscb.SelectedIndex >= 0)
				rtb.Font = new Font (rtb.Font.Name, float.Parse (tscb.SelectedItem.ToString ()));
		}

		public void New_Document_Clicked (object sender, EventArgs e)
		{
			rtb.Clear ();
		}

		public void Open_Document_Clicked (object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog ();

			if (ofd.ShowDialog () == DialogResult.OK) {
				StreamReader sr = new StreamReader (ofd.OpenFile ());
				rtb.Text = sr.ReadToEnd ();
				sr.Close ();
			}
		}

		public void Save_Document_Clicked (object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog ();

			if (sfd.ShowDialog () == DialogResult.OK) {
				StreamWriter sw = new StreamWriter (sfd.OpenFile ());
				sw.Write (rtb.Text);
				sw.Close ();
			}
		}

		public void Undo_Clicked (object sender, EventArgs e)
		{
			rtb.Undo ();
		}
		
		public void Cut_Clicked (object sender, EventArgs e)
		{
			rtb.Cut ();
		}

		public void Copy_Clicked (object sender, EventArgs e)
		{
			rtb.Copy ();
		}

		public void Paste_Clicked (object sender, EventArgs e)
		{
			rtb.Paste ();
		}

		public void Change_Style_Clicked (object sender, EventArgs e)
		{
			ToolStripMenuItem tsi = (ToolStripMenuItem)sender;
			
			foreach (ToolStripMenuItem tsi2 in (tsi.OwnerItem as ToolStripMenuItem).DropDownItems)
				tsi2.Checked = false;
				
			tsi.Checked = true;

			ToolStripItemDisplayStyle style;
			
			switch (tsi.Text) {
				case "Image":
				default:
					style = ToolStripItemDisplayStyle.Image;
					break;
				case "Image and Text":
					style = ToolStripItemDisplayStyle.ImageAndText;
					break;
				case "Text":
					style = ToolStripItemDisplayStyle.Text;
					break;
				case "None":
					style = ToolStripItemDisplayStyle.None;
					break;
			}
			
			foreach (ToolStripItem tsi2 in ts.Items)
				if (tsi2 is ToolStripButton)
					tsi2.DisplayStyle = style;
		}

		public void NotImplemented (object sender, EventArgs e)
		{
			MessageBox.Show ("Nothing to see here");
		}
	}
}
