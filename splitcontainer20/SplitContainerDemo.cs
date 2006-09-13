using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProfessionalColorTest
{
	public class SplitContainerDemo : Form
	{
            [STAThread]
            static void Main()
            {
                    Application.Run(new SplitContainerDemo());
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode ("Calendar");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode ("Contacts");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode ("Deleted Items");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode ("Drafts");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode ("Inbox");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode ("Outbox");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode ("Sent Items");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode ("Mail Center", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem (new string[] {
            "",
            "Bob",
            "Hi There!",
            "5/11/2006"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem (new string[] {
            "",
            "Sue",
            "Happy Birthday!",
            "5/11/2006"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem (new string[] {
            "",
            "Ralph",
            "Project Proposal",
            "5/10/2006"}, -1);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer ();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer ();
			this.treeView1 = new System.Windows.Forms.TreeView ();
			this.checkBox1 = new System.Windows.Forms.CheckBox ();
			this.checkBox2 = new System.Windows.Forms.CheckBox ();
			this.checkBox3 = new System.Windows.Forms.CheckBox ();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer ();
			this.listView1 = new System.Windows.Forms.ListView ();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader ();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader ();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader ();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader ();
			this.textBox3 = new System.Windows.Forms.TextBox ();
			this.splitContainer1.Panel1.SuspendLayout ();
			this.splitContainer1.Panel2.SuspendLayout ();
			this.splitContainer1.SuspendLayout ();
			this.splitContainer2.Panel1.SuspendLayout ();
			this.splitContainer2.Panel2.SuspendLayout ();
			this.splitContainer2.SuspendLayout ();
			this.splitContainer3.Panel1.SuspendLayout ();
			this.splitContainer3.Panel2.SuspendLayout ();
			this.splitContainer3.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point (0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add (this.treeView1);
			this.splitContainer1.Panel1MinSize = 100;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add (this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size (707, 477);
			this.splitContainer1.SplitterDistance = 149;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point (0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add (this.listView1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add (this.splitContainer3);
			this.splitContainer2.Size = new System.Drawing.Size (554, 477);
			this.splitContainer2.SplitterDistance = 112;
			this.splitContainer2.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point (0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Text = "Calendar";
			treeNode2.Text = "Contacts";
			treeNode3.Text = "Deleted Items";
			treeNode4.Text = "Drafts";
			treeNode5.Text = "Inbox";
			treeNode6.Text = "Outbox";
			treeNode7.Text = "Sent Items";
			treeNode8.Text = "Mail Center";
			this.treeView1.Nodes.AddRange (new System.Windows.Forms.TreeNode[] {
            treeNode8});
			this.treeView1.Size = new System.Drawing.Size (149, 477);
			this.treeView1.TabIndex = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point (3, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size (90, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Lock Splitters";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler (this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point (3, 24);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size (112, 17);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Switch Orientation";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler (this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point (3, 41);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size (124, 17);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Cancel Splitter Move";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point (0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add (this.textBox3);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add (this.checkBox3);
			this.splitContainer3.Panel2.Controls.Add (this.checkBox1);
			this.splitContainer3.Panel2.Controls.Add (this.checkBox2);
			this.splitContainer3.Size = new System.Drawing.Size (554, 361);
			this.splitContainer3.SplitterDistance = 297;
			this.splitContainer3.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.Items.AddRange (new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.listView1.Location = new System.Drawing.Point (0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size (554, 112);
			this.listView1.TabIndex = 17;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Width = 0;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "From";
			this.columnHeader1.Width = 130;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Subject";
			this.columnHeader2.Width = 251;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Date";
			this.columnHeader3.Width = 127;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point (0, 0);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size (554, 297);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "Some fancy text goes here...";
			// 
			// SplitContainerDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (707, 477);
			this.Controls.Add (this.splitContainer1);
			this.Name = "SplitContainerDemo";
			this.Text = "SplitContainerDemo";
			this.splitContainer1.Panel1.ResumeLayout (false);
			this.splitContainer1.Panel2.ResumeLayout (false);
			this.splitContainer1.ResumeLayout (false);
			this.splitContainer2.Panel1.ResumeLayout (false);
			this.splitContainer2.Panel2.ResumeLayout (false);
			this.splitContainer2.ResumeLayout (false);
			this.splitContainer3.Panel1.ResumeLayout (false);
			this.splitContainer3.Panel1.PerformLayout ();
			this.splitContainer3.Panel2.ResumeLayout (false);
			this.splitContainer3.Panel2.PerformLayout ();
			this.splitContainer3.ResumeLayout (false);
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox textBox3;

		public SplitContainerDemo ()
		{
			InitializeComponent ();

			splitContainer1.SplitterMoving += new SplitterCancelEventHandler (splitContainer1_SplitterMoving);
			splitContainer2.SplitterMoving += new SplitterCancelEventHandler (splitContainer1_SplitterMoving);
		}

		void splitContainer1_SplitterMoving (object sender, SplitterCancelEventArgs e)
		{
			if (checkBox3.Checked) e.Cancel = true;
		}

		private void checkBox1_CheckedChanged (object sender, EventArgs e)
		{
			splitContainer1.IsSplitterFixed = checkBox1.Checked;
			splitContainer2.IsSplitterFixed = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged (object sender, EventArgs e)
		{
			if (checkBox2.Checked)
				splitContainer2.Orientation = Orientation.Vertical;
			else
				splitContainer2.Orientation = Orientation.Horizontal;
		}
	}
}