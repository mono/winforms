using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace print_tester
{
	public class Form1 : System.Windows.Forms.Form
	{
		private PrintDocument printDoc = new PrintDocument();
		private PageSettings pgSettings = new PageSettings();
		private PrinterSettings prtSettings = new PrinterSettings();

		public Form1() 
		{
			MenuItem fileMenuItem = new MenuItem("&File");
			MenuItem filePageSetupMenuItem = new MenuItem("Page Set&up...", 
				new EventHandler(filePageSetupMenuItem_Click));
			MenuItem filePrintPreviewMenuItem = new MenuItem("Print Pre&view", 
				new EventHandler(filePrintPreviewMenuItem_Click));
			MenuItem filePrintMenuItem = new MenuItem("&Print...", 
				new EventHandler(filePrintMenuItem_Click), Shortcut.CtrlP);

			fileMenuItem.MenuItems.Add(filePageSetupMenuItem);
			fileMenuItem.MenuItems.Add(filePrintPreviewMenuItem);
			fileMenuItem.MenuItems.Add(filePrintMenuItem);

			this.Menu = new MainMenu();
			this.Menu.MenuItems.Add(fileMenuItem);
			printDoc.PrintPage += new PrintPageEventHandler(
				printDoc_PrintPage); 
		}
        
		// -------------- event handlers ------------------------------------
		private void filePrintMenuItem_Click(Object sender , 
			EventArgs e) 
		{

			printDoc.DefaultPageSettings = pgSettings;
			PrintDialog dlg = new PrintDialog();
			dlg.Document = printDoc;
			if (dlg.ShowDialog() == DialogResult.OK) 
			{
				printDoc.Print();
			}
		}
    
		private void filePrintPreviewMenuItem_Click(Object sender , 
			EventArgs e) 
		{
			PrintPreviewDialog dlg = new PrintPreviewDialog();
			dlg.Document = printDoc;
			dlg.ShowDialog();
		}
    
		private void filePageSetupMenuItem_Click(Object sender , 
			EventArgs e) 
		{
			PageSetupDialog pageSetupDialog = new PageSetupDialog();
			pageSetupDialog.PageSettings = pgSettings;
			pageSetupDialog.PrinterSettings = prtSettings;
			pageSetupDialog.AllowOrientation = true;
			pageSetupDialog.AllowMargins = true;
			pageSetupDialog.ShowDialog();
		}
    
		private void printDoc_PrintPage(Object sender , 
			PrintPageEventArgs e)
		{
			String textToPrint = ".NET Printing is easy";
			Font printFont = new Font("Courier New", 12);
			int leftMargin = e.MarginBounds.Left;
			int topMargin = e.MarginBounds.Top;
			e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, 
				leftMargin, topMargin);
		}

		//-------------- end of event handlers -----------------------------

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

	}
}