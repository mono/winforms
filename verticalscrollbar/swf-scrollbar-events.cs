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
// Copyright (c) 2005 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Jordi Mas i Hernadez <jordi@ximian.com>
//
// Sample to test the use of the Scroll event to change the scroll behavior
//

using System.Windows.Forms;
using System.Drawing;
using System;

namespace MyFormProject
{
	class MainForm : System.Windows.Forms.Form
	{
		private static VScrollBar scroll_bar =  new VScrollBar ();		

		public MainForm()
		{
			scroll_bar.Scroll += new ScrollEventHandler (OnScroll);
			scroll_bar.ValueChanged += new EventHandler (OnValueChanged);
			Controls.Add (scroll_bar);			
			ClientSize = new System.Drawing.Size (400, 400);
			scroll_bar.Location = new Point (10,10);
		}

		// OnScroll event that changes the NewValue
		private void OnScroll (object sender, ScrollEventArgs sc_event)
		{
			int val = sc_event.NewValue;

			switch (sc_event.Type)
			{
				case ScrollEventType.First:
					sc_event.NewValue = scroll_bar.Maximum;
					break;
				case ScrollEventType.Last:
					sc_event.NewValue = scroll_bar.Minimum;
					break;
				case ScrollEventType.SmallDecrement:
					sc_event.NewValue -= 15;
					break;
				case ScrollEventType.SmallIncrement:
					sc_event.NewValue += 15;
					break;
				case ScrollEventType.LargeDecrement:
					sc_event.NewValue = 0;
					break;
				case ScrollEventType.LargeIncrement:
					sc_event.NewValue = 100;
					break;
				default:
					break;
			}

			Console.WriteLine ("OnScroll. Type: {0} in value {1} out value {2}",
				sc_event.Type, val, sc_event.NewValue);
		}
		
		// 
		private void OnValueChanged (object sender, EventArgs evargs)
		{
			Console.WriteLine ("OnValueChanged {0}", scroll_bar.Value);
		}
				
		public static void Main(string[] args)
		{
			Application.Run (new MainForm ());
		}
	}

}

