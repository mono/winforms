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
using Mono.WebBrowser.DOM;
namespace standalone
{
	public class EventMonitor : Form
	{
		ListView events;
		public INode node;
		
		public EventMonitor(INode target)
		{
			this.node = target;
			events = new ListView();
			events.Columns.Add ("Event", -2);
			events.View = View.Details;
			events.GridLines = true;
			events.Dock = DockStyle.Fill;
			Controls.Add (events);
			
			node.Click += delegate (object sender, NodeEventArgs e) {
				addEvent ("Click");
			};
			node.DoubleClick += delegate (object sender, NodeEventArgs e) {
				addEvent ("DoubleClick");
			};
			
			node.KeyDown += delegate (object sender, NodeEventArgs e) {
				addEvent ("KeyDown");
			};
			
			node.KeyPress += delegate (object sender, NodeEventArgs e) {
				addEvent ("KeyPress");
			};
			
			node.KeyUp += delegate (object sender, NodeEventArgs e) {
				addEvent ("KeyUp");
			};
			
			node.MouseDown += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseDown");
			};
			
			node.MouseEnter += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseEnter");
			};
			
			node.MouseLeave += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseLeave");
			};
			
			node.MouseMove += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseMove");
			};
			
			node.MouseOver += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseOver");
			};
			
			node.MouseUp += delegate (object sender, NodeEventArgs e) {
				addEvent ("MouseUp");
			};
			
			node.OnFocus += delegate (object sender, NodeEventArgs e) {
				addEvent ("Focus");
			};
			
			node.OnBlur += delegate (object sender, NodeEventArgs e) {
				addEvent ("Blur");
			};
						
		}
		public void addEvent (string eve) {
			events.Items.Add (eve);
		}
	}
}
