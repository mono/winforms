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

		public ToolStripDemo()
		{
			this.Text = "ToolStrip Sample";
			this.Size = new Size(750, 450);

			image_path = Path.Combine (Path.GetDirectoryName (Application.ExecutablePath), "images");

			rtb = new TextBox ();
			rtb.Multiline = true;
			rtb.Dock = DockStyle.Fill;
			this.Controls.Add (rtb);
			
			ts = new ToolStrip ();
			this.Controls.Add(ts);

			Image image1 = Image.FromFile (Path.Combine (image_path, "document-new.png"));
			ToolStripButton tb1 = new ToolStripButton ("New Document", image1, new EventHandler (New_Document_Clicked));
			tb1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb1);

			Image image2 = Image.FromFile (Path.Combine (image_path, "document-open.png"));
			ToolStripButton tb2 = new ToolStripButton ("Open Document", image2, new EventHandler (Open_Document_Clicked));
			tb2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb2);

			Image image3 = Image.FromFile (Path.Combine (image_path, "document-save.png"));
			ToolStripButton tb3 = new ToolStripButton ("Save Document", image3, new EventHandler (Save_Document_Clicked));
			tb3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb3);
			
			ts.Items.Add(new ToolStripSeparator());

			Image image5 = Image.FromFile (Path.Combine (image_path, "edit-cut.png"));
			ToolStripButton tb5 = new ToolStripButton ("Cut", image5, new EventHandler (Cut_Clicked));
			tb5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb5);

			Image image6 = Image.FromFile (Path.Combine (image_path, "edit-copy.png"));
			ToolStripButton tb6 = new ToolStripButton ("Copy", image6, new EventHandler (Copy_Clicked));
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

			ToolStripLabel tsl2 = new ToolStripLabel("Button Style:");
			ts.Items.Add (tsl2);

			Image image10 = Image.FromFile (Path.Combine (image_path, "image-x-generic.png"));
			ToolStripButton tb10 = new ToolStripButton ("Style", image10, new EventHandler(Change_Style_Clicked));
			tb10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ts.Items.Add (tb10);

			font_combo.SelectedIndex = font_combo.FindStringExact (rtb.Font.Name);
			tscb.SelectedIndex = tscb.FindStringExact (rtb.Font.Size.ToString());
		}
		
		void font_combo_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (font_combo.SelectedIndex >= 0)
				rtb.Font = new Font ((string)font_combo.SelectedItem, rtb.Font.Size);
		}

		void tscb_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (tscb.SelectedIndex >= 0)
				rtb.Font = new Font (rtb.Font.Name, float.Parse(tscb.SelectedItem.ToString()));
		}

		public void New_Document_Clicked (object sender, EventArgs e)
		{
			rtb.Clear();
		}	
		
		public void Open_Document_Clicked (object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(ofd.OpenFile());
				rtb.Text = sr.ReadToEnd();
				sr.Close();
			}
		}

		public void Save_Document_Clicked (object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog ();

			if (sfd.ShowDialog () == DialogResult.OK) {
				StreamWriter sw = new StreamWriter (sfd.OpenFile ());
				sw.Write(rtb.Text);
				sw.Close();
			}
		}

		public void Cut_Clicked (object sender, EventArgs e)
		{
			rtb.Cut();
		}

		public void Copy_Clicked (object sender, EventArgs e)
		{
			rtb.Copy();
		}

		public void Paste_Clicked (object sender, EventArgs e)
		{
			rtb.Paste();
		}

		public void Change_Style_Clicked (object sender, EventArgs e)
		{
			int style = (int)ts.Items[0].DisplayStyle + 1;
			
			if (style > 3)
				style = 1;
				
			foreach (ToolStripItem tsi in ts.Items)
				if (tsi is ToolStripButton)
					tsi.DisplayStyle = (ToolStripItemDisplayStyle)style;
		}

	}
}
