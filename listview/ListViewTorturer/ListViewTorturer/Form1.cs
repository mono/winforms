using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public partial class Form1 : Form
	{
		const int DefaultItemCount = 5000;

		TestForm test_form;
		ResultForm result_form;

		public Form1 ()
		{
			InitializeComponent ();

			test_form = new TestForm ();
			test_form.EndTest += TestForm_EndTestHandler;

			result_form = new ResultForm ();

			numericUpDown1.Maximum = Int32.MaxValue;
			numericUpDown1.Value = DefaultItemCount;
			comboBox1.SelectedIndex = 0;
		}

		void TestForm_EndTestHandler (object o, EndTestEventArgs args)
		{
			if (!args.ShowDefaultDialog)
				return;

			result_form.Interval = args.Interval;
			result_form.ListView = test_form.Tester.ListView;
			result_form.ShowDialog ();
		}

		ListViewDescriptor GetDescriptor ()
		{
			ListViewDescriptor descriptor = new ListViewDescriptor ();

			descriptor.ItemCount = (int)numericUpDown1.Value;

			switch (comboBox1.SelectedIndex) {
				case 0: 
					descriptor.View = View.LargeIcon;
					break;
				case 1:
					descriptor.View = View.SmallIcon;
					break;
				case 2:
					descriptor.View = View.List;
					break;
				case 3:
					descriptor.View = View.Tile;
					break;
				case 4:
					descriptor.View = View.Details;
					break;
			}

			return descriptor;
		}

		private void resizeButton_Click (object sender, EventArgs e)
		{
		}

		private void exitButton_Click (object sender, EventArgs e)
		{
			Close ();
		}

		private void numericUpDown1_ValueChanged (object sender, EventArgs e)
		{
		}

		private void button1_Click (object sender, EventArgs e)
		{
			AddItemsTester tester = new AddItemsTester (GetDescriptor ());
			test_form.Tester = tester;
			test_form.ShowDialog ();
		}

		private void button2_Click (object sender, EventArgs e)
		{
			SelectionChangeTester tester = new SelectionChangeTester (GetDescriptor ());
			test_form.Tester = tester;
			test_form.ShowDialog ();
		}
	}
}