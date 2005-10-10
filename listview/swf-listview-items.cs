// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2005 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//
// Application that allows to test intensively the ListView control
//
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MonoSamples
{
	public class ListViewTest : Form
	{
		private ListView listView_content;

		private Label label_activation;
		private ComboBox combo_activation;
		private Label label_alignment;
		private ComboBox combo_alignment;
		private Label label_borderstyle;
		private ComboBox combo_borderstyle;
		private Label label_view;
		private ComboBox combo_view;
		private Label label_sorting;
		private ComboBox combo_sorting;
		private Button button_addheaders;
		private Button button_removeheaders;
		private Button button_additems;
		private Button button_removeitems;
		private Button button_changeitems;
		private Label label_itemprop;
		private Label label_index;
		private Label label_index_val;
		private Label label_bounds;
		private Label label_bounds_val;
		private Label label_checked;
		private Label label_checked_val;
		private Label label_selected;
		private Label label_selected_val;
		private CheckBox checkbox_hidesel;
		private CheckBox checkbox_fullrow;
		private CheckBox checkbox_gridlines;
		private CheckBox checkbox_checkboxes;
		private CheckBox checkbox_labeledit;
		private	CheckBox checkbox_hover;
		private	CheckBox checkbox_multisel;
		private	CheckBox checkbox_labelwrap;
		private	CheckBox checkbox_scrollable;
		private int last_item = 0;
		private int image_index = 0;

		string[] names = {
				"abiword_48.png",
				"bmp.png",
				"disks.png",
				"evolution.png",				
			};

		public ListViewTest ()
		{
			InitializeComponent ();
		}

		public static void Main (string[] args)
		{
			Application.Run(new ListViewTest());
		}

		private void InitializeComponent ()
		{

			listView_content = new ListView ();
			listView_content.Location = new System.Drawing.Point (10, 10);
			listView_content.Size = new System.Drawing.Size (400, 300);
			listView_content.SelectedIndexChanged += new System.EventHandler (listviewIndexChanged);

			/* Small images */
			ImageList il = new ImageList ();
                	il.ColorDepth = ColorDepth.Depth32Bit;
                	il.ImageSize = new Size (32, 32);

                	for (int i = 0; i < names.Length; i++)                	
                		il.Images.Add (Image.FromFile ("listview-items-icons/32x32/" + names[i]));

                	listView_content.SmallImageList  = il;

                	/* Small images */
			il = new ImageList ();
                	il.ColorDepth = ColorDepth.Depth32Bit;
                	il.ImageSize = new Size (64, 64);
                	//il.ImageSize = new Size (128, 128);

                	for (int i = 0; i < names.Length; i++)                	                		
                		il.Images.Add (Image.FromFile ("listview-items-icons/64x64/" + names[i]));

			il.Images[1] = Image.FromFile ("horse.bmp");

                	listView_content.LargeImageList  = il;
			Controls.Add (listView_content);

			// 1 line
			label_activation = new Label ();
			label_activation.Text = "Activation";
			label_activation.Location = new System.Drawing.Point (430, 20);
			label_activation.AutoSize = true;
			Controls.Add (label_activation);

			combo_activation = new ComboBox ();
			combo_activation.Location = new System.Drawing.Point (430 + 80, 20);
			combo_activation.Size = new Size (100, 40);
			combo_activation.Items.AddRange (new object[] {"Standard", "OneClick","TwoClick"});
			combo_activation.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_activation.Text = Enum.GetName (listView_content.Activation.GetType(), listView_content.Activation);
			combo_activation.SelectedIndexChanged  += new System.EventHandler (comboactivation_selectedindex);
			Controls.Add (combo_activation);

			button_addheaders = new Button ();
			button_addheaders.Location = new System.Drawing.Point (430 + 200, 20);
			button_addheaders.Text = "Add Headers";
			button_addheaders.Click += new System.EventHandler (buttonAddHeaders);
			Controls.Add (button_addheaders);


			// 2 line
			label_alignment = new Label ();
			label_alignment.Text = "Aligment";
			label_alignment.Location = new System.Drawing.Point (430, 60);
			label_alignment.AutoSize = true;
			Controls.Add (label_alignment);

			combo_alignment = new ComboBox ();
			combo_alignment.Location = new System.Drawing.Point (430 + 80, 60);
			combo_alignment.Size = new Size (100, 40);
			combo_alignment.Items.AddRange (new object[] {"Default", "Left","SnapToGrid", "Top"});
			combo_alignment.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_alignment.Text = Enum.GetName (listView_content.Alignment.GetType(), listView_content.Alignment);
			combo_alignment.SelectedIndexChanged  += new System.EventHandler (comboalignment_selectedindex);
			Controls.Add (combo_alignment);

			button_removeheaders = new Button ();
			button_removeheaders.Location = new System.Drawing.Point (430 + 200, 60);
			button_removeheaders.Text = "Del Headers";
			button_removeheaders.Click += new System.EventHandler (buttonRemoveHeaders);
			Controls.Add (button_removeheaders);

			// 3 line
			label_borderstyle = new Label ();
			label_borderstyle.Text = "BorderStyle";
			label_borderstyle.Location = new System.Drawing.Point (430, 100);
			label_borderstyle.AutoSize = true;
			Controls.Add (label_borderstyle);

			combo_borderstyle = new ComboBox ();
			combo_borderstyle.Location = new System.Drawing.Point (430 + 80, 100);
			combo_borderstyle.Size = new Size (100, 40);
			combo_borderstyle.Items.AddRange (new object[] {"Fixed3D", "FixedSingle","None"});
			combo_borderstyle.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_borderstyle.Text = Enum.GetName (listView_content.BorderStyle.GetType(), listView_content.BorderStyle);
			combo_borderstyle.SelectedIndexChanged  += new System.EventHandler (comboborderstyle_selectedindex);
			Controls.Add (combo_borderstyle);

			button_additems = new Button ();
			button_additems.Location = new System.Drawing.Point (430 + 200, 100);
			button_additems.Text = "Add Items";
			button_additems.Click += new System.EventHandler (buttonAddItemsClick);
			Controls.Add (button_additems);

			// 4 line
			label_view = new Label ();
			label_view.Text = "View Mode";
			label_view.Location = new System.Drawing.Point (430, 140);
			label_view.AutoSize = true;
			Controls.Add (label_view);

			combo_view = new ComboBox ();
			combo_view.Location = new System.Drawing.Point (430 + 80, 140);
			combo_view.Size = new Size (100, 40);
			combo_view.Items.AddRange (new object[] {"Details", "LargeIcon","List", "SmallIcon "});
			combo_view.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_view.Text = Enum.GetName (listView_content.View.GetType(), listView_content.View);
			combo_view.SelectedIndexChanged  += new System.EventHandler (comboview_selectedindex);
			Controls.Add (combo_view);

			button_removeitems = new Button ();
			button_removeitems.Location = new System.Drawing.Point (430 + 200, 140);
			button_removeitems.Text = "Del Items";
			button_removeitems.Click += new System.EventHandler (buttonDelItemsClick);
			Controls.Add (button_removeitems);

			// 5 line
			label_sorting = new Label ();
			label_sorting.Text = "Sorting";
			label_sorting.Location = new System.Drawing.Point (430, 180);
			label_sorting.AutoSize = true;
			Controls.Add (label_sorting);

			combo_sorting = new ComboBox ();
			combo_sorting.Location = new System.Drawing.Point (430 + 80, 180);
			combo_sorting.Size = new Size (100, 40);
			combo_sorting.Items.AddRange (new object[] {"Ascending", "Descending","None"});
			combo_sorting.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_sorting.Text = Enum.GetName (listView_content.Sorting.GetType(), listView_content.Sorting);
			combo_sorting.SelectedIndexChanged  += new System.EventHandler (combosorting_selectedindex);
			Controls.Add (combo_sorting);

			button_changeitems = new Button ();
			button_changeitems.Location = new System.Drawing.Point (430 + 200, 180);
			button_changeitems.Text = "Chg Items";
			button_changeitems.Click += new System.EventHandler (buttonChgItemsClick);
			Controls.Add (button_changeitems);

			// Item properties
			label_itemprop = new Label ();
			label_itemprop.Font = new Font (label_itemprop.Font, FontStyle.Underline);
			label_itemprop.Text = "ListViewItem properties";
			label_itemprop.Location = new System.Drawing.Point (430, 350 + 50);
			label_itemprop.AutoSize = true;
			Controls.Add (label_itemprop);

			label_index = new Label ();
			label_index.Text = "Index:";
			label_index.Location = new System.Drawing.Point (430, 380 + 50);
			label_index.AutoSize = true;
			Controls.Add (label_index);

			label_index_val = new Label ();
			label_index_val.Location = new System.Drawing.Point (430 + 80, 380 + 50);
			label_index_val.AutoSize = true;
			Controls.Add (label_index_val);

			label_bounds = new Label ();
			label_bounds.Text = "Bounds:";
			label_bounds.Location = new System.Drawing.Point (430, 410 + 50);
			label_bounds.AutoSize = true;
			Controls.Add (label_bounds);

			label_bounds_val = new Label ();
			label_bounds_val.Location = new System.Drawing.Point (430 + 80, 410 + 50);
			label_bounds_val.AutoSize = true;
			Controls.Add (label_bounds_val);

			label_checked = new Label ();
			label_checked.Text = "Checked:";
			label_checked.Location = new System.Drawing.Point (430, 440 + 50);
			label_checked.AutoSize = true;
			Controls.Add (label_checked);

			label_checked_val = new Label ();
			label_checked_val.Location = new System.Drawing.Point (430 + 80, 440 + 50);
			label_checked_val.AutoSize = true;
			Controls.Add (label_checked_val);

			label_selected = new Label ();
			label_selected.Text = "Selected:";
			label_selected.Location = new System.Drawing.Point (430, 470+ 50);
			label_selected.AutoSize = true;
			Controls.Add (label_selected);

			label_selected_val = new Label ();
			label_selected_val.Location = new System.Drawing.Point (430 + 80, 470+ 50);
			label_selected_val.AutoSize = true;
			Controls.Add (label_selected_val);

			// CheckBoxes
			checkbox_checkboxes = new CheckBox ();
			checkbox_checkboxes.Location = new System.Drawing.Point (430, 240);
			checkbox_checkboxes.Text = "CheckBoxes";
			checkbox_checkboxes.Checked = listView_content.CheckBoxes;
			button_removeitems.Click += new System.EventHandler (checkboxcheckboxesChanged);
			Controls.Add (checkbox_checkboxes);

			checkbox_gridlines = new CheckBox ();
			checkbox_gridlines.Location = new System.Drawing.Point (430 + 150, 240);
			checkbox_gridlines.Text = "GridLines";
			checkbox_gridlines.Click += new System.EventHandler (checkboxgridlinesChanged);
			checkbox_gridlines.Checked = listView_content.GridLines;
			Controls.Add (checkbox_gridlines);

			checkbox_fullrow = new CheckBox ();
			checkbox_fullrow.Location = new System.Drawing.Point (430, 270);
			checkbox_fullrow.Text = "Full Row Select";
			checkbox_fullrow.Click += new System.EventHandler (checkbox_fullrowChanged);
			checkbox_fullrow.Checked = listView_content.FullRowSelect;
			Controls.Add (checkbox_fullrow);

			checkbox_hidesel = new CheckBox ();
			checkbox_hidesel.Location = new System.Drawing.Point (430 + 150, 270);
			checkbox_hidesel.Text = "Hide Selection";
			checkbox_hidesel.Click += new System.EventHandler (checkbox_hideselChanged);
			checkbox_hidesel.Checked = listView_content.HideSelection;
			Controls.Add (checkbox_hidesel);

			checkbox_hover = new CheckBox ();
			checkbox_hover.Location = new System.Drawing.Point (430, 300);
			checkbox_hover.Text = "HoverSelection";
			checkbox_hover.Click += new System.EventHandler (checkbox_hoverChanged);
			checkbox_hover.Checked = listView_content.HoverSelection;
			Controls.Add (checkbox_hover);

			checkbox_labeledit = new CheckBox ();
			checkbox_labeledit.Location = new System.Drawing.Point (430 + 150, 300);
			checkbox_labeledit.Text = "LabelEdit";
			checkbox_labeledit.Click += new System.EventHandler (checkbox_labeleditChanged);
			checkbox_labeledit.Checked = listView_content.LabelEdit;
			Controls.Add (checkbox_labeledit);

			checkbox_labelwrap = new CheckBox ();
			checkbox_labelwrap.Location = new System.Drawing.Point (430, 330);
			checkbox_labelwrap.Text = "LabelWrap";
			checkbox_labelwrap.Click += new System.EventHandler (checkbox_labelwrapChanged);
			checkbox_labelwrap.Checked = listView_content.LabelWrap;
			Controls.Add (checkbox_labelwrap);

			checkbox_multisel = new CheckBox ();
			checkbox_multisel.Location = new System.Drawing.Point (430 + 150, 330);
			checkbox_multisel.Text = "MultiSelect";
			checkbox_multisel.Click += new System.EventHandler (checkbox_multiselChanged);
			checkbox_multisel.Checked = listView_content.MultiSelect;
			Controls.Add (checkbox_multisel);

			checkbox_scrollable = new CheckBox ();
			checkbox_scrollable.Location = new System.Drawing.Point (430, 360);
			checkbox_scrollable.Text = "Scrollable";
			checkbox_scrollable.Click += new System.EventHandler (checkbox_labelwrapChanged);
			checkbox_scrollable.Checked = listView_content.Scrollable;
			Controls.Add (checkbox_scrollable);

			// ListViewTest
			ClientSize = new System.Drawing.Size (800, 600);
			Text = "ListView-Items";

		}

		// Events
		private void buttonAddItemsClick (object sender, System.EventArgs e)
		{
			for (int i = 0; i < 10; i++) {
				ListViewItem item = new ListViewItem ();
				item.Text = "Item " + last_item;
				item.ImageIndex = image_index;
				listView_content.Items.Add (item);
				last_item++;
				image_index++;
				
				for (int subitems = 0; subitems < 5; subitems++) {					
    					item.SubItems.Add ("SubItem" + subitems);
				}

				if (image_index >= names.Length)
					image_index  = 0;
			}
		}

		private void buttonDelItemsClick (object sender, System.EventArgs e)
		{
			listView_content.Clear ();
		}

		private void buttonChgItemsClick (object sender, System.EventArgs e)
		{
			for (int i = 0; i < listView_content.Items.Count; i++) {
				listView_content.Items [i].BackColor = Color.Blue;
				Console.WriteLine ("Item {0} - {1}", listView_content.Items [i].Text,
						listView_content.Items [i].GetBounds (ItemBoundsPortion.Entire));
			}
		}

		private void listviewIndexChanged (object sender, System.EventArgs e)
		{
			label_index_val.Text = "" + listView_content.FocusedItem.Index;
			label_bounds_val.Text = "" + listView_content.FocusedItem.Bounds;
			label_checked_val.Text = "" + listView_content.FocusedItem.Checked;
			label_selected_val.Text = "" + listView_content.FocusedItem.Selected;
		}

		private void comboview_selectedindex (object sender, System.EventArgs e)
		{
			listView_content.View = (View) Enum.Parse (listView_content.View.GetType(), combo_view.Text);
		}

		private void comboborderstyle_selectedindex (object sender, System.EventArgs e)
		{
			listView_content.BorderStyle = (BorderStyle) Enum.Parse (listView_content.BorderStyle.GetType(), combo_borderstyle.Text);
		}

		private void comboalignment_selectedindex (object sender, System.EventArgs e)
		{
			listView_content.Alignment = (ListViewAlignment) Enum.Parse (listView_content.Alignment.GetType(), combo_alignment.Text);
		}

		private void comboactivation_selectedindex (object sender, System.EventArgs e)
		{
			listView_content.Activation = (ItemActivation) Enum.Parse (listView_content.Activation.GetType(), combo_activation.Text);
		}

		private void combosorting_selectedindex (object sender, System.EventArgs e)
		{
			listView_content.Sorting = (SortOrder) Enum.Parse (listView_content.Sorting.GetType(), combo_sorting.Text);
		}

		private void checkbox_fullrowChanged (object sender, System.EventArgs e)
		{
			listView_content.FullRowSelect = !listView_content.FullRowSelect;
		}

		private void checkboxgridlinesChanged (object sender, System.EventArgs e)
		{
			listView_content.GridLines = !listView_content.GridLines;
		}

		private void checkbox_hideselChanged (object sender, System.EventArgs e)
		{
			listView_content.HideSelection = !listView_content.HideSelection;
		}

		private void checkboxcheckboxesChanged (object sender, System.EventArgs e)
		{
			listView_content.CheckBoxes = !listView_content.CheckBoxes;
		}

		private void checkbox_hoverChanged (object sender, System.EventArgs e)
		{
			listView_content.HoverSelection = !listView_content.HoverSelection;
		}

		private void checkbox_labeleditChanged (object sender, System.EventArgs e)
		{
			listView_content.LabelEdit  = !listView_content.LabelEdit ;
		}

		private void checkbox_labelwrapChanged (object sender, System.EventArgs e)
		{
			listView_content.LabelWrap = !listView_content.LabelWrap;
		}

		private void checkbox_multiselChanged (object sender, System.EventArgs e)
		{
			listView_content.MultiSelect  = !listView_content.MultiSelect;
		}

		private void checkbox_scrollableChanged (object sender, System.EventArgs e)
		{
			listView_content.Scrollable = !listView_content.Scrollable;
		}

		private void buttonAddHeaders (object sender, System.EventArgs e)
		{
			listView_content.Columns.Add ("Item Column",150, HorizontalAlignment.Right);
    			listView_content.Columns.Add ("Column 2", 100, HorizontalAlignment.Left);
    			listView_content.Columns.Add ("Column 3", 100, HorizontalAlignment.Left);
    			listView_content.Columns.Add ("Column 4", 400, HorizontalAlignment.Center);
		}

		private void buttonRemoveHeaders (object sender, System.EventArgs e)
		{
			listView_content.Columns.Clear ();
		}
	}
}
