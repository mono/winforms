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
using System.Collections.Generic;

namespace webbrowser.tests
{
	
	
	public class monitor : Form
	{
		main main;
		Panel top;
		Panel bottom;
		Splitter splitter;
		ListView events;
		
		public monitor (main main)
		{
			this.main = main;
			
			top = new Panel();
			bottom = new Panel();
			splitter = new Splitter();
			events = new ListView();
			events.View = View.List;
			events.GridLines = true;
			
			top.Controls.Add (events);
			top.Dock = DockStyle.Top;
			splitter.Dock = DockStyle.Top;
			bottom.Dock = DockStyle.Fill;
			
			this.Controls.Add (bottom);
			this.Controls.Add (splitter);
			this.Controls.Add (top);
		}
		
		public void addEvent (string eve) {
			events.Items.Add (eve);
		}
	}
}
