namespace ListViewTorturer
{
	partial class Form1
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
			this.resizeButton = new System.Windows.Forms.Button ();
			this.groupBox1 = new System.Windows.Forms.GroupBox ();
			this.button3 = new System.Windows.Forms.Button ();
			this.button2 = new System.Windows.Forms.Button ();
			this.button1 = new System.Windows.Forms.Button ();
			this.groupBox2 = new System.Windows.Forms.GroupBox ();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown ();
			this.comboBox1 = new System.Windows.Forms.ComboBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.label1 = new System.Windows.Forms.Label ();
			this.groupBox1.SuspendLayout ();
			this.groupBox2.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit ();
			this.SuspendLayout ();
			// 
			// resizeButton
			// 
			this.resizeButton.Enabled = false;
			this.resizeButton.Location = new System.Drawing.Point (6, 19);
			this.resizeButton.Name = "resizeButton";
			this.resizeButton.Size = new System.Drawing.Size (119, 32);
			this.resizeButton.TabIndex = 0;
			this.resizeButton.Text = "Resize";
			this.resizeButton.UseVisualStyleBackColor = true;
			this.resizeButton.Click += new System.EventHandler (this.resizeButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add (this.button3);
			this.groupBox1.Controls.Add (this.button2);
			this.groupBox1.Controls.Add (this.button1);
			this.groupBox1.Controls.Add (this.resizeButton);
			this.groupBox1.Location = new System.Drawing.Point (12, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size (136, 176);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Demos";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point (6, 134);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size (119, 31);
			this.button3.TabIndex = 3;
			this.button3.Text = "Sorting";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point (6, 95);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size (119, 33);
			this.button2.TabIndex = 2;
			this.button2.Text = "Change Selection";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler (this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point (6, 57);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size (119, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add Items";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler (this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add (this.numericUpDown1);
			this.groupBox2.Controls.Add (this.comboBox1);
			this.groupBox2.Controls.Add (this.label2);
			this.groupBox2.Controls.Add (this.label1);
			this.groupBox2.Location = new System.Drawing.Point (154, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size (170, 89);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ListView properties";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point (72, 23);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size (86, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.ValueChanged += new System.EventHandler (this.numericUpDown1_ValueChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange (new object [] {
            "LargeIcon",
            "SmallIcon",
            "List",
            "Tile",
            "Details"});
			this.comboBox1.Location = new System.Drawing.Point (72, 53);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size (86, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point (36, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "View";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point (34, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Items";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (337, 189);
			this.Controls.Add (this.groupBox2);
			this.Controls.Add (this.groupBox1);
			this.Name = "Form1";
			this.Text = "ListView Torturer";
			this.groupBox1.ResumeLayout (false);
			this.groupBox2.ResumeLayout (false);
			this.groupBox2.PerformLayout ();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit ();
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.Button resizeButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}

