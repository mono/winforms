using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonoCHelloWorld
{
	public class RendererTest : Form
	{
		[STAThread]
		static void Main ()
		{
		        Application.EnableVisualStyles ();
		        Application.SetCompatibleTextRenderingDefault (false);
		        Application.Run (new RendererTest ());
		}

		private ComboBox comboBox1;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox ();
			this.SuspendLayout ();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange (new object[] {
            "ButtonRenderer",
            "CheckBoxRenderer",
            "ComboBoxRenderer",
            "GroupBoxRenderer",
            "ProgressBarRenderer",
            "RadioButtonRenderer",
            "ScrollBarRenderer",
            "TabRenderer",
            "TextBoxRenderer",
            "TrackBarRenderer"});
			this.comboBox1.Location = new System.Drawing.Point (565, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size (175, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler (this.comboBox1_SelectedIndexChanged);
			// 
			// RendererTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (740, 529);
			this.Controls.Add (this.comboBox1);
			this.Name = "RendererTest";
			this.Text = "RendererTest";
			this.ResumeLayout (false);

		}

		#endregion

		public RendererTest ()
		{
			InitializeComponent ();
		}

		private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == null)
				return;

			this.Invalidate ();
		}

		protected override void OnPaint (PaintEventArgs e)
		{
			base.OnPaint (e);

			if (comboBox1.SelectedItem == null)
				return;

			Graphics g = e.Graphics;
			Image i = Image.FromFile (@"accessories-character-map.png");
			Font f = new Font ("Microsoft Sans Serif", 8);

			switch (comboBox1.SelectedItem.ToString()) {
				case "ButtonRenderer":
					ButtonRenderer.DrawButton (g, new Rectangle (0, 125, 75, 23), System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (0, 25, 75, 23), System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (0, 50, 75, 23), System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (0, 75, 75, 23), System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (0, 100, 75, 23), System.Windows.Forms.VisualStyles.PushButtonState.Normal);

					ButtonRenderer.DrawButton (g, new Rectangle (100, 125, 75, 23), true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (100, 25, 75, 23), true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (100, 50, 75, 23), true, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (100, 75, 75, 23), true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (100, 100, 75, 23), true, System.Windows.Forms.VisualStyles.PushButtonState.Normal);


					ButtonRenderer.DrawButton (g, new Rectangle (200, 125, 75, 23), i, new Rectangle (200, 128, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (200, 25, 75, 23), i, new Rectangle (203, 28, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (200, 50, 75, 23), i, new Rectangle (203, 53, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (200, 75, 75, 23), i, new Rectangle (203, 78, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (200, 100, 75, 23), i, new Rectangle (203, 103, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);


					ButtonRenderer.DrawButton (g, new Rectangle (300, 125, 75, 23), "Hi there button!", f, true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (300, 25, 75, 23), "Hi there button!", f, true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (300, 50, 75, 23), "Hi there button!", f, false, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (300, 75, 75, 23), "Hi there button!", f, true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (300, 100, 75, 23), "Hi there button!", f, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);

					ButtonRenderer.DrawButton (g, new Rectangle (400, 125, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (400, 25, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (400, 50, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, false, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (400, 75, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (400, 100, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);

					ButtonRenderer.DrawButton (g, new Rectangle (500, 125, 75, 23), "Hi there button!", f, i, new Rectangle (500, 128, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (500, 25, 75, 23), "Hi there button!", f, i, new Rectangle (500, 28, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (500, 50, 75, 23), "Hi there button!", f, i, new Rectangle (500, 53, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (500, 75, 75, 23), "Hi there button!", f, i, new Rectangle (500, 78, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (500, 100, 75, 23), "Hi there button!", f, i, new Rectangle (500, 103, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);

					ButtonRenderer.DrawButton (g, new Rectangle (600, 125, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, i, new Rectangle (600, 128, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
					ButtonRenderer.DrawButton (g, new Rectangle (600, 25, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, i, new Rectangle (600, 28, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
					ButtonRenderer.DrawButton (g, new Rectangle (600, 50, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, i, new Rectangle (600, 53, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
					ButtonRenderer.DrawButton (g, new Rectangle (600, 75, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, i, new Rectangle (600, 78, 16, 16), true, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
					ButtonRenderer.DrawButton (g, new Rectangle (600, 100, 75, 23), "Hi there button!", f, TextFormatFlags.Left & TextFormatFlags.WordEllipsis, i, new Rectangle (600, 103, 16, 16), false, System.Windows.Forms.VisualStyles.PushButtonState.Normal);
					break;
				case "CheckBoxRenderer":
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 5), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 5, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 4, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedDisabled);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 25), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 25, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 24, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedHot);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 45), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 45, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 44, 16, 16), true, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 65), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 65, 75, 14), "checkBox1", f, TextFormatFlags.Default, false, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedPressed);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 85), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 85, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 84, 16, 16), true, System.Windows.Forms.VisualStyles.CheckBoxState.MixedDisabled);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 105), System.Windows.Forms.VisualStyles.CheckBoxState.MixedHot);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 125), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 125, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 124, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.MixedNormal);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 145), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 145, 75, 14), "checkBox1", f, i, new Rectangle (90, 144, 16, 16), true, System.Windows.Forms.VisualStyles.CheckBoxState.MixedPressed);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 165), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 165, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 164, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedDisabled);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 185), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 185, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 184, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedHot);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 205), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 205, 75, 14), "checkBox1", f, true, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
					CheckBoxRenderer.DrawCheckBox (g, new Point (5, 225), new Rectangle (8 + CheckBoxRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal).Width, 225, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 224, 16, 16), false, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedPressed);
					break;
				case "ComboBoxRenderer":
					if (!ComboBoxRenderer.IsSupported) {
						g.DrawString("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					ComboBoxRenderer.DrawTextBox (e.Graphics, new Rectangle (5, 5, 121, 21), System.Windows.Forms.VisualStyles.ComboBoxState.Normal);
					ComboBoxRenderer.DrawDropDownButton (e.Graphics, new Rectangle (109, 6, 16, 19), System.Windows.Forms.VisualStyles.ComboBoxState.Normal);
					ComboBoxRenderer.DrawTextBox (e.Graphics, new Rectangle (5, 35, 121, 21), this.Text, this.Font, System.Windows.Forms.VisualStyles.ComboBoxState.Hot);
					ComboBoxRenderer.DrawDropDownButton (e.Graphics, new Rectangle (109, 36, 16, 19), System.Windows.Forms.VisualStyles.ComboBoxState.Hot);
					ComboBoxRenderer.DrawTextBox (e.Graphics, new Rectangle (5, 65, 121, 21), this.Text, this.Font, new Rectangle (8, 65, 57, 21), System.Windows.Forms.VisualStyles.ComboBoxState.Disabled);
					ComboBoxRenderer.DrawDropDownButton (e.Graphics, new Rectangle (109, 66, 16, 19), System.Windows.Forms.VisualStyles.ComboBoxState.Disabled);
					ComboBoxRenderer.DrawTextBox (e.Graphics, new Rectangle (5, 95, 121, 21), this.Text, this.Font, TextFormatFlags.WordEllipsis, System.Windows.Forms.VisualStyles.ComboBoxState.Pressed);
					ComboBoxRenderer.DrawDropDownButton (e.Graphics, new Rectangle (109, 96, 16, 19), System.Windows.Forms.VisualStyles.ComboBoxState.Pressed);
					break;
				case "GroupBoxRenderer":
					Font f2 = new Font ("Microsoft Sans Serif", 12);
					Font f3 = new Font ("Microsoft Sans Serif", 14);
					Font f4 = new Font ("Microsoft Sans Serif", 8);
					GroupBoxRenderer.DrawGroupBox (g, new Rectangle (5, 5, 150, 75), "My Group!", f, Color.Black, TextFormatFlags.Default, System.Windows.Forms.VisualStyles.GroupBoxState.Normal);
					GroupBoxRenderer.DrawGroupBox (g, new Rectangle (5, 105, 150, 75), "My Group!", f2, Color.Red, System.Windows.Forms.VisualStyles.GroupBoxState.Disabled);
					GroupBoxRenderer.DrawGroupBox (g, new Rectangle (5, 205, 150, 75), "My Group!", f3, TextFormatFlags.Default, System.Windows.Forms.VisualStyles.GroupBoxState.Normal);
					GroupBoxRenderer.DrawGroupBox (g, new Rectangle (5, 305, 150, 75), "My Group!", f4, System.Windows.Forms.VisualStyles.GroupBoxState.Disabled);
					GroupBoxRenderer.DrawGroupBox (g, new Rectangle (5, 405, 150, 75), System.Windows.Forms.VisualStyles.GroupBoxState.Normal);
					break;
				case "ProgressBarRenderer":
					if (!ProgressBarRenderer.IsSupported) {
						g.DrawString ("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					g.DrawString ("ChunkSpaceThickness: " + ProgressBarRenderer.ChunkSpaceThickness.ToString (), this.Font, Brushes.Black, 0, 0);
					g.DrawString ("ChunkThickness: " + ProgressBarRenderer.ChunkThickness.ToString (), this.Font, Brushes.Black, 0, 20);

					ProgressBarRenderer.DrawHorizontalBar (g, new Rectangle (5, 40, 100, 20));
					ProgressBarRenderer.DrawHorizontalChunks (g, new Rectangle (7, 42, 47, 16));
					ProgressBarRenderer.DrawVerticalBar (g, new Rectangle (110, 40, 20, 100));
					ProgressBarRenderer.DrawVerticalChunks (g, new Rectangle (112, 42, 16, 47));
					break;
				case "RadioButtonRenderer":
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 5), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 5, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 4, 16, 16), false, System.Windows.Forms.VisualStyles.RadioButtonState.CheckedDisabled);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 25), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 25, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 24, 16, 16), false, System.Windows.Forms.VisualStyles.RadioButtonState.CheckedHot);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 45), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 45, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 44, 16, 16), true, System.Windows.Forms.VisualStyles.RadioButtonState.CheckedNormal);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 65), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 65, 75, 14), "checkBox1", f, TextFormatFlags.Default, false, System.Windows.Forms.VisualStyles.RadioButtonState.CheckedPressed);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 85), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 85, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 84, 16, 16), true, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedDisabled);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 105), System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedHot);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 125), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 125, 75, 14), "checkBox1", f, TextFormatFlags.Default, i, new Rectangle (90, 124, 16, 16), false, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal);
					RadioButtonRenderer.DrawRadioButton (g, new Point (5, 145), new Rectangle (8 + RadioButtonRenderer.GetGlyphSize (g, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedNormal).Width, 145, 75, 14), "checkBox1", f, i, new Rectangle (90, 144, 16, 16), true, System.Windows.Forms.VisualStyles.RadioButtonState.UncheckedPressed);
					break;
				case "ScrollBarRenderer":
					if (!ScrollBarRenderer.IsSupported) {
						g.DrawString ("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (5, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.DownDisabled);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (25, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.DownHot);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (45, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.DownNormal);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (65, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.DownPressed);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (85, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.LeftDisabled);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (105, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.LeftHot);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (125, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.LeftNormal);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (145, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.LeftPressed);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (165, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.RightDisabled);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (185, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.RightHot);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (205, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.RightNormal);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (225, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.RightPressed);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (245, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.UpDisabled);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (265, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.UpHot);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (285, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.UpNormal);
					ScrollBarRenderer.DrawArrowButton (g, new Rectangle (305, 5, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarArrowButtonState.UpPressed);

					ScrollBarRenderer.DrawHorizontalThumb (g, new Rectangle (5, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawHorizontalThumb (g, new Rectangle (45, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawHorizontalThumb (g, new Rectangle (85, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawHorizontalThumb (g, new Rectangle (125, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawHorizontalThumbGrip (g, new Rectangle (5, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawHorizontalThumbGrip (g, new Rectangle (45, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawHorizontalThumbGrip (g, new Rectangle (85, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawHorizontalThumbGrip (g, new Rectangle (125, 25, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawLeftHorizontalTrack (g, new Rectangle (5, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawLeftHorizontalTrack (g, new Rectangle (45, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawLeftHorizontalTrack (g, new Rectangle (85, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawLeftHorizontalTrack (g, new Rectangle (125, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawLowerVerticalTrack (g, new Rectangle (5, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawLowerVerticalTrack (g, new Rectangle (25, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawLowerVerticalTrack (g, new Rectangle (45, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawLowerVerticalTrack (g, new Rectangle (65, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawRightHorizontalTrack (g, new Rectangle (165, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawRightHorizontalTrack (g, new Rectangle (205, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawRightHorizontalTrack (g, new Rectangle (245, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawRightHorizontalTrack (g, new Rectangle (285, 45, 38, 18), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);
					
					ScrollBarRenderer.DrawSizeBox(g, new Rectangle(5,105,18,18), System.Windows.Forms.VisualStyles.ScrollBarSizeBoxState.LeftAlign);
					ScrollBarRenderer.DrawSizeBox (g, new Rectangle (25, 105, 18, 18), System.Windows.Forms.VisualStyles.ScrollBarSizeBoxState.RightAlign);

					ScrollBarRenderer.DrawUpperVerticalTrack (g, new Rectangle (85, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawUpperVerticalTrack (g, new Rectangle (105, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawUpperVerticalTrack (g, new Rectangle (125, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawUpperVerticalTrack (g, new Rectangle (145, 65, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawVerticalThumb (g, new Rectangle (5, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawVerticalThumb (g, new Rectangle (25, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawVerticalThumb (g, new Rectangle (45, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawVerticalThumb (g, new Rectangle (65, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					ScrollBarRenderer.DrawVerticalThumbGrip (g, new Rectangle (5, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Disabled);
					ScrollBarRenderer.DrawVerticalThumbGrip (g, new Rectangle (25, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Hot);
					ScrollBarRenderer.DrawVerticalThumbGrip (g, new Rectangle (45, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Normal);
					ScrollBarRenderer.DrawVerticalThumbGrip (g, new Rectangle (65, 105, 18, 38), System.Windows.Forms.VisualStyles.ScrollBarState.Pressed);

					g.DrawString (ScrollBarRenderer.GetSizeBoxSize (g, System.Windows.Forms.VisualStyles.ScrollBarState.Normal).ToString (), f, Brushes.Black, new PointF (5, 145));
					g.DrawString (ScrollBarRenderer.GetThumbGripSize (g, System.Windows.Forms.VisualStyles.ScrollBarState.Normal).ToString (), f, Brushes.Black, new PointF (5, 165));
					break;
				case "TabRenderer":
					if (!TabRenderer.IsSupported) {
						g.DrawString ("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					TabRenderer.DrawTabPage (g, new Rectangle (5, 95, 700, 50));

					TabRenderer.DrawTabItem (g, new Rectangle (5, 55, 70, 25), System.Windows.Forms.VisualStyles.TabItemState.Normal);
					TabRenderer.DrawTabItem (g, new Rectangle (95, 55, 70, 25), true, System.Windows.Forms.VisualStyles.TabItemState.Selected);
					TabRenderer.DrawTabItem (g, new Rectangle (185, 55, 70, 25), "Tab 1", f, System.Windows.Forms.VisualStyles.TabItemState.Normal);
					TabRenderer.DrawTabItem (g, new Rectangle (275, 55, 70, 25), i, new Rectangle (278, 58, 16, 16), false, System.Windows.Forms.VisualStyles.TabItemState.Hot);
					TabRenderer.DrawTabItem (g, new Rectangle (365, 55, 70, 25), "Tab 6 is too long", f, true, System.Windows.Forms.VisualStyles.TabItemState.Normal);
					TabRenderer.DrawTabItem (g, new Rectangle (455, 55, 70, 25), "My Tab Octopus", f, TextFormatFlags.WordEllipsis, false, System.Windows.Forms.VisualStyles.TabItemState.Disabled);
					TabRenderer.DrawTabItem (g, new Rectangle (545, 55, 70, 25), "Tab 7", f, i, new Rectangle (546, 56, 16, 16), true, System.Windows.Forms.VisualStyles.TabItemState.Normal);
					TabRenderer.DrawTabItem (g, new Rectangle (635, 55, 70, 25), "Tab 8", f, TextFormatFlags.WordEllipsis, i, new Rectangle (638, 58, 16, 16), false, System.Windows.Forms.VisualStyles.TabItemState.Disabled);
					break;
				case "TextBoxRenderer":
					if (!TextBoxRenderer.IsSupported) {
						g.DrawString ("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					TextBoxRenderer.DrawTextBox (g, new Rectangle (5, 55, 95, 40), System.Windows.Forms.VisualStyles.TextBoxState.Assist);
					TextBoxRenderer.DrawTextBox (g, new Rectangle (105, 55, 95, 40), "This is my text box text!!!", f, System.Windows.Forms.VisualStyles.TextBoxState.Disabled);
					TextBoxRenderer.DrawTextBox (g, new Rectangle (205, 55, 95, 40), "This is my text box text!!!", f, new Rectangle (205, 55, 95, 40), System.Windows.Forms.VisualStyles.TextBoxState.Hot);
					TextBoxRenderer.DrawTextBox (g, new Rectangle (305, 55, 95, 40), "This is my text box text!!!", f, TextFormatFlags.WordEllipsis, System.Windows.Forms.VisualStyles.TextBoxState.Normal);
					TextBoxRenderer.DrawTextBox (g, new Rectangle (405, 55, 95, 40), "This is my text box text!!!", f, new Rectangle (405, 55, 95, 40), TextFormatFlags.WordEllipsis, System.Windows.Forms.VisualStyles.TextBoxState.Readonly);
					TextBoxRenderer.DrawTextBox (g, new Rectangle (505, 55, 95, 40), System.Windows.Forms.VisualStyles.TextBoxState.Selected);
					break;
				case "TrackBarRenderer":
					if (!TrackBarRenderer.IsSupported) {
						g.DrawString ("Visual Styles not enabled", f, Brushes.Black, 0, 0);
						break;
					}
					TrackBarRenderer.DrawBottomPointingThumb (g, new Rectangle (5, 5, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawBottomPointingThumb (g, new Rectangle (20, 5, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawBottomPointingThumb (g, new Rectangle (35, 5, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawBottomPointingThumb (g, new Rectangle (50, 5, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawHorizontalThumb (g, new Rectangle (5, 45, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawHorizontalThumb (g, new Rectangle (20, 45, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawHorizontalThumb (g, new Rectangle (35, 45, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawHorizontalThumb (g, new Rectangle (50, 45, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawHorizontalTicks (g, new Rectangle (5, 75, 100, 20), 15, System.Windows.Forms.VisualStyles.EdgeStyle.Bump);
					TrackBarRenderer.DrawHorizontalTicks (g, new Rectangle (115, 75, 100, 20), 10, System.Windows.Forms.VisualStyles.EdgeStyle.Etched);
					TrackBarRenderer.DrawHorizontalTicks (g, new Rectangle (225, 75, 100, 20), 5, System.Windows.Forms.VisualStyles.EdgeStyle.Raised);
					TrackBarRenderer.DrawHorizontalTicks (g, new Rectangle (335, 75, 100, 20), 25, System.Windows.Forms.VisualStyles.EdgeStyle.Sunken);

					TrackBarRenderer.DrawHorizontalTrack (g, new Rectangle (5, 120, 100, 20));

					TrackBarRenderer.DrawLeftPointingThumb (g, new Rectangle (5, 145, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawLeftPointingThumb (g, new Rectangle (25, 145, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawLeftPointingThumb (g, new Rectangle (45, 145, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawLeftPointingThumb (g, new Rectangle (65, 145, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawRightPointingThumb (g, new Rectangle (5, 165, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawRightPointingThumb (g, new Rectangle (25, 165, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawRightPointingThumb (g, new Rectangle (45, 165, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawRightPointingThumb (g, new Rectangle (65, 165, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawTopPointingThumb (g, new Rectangle (5, 185, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawTopPointingThumb (g, new Rectangle (20, 185, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawTopPointingThumb (g, new Rectangle (35, 185, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawTopPointingThumb (g, new Rectangle (50, 185, 12, 20), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawVerticalThumb (g, new Rectangle (5, 215, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled);
					TrackBarRenderer.DrawVerticalThumb (g, new Rectangle (25, 215, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot);
					TrackBarRenderer.DrawVerticalThumb (g, new Rectangle (45, 215, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal);
					TrackBarRenderer.DrawVerticalThumb (g, new Rectangle (65, 215, 20, 12), System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed);

					TrackBarRenderer.DrawVerticalTicks (g, new Rectangle (5, 230, 20, 100), 15, System.Windows.Forms.VisualStyles.EdgeStyle.Bump);
					TrackBarRenderer.DrawVerticalTicks (g, new Rectangle (50, 230, 20, 100), 10, System.Windows.Forms.VisualStyles.EdgeStyle.Etched);
					TrackBarRenderer.DrawVerticalTicks (g, new Rectangle (95, 230, 20, 100), 5, System.Windows.Forms.VisualStyles.EdgeStyle.Raised);
					TrackBarRenderer.DrawVerticalTicks (g, new Rectangle (140, 230, 20, 100), 25, System.Windows.Forms.VisualStyles.EdgeStyle.Sunken);

					TrackBarRenderer.DrawVerticalTrack (g, new Rectangle (185, 230, 20, 100));

					g.DrawString (TrackBarRenderer.GetBottomPointingThumbSize (g, System.Windows.Forms.VisualStyles.TrackBarThumbState.Normal).ToString (), f, Brushes.Black, new Point (5, 340));
					g.DrawString (TrackBarRenderer.GetLeftPointingThumbSize (g, System.Windows.Forms.VisualStyles.TrackBarThumbState.Hot).ToString (), f, Brushes.Black, new Point (5, 370));
					g.DrawString (TrackBarRenderer.GetRightPointingThumbSize (g, System.Windows.Forms.VisualStyles.TrackBarThumbState.Disabled).ToString (), f, Brushes.Black, new Point (5, 400));
					g.DrawString (TrackBarRenderer.GetTopPointingThumbSize (g, System.Windows.Forms.VisualStyles.TrackBarThumbState.Pressed).ToString (), f, Brushes.Black, new Point (5, 430));
					break;
				default:
					break;
			}
		}
	}
}