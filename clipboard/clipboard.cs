using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace System.Windows.Forms {
	public class clipboard : Form {

		public clipboard ()
		{
			this.Width = 400;
			this.Height = 400;

			Clipboard.SetDataObject("blah", true);
		}

		public static void PrintFormatInfo(DataFormats.Format f) {
			Console.WriteLine("Format ID: " + f.Id + ", Name: " + f.Name);
		}

		public static void PrintFormats(string title, string[] s) {
			Console.WriteLine("{0}", title);
			for (int i = 0; i < s.Length; i++ ) {
				Console.WriteLine(" => {0}", s[i]);
			}
			Console.WriteLine("");
		}

		public static void Main ()
		{
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Bitmap));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.CommaSeparatedValue));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Dib));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Dif));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.EnhancedMetafile));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.FileDrop));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Html));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Locale));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.MetafilePict));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.OemText));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Palette));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.PenData));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Riff));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Rtf));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Serializable));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.StringFormat));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.SymbolicLink));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Text));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.Tiff));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.UnicodeText));
			PrintFormatInfo(DataFormats.GetFormat(DataFormats.WaveAudio));

			// Add our own format
			PrintFormatInfo(DataFormats.GetFormat("Birthday"));

			// Test some basic stuff
			DataObject	dobj;
			Control		c;
			string		rtf;

			c = new Control();
			rtf = "\\r\\t\\f  string";

			// Load the data object
			dobj = new DataObject(DataFormats.Text, "I am text");
			dobj.SetData(c.GetType(), c);
			dobj.SetData(DataFormats.Rtf, rtf);

			PrintFormats("GetFormats(): ", dobj.GetFormats());		// Count should be 5
			PrintFormats("GetFormats(true): ", dobj.GetFormats(true));	// Count should be 5
			PrintFormats("GetFormats(false): ", dobj.GetFormats(false));	// Count should be 3

			Console.WriteLine("GetDataPresent(typeof(string)): {0}", dobj.GetDataPresent(typeof(string)));			// We expect true
			Console.WriteLine("GetDataPresent(DataFormats.Text): {0}", dobj.GetDataPresent(DataFormats.Text));		// We expect true
			Console.WriteLine("GetDataPresent(DataFormats.WaveAudio): {0}", dobj.GetDataPresent(DataFormats.WaveAudio));	// We expect false

			Console.WriteLine("GetData(DataFormats.Rtf): {0}", dobj.GetData(DataFormats.Rtf));				// We expect "\r\t\f  string"

			clipboard clip = new clipboard ();

			Application.Run (clip);
		}
	}
}

