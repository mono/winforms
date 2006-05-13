//
// Small sample that brings the PrintDialog
//
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace MyFormProject
{
	public class ShowPrintDialog
	{
			public ShowPrintDialog ()
			{
			}

			static void Main ()
			{
				PrintDialog pd = new PrintDialog ();

				pd.AllowSomePages = true;
				pd.AllowSelection = true;
				//pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings ();
				pd.Document  = new PrintDocument ();
				pd.Document.PrinterSettings.FromPage = 20;
				pd.Document.PrinterSettings.ToPage = 30;
				pd.Document.PrinterSettings.MaximumPage = 50;
				pd.Document.PrinterSettings.Copies = 5;
				pd.ShowHelp = true;
				pd.ShowNetwork = true;
				pd.Document.PrinterSettings.PrintRange = PrintRange.SomePages;
				pd.ShowDialog ();

				Console.WriteLine ("Printer {0}", pd.Document.PrinterSettings);
				Console.WriteLine ("AllowSomePages {0}", pd.AllowSomePages);
				Console.WriteLine ("PrintToFile {0}",  pd.Document.PrinterSettings.PrintToFile);
				Console.WriteLine ("PrintRange {0}",  pd.Document.PrinterSettings.PrintRange);

			}
	}
}
