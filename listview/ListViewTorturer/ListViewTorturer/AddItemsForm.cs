using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewTorturer
{
	public partial class AddItemsForm : Form
	{
		ListView lv;

		public AddItemsForm ()
		{
			InitializeComponent ();

		}

		public ListView ListView {
			get {
				return lv;
			}
			set {
				this.lv = value;
			}
		}

		protected override void OnVisibleChanged (EventArgs e)
		{
			base.OnVisibleChanged (e);
			if (!Visible)
				return;
		}
	}
}
