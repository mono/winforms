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
// Copyright (c) 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace webbrowser.tests
{
	public class main : Form
	{
		public WebBrowser webBrowser;
		public int navigated;
		monitor monitor;
		controls controls;
		
		[STAThread]
		public static void Main () {
			Application.Run (new main ());
		}
		
		public main()
		{
			gui ();
			controls.Show ();
			monitor.Show ();
		}
		
		void gui () {
			SuspendLayout ();
			this.StartPosition = FormStartPosition.Manual;
			this.Left = 400;
			this.Top = 100;
			this.Size = new Size (650, 650);

			controls = new controls (this);
			controls.SuspendLayout ();
			controls.Top = 100;
			monitor = new monitor(this);
			monitor.SuspendLayout ();
			monitor.Top = 100;
			controls.Size = new Size(400, 400);
			monitor.Size = new Size(400, 400);
			controls.Left = this.Left - 400;
			monitor.Left = this.Right;
			
			webBrowser = new WebBrowser ();
			webBrowser.Navigating += delegate (object sender, WebBrowserNavigatingEventArgs args) {
				monitor.addEvent ("Navigating");
			};
			webBrowser.Navigated += delegate (object sender, WebBrowserNavigatedEventArgs args) {
				navigated++;
				monitor.addEvent ("Navigated");
			};
			webBrowser.CanGoBackChanged += delegate (object sender, EventArgs args) {
				monitor.addEvent ("CanGoBackChanged");
			};
			webBrowser.CanGoForwardChanged += delegate (object sender, EventArgs args) {
				monitor.addEvent ("CanGoForwardChanged");
			};
			webBrowser.DocumentCompleted  += delegate (object sender, WebBrowserDocumentCompletedEventArgs args) {
				monitor.addEvent ("DocumentCompleted");
			};
			webBrowser.DocumentTitleChanged += delegate (object sender, EventArgs args) {
				monitor.addEvent ("DocumentTitleChanged");
			};
			webBrowser.EncryptionLevelChanged  += delegate (object sender, EventArgs args) {
				monitor.addEvent ("EncryptionLevelChanged");
			};
			webBrowser.FileDownload  += delegate (object sender, EventArgs args) {
				monitor.addEvent ("FileDownload");
			};
			webBrowser.NewWindow += delegate (object sender, CancelEventArgs args) {
				monitor.addEvent ("NewWindow");
			};
			webBrowser.ProgressChanged  += delegate (object sender, WebBrowserProgressChangedEventArgs args) {
				monitor.addEvent ("ProgressChanged");
			};
			webBrowser.StatusTextChanged  += delegate (object sender, EventArgs args) {
				monitor.addEvent ("StatusTextChanged");
			};
			webBrowser.Dock = DockStyle.Fill;
			this.Controls.Add (webBrowser);
			
			monitor.ResumeLayout ();
			controls.ResumeLayout ();
			this.ResumeLayout ();
		}
	}
}
