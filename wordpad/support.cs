using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WordPad {
	[Serializable]
	public class Configuration {
		#region	Local Variables
		private Point		location;
		private Size		size;
		private bool		shortcutbar;
		private bool		formatbar;
		private ArrayList	mru;
		#endregion	// Local Variables

		#region	Constructors
		public Configuration() {
			size = new Size(300, 300);
			location = new Point(-1, -1);
			shortcutbar = true;
			formatbar = true;
			mru = new ArrayList(4);
		}
		#endregion	// Constructors

		#region	Properties
		public Point Location {
			get { return location; }
			set { location = value; }
		}

		public Size Size {
			get { return size; }
			set { size = value; }
		}

		public bool ShortcutBar {
			get { return shortcutbar; }
			set { shortcutbar = value; }
		}

		public bool FormatBar {
			get { return formatbar; }
			set { formatbar = value; }
		}

		public ArrayList MRU {
			get { return mru; }
			set { mru = value; }
		}
		#endregion	// Properties

		#region Static Methods
		static public void Save(Configuration config) {
			IsolatedStorageFile	isoFile;

			isoFile = IsolatedStorageFile.GetUserStoreForAssembly();

			try {
				using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("WordPad", FileMode.OpenOrCreate, FileAccess.Write, isoFile)) {
					BinaryFormatter formatter;

					formatter = new BinaryFormatter();
					formatter.Serialize(isoStream, config);
				}
			}

			catch {
				MessageBox.Show("Could not save configuration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		static public Configuration Load() {
			Configuration		config;
			IsolatedStorageFile	isoFile;

			isoFile = IsolatedStorageFile.GetUserStoreForAssembly();

			try {
				using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("WordPad", FileMode.Open, FileAccess.Read, isoFile)) {
					BinaryFormatter formatter;

					formatter = new BinaryFormatter();
					config = (Configuration)formatter.Deserialize(isoStream);

					return config;
				}
			}

			catch {
				MessageBox.Show("Could not load configuration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			// We failed, return default
			return new Configuration();
		}

		static public void Apply(WordPad wordpad) {
			Configuration config;

			config = Configuration.Load();

			if (config.Location.X != -1) {
				wordpad.StartPosition = FormStartPosition.Manual;
			}
			wordpad.Location = config.Location;
			wordpad.Size = config.Size;

			if (config.FormatBar) {
				wordpad.formatting.Visible = true;
			} else {
				wordpad.formatting.Visible = false;
			}

			if (config.ShortcutBar) {
				wordpad.buttons.Visible = true;
			} else {
				wordpad.buttons.Visible = false;
			}

			wordpad.MRU = config.MRU;
		}

		static public void Store(WordPad wordpad) {
			Configuration config;

			config = new Configuration();

			config.Location = wordpad.Location;
			config.Size = wordpad.Size;
			config.MRU = wordpad.MRU;

			if (wordpad.formatting.Visible) {
				config.FormatBar = true;
			} else {
				config.FormatBar = true;
			}

			if (wordpad.buttons.Visible) {
				config.ShortcutBar = true;
			} else {
				config.ShortcutBar = true;
			}

			Configuration.Save(config);
		}
		#endregion
	}

	#region WordPad Format Toolbar
	public class WordPadFormat : Control {
		#region Local Variables
		WordPad		wordpad;
		ComboBox	fonts;
		ComboBox	sizes;
		#endregion	// Local Variables

		#region Constructors
		public WordPadFormat(WordPad wordpad) {
			FontFamily[]	fontFamilies;

			this.wordpad = wordpad;
			Height = 21;
			fonts = new ComboBox();
			sizes = new ComboBox();

			fonts.DropDownStyle = ComboBoxStyle.DropDownList;

			fontFamilies = FontFamily.Families;
			fonts.BeginUpdate( );
			foreach ( FontFamily ff in fontFamilies ) {
				fonts.Items.Add( ff.Name );
			}
			fonts.EndUpdate();
			fonts.Location = new Point(0, 0);
			fonts.Width = 150;

			fonts.SelectedIndex = fonts.FindString("Arial");
			fonts.SelectedIndexChanged += new EventHandler(fonts_SelectedIndexChanged);

			sizes.DropDownStyle = ComboBoxStyle.DropDownList;
			sizes.Location = new Point(160, 0);
			sizes.Width = 50;

			sizes.Items.AddRange(new string[] {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"});
			sizes.SelectedIndex = 4;
			sizes.SelectedIndexChanged += new EventHandler(sizes_SelectedIndexChanged);



			this.Controls.Add(fonts);
			this.Controls.Add(sizes);
		}
		#endregion	// Constructors

		#region Properties
		#endregion	// Properties

		#region Methods
		#endregion	// Methods

		#region Event Handlers
		#endregion	// Event Handlers

		private void fonts_SelectedIndexChanged(object sender, EventArgs e) {
			if ((wordpad.edit != null) && (wordpad.edit.SelectionLength > 0)) {
				wordpad.edit.SelectionFont = new Font((string)fonts.Items[fonts.SelectedIndex], Int32.Parse((string)(sizes.Items[sizes.SelectedIndex])));
				wordpad.edit.Focus();
			}
		}

		private void sizes_SelectedIndexChanged(object sender, EventArgs e) {
			if ((wordpad.edit != null) && (wordpad.edit.SelectionLength > 0)) {
				wordpad.edit.SelectionFont = new Font((string)fonts.Items[fonts.SelectedIndex], Int32.Parse((string)(sizes.Items[sizes.SelectedIndex])));
				wordpad.edit.Focus();
			}
		}
	}
	#endregion	// WordPad Format Toolbar


	#region WordPad Menu Class
	public class WordPadMenu {
		#region	Local Variables
		MainMenu	menu;
		MenuItem	file, edit, view, insert, format, help;
		MenuItem	mnew, open, save, saveas, print, printpreview, pagesetup, mru1, mru2, mru3, mru4, exit;
		MenuItem	undo, cut, copy, paste, clear, selectall, find, findnext, replace;
		MenuItem	toolbar, formatbar, statusbar, options;
		MenuItem	datetime;
		MenuItem	fontstyle, bullet, paragraph, tabs;
		MenuItem	about;
		StatusBar	status;
		WordPad		wordpad;
		#endregion	// Local Variables

		#region Constructor
		public WordPadMenu(WordPad wordpad, StatusBar status) {
			this.status = status;
			this.wordpad = wordpad;

			mnew = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlN, "&New...", new EventHandler(NewDocument), null, new EventHandler(MenuSelectHandler), null);
			open = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlO, "&Open...", new EventHandler(OpenDocument), null, new EventHandler(MenuSelectHandler), null);
			save = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlS, "&Save...", new EventHandler(SaveDocument), null, new EventHandler(MenuSelectHandler), null);
			saveas = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "Save &As...", new EventHandler(SaveAs), null, new EventHandler(MenuSelectHandler), null);
			print = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlP, "&Print...", new EventHandler(PrintDocument), null, new EventHandler(MenuSelectHandler), null);
			printpreview = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "Print Pre&view", new EventHandler(PrintPreview), null, new EventHandler(MenuSelectHandler), null);
			pagesetup = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "Page Set&up...", new EventHandler(PrintPageSetup), null, new EventHandler(MenuSelectHandler), null);
			mru1 = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&1 - ", new EventHandler(OpenMRU1), null, new EventHandler(MenuSelectHandler), null);
			mru2 = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&2 - ", new EventHandler(OpenMRU2), null, new EventHandler(MenuSelectHandler), null);
			mru3 = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&3 - ", new EventHandler(OpenMRU3), null, new EventHandler(MenuSelectHandler), null);
			mru4 = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&4 - ", new EventHandler(OpenMRU4), null, new EventHandler(MenuSelectHandler), null);
			exit = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "E&xit", new EventHandler(Exit), null, new EventHandler(MenuSelectHandler), null);


			// FILE menu
			file = new MenuItem("&File");
			UpdateMRU();


			// EDIT menu
			edit = new MenuItem("&Edit");
			undo = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlZ, "&Undo", new EventHandler(DoUndo), null, new EventHandler(MenuSelectHandler), null);
			cut = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlX, "Cu&t", new EventHandler(DoCut), null, new EventHandler(MenuSelectHandler), null);
			copy = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlC, "&Copy", new EventHandler(DoCopy), null, new EventHandler(MenuSelectHandler), null);
			paste = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlV, "&Paste", new EventHandler(DoPaste), null, new EventHandler(MenuSelectHandler), null);
			clear = new MenuItem(MenuMerge.Add, 0, Shortcut.Del, "Cle&ar", new EventHandler(DoClear), null, new EventHandler(MenuSelectHandler), null);
			selectall = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlA, "Select A&ll", new EventHandler(DoSelectAll), null, new EventHandler(MenuSelectHandler), null);
			find = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlF, "&Find...", new EventHandler(DoFind), null, new EventHandler(MenuSelectHandler), null);
			findnext = new MenuItem(MenuMerge.Add, 0, Shortcut.F3, "Find &Next", new EventHandler(DoFindNext), null, new EventHandler(MenuSelectHandler), null);
			replace = new MenuItem(MenuMerge.Add, 0, Shortcut.CtrlH, "R&eplace...", new EventHandler(DoReplace), null, new EventHandler(MenuSelectHandler), null);
			edit.MenuItems.AddRange(new MenuItem[] {undo, new MenuItem("-"), cut, copy, paste, clear, selectall, new MenuItem("-"), find, findnext, replace});


			// VIEW menu
			view = new MenuItem("&View");
			toolbar = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Toolbar", new EventHandler(DoToolBar), null, new EventHandler(MenuSelectHandler), null);
			formatbar = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Format Bar", new EventHandler(DoFormatBar), null, new EventHandler(MenuSelectHandler), null);
			statusbar = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Status Bar", new EventHandler(DoStatusBar), null, new EventHandler(MenuSelectHandler), null);
			options = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Options...", new EventHandler(Options), null, new EventHandler(MenuSelectHandler), null);
			view.MenuItems.AddRange(new MenuItem[] {toolbar, formatbar, statusbar, new MenuItem("-"), options});


			// INSERT menu
			insert = new MenuItem("&Insert");
			datetime = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Date and Time...", new EventHandler(InsertDateTime), null, new EventHandler(MenuSelectHandler), null);
			insert.MenuItems.AddRange(new MenuItem[] {datetime});


			// FORMAT menu
			format = new MenuItem("F&ormat");
			fontstyle = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Font...", new EventHandler(ChangeFont), null, new EventHandler(MenuSelectHandler), null);
			bullet = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Bullet Style", new EventHandler(ChangeBulletStyle), null, new EventHandler(MenuSelectHandler), null);
			paragraph = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Paragraph...", new EventHandler(ChangeParagraph), null, new EventHandler(MenuSelectHandler), null);
			tabs = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&Tabs...", new EventHandler(ChangeTabs), null, new EventHandler(MenuSelectHandler), null);
			format.MenuItems.AddRange(new MenuItem[] {fontstyle, bullet, paragraph, tabs});


			// HELP menu
			help = new MenuItem("Help");
			about = new MenuItem(MenuMerge.Add, 0, Shortcut.None, "&About...", new EventHandler(About), null, new EventHandler(MenuSelectHandler), null);
			help.MenuItems.AddRange(new MenuItem[] {about});

			menu = new MainMenu(new MenuItem[] {file, edit, view, insert, format, help});

			edit.Popup += new EventHandler (OnEditPopup);
		}
		#endregion	// Constructor

		#region	Properties
		public StatusBar StatusBarObject {
			get { return status; }
			set { status = value; }
		}

		public MainMenu MainMenu {
			get { return menu; }
		}

		public bool Undo {
			get { return undo.Enabled; }
			set { undo.Enabled = value; }
		}

		public bool Cut {
			get { return cut.Enabled; }
			set { cut.Enabled = value; }
		}

		public bool Copy {
			get { return copy.Enabled; }
			set { copy.Enabled = value; }
		}

		public bool Paste {
			get { return paste.Enabled; }
			set { paste.Enabled = value; }
		}

		public bool Clear {
			get { return clear.Enabled; }
			set { clear.Enabled = value; }
		}

		public bool FindNext {
			get { return findnext.Enabled; }
			set { findnext.Enabled = value; }
		}

		public bool ToolBar {
			get { return toolbar.Checked; }
			set { toolbar.Checked = value; }
		}

		public bool FormatBar {
			get { return formatbar.Checked; }
			set { formatbar.Checked = value; }
		}

		public bool StatusBar {
			get { return statusbar.Checked; }
			set { statusbar.Checked = value; }
		}
		#endregion	// Properties

		#region Methods
		public void UpdateMRU() {
			if (wordpad != null && wordpad.MRU != null) {
				if (wordpad.MRU.Count > 0) mru1.Text = "&1 - " + (string)wordpad.MRU[0];
				if (wordpad.MRU.Count > 1) mru2.Text = "&2 - " + (string)wordpad.MRU[1];
				if (wordpad.MRU.Count > 2) mru3.Text = "&3 - " + (string)wordpad.MRU[2];
				if (wordpad.MRU.Count > 3) mru4.Text = "&4 - " + (string)wordpad.MRU[3];
			}
			
			// FILE menu
			file.MenuItems.Clear();
			file.MenuItems.AddRange(new MenuItem[] {mnew, open, save, saveas, new MenuItem("-"), print, printpreview, pagesetup, new MenuItem("-")});
			if (wordpad != null && wordpad.MRU != null) {
				if (wordpad.MRU.Count > 0) file.MenuItems.Add(mru1);
				if (wordpad.MRU.Count > 1) file.MenuItems.Add(mru2);
				if (wordpad.MRU.Count > 2) file.MenuItems.Add(mru3);
				if (wordpad.MRU.Count > 3) file.MenuItems.Add(mru4);
				file.MenuItems.Add(new MenuItem("-"));
			}
			file.MenuItems.Add(exit);
		}
		#endregion	// Methods

		#region Event Handlers
		private void MenuSelectHandler(object sender, EventArgs e) {
			if (status != null) {
				if (sender == mnew) status.Text = "Create new document"; 
				if (sender == open) status.Text = "Open existing document";
				if (sender == save) status.Text = "Save current document";
				if (sender == saveas) status.Text = "Save current document under new name";
				if (sender == print) status.Text = "Print document";
				if (sender == printpreview) status.Text = "Preview printed document";
				if (sender == pagesetup) status.Text = "Set up page layout for printing";
				if (sender == mru1 || sender == mru2 || sender == mru3 || sender == mru4) status.Text = "Open this document";
				if (sender == exit) status.Text = "Exit application";

				if (sender == undo) status.Text = "Undo last change";
				if (sender == cut) status.Text = "Cut the selection and put it into the clipboard";
				if (sender == copy) status.Text = "Copy the selection into the clipboard";
				if (sender == paste) status.Text = "Paste clipboard contents";
				if (sender == clear) status.Text = "Remove selected text";
				if (sender == selectall) status.Text = "Select the whole document";
				if (sender == find) status.Text = "Find text";
				if (sender == findnext) status.Text = "Repeat last find operation";
				if (sender == replace) status.Text = "Find and replace text";

				if (sender == toolbar) status.Text = "Show or hide the toolbar";
				if (sender == formatbar) status.Text = "Show or hide the formatting bar";
				if (sender == statusbar) status.Text = "Show or hide the status bar";
				if (sender == options) status.Text = "Set Options";

				if (sender == datetime) status.Text = "Insert current date and time";

				if (sender == fontstyle) status.Text = "Change Font";
				if (sender == bullet) status.Text = "Change Bullet Style";
				if (sender == paragraph) status.Text = "Change Paragraph settings";
				if (sender == tabs) status.Text = "Change tab settings";

				if (sender == about) status.Text = "Display information about this application";
			}
		}

		private void OnEditPopup (object sender, EventArgs e)
		{
			if (wordpad.edit.SelectionLength == 0) {
				cut.Enabled = false;
				copy.Enabled = false;
				clear.Enabled = false;
			} else {
				Console.WriteLine ("ENABLING ITEMS");
				cut.Enabled = true;
				copy.Enabled = true;
				clear.Enabled = true;
			}
		}

		// FILE
		private void NewDocument(object sender, EventArgs e) {
			wordpad.Clear();
		}

		private void OpenDocument(object sender, EventArgs e) {
			wordpad.Open();
		}

		private void SaveDocument(object sender, EventArgs e) {
			wordpad.Save(false);
		}

		private void SaveAs(object sender, EventArgs e) {
			wordpad.Save(true);
		}

		private void PrintDocument(object sender, EventArgs e) {
		}

		private void PrintPreview(object sender, EventArgs e) {
		}

		private void PrintPageSetup(object sender, EventArgs e) {
		}

		private void OpenMRU1(object sender, EventArgs e) {
			wordpad.OpenFile((string)wordpad.MRU[0], ((string)(wordpad.MRU[0])).EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
		}

		private void OpenMRU2(object sender, EventArgs e) {
			wordpad.OpenFile((string)wordpad.MRU[1], ((string)(wordpad.MRU[1])).EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
		}

		private void OpenMRU3(object sender, EventArgs e) {
			wordpad.OpenFile((string)wordpad.MRU[2], ((string)(wordpad.MRU[2])).EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
		}

		private void OpenMRU4(object sender, EventArgs e) {
			wordpad.OpenFile((string)wordpad.MRU[3], ((string)(wordpad.MRU[3])).EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
		}

		private void Exit(object sender, EventArgs e) {
			wordpad.Exit();
		}

		// EDIT
		private void DoUndo(object sender, EventArgs e) {
			wordpad.edit.Undo();
		}

		private void DoCut(object sender, EventArgs e) {
			wordpad.edit.Cut();
		}

		private void DoCopy(object sender, EventArgs e) {
			wordpad.edit.Copy();
		}

		private void DoPaste(object sender, EventArgs e) {
			wordpad.edit.Paste();
		}

		private void DoClear(object sender, EventArgs e) {
			wordpad.edit.SelectedText = String.Empty;

		}

		private void DoSelectAll(object sender, EventArgs e) {
			wordpad.edit.SelectAll();
		}

		private void DoFind(object sender, EventArgs e) {
			wordpad.findbar.Open ();
		}

		private void DoFindNext(object sender, EventArgs e) {
		}

		private void DoReplace(object sender, EventArgs e) {
		}

		// VIEW
		private void DoToolBar(object sender, EventArgs e) {
		}

		private void DoFormatBar(object sender, EventArgs e) {
		}

		private void DoStatusBar(object sender, EventArgs e) {
		}

		private void Options(object sender, EventArgs e) {
		}

		// INSERT
		private void InsertDateTime(object sender, EventArgs e) {
                        wordpad.edit.AppendText (DateTime.Now.ToString ());
		}
				
		// FORMAT
		private void ChangeFont(object sender, EventArgs e) {
		}

		private void ChangeBulletStyle(object sender, EventArgs e) {
		}

		private void ChangeParagraph(object sender, EventArgs e) {
		}

		private void ChangeTabs(object sender, EventArgs e) {
		}

		// HELP
		private void About(object sender, EventArgs e) {
		}

		#endregion
	}
	#endregion	// WordPad Menu Class
}
