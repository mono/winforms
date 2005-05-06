using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Text;
using System.Threading;

namespace TextTestClass {
	public class MainWindow : System.Windows.Forms.Form {
		static System.Windows.Forms.Timer	t;
		static Form		main_window;
		static Label		label1;
		static Label		label2;
		static Label		label3;
		static Label		label4;
		static Label		label5;
		static Label		label6;
		static ErrorProvider	e;
		static bool		etype;

		public MainWindow() {
			this.ClientSize = new Size(300, 300);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.SuspendLayout();

			label1 = new Label();
			label1.Font = new Font("Arial", 24);
			label1.Location= new Point(15, 15);
			label1.Size = new Size(70, 70);
			label1.Text="Label1";
			label1.ForeColor = Color.Green;
			label1.BackColor = Color.LightGray;
			label1.Anchor=AnchorStyles.Left | AnchorStyles.Top;
			this.Controls.Add(label1);

			label2 = new Label();
			label2.Font = new Font("Times New Roman", 16);
			label2.Location= new Point(115, 15);
			label2.Size = new Size(70, 70);
			label2.Text="Label2";
			label2.ForeColor = Color.Red;
			label2.BackColor = Color.White;
			this.Controls.Add(label2);

			label3 = new Label();
			label3.Font = new Font("Sans Serif", 12);
			label3.Location= new Point(15, 215);
			label3.Size = new Size(70, 70);
			label3.Text="Label3";
			label3.ForeColor = Color.Red;
			label3.BackColor = Color.White;
			this.Controls.Add(label3);

			label4 = new Label();
			label4.Font = new Font("Arial", 24);
			label4.Location= new Point(15, 115);
			label4.Size = new Size(70, 70);
			label4.Text="label4";
			label4.ForeColor = Color.Green;
			label4.BackColor = Color.LightGray;
			this.Controls.Add(label4);

			label5 = new Label();
			label5.Font = new Font("Times New Roman", 16);
			label5.Location= new Point(115, 115);
			label5.Size = new Size(70, 70);
			label5.Text="label5";
			label5.ForeColor = Color.Red;
			label5.BackColor = Color.White;
			this.Controls.Add(label5);

			label6 = new Label();
			label6.Font = new Font("Sans Serif", 12);
			label6.Location= new Point(215, 115);
			label6.Size = new Size(70, 70);
			label6.Text="Label6";
			label6.ForeColor = Color.Red;
			label6.BackColor = Color.White;
			label6.Dock = DockStyle.Right;
			this.Controls.Add(label6);

			this.ResumeLayout(true);

			e = new ErrorProvider(this);

			e.SetIconAlignment(label1, ErrorIconAlignment.TopLeft);
			e.SetError(label1, "label1");

			e.SetIconAlignment(label2, ErrorIconAlignment.TopRight);
			e.SetError(label2, "label2 error");

			e.SetIconAlignment(label3, ErrorIconAlignment.BottomLeft);
			e.SetError(label3, "label3 error");
			e.SetIconPadding(label3, 5);

			e.SetIconAlignment(label4, ErrorIconAlignment.BottomRight);
			e.SetError(label4, "label4 error");

			e.SetIconAlignment(label5, ErrorIconAlignment.MiddleRight);
			e.SetError(label5, "label5 error");

			e.SetIconAlignment(label6, ErrorIconAlignment.MiddleLeft);
			e.SetError(label6, "label6 error");

			t = new System.Windows.Forms.Timer();
			t.Tick += new EventHandler(t_Tick);
			t.Interval = 5000;	// 5 seconds
			t.Enabled = true;
		}

		public static void Main() {
			main_window = new MainWindow();
			Application.Run(main_window);
		}

		private void t_Tick(object sender, EventArgs ev) {
			Console.WriteLine("Changing label6 text");
			if (etype) {
				e.SetError(label6, "Timed error 1");
				etype = false;
			} else {
				e.SetError(label6, "Timed error 2");
				etype = true;
			}
		}
	}
}
