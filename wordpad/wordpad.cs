using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WordPad {
	public class WordPad : System.Windows.Forms.Form {	
		#region	Local Variables
		static public WordPad	wordpad;
		static public int	debug;

		// UI Components
		public RichTextBox	edit;
		public WordPadMenu	menu;
		public ToolBar		buttons;
		public WordPadFormat	formatting;
		public StatusBar	status;
		public Panel		toolbarpanel;

		// Document
		public string			filename;
		public RichTextBoxStreamType	filetype;

		// State
		public bool		changed;
		public ArrayList	mru;
		#endregion	// Local Variables

		#region	Constructors
		public WordPad(string file) {
			// Object setup
			changed = false;
			if (file != null) {
				filename = file;
			} else {
				filename = "Document";
			}
			filetype = RichTextBoxStreamType.RichText;

			// UI Setup
			toolbarpanel = new Panel();
			buttons = new ToolBar();
			formatting = new WordPadFormat(this);
			status = new StatusBar();
			edit = new RichTextBox();
			Configuration.Apply(this);	// Call before creating the menu to have MRU loaded
			menu = new WordPadMenu(this, status);

			this.Menu = menu.MainMenu;

			buttons.Appearance = ToolBarAppearance.Flat;
			buttons.TextAlign = ToolBarTextAlign.Right;
			buttons.ButtonSize = new Size(12, 12);
			buttons.Buttons.Add("New");
			buttons.Buttons.Add("Open");
			buttons.Buttons.Add("Save");
			buttons.Divider = false;

			buttons.Location = new Point(0, 0);
			formatting.Location = new Point(0, buttons.Height);
			toolbarpanel.Height = buttons.Height + formatting.Height + 8;
			formatting.Dock = DockStyle.Bottom;

			// Register all required events
			this.Closing += new CancelEventHandler(WordPadClosing);
			edit.TextChanged += new EventHandler(DocumentChanged);

			// Layout
			toolbarpanel.Controls.Add(buttons);
			toolbarpanel.Controls.Add(formatting);

			// Edit must be first to be 'filled' properly
			this.Controls.Add(edit);
			this.Controls.Add(toolbarpanel);
			this.Controls.Add(status);

			toolbarpanel.Dock = DockStyle.Top;
			status.Dock = DockStyle.Bottom;
			edit.Dock = DockStyle.Fill;

			// Load our file, if any
			if (file != null) {
				OpenFile(file, file.EndsWith("txt") ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
			}
			UpdateTitle();
		}
		#endregion	// Constructors

		#region Properties
		public bool Changed {
			get {
				return changed;
			}

			set {
				if (changed != value) {
					changed = value;
					UpdateTitle();
				}
			}
		}

		public string Filename {
			get {
				return filename;
			}

			set {
				if (filename != value) {
					filename = value;
					UpdateTitle();
				}
			}
		}

		public ArrayList MRU {
			get {
				return mru;
			}

			set {
				mru = value;
			}
		}
		#endregion	// Properties

		#region Methods
		public void AddMRU(string item) {
			while (mru.Contains(item)) {
				mru.Remove(item);
			}
			mru.Insert(0, item);
			while (mru.Count > 4) {
				mru.RemoveAt(4);
			}
			menu.UpdateMRU();
		}

		public void Clear() {
			DialogResult	result;

			if (Changed) {
				result = MessageBox.Show("Save changed to " + filename + "?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

				if (result == DialogResult.Cancel) {
					return;
				}

				if (result == DialogResult.Yes) {
					Save(false);
				}
			}

			// FIXME - we need a dialog and ask for the document type
			filename = "Document";
			filetype = RichTextBoxStreamType.RichText;
			edit.Clear();
			Changed = false;
		}


		public void Exit() {
			DialogResult	result;

			if (Changed) {
				result = MessageBox.Show("Save changed to " + filename + "?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

				if (result == DialogResult.Cancel) {
					return;
				}

				if (result == DialogResult.Yes) {
					Save(false);
				}
			}
			Application.Exit();
		}

		public bool Open() {
			OpenFileDialog	openfile;

			openfile = new OpenFileDialog();
			openfile.AddExtension = true;
			openfile.CheckFileExists = true;
			openfile.DereferenceLinks = true;
			openfile.DefaultExt = "rtf";
			openfile.Filter = "Rich Text Format (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*";

			if (openfile.ShowDialog() == DialogResult.Cancel) {
				return false;
			}

			if (openfile.FilterIndex == 1) {
				return OpenFile(openfile.FileName, RichTextBoxStreamType.RichText);
			} else {
				return OpenFile(openfile.FileName, RichTextBoxStreamType.PlainText);
			}
		}

		public bool OpenFile(string name, RichTextBoxStreamType type) {
			if (Changed) {
				DialogResult	result;

				result = MessageBox.Show("Save changed to " + filename + "?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

				if (result == DialogResult.Cancel) {
					return false;
				}

				if (result == DialogResult.Yes) {
					Save(false);
				}
			}

			filename = name;
			filetype = type;
			edit.LoadFile(filename, filetype);
			AddMRU(filename);
			Changed = false;
			return true;
		}

		public bool Save(bool ask) {
			if ((filename == "Document") || ask) {
				SaveFileDialog	savefile;
				DialogResult	result;

				savefile = new SaveFileDialog();
				savefile.AddExtension = true;
				savefile.CheckFileExists = false;
				savefile.DereferenceLinks = true;
				savefile.DefaultExt = "rtf";
				savefile.Filter = "Rich Text Format (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*";

				result = savefile.ShowDialog();

				if (result != DialogResult.OK) {
					return false;
				}

				if (savefile.FilterIndex == 1) {
					filetype = RichTextBoxStreamType.RichText;
				} else {
					filetype = RichTextBoxStreamType.PlainText;
				}
				filename = savefile.FileName;
			}

			if (filename == String.Empty) {
				return false;
			}

			edit.SaveFile(filename, filetype);
			Changed = false;
			return true;
		}

		public void UpdateTitle() {
			string	title;

			title = filename + (Changed ? "*" : "") + " - WordPad";
			this.Text = title;
		}
		#endregion	// Methods

		#region Static Methods
		public static int Main(string[] args) {
			string	file;

			file = null;

			if (args.Length > 0) {
				for (int i=0; i< args.Length; i++) {
					if ((args[i] == "-d") || (args[i] == "--debug")) {
						debug++;
						continue;
					}

					if ((args[i] == "-?") || (args[i] == "-h") || (args[i] == "--help")) {
						Console.WriteLine("Usage: <cmd> [-d | --debug]");
						return 0;
					}

					file = args[i];
				}
			}

			wordpad = new WordPad(file);
			Application.Run(wordpad);

			return 0;
		}
		#endregion	// Static Methods

		#region Event Handlers
		private void WordPadClosing(object sender, CancelEventArgs e) {
			Configuration.Store(wordpad);
		}

		private void DocumentChanged(object sender, EventArgs e) {
			wordpad.Changed = true;
		}
		#endregion	// Event Handlers

	}
}
