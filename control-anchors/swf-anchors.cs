using System;
using System.Windows.Forms;

namespace MonoSamples
{
	/// <summary>
	/// Summary description for AnchorForm.
	/// </summary>
	public class AnchorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnTop;
		private System.Windows.Forms.Button btnBottom;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnBottomRight;
		private System.Windows.Forms.Button btnTopRight;
		private System.Windows.Forms.Button btnBottomLeft;
		private System.Windows.Forms.Button btnTopLeft;
		private System.Windows.Forms.Button btnTopRightLeft;
		private System.Windows.Forms.Button btnTopLeftBottom;
		private System.Windows.Forms.Button btnTopRightBottom;
		private System.Windows.Forms.Button btnBottomRightLeft;
		private System.Windows.Forms.Button btnRightLeft;
		private System.Windows.Forms.Button btnTopBottom;
		private System.Windows.Forms.Button btnNone;

		public AnchorForm()
		{
			InitializeComponent();
		}

		public static void Main(string[] args)
		{
			Application.Run(new AnchorForm());
		}

		private void InitializeComponent()
		{
			this.btnTopRightLeft = new System.Windows.Forms.Button();
			this.btnTopLeftBottom = new System.Windows.Forms.Button();
			this.btnTopRightBottom = new System.Windows.Forms.Button();
			this.btnBottomRightLeft = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnTop = new System.Windows.Forms.Button();
			this.btnBottom = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnBottomRight = new System.Windows.Forms.Button();
			this.btnTopRight = new System.Windows.Forms.Button();
			this.btnBottomLeft = new System.Windows.Forms.Button();
			this.btnTopLeft = new System.Windows.Forms.Button();
			this.btnRightLeft = new System.Windows.Forms.Button();
			this.btnTopBottom = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			// 
			// btnTopRightLeft
			// 
			this.btnTopRightLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.btnTopRightLeft.Location = new System.Drawing.Point(168, 19);
			this.btnTopRightLeft.Name = "btnTopRightLeft";
			this.btnTopRightLeft.Size = new System.Drawing.Size(216, 23);
			this.btnTopRightLeft.TabIndex = 129;
			this.btnTopRightLeft.Text = "Anchor=Top,Right,Left";
			// 
			// btnTopLeftBottom
			// 
			this.btnTopLeftBottom.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnTopLeftBottom.Location = new System.Drawing.Point(524, 46);
			this.btnTopLeftBottom.Name = "btnTopLeftBottom";
			this.btnTopLeftBottom.Size = new System.Drawing.Size(24, 240);
			this.btnTopLeftBottom.TabIndex = 128;
			this.btnTopLeftBottom.Text = "Anchor=Top,Left,Bottom";
			// 
			// btnTopRightBottom
			// 
			this.btnTopRightBottom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.btnTopRightBottom.Location = new System.Drawing.Point(4, 46);
			this.btnTopRightBottom.Name = "btnTopRightBottom";
			this.btnTopRightBottom.Size = new System.Drawing.Size(24, 240);
			this.btnTopRightBottom.TabIndex = 127;
			this.btnTopRightBottom.Text = "Anchor=Top,Right,Bottom";
			// 
			// btnBottomRightLeft
			// 
			this.btnBottomRightLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.btnBottomRightLeft.Location = new System.Drawing.Point(164, 291);
			this.btnBottomRightLeft.Name = "btnBottomRightLeft";
			this.btnBottomRightLeft.Size = new System.Drawing.Size(216, 23);
			this.btnBottomRightLeft.TabIndex = 126;
			this.btnBottomRightLeft.Text = "Anchor=Bottom,Right,Left";
			// 
			// btnAll
			// 
			this.btnAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.btnAll.Location = new System.Drawing.Point(226, 133);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(100, 67);
			this.btnAll.TabIndex = 125;
			this.btnAll.Text = "Anchor=All";
			// 
			// btnTop
			// 
			this.btnTop.Anchor = AnchorStyles.Top;
			this.btnTop.Location = new System.Drawing.Point(220, 61);
			this.btnTop.Name = "btnTop";
			this.btnTop.Size = new System.Drawing.Size(116, 23);
			this.btnTop.TabIndex = 124;
			this.btnTop.Text = "Anchor=Top";
			// 
			// btnBottom
			// 
			this.btnBottom.Anchor = AnchorStyles.Bottom;
			this.btnBottom.Location = new System.Drawing.Point(220, 248);
			this.btnBottom.Name = "btnBottom";
			this.btnBottom.Size = new System.Drawing.Size(116, 23);
			this.btnBottom.TabIndex = 123;
			this.btnBottom.Text = "Anchor=Bottom";
			// 
			// btnLeft
			// 
			this.btnLeft.Anchor = AnchorStyles.Left;
			this.btnLeft.Location = new System.Drawing.Point(52, 149);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(120, 23);
			this.btnLeft.TabIndex = 122;
			this.btnLeft.Text = "Anchor=Left";
			// 
			// btnRight
			// 
			this.btnRight.Anchor = AnchorStyles.Right;
			this.btnRight.Location = new System.Drawing.Point(372, 149);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(120, 23);
			this.btnRight.TabIndex = 121;
			this.btnRight.Text = "Anchor=Right";
			// 
			// btnBottomRight
			// 
			this.btnBottomRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnBottomRight.Location = new System.Drawing.Point(372, 248);
			this.btnBottomRight.Name = "btnBottomRight";
			this.btnBottomRight.Size = new System.Drawing.Size(120, 23);
			this.btnBottomRight.TabIndex = 120;
			this.btnBottomRight.Text = "Anchor=Bottom,Right";
			// 
			// btnTopRight
			// 
			this.btnTopRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.btnTopRight.Location = new System.Drawing.Point(372, 61);
			this.btnTopRight.Name = "btnTopRight";
			this.btnTopRight.Size = new System.Drawing.Size(120, 23);
			this.btnTopRight.TabIndex = 119;
			this.btnTopRight.Text = "Anchor=Top,Right";
			// 
			// btnBottomLeft
			// 
			this.btnBottomLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.btnBottomLeft.Location = new System.Drawing.Point(52, 248);
			this.btnBottomLeft.Name = "btnBottomLeft";
			this.btnBottomLeft.Size = new System.Drawing.Size(120, 23);
			this.btnBottomLeft.TabIndex = 118;
			this.btnBottomLeft.Text = "Anchor=Bottom,Left";
			// 
			// btnTopLeft
			// 
			this.btnTopLeft.Location = new System.Drawing.Point(52, 61);
			this.btnTopLeft.Name = "btnTopLeft";
			this.btnTopLeft.Size = new System.Drawing.Size(120, 23);
			this.btnTopLeft.TabIndex = 117;
			this.btnTopLeft.Text = "Anchor=Top,Left";
			// 
			// btnRightLeft
			// 
			this.btnRightLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			this.btnRightLeft.Location = new System.Drawing.Point(104, 104);
			this.btnRightLeft.Name = "btnRightLeft";
			this.btnRightLeft.Size = new System.Drawing.Size(120, 23);
			this.btnRightLeft.TabIndex = 130;
			this.btnRightLeft.Text = "Anchor=Right,Left";
			// 
			// btnTopBottom
			// 
			this.btnTopBottom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			this.btnTopBottom.Location = new System.Drawing.Point(336, 96);
			this.btnTopBottom.Name = "btnTopBottom";
			this.btnTopBottom.Size = new System.Drawing.Size(24, 136);
			this.btnTopBottom.TabIndex = 131;
			this.btnTopBottom.Text = "Anchor=Top,Bottom";
			// 
			// btnNone
			// 
			this.btnNone.Anchor = AnchorStyles.None;
			this.btnNone.Location = new System.Drawing.Point(5, 5);
			this.btnNone.Name = "None";
			this.btnNone.Size = new System.Drawing.Size(40, 40);
			this.btnNone.TabIndex = 133;
			this.btnNone.Text = "None";


			// 
			// AnchorForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 333);
			this.SuspendLayout();
			this.Controls.Add(this.btnNone);
			this.Controls.Add(this.btnTopBottom);
			this.Controls.Add(this.btnRightLeft);
			this.Controls.Add(this.btnTopRightLeft);
			this.Controls.Add(this.btnTopLeftBottom);
			this.Controls.Add(this.btnTopRightBottom);
			this.Controls.Add(this.btnBottomRightLeft);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnTop);
			this.Controls.Add(this.btnBottom);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnBottomRight);
			this.Controls.Add(this.btnTopRight);
			this.Controls.Add(this.btnBottomLeft);
			this.Controls.Add(this.btnTopLeft);
			this.MinimumSize = new System.Drawing.Size(560, 360);
			this.Name = "AnchorForm";
			this.Text = "SWF-Anchors";
			this.ResumeLayout(false);

		}
	}
}
