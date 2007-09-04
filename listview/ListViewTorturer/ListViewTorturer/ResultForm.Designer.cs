namespace ListViewTorturer
{
	partial class ResultForm
	{
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup ("ListView information", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup ("Time", System.Windows.Forms.HorizontalAlignment.Left);
			this.listView1 = new System.Windows.Forms.ListView ();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader ();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader ();
			this.SuspendLayout ();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange (new System.Windows.Forms.ColumnHeader [] {
            this.columnHeader1,
            this.columnHeader2});
			listViewGroup1.Header = "ListView information";
			listViewGroup1.Name = "listviewGroup";
			listViewGroup2.Header = "Time";
			listViewGroup2.Name = "timeGroup";
			this.listView1.Groups.AddRange (new System.Windows.Forms.ListViewGroup [] {
            listViewGroup1,
            listViewGroup2});
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView1.Location = new System.Drawing.Point (6, 6);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size (195, 203);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Property";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (205, 213);
			this.Controls.Add (this.listView1);
			this.Name = "ResultForm";
			this.ShowInTaskbar = false;
			this.Text = "ResultForm";
			this.Load += new System.EventHandler (this.ResultForm_Load);
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;

	}
}