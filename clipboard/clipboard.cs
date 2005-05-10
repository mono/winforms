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


			clipboard clip = new clipboard ();

			Application.Run (clip);
		}
	}
}

