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
// Copyright (c) 2005 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
// Shows a DrawFocusRectangle 
//

using System.Windows.Forms;
using System.Drawing;
using System;

namespace MyFormProject 
{	
    	public class OwnerDrawCtrl : Control
    	{
    		public OwnerDrawCtrl () 
    		{
    			Paint += new PaintEventHandler (OnPaintCtrl);
    		}	
    		
    		private void OnPaintCtrl (Object o, PaintEventArgs pevent)
		{
			ControlPaint.DrawFocusRectangle (pevent.Graphics, ClientRectangle);
		}  		    		
    	}

	
	class MainForm : System.Windows.Forms.Form
	{	
		static private OwnerDrawCtrl drawctrl = new OwnerDrawCtrl ();
		
		public MainForm()
		{
			ClientSize = new System.Drawing.Size (100, 100);
			
			drawctrl.Location = new Point (10,10);
			drawctrl.Size = new Size (40, 40);
			Controls.Add (drawctrl);				
			
		}			
		
		public static void Main(string[] args)
		{
			Application.Run (new MainForm ());			
		}
	}
	
}