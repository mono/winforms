using System;
using System.Windows.Forms;

namespace MonoSamples
{
	public class ListViewTest : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpAlignment;
		private System.Windows.Forms.GroupBox grpBorderStyle;
		private System.Windows.Forms.GroupBox grpFont;
		private System.Windows.Forms.GroupBox grpHeader;
		private System.Windows.Forms.GroupBox grpMisc;
		private System.Windows.Forms.Label lblAlignmentLeft;
		private System.Windows.Forms.Label lblAlignmentSnapToGrid;
		private System.Windows.Forms.Label lblAlignmentTop;
		private System.Windows.Forms.Label lblBSFixed3D;
		private System.Windows.Forms.Label lblBSFixedSingle;
		private System.Windows.Forms.Label lblBSNone;
		private System.Windows.Forms.Label lblFontBackColor;
		private System.Windows.Forms.Label lblFontFont;
		private System.Windows.Forms.Label lblFontForeColor;
		private System.Windows.Forms.Label lblHSClickable;
		private System.Windows.Forms.Label lblHSNonClickable;
		private System.Windows.Forms.Label lblHSNone;
		private System.Windows.Forms.Label lblMiscGridLines;
		private System.Windows.Forms.Label lblMiscRowSelect;
		private System.Windows.Forms.Label lblMiscScrollable;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.ListView listView6;
		private System.Windows.Forms.ListView listView7;
		private System.Windows.Forms.ListView listView8;
		private System.Windows.Forms.ListView listView9;
		private System.Windows.Forms.ListView listView10;
		private System.Windows.Forms.ListView listView11;
		private System.Windows.Forms.ListView listView12;
		private System.Windows.Forms.ListView listView13;
		private System.Windows.Forms.ListView listView14;
		private System.Windows.Forms.ListView listView15;

		public ListViewTest()
		{
			InitializeComponent();

			fillListView(this.listView1);
			fillListView(this.listView2);
			fillListView(this.listView3);
			fillListView(this.listView4);
			fillListView(this.listView5);
			fillListView(this.listView6);
			fillListView(this.listView7);
			fillListView(this.listView8);
			fillListView(this.listView9);
			fillListViewDetails(this.listView10);
			fillListViewDetails(this.listView11);
			fillListViewDetails(this.listView12);
			fillListViewDetails(this.listView13);
			fillListViewDetails(this.listView14);
			fillListViewDetails(this.listView15);
		}

		public static void Main(string[] args)
		{
			Application.Run(new ListViewTest());
		}

		private void fillListView(ListView lv)
		{
			lv.Items.Add(new ListViewItem(new string[]{"foo"}));
			lv.Items.Add(new ListViewItem(new string[]{"bar"}));
			lv.Items.Add(new ListViewItem(new string[]{"baz"}));
			lv.Items.Add(new ListViewItem(new string[]{"quux"}));
		}

		private void fillListViewDetails(ListView lv)
		{
			ColumnHeader header = null;
			ListViewItem item = null;

			header = new ColumnHeader();
			header.Text = "un";
			lv.Columns.Add(header);

			header = new ColumnHeader();
			header.Text = "deux";
			lv.Columns.Add(header);

			header = new ColumnHeader();
			header.Text = "trois";
			lv.Columns.Add(header);

			item = new ListViewItem("foo");
			item.SubItems.Add("bar");
			item.SubItems.Add("baz");
			lv.Items.Add(item);

			item = new ListViewItem("CA");
			item.SubItems.Add("MD");
			item.SubItems.Add("WI");
			lv.Items.Add(item);

			item = new ListViewItem("Sushi");
			item.SubItems.Add("Indian");
			item.SubItems.Add("Tex-Mex");
			lv.Items.Add(item);
		}

		private void InitializeComponent()
		{
			this.grpAlignment = new System.Windows.Forms.GroupBox();
			this.grpBorderStyle = new System.Windows.Forms.GroupBox();
			this.grpFont = new System.Windows.Forms.GroupBox();
			this.grpHeader = new System.Windows.Forms.GroupBox();
			this.grpMisc = new System.Windows.Forms.GroupBox();
			this.lblAlignmentLeft = new System.Windows.Forms.Label();
			this.lblAlignmentSnapToGrid = new System.Windows.Forms.Label();
			this.lblAlignmentTop = new System.Windows.Forms.Label();
			this.lblBSFixed3D = new System.Windows.Forms.Label();
			this.lblBSFixedSingle = new System.Windows.Forms.Label();
			this.lblBSNone = new System.Windows.Forms.Label();
			this.lblFontBackColor = new System.Windows.Forms.Label();
			this.lblFontFont = new System.Windows.Forms.Label();
			this.lblFontForeColor = new System.Windows.Forms.Label();
			this.lblHSClickable = new System.Windows.Forms.Label();
			this.lblHSNonClickable = new System.Windows.Forms.Label();
			this.lblHSNone = new System.Windows.Forms.Label();
			this.lblMiscGridLines = new System.Windows.Forms.Label();
			this.lblMiscRowSelect = new System.Windows.Forms.Label();
			this.lblMiscScrollable = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView3 = new System.Windows.Forms.ListView();
			this.listView4 = new System.Windows.Forms.ListView();
			this.listView5 = new System.Windows.Forms.ListView();
			this.listView6 = new System.Windows.Forms.ListView();
			this.listView7 = new System.Windows.Forms.ListView();
			this.listView8 = new System.Windows.Forms.ListView();
			this.listView9 = new System.Windows.Forms.ListView();
			this.listView10 = new System.Windows.Forms.ListView();
			this.listView11 = new System.Windows.Forms.ListView();
			this.listView12 = new System.Windows.Forms.ListView();
			this.listView13 = new System.Windows.Forms.ListView();
			this.listView14 = new System.Windows.Forms.ListView();
			this.listView15 = new System.Windows.Forms.ListView();

			//-----------------------------------------------------------------
			// Border Style
			//
			// grpBorderStyle
			this.grpBorderStyle.Controls.Add(this.listView1);
			this.grpBorderStyle.Controls.Add(this.listView2);
			this.grpBorderStyle.Controls.Add(this.listView3);
			this.grpBorderStyle.Controls.Add(this.lblBSNone);
			this.grpBorderStyle.Controls.Add(this.lblBSFixedSingle);
			this.grpBorderStyle.Controls.Add(this.lblBSFixed3D);
			this.grpBorderStyle.Location = new System.Drawing.Point(8, 0);
			this.grpBorderStyle.Name = "grpBorderStyle";
			this.grpBorderStyle.Size = new System.Drawing.Size(392, 88);
			this.grpBorderStyle.TabIndex = 4;
			this.grpBorderStyle.TabStop = false;
			this.grpBorderStyle.Text = "Border Style";
			// lblBSNone
			this.lblBSNone.Location = new System.Drawing.Point(272, 16);
			this.lblBSNone.Name = "lblBSNone";
			this.lblBSNone.TabIndex = 8;
			this.lblBSNone.Text = "None";
			// lblBSFixedSingle
			this.lblBSFixedSingle.Location = new System.Drawing.Point(144, 16);
			this.lblBSFixedSingle.Name = "lblBSFixedSingle";
			this.lblBSFixedSingle.TabIndex = 7;
			this.lblBSFixedSingle.Text = "FixedSingle";
			// lblBSFixed3D
			this.lblBSFixed3D.Location = new System.Drawing.Point(16, 16);
			this.lblBSFixed3D.Name = "lblBSFixed3D";
			this.lblBSFixed3D.TabIndex = 6;
			this.lblBSFixed3D.Text = "Fixed3D";
			// listView1
			this.listView1.Location = new System.Drawing.Point(8, 32);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(120, 40);
			this.listView1.TabIndex = 3;
			// listView2
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Location = new System.Drawing.Point(136, 32);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(120, 40);
			this.listView2.TabIndex = 4;
			// listView3
			this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView3.Location = new System.Drawing.Point(264, 32);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(120, 40);
			this.listView3.TabIndex = 5;

			//-----------------------------------------------------------------
			// Font
			//

			// grpFont
			this.grpFont.Controls.Add(this.listView4);
			this.grpFont.Controls.Add(this.listView5);
			this.grpFont.Controls.Add(this.listView6);
			this.grpFont.Controls.Add(this.lblFontFont);
			this.grpFont.Controls.Add(this.lblFontForeColor);
			this.grpFont.Controls.Add(this.lblFontBackColor);
			this.grpFont.Location = new System.Drawing.Point(8, 88);
			this.grpFont.Name = "grpFont";
			this.grpFont.Size = new System.Drawing.Size(392, 100);
			this.grpFont.TabIndex = 5;
			this.grpFont.TabStop = false;
			this.grpFont.Text = "Font";
			// lblFontFont
			this.lblFontFont.Location = new System.Drawing.Point(280, 16);
			this.lblFontFont.Name = "lblFontFont";
			this.lblFontFont.Size = new System.Drawing.Size(100, 16);
			this.lblFontFont.TabIndex = 8;
			this.lblFontFont.Text = "Font=Verdana, 9pt";
			// lblFontForeColor
			this.lblFontForeColor.Location = new System.Drawing.Point(144, 16);
			this.lblFontForeColor.Name = "lblFontForeColor";
			this.lblFontForeColor.Size = new System.Drawing.Size(100, 16);
			this.lblFontForeColor.TabIndex = 6;
			this.lblFontForeColor.Text = "ForeColor=red";
			// lblFontBackColor
			this.lblFontBackColor.Location = new System.Drawing.Point(24, 16);
			this.lblFontBackColor.Name = "lblFontBackColor";
			this.lblFontBackColor.Size = new System.Drawing.Size(100, 16);
			this.lblFontBackColor.TabIndex = 5;
			this.lblFontBackColor.Text = "BackColor=red";
			// listView4
			this.listView4.BackColor = System.Drawing.Color.Red;
			this.listView4.Location = new System.Drawing.Point(8, 32);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(120, 56);
			this.listView4.TabIndex = 3;
			// listView5
			this.listView5.ForeColor = System.Drawing.Color.Red;
			this.listView5.Location = new System.Drawing.Point(136, 32);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(120, 56);
			this.listView5.TabIndex = 4;
			// listView6
			this.listView6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView6.Location = new System.Drawing.Point(264, 32);
			this.listView6.Name = "listView6";
			this.listView6.Size = new System.Drawing.Size(120, 56);
			this.listView6.TabIndex = 7;

			//-----------------------------------------------------------------
			// Alignment
			//

			// grpAlignment
			this.grpAlignment.Controls.Add(this.listView7);
			this.grpAlignment.Controls.Add(this.listView8);
			this.grpAlignment.Controls.Add(this.listView9);
			this.grpAlignment.Controls.Add(this.lblAlignmentLeft);
			this.grpAlignment.Controls.Add(this.lblAlignmentTop);
			this.grpAlignment.Controls.Add(this.lblAlignmentSnapToGrid);
			this.grpAlignment.Location = new System.Drawing.Point(8, 192);
			this.grpAlignment.Name = "grpAlignment";
			this.grpAlignment.Size = new System.Drawing.Size(392, 96);
			this.grpAlignment.TabIndex = 9;
			this.grpAlignment.TabStop = false;
			this.grpAlignment.Text = "Alignment";
			// lblAlignmentLeft
			this.lblAlignmentLeft.Location = new System.Drawing.Point(24, 16);
			this.lblAlignmentLeft.Name = "lblAlignmentLeft";
			this.lblAlignmentLeft.TabIndex = 3;
			this.lblAlignmentLeft.Text = "Alignment=Left";
			// lblAlignmentTop
			this.lblAlignmentTop.Location = new System.Drawing.Point(150, 16);
			this.lblAlignmentTop.Name = "lblAlignmentTop";
			this.lblAlignmentTop.TabIndex = 4;
			this.lblAlignmentTop.Text = "Alignment=Top";
			// lblAlignmentSnapToGrid
			this.lblAlignmentSnapToGrid.Location = new System.Drawing.Point(256, 16);
			this.lblAlignmentSnapToGrid.Name = "lblAlignmentSnapToGrid";
			this.lblAlignmentSnapToGrid.Size = new System.Drawing.Size(128, 23);
			this.lblAlignmentSnapToGrid.TabIndex = 5;
			this.lblAlignmentSnapToGrid.Text = "Alignment=SnapToGrid";
			// listView7
			this.listView7.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.listView7.Location = new System.Drawing.Point(8, 32);
			this.listView7.Name = "listView7";
			this.listView7.Size = new System.Drawing.Size(120, 56);
			this.listView7.TabIndex = 0;
			// listView8
			this.listView8.Location = new System.Drawing.Point(136, 32);
			this.listView8.Name = "listView8";
			this.listView8.Size = new System.Drawing.Size(120, 56);
			this.listView8.TabIndex = 1;
			// listView9
			this.listView9.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.listView9.Location = new System.Drawing.Point(264, 32);
			this.listView9.Name = "listView9";
			this.listView9.Size = new System.Drawing.Size(120, 56);
			this.listView9.TabIndex = 2;

			//-----------------------------------------------------------------
			// Misc
			//

			// grpMisc
			this.grpMisc.Controls.Add(this.listView11);
			this.grpMisc.Controls.Add(this.listView10);
			this.grpMisc.Controls.Add(this.lblMiscRowSelect);
			this.grpMisc.Controls.Add(this.lblMiscGridLines);
			this.grpMisc.Controls.Add(this.listView12);
			this.grpMisc.Controls.Add(this.lblMiscScrollable);
			this.grpMisc.Location = new System.Drawing.Point(8, 288);
			this.grpMisc.Name = "grpMisc";
			this.grpMisc.Size = new System.Drawing.Size(392, 96);
			this.grpMisc.TabIndex = 17;
			this.grpMisc.TabStop = false;
			this.grpMisc.Text = "Misc";
			// lblMiscRowSelect
			this.lblMiscRowSelect.Location = new System.Drawing.Point(16, 14);
			this.lblMiscRowSelect.Name = "lblMiscRowSelect";
			this.lblMiscRowSelect.Size = new System.Drawing.Size(104, 23);
			this.lblMiscRowSelect.TabIndex = 19;
			this.lblMiscRowSelect.Text = "FullRowSelect=true";
			// lblMiscGridLines
			this.lblMiscGridLines.Location = new System.Drawing.Point(152, 14);
			this.lblMiscGridLines.Name = "lblMiscGridLines";
			this.lblMiscGridLines.Size = new System.Drawing.Size(88, 23);
			this.lblMiscGridLines.TabIndex = 21;
			this.lblMiscGridLines.Text = "GridLines=true";
			// lblMiscScrollable
			this.lblMiscScrollable.Location = new System.Drawing.Point(264, 16);
			this.lblMiscScrollable.Name = "lblMiscScrollable";
			this.lblMiscScrollable.Size = new System.Drawing.Size(104, 23);
			this.lblMiscScrollable.TabIndex = 22;
			this.lblMiscScrollable.Text = "Scrollable=false";
			// listView10
			this.listView10.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.listView10.CheckBoxes = true;
			this.listView10.FullRowSelect = true;
			this.listView10.Location = new System.Drawing.Point(8, 30);
			this.listView10.Name = "listView10";
			this.listView10.Size = new System.Drawing.Size(120, 56);
			this.listView10.TabIndex = 18;
			this.listView10.View = System.Windows.Forms.View.Details;
			// listView11
			this.listView11.GridLines = true;
			this.listView11.Location = new System.Drawing.Point(136, 30);
			this.listView11.Name = "listView11";
			this.listView11.Size = new System.Drawing.Size(112, 56);
			this.listView11.TabIndex = 20;
			this.listView11.View = System.Windows.Forms.View.Details;
			// listView12
			this.listView12.Location = new System.Drawing.Point(256, 32);
			this.listView12.Name = "listView12";
			this.listView12.Scrollable = false;
			this.listView12.Size = new System.Drawing.Size(121, 56);
			this.listView12.TabIndex = 18;
			this.listView12.View = System.Windows.Forms.View.Details;

			//-----------------------------------------------------------------
			// Header Style
			//

			// grpHeader
			this.grpHeader.Controls.Add(this.listView15);
			this.grpHeader.Controls.Add(this.listView14);
			this.grpHeader.Controls.Add(this.listView13);
			this.grpHeader.Controls.Add(this.lblHSClickable);
			this.grpHeader.Controls.Add(this.lblHSNonClickable);
			this.grpHeader.Controls.Add(this.lblHSNone);
			this.grpHeader.Location = new System.Drawing.Point(8, 384);
			this.grpHeader.Name = "grpHeader";
			this.grpHeader.Size = new System.Drawing.Size(392, 96);
			this.grpHeader.TabIndex = 28;
			this.grpHeader.TabStop = false;
			this.grpHeader.Text = "Header Style";
			// lblHSClickable
			this.lblHSClickable.Location = new System.Drawing.Point(24, 16);
			this.lblHSClickable.Name = "lblHSClickable";
			this.lblHSClickable.Size = new System.Drawing.Size(88, 23);
			this.lblHSClickable.TabIndex = 31;
			this.lblHSClickable.Text = "Clickable";
			// lblHSNonClickable
			this.lblHSNonClickable.Location = new System.Drawing.Point(152, 16);
			this.lblHSNonClickable.Name = "lblHSNonClickable";
			this.lblHSNonClickable.Size = new System.Drawing.Size(88, 23);
			this.lblHSNonClickable.TabIndex = 32;
			this.lblHSNonClickable.Text = "NonClickable";
			// lblHSNone
			this.lblHSNone.Location = new System.Drawing.Point(280, 16);
			this.lblHSNone.Name = "lblHSNone";
			this.lblHSNone.Size = new System.Drawing.Size(88, 23);
			this.lblHSNone.TabIndex = 33;
			this.lblHSNone.Text = "None";
			// listView13
			this.listView13.Location = new System.Drawing.Point(8, 32);
			this.listView13.Name = "listView13";
			this.listView13.Size = new System.Drawing.Size(120, 56);
			this.listView13.TabIndex = 28;
			this.listView13.View = System.Windows.Forms.View.Details;
			// listView14
			this.listView14.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView14.Location = new System.Drawing.Point(136, 32);
			this.listView14.Name = "listView14";
			this.listView14.Size = new System.Drawing.Size(120, 56);
			this.listView14.TabIndex = 29;
			this.listView14.View = System.Windows.Forms.View.Details;
			// listView15
			this.listView15.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView15.Location = new System.Drawing.Point(264, 32);
			this.listView15.Name = "listView15";
			this.listView15.Size = new System.Drawing.Size(120, 56);
			this.listView15.TabIndex = 30;
			this.listView15.View = System.Windows.Forms.View.Details;

			// ListViewTest
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 493);
			this.Controls.Add(this.grpHeader);
			this.Controls.Add(this.grpAlignment);
			this.Controls.Add(this.grpFont);
			this.Controls.Add(this.grpBorderStyle);
			this.Controls.Add(this.grpMisc);
			this.Name = "ListViewTest";
			this.Text = "SWF-listviews";

		}
	}
}
