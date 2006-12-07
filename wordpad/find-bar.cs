

using System;
using System.Drawing;
using System.Windows.Forms;


public class FindBar : UserControl {

	private class UnSelectableButton : Button {

		public UnSelectableButton ()
		{
			SetStyle (ControlStyles.Selectable, false);
		}
	}

	private class UnSelectableCheckBox : CheckBox {

		public UnSelectableCheckBox ()
		{
			SetStyle (ControlStyles.Selectable, false);
		}
	}

	private RichTextBox rtb;

	private Button close;
	private Label find_label;
	private TextBox search_box;
	private Button find_next;
	private Button find_previous;
	private Button highlight;
	private CheckBox match_case;
	private Label phrase_not_found;

	private int search_index = -1;
	private RichTextBoxFinds find_options = RichTextBoxFinds.None;
	private Color no_match_found_color;

	public FindBar (RichTextBox rtb)
	{
		this.rtb = rtb;

		no_match_found_color = Color.FromArgb (255, 255, 102, 102);
		Height = 25;

		close = new UnSelectableButton ();
		close.Image = Image.FromFile ("close.png");
		close.Size = new Size (16, 16);
		close.Location = new Point (3, 4);
		close.Click += new EventHandler (CloseClickedHandler);
		Controls.Add (close);

		find_label = new Label ();
		find_label.AutoSize = true;
		find_label.Text = "Find:";
		find_label.Font = new Font (FontFamily.GenericSansSerif, 12f);
		find_label.Location = new Point (close.Right + 10, 4);
		find_label.Width = 30;  // AutoSize broken???
		Controls.Add (find_label);
		
		search_box = new TextBox ();
		search_box.Width = 100;
		search_box.Font = new Font (FontFamily.GenericSansSerif, 12f);
		search_box.Location = new Point (find_label.Right + 5, 1);
		search_box.Height = 22;
		search_box.TextChanged += new EventHandler (TextChangedHandler);
		Controls.Add (search_box);

		find_next = new UnSelectableButton ();
		find_next.Image = Image.FromFile ("next.png");
		find_next.Text = "Find Next ";
		find_next.ImageAlign = ContentAlignment.MiddleLeft;
		find_next.TextAlign = ContentAlignment.MiddleRight;
		find_next.FlatStyle = FlatStyle.Popup;
		find_next.Size = new Size (75, 22);
		find_next.Location = new Point (search_box.Right + 10, 1);
		find_next.Click += new EventHandler (FindNextHandler);
		Controls.Add (find_next);

		find_previous = new UnSelectableButton ();
		find_previous.Image = Image.FromFile ("previous.png");
		find_previous.Text = "Find Previous";
		find_previous.ImageAlign = ContentAlignment.MiddleLeft;
		find_previous.TextAlign = ContentAlignment.MiddleRight;
		find_previous.FlatStyle = FlatStyle.Popup;
		find_previous.Size = new Size (90, 22);
		find_previous.Location = new Point (find_next.Right + 2, 1);
		find_previous.Click += new EventHandler (FindPreviousHandler);
		Controls.Add (find_previous);

		highlight = new UnSelectableButton ();
		highlight.Image = Image.FromFile ("highlight-all.png");
		highlight.Text = "Highlight All";
		highlight.ImageAlign = ContentAlignment.MiddleLeft;
		highlight.TextAlign = ContentAlignment.MiddleRight;
		highlight.FlatStyle = FlatStyle.Popup;
		highlight.Size = new Size (83, 22);
		highlight.Location = new Point (find_previous.Right + 2, 1);
		Controls.Add (highlight);

		match_case = new UnSelectableCheckBox ();
		match_case.Font = new Font (FontFamily.GenericSansSerif, 12f);
		match_case.Text = "Match case";
		match_case.Location = new Point (highlight.Right + 3, 0);
		match_case.CheckedChanged += new EventHandler (MatchCaseCheckedChangedHandler);
		Controls.Add (match_case);

		phrase_not_found = new Label ();
		phrase_not_found.Font = new Font (FontFamily.GenericSansSerif, 12f);
		phrase_not_found.Image = Image.FromFile ("phrase-not-found.png");
		phrase_not_found.Text = "Phrase not found";
		phrase_not_found.ImageAlign = ContentAlignment.MiddleLeft;
		phrase_not_found.TextAlign = ContentAlignment.MiddleRight;
		phrase_not_found.Location = new Point (match_case.Right + 15, 1);
		phrase_not_found.Width = 130;
		phrase_not_found.Visible = false;
		Controls.Add (phrase_not_found);
	}

	public Color NoMatchFoundColor {
		get { return no_match_found_color; }
		set {
			// TODO update the textbox if this color is in use
			no_match_found_color = value;
		}
	}

	public void Open ()
	{
		Visible = true;
		search_box.Focus ();

		rtb.HideSelection = false;
		search_index = 0;

		search_index = 0; // Math.Max (rtb.SelectionStart, 0);
	}

	private void CloseClickedHandler (object sender, EventArgs e)
	{
		Hide ();
		Parent.PerformLayout ();
	}

	
	private void TextChangedHandler (object sender, EventArgs e)
	{
		/// TODO: Handle enter
		Search ();
	}

	private void Search ()
	{
		Console.WriteLine ("search index:  {0}", search_index);
		int next_index = rtb.Find (search_box.Text, search_index, -1, find_options);

		if (next_index != -1) {
			rtb.SelectionStart = next_index;
			rtb.SelectionLength = search_box.Text.Length;
			search_index = next_index;

			search_box.BackColor = SystemColors.Window;
			phrase_not_found.Visible = false;
		} else {
			rtb.SelectionStart = 0;
			rtb.SelectionLength = 0;

			search_box.BackColor = NoMatchFoundColor;
			phrase_not_found.Visible = true;
		}
		Console.WriteLine ("searching for: '{0}'  found at index: '{1}'",
				search_box.Text, next_index);
	}

	private void FindNextHandler (object sender, EventArgs e)
	{
		search_index++;
		int next_index = rtb.Find (search_box.Text, search_index, -1, find_options);

		if (next_index != -1) {
			rtb.SelectionStart = next_index;
			rtb.SelectionLength = search_box.Text.Length;
			search_index = next_index;
			Console.WriteLine ("FOUND NEXT:  '{0}'  at index:   {1}", search_box.Text, next_index);
		} else {
			
			search_index--;
			Console.WriteLine ("no next match found");
		}
	}

	private void FindPreviousHandler (object sender, EventArgs e)
	{
		int next_index = rtb.Find (search_box.Text, -1, search_index,
				find_options | RichTextBoxFinds.Reverse);

		if (next_index != -1) {
			rtb.SelectionStart = next_index;
			rtb.SelectionLength = search_box.Text.Length;
			search_index = next_index;
			Console.WriteLine ("FOUND PREVIOUS:  '{0}'  at index:   {1}",
					search_box.Text, next_index);
		} else {
			Console.WriteLine ("no previous match found");
		}
	}

	private void MatchCaseCheckedChangedHandler (object sender, EventArgs e)
	{
		if (match_case.Checked)
			find_options |= RichTextBoxFinds.MatchCase;
		else
			find_options ^= RichTextBoxFinds.MatchCase;
		Console.WriteLine ("search options:   {0}", find_options);

		Search ();
	}

	protected override void OnGotFocus (EventArgs e)
	{
		search_box.Focus ();
	}

#if _FINDBAR_TEST
	public static void Main ()
	{
		Form form = new Form ();
		RichTextBox rtb = new RichTextBox ();
		FindBar fb = new FindBar (rtb);

		fb.Dock = DockStyle.Bottom;
		form.Controls.Add (fb);

		rtb.Dock = DockStyle.Fill;
		form.Controls.Add (rtb);

		Application.Run (form);
	}
#endif
	
}

