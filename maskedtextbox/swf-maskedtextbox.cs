using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swf_maskedtextbox
{
	public class frmMain : Form
	{
		static void Main ()
		{
			Application.Run (new frmMain ());
		}
		
		public frmMain ()
		{
			InitializeComponent ();

			UpdateLabels (Controls);
			AttachEvents (Controls);
		}

		void AttachEvents (Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls) {
				AttachEvents (ctrl.Controls);
				MaskedTextBox mtp = ctrl as MaskedTextBox;

				if (mtp == null)
					continue;

				mtp.Validating += new System.ComponentModel.CancelEventHandler (this.maskedTextBox_Validating);
				mtp.MaskChanged += new System.EventHandler (this.maskedTextBox_MaskChanged);
				mtp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler (this.maskedTextBox_PreviewKeyDown);
				mtp.Validated += new System.EventHandler (this.maskedTextBox_Validated);
				mtp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler (this.maskedTextBox_MaskInputRejected);
				mtp.Enter += new System.EventHandler (this.maskedTextBox_Enter);
				mtp.ModifiedChanged += new System.EventHandler (this.maskedTextBox_ModifiedChanged);
				mtp.KeyDown += new System.Windows.Forms.KeyEventHandler (this.maskedTextBox_KeyDown);
				mtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.maskedTextBox_KeyPress);
				mtp.IsOverwriteModeChanged += new System.EventHandler (this.maskedTextBox_IsOverwriteModeChanged);
				mtp.KeyUp += new System.Windows.Forms.KeyEventHandler (this.maskedTextBox_KeyUp);
				mtp.TextChanged += new System.EventHandler (this.maskedTextBox_TextChanged);
				mtp.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler (this.maskedTextBox_TypeValidationCompleted);
				mtp.Leave += new System.EventHandler (this.maskedTextBox_Leave);
				mtp.Click += new System.EventHandler (this.maskedTextBox_Click);
			}
		}

		void UpdateLabels (Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls) {
				UpdateLabels (ctrl.Controls);
				MaskedTextBox mtp = ctrl as MaskedTextBox;

				if (mtp == null)
					continue;

				if (!mtp.Name.StartsWith ("maskedTextBox"))
					continue;

				Label lbl = controls [mtp.Name.Replace ("maskedTextBox", "label")] as Label;

				if (lbl == null)
					continue;

				lbl.Text = string.Format ("Mask = {0}, ??", mtp.Mask, mtp.AsciiOnly, mtp.HidePromptOnLeave, mtp.InsertKeyMode, mtp.IsOverwriteMode,
					mtp.RejectInputOnFirstFailure, mtp.ResetOnPrompt, mtp.ResetOnSpace, mtp.CutCopyMaskFormat, mtp.TextMaskFormat,
					mtp.ValidatingType, mtp.AllowPromptAsInput, mtp.PasswordChar);
			}
		}

		private void maskedTextBox_Click (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_Enter (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_IsOverwriteModeChanged (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_KeyDown (object sender, KeyEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_KeyUp (object sender, KeyEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_Leave (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_MaskChanged (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_MaskInputRejected (object sender, MaskInputRejectedEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_ModifiedChanged (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_PreviewKeyDown (object sender, PreviewKeyDownEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_TextChanged (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_TypeValidationCompleted (object sender, TypeValidationEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_Validated (object sender, EventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
		}

		private void maskedTextBox_Validating (object sender, CancelEventArgs e)
		{
			MaskedTextBox mtp = sender as MaskedTextBox;
			if (mtp == null) return;
			lstEvents.Items.Add (mtp.Name + "." + System.Reflection.MethodInfo.GetCurrentMethod ().Name.Substring (14));
			lstEvents.TopIndex = lstEvents.Items.Count - 1;
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
			this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox ();
			this.tabControl1 = new System.Windows.Forms.TabControl ();
			this.tabPage1 = new System.Windows.Forms.TabPage ();
			this.label8 = new System.Windows.Forms.Label ();
			this.label7 = new System.Windows.Forms.Label ();
			this.label6 = new System.Windows.Forms.Label ();
			this.label5 = new System.Windows.Forms.Label ();
			this.label4 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label9 = new System.Windows.Forms.Label ();
			this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox ();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox ();
			this.tabPage2 = new System.Windows.Forms.TabPage ();
			this.gridProperties = new System.Windows.Forms.PropertyGrid ();
			this.mtbPropertyGrid = new System.Windows.Forms.MaskedTextBox ();
			this.lstEvents = new System.Windows.Forms.ListBox ();
			this.tabControl1.SuspendLayout ();
			this.tabPage1.SuspendLayout ();
			this.tabPage2.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// maskedTextBox9
			// 
			this.maskedTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox9.Location = new System.Drawing.Point (8, 409);
			this.maskedTextBox9.Mask = "000-00-0000";
			this.maskedTextBox9.Name = "maskedTextBox9";
			this.maskedTextBox9.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox9.TabIndex = 16;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add (this.tabPage1);
			this.tabControl1.Controls.Add (this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point (0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size (751, 582);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add (this.label8);
			this.tabPage1.Controls.Add (this.label7);
			this.tabPage1.Controls.Add (this.label6);
			this.tabPage1.Controls.Add (this.label5);
			this.tabPage1.Controls.Add (this.label4);
			this.tabPage1.Controls.Add (this.label3);
			this.tabPage1.Controls.Add (this.label2);
			this.tabPage1.Controls.Add (this.label1);
			this.tabPage1.Controls.Add (this.label9);
			this.tabPage1.Controls.Add (this.maskedTextBox8);
			this.tabPage1.Controls.Add (this.maskedTextBox7);
			this.tabPage1.Controls.Add (this.maskedTextBox6);
			this.tabPage1.Controls.Add (this.maskedTextBox5);
			this.tabPage1.Controls.Add (this.maskedTextBox4);
			this.tabPage1.Controls.Add (this.maskedTextBox3);
			this.tabPage1.Controls.Add (this.maskedTextBox2);
			this.tabPage1.Controls.Add (this.maskedTextBox1);
			this.tabPage1.Controls.Add (this.maskedTextBox9);
			this.tabPage1.Location = new System.Drawing.Point (4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding (3);
			this.tabPage1.Size = new System.Drawing.Size (743, 556);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point (8, 382);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size (729, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "label1";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point (8, 332);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size (729, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "label1";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point (8, 282);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size (729, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "label1";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point (8, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size (729, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "label1";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point (8, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size (729, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "label1";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point (8, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size (729, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "label1";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point (8, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (729, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "label1";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point (8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (729, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point (8, 432);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size (729, 18);
			this.label9.TabIndex = 17;
			this.label9.Text = "label1";
			// 
			// maskedTextBox8
			// 
			this.maskedTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox8.Location = new System.Drawing.Point (8, 359);
			this.maskedTextBox8.Mask = "000-0000";
			this.maskedTextBox8.Name = "maskedTextBox8";
			this.maskedTextBox8.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox8.TabIndex = 14;
			// 
			// maskedTextBox7
			// 
			this.maskedTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox7.Location = new System.Drawing.Point (8, 309);
			this.maskedTextBox7.Mask = "000-000-0000";
			this.maskedTextBox7.Name = "maskedTextBox7";
			this.maskedTextBox7.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox7.TabIndex = 12;
			// 
			// maskedTextBox6
			// 
			this.maskedTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox6.Location = new System.Drawing.Point (8, 259);
			this.maskedTextBox6.Mask = "(999)000-0000";
			this.maskedTextBox6.Name = "maskedTextBox6";
			this.maskedTextBox6.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox6.TabIndex = 10;
			// 
			// maskedTextBox5
			// 
			this.maskedTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox5.Location = new System.Drawing.Point (8, 209);
			this.maskedTextBox5.Mask = "99999";
			this.maskedTextBox5.Name = "maskedTextBox5";
			this.maskedTextBox5.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox5.TabIndex = 8;
			this.maskedTextBox5.ValidatingType = typeof (int);
			// 
			// maskedTextBox4
			// 
			this.maskedTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox4.Location = new System.Drawing.Point (8, 159);
			this.maskedTextBox4.Mask = "00:00";
			this.maskedTextBox4.Name = "maskedTextBox4";
			this.maskedTextBox4.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox4.TabIndex = 6;
			this.maskedTextBox4.ValidatingType = typeof (System.DateTime);
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox3.Location = new System.Drawing.Point (8, 109);
			this.maskedTextBox3.Mask = "00/00/0000 00:00";
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox3.TabIndex = 4;
			this.maskedTextBox3.ValidatingType = typeof (System.DateTime);
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox2.Location = new System.Drawing.Point (8, 59);
			this.maskedTextBox2.Mask = "00/00/0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox2.TabIndex = 2;
			this.maskedTextBox2.ValidatingType = typeof (System.DateTime);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox1.Location = new System.Drawing.Point (8, 9);
			this.maskedTextBox1.Mask = "00000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size (729, 20);
			this.maskedTextBox1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add (this.gridProperties);
			this.tabPage2.Controls.Add (this.mtbPropertyGrid);
			this.tabPage2.Location = new System.Drawing.Point (4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding (3);
			this.tabPage2.Size = new System.Drawing.Size (482, 566);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Manual";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gridProperties
			// 
			this.gridProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				    | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.gridProperties.Location = new System.Drawing.Point (8, 32);
			this.gridProperties.Name = "gridProperties";
			this.gridProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.gridProperties.SelectedObject = this.mtbPropertyGrid;
			this.gridProperties.Size = new System.Drawing.Size (468, 528);
			this.gridProperties.TabIndex = 1;
			// 
			// mtbPropertyGrid
			// 
			this.mtbPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.mtbPropertyGrid.Location = new System.Drawing.Point (8, 6);
			this.mtbPropertyGrid.Name = "mtbPropertyGrid";
			this.mtbPropertyGrid.Size = new System.Drawing.Size (468, 20);
			this.mtbPropertyGrid.TabIndex = 0;
			// 
			// lstEvents
			// 
			this.lstEvents.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstEvents.FormattingEnabled = true;
			this.lstEvents.Location = new System.Drawing.Point (751, 0);
			this.lstEvents.Name = "lstEvents";
			this.lstEvents.Size = new System.Drawing.Size (220, 576);
			this.lstEvents.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (971, 582);
			this.Controls.Add (this.tabControl1);
			this.Controls.Add (this.lstEvents);
			this.Name = "frmMain";
			this.Text = "MaskedTextBox";
			this.tabControl1.ResumeLayout (false);
			this.tabPage1.ResumeLayout (false);
			this.tabPage1.PerformLayout ();
			this.tabPage2.ResumeLayout (false);
			this.tabPage2.PerformLayout ();
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox maskedTextBox9;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PropertyGrid gridProperties;
		private System.Windows.Forms.MaskedTextBox mtbPropertyGrid;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox lstEvents;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox8;
		private System.Windows.Forms.MaskedTextBox maskedTextBox7;
		private System.Windows.Forms.MaskedTextBox maskedTextBox6;
		private System.Windows.Forms.MaskedTextBox maskedTextBox5;
		private System.Windows.Forms.MaskedTextBox maskedTextBox4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}