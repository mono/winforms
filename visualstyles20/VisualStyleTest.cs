using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using System.Reflection;

namespace StyleTest
{
	public class VisualStyleTest : Form
	{
                [STAThread]
                static void Main()
                {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new VisualStyleTest());
                }

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.treeView1 = new System.Windows.Forms.TreeView ();
			this.SuspendLayout ();
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.Location = new System.Drawing.Point (0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size (224, 657);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler (this.treeView1_AfterSelect);
			this.treeView1.Sorted = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size (674, 657);
			this.Controls.Add (this.treeView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler (this.Form1_Load);
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		VisualStyleRenderer vsr;
		int TextY;

		public VisualStyleTest ()
		{
			InitializeComponent ();
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			// Populate the treeview with every defined VisualStyleElement
			foreach (Type t in typeof(VisualStyleElement).GetNestedTypes()) {
				foreach (Type t2 in t.GetNestedTypes ())
					foreach (MethodInfo m in t2.GetMethods ()) {
						if (m.Name.StartsWith ("get_")) {
							TreeNode n = new TreeNode (t.Name + "." + t2.Name + "." + m.Name.Substring (4));
							n.Tag = m;
							treeView1.Nodes.Add (n);
						}
					}

			}
		}

		private void treeView1_AfterSelect (object sender, TreeViewEventArgs e)
		{
			if (treeView1.SelectedNode != null) {
				Graphics g = Graphics.FromHwnd (this.Handle);
				g.Clear (this.BackColor);
				TextY = 0;

				if (VisualStyleInformation.IsSupportedByOS)
					DrawText (g, "VisualStyles supported by OS");
				else {
					DrawText (g, "VisualStyles not supported by OS.");
					return;
				}

				if (VisualStyleInformation.IsEnabledByUser)
					DrawText (g, "VisualStyles enabled by user.");
				else {
					DrawText (g, "VisualStyles not enabled by user.");
					return;
				}

				// Create the VisualStyleElement
				MethodInfo m = (MethodInfo)treeView1.SelectedNode.Tag;
				VisualStyleElement vse = (VisualStyleElement)m.Invoke (null, null);

				if (!VisualStyleRenderer.IsElementDefined (vse)) {
					DrawText (g, treeView1.SelectedNode.Text + " is not defined by the current style.");
					return;
				}

				try {
					// Create the VisualStyleRenderer
					if (vsr == null)
						vsr = new VisualStyleRenderer (vse);
					else
						vsr.SetParameters (vse);

					// Draw some pretty graphics
					TextY += 25;
					vsr.DrawBackground (g, new Rectangle (250, TextY, 25, 25));
					vsr.DrawBackground (g, new Rectangle (350, TextY, 50, 50));
					vsr.DrawBackground (g, new Rectangle (450, TextY, 50, 50), new Rectangle (450, TextY, 25, 25));
					TextY += 75;

					// Test some other methods
					DrawText (g, "GetBackgroundContentRectangle: " + vsr.GetBackgroundContentRectangle (g, new Rectangle (300, 0, 300, 50)).ToString ());
					DrawText (g, "GetBackgroundExtent: " + vsr.GetBackgroundExtent (g, new Rectangle (300, 0, 300, 50)).ToString ());
					DrawText (g, "GetBoolean: " + vsr.GetBoolean (BooleanProperty.MirrorImage).ToString ());
					DrawText (g, "GetEnumValue: " + vsr.GetEnumValue (EnumProperty.VerticalAlignment).ToString ());
					DrawText (g, "GetFilename: " + vsr.GetFilename (FilenameProperty.ImageFile).ToString ());
					DrawText (g, "GetInteger: " + vsr.GetInteger (IntegerProperty.BorderSize).ToString ());
					DrawText (g, "GetMargins: " + vsr.GetMargins (g, MarginProperty.CaptionMargins).ToString ());
					DrawText (g, "GetPartSize: " + vsr.GetPartSize (g, ThemeSizeType.Draw).ToString ());
					DrawText (g, "GetPoint: " + vsr.GetPoint (PointProperty.MinSize).ToString ());
					DrawText (g, "GetString: " + vsr.GetString (StringProperty.Text).ToString ());
					DrawText (g, "GetTextExtent: " + vsr.GetTextExtent (g, "HeyThere!", TextFormatFlags.Default).ToString ());
					DrawText (g, "GetTextMetrics: " + vsr.GetTextMetrics (g).Ascent.ToString ());
					DrawText (g, "GetBackgroundRegion: " + vsr.GetBackgroundRegion (g, this.ClientRectangle).GetBounds (g).ToString ());
					DrawText (g, "HitTestBackground: " + vsr.HitTestBackground (g, this.ClientRectangle, new Point (300, 300), HitTestOptions.Caption).ToString ());
					DrawText (g, "Author: " + VisualStyleInformation.Author);
					DrawText (g, "ColorScheme: " + VisualStyleInformation.ColorScheme);
					DrawText (g, "Company: " + VisualStyleInformation.Company);
					DrawText (g, "ControlHighlightHot: " + VisualStyleInformation.ControlHighlightHot.ToString ());
					DrawText (g, "Copyright: " + VisualStyleInformation.Copyright);
					DrawText (g, "Description: " + VisualStyleInformation.Description);
					DrawText (g, "DisplayName: " + VisualStyleInformation.DisplayName);
					DrawText (g, "MinimumColorDepth: " + VisualStyleInformation.MinimumColorDepth.ToString ());
					DrawText (g, "Size: " + VisualStyleInformation.Size.ToString ());
					DrawText (g, "SupportsFlatMenus: " + VisualStyleInformation.SupportsFlatMenus.ToString ());
					DrawText (g, "TextControlBorder: " + VisualStyleInformation.TextControlBorder.ToString ());
					DrawText (g, "Url: " + VisualStyleInformation.Url);
					DrawText (g, "Version: " + VisualStyleInformation.Version.ToString ());
				}
				catch (Exception ex) {
					System.Console.WriteLine (ex.ToString ());
				}
			}
		}

		private void DrawText (Graphics g, string text)
		{
			g.DrawString (text, this.Font, Brushes.Black, 250, TextY);
			TextY += 18;
		}

	}
}