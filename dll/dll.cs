using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestDllMono {
	/// <summary>
	/// Summary description for TestForm.
	/// </summary>
	public class TestForm : System.Windows.Forms.Form {
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtSrNo;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress1;
		private System.Windows.Forms.TextBox txtAddress2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TestForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
				//
			}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtSrNo = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress1 = new System.Windows.Forms.TextBox();
			this.txtAddress2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//  
			// pictureBox1
			//  
			this.pictureBox1.Location = new System.Drawing.Point(8, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(744, 640);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			//  
			// label1
			//  
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Serial No. :";
			//  
			// label2
			//  
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 40);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name :";
			//  
			// label3
			//  
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(56, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 48);
			this.label3.TabIndex = 3;
			this.label3.Text = "Address1 :";
			//  
			// label4
			//  
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(56, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 40);
			this.label4.TabIndex = 4;
			this.label4.Text = "Address2";
			//  
			// btnSave
			//  
			this.btnSave.Location = new System.Drawing.Point(184, 328);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(96, 40);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new 
				System.EventHandler(this.btnSave_Click);
			//  
			// btnClose
			//  
			this.btnClose.Location = new System.Drawing.Point(328, 328);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 40);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new 
				System.EventHandler(this.btnClose_Click);
			//  
			// txtSrNo
			//  
			this.txtSrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSrNo.Location = new System.Drawing.Point(176, 48);
			this.txtSrNo.Name = "txtSrNo";
			this.txtSrNo.Size = new System.Drawing.Size(216, 22);
			this.txtSrNo.TabIndex = 7;
			this.txtSrNo.Text = "";
			//  
			// txtName
			//  
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, 
					     System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtName.Location = new System.Drawing.Point(176, 104);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(216, 22);
			this.txtName.TabIndex = 8;
			this.txtName.Text = "";
			//  
			// txtAddress1
			//  
			this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, 
						  System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAddress1.Location = new System.Drawing.Point(176, 168);
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.Size = new System.Drawing.Size(216, 22);
			this.txtAddress1.TabIndex = 9;
			this.txtAddress1.Text = "";
			//  
			// txtAddress2
			//  
			this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, 
						  System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAddress2.Location = new System.Drawing.Point(176, 232);
			this.txtAddress2.Name = "txtAddress2";
			this.txtAddress2.Size = new System.Drawing.Size(224, 22);
			this.txtAddress2.TabIndex = 10;
			this.txtAddress2.Text = "";
			//  
			// TestForm
			//  
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(768, 669);
			this.Controls.Add(this.txtAddress2);
			this.Controls.Add(this.txtAddress1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtSrNo);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			//this.Controls.Add(this.pictureBox1);
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e) {
			this.Close();  
		}

		private void btnSave_Click(object sender, System.EventArgs e) {
#if not
			DataLayer.DataLayer  dtLayer = new DataLayer.DataLayer();

			//MessageBox.Show (dtLayer.ReturnError );

             
			dtLayer.SrNo = txtSrNo.Text  ;
			dtLayer.Name = txtName.Text;
			dtLayer.Address1 = txtAddress1.Text;
			dtLayer.Address2 = txtAddress2.Text;
			dtLayer.EntryType = "1";
			try {
				dtLayer.InsertData ();

				//    MessageBox.Show (dtLayer.ReturnError );

			}
			catch (Exception ex) {
				MessageBox.Show (ex.Message );
			}

#endif
			MessageBox.Show ("Data Entry Successfull");

		}

		private void TestForm_Load(object sender, System.EventArgs e) {
			this.Left = 0 ;
			this.Top = 0  ;

		}
	}
}
