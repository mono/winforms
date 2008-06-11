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



using System;
using System.ComponentModel;

using Mono.WebBrowser.DOM;

namespace standalone
{
	
	public class Page : Component
	{
		MainForm parent;
		public Page (MainForm parent) {
			this.parent = parent;
		}
		
		public delegate void TextChangedHandler (string text);	
		public delegate void RootNodeChangedHandler ();
		public delegate void ElementCollectionChangedHandler ();
		public delegate void AttributeCollectionChangedHandler ();
		public delegate void StylesheetListChangedHandler ();
		public delegate void WindowCollectionChangedHandler ();
		
		public INode lastNodeFetched;
		public IDocument document;
		
		public INode NewRootNode {
			get {return lastNodeFetched;}
			set {
				lastNodeFetched = value;
				OnRootNodeChanged ();
			}
		}

		public IElementCollection elementCollection;
		public IElementCollection ElementCollection {
			get {return elementCollection;}
			set {
				elementCollection = value;
				OnElementCollectionChanged ();
			}
		}
		
		public IAttributeCollection attributeCollection;
		public IAttributeCollection AttributeCollection {
			get {return attributeCollection;}
			set {
				attributeCollection = value;
				OnAttributeCollectionChanged ();
			}
		}
		
		public IStylesheetList stylesheetList;
		public IStylesheetList StylesheetList {
			get {return stylesheetList;}
			set {
				stylesheetList = value;
				OnStylesheetListChanged ();
			}
		}
		
		public IWindowCollection windows;
		public IWindowCollection Windows {
			get {return windows;}
			set {
				windows = value;
				OnWindowCollectionChanged ();
			}
		}

		public string retVal;
		
		public event TextChangedHandler TextChanged;
		public void OnTextChanged(string text) {
			if (TextChanged != null)
				TextChanged (text);
		}
		
		public event RootNodeChangedHandler RootNodeChanged;
		public void OnRootNodeChanged() {
			if (RootNodeChanged != null)
				RootNodeChanged ();
		}		


		public event ElementCollectionChangedHandler ElementCollectionChanged;
		public void OnElementCollectionChanged() {
			if (ElementCollectionChanged != null)
				ElementCollectionChanged ();
		}		

		public event AttributeCollectionChangedHandler AttributeCollectionChanged;
		public void OnAttributeCollectionChanged() {
			if (AttributeCollectionChanged != null)
				AttributeCollectionChanged ();
		}		
		
		public event StylesheetListChangedHandler StylesheetListChanged;
		public void OnStylesheetListChanged() {
			if (StylesheetListChanged != null)
				StylesheetListChanged ();
		}		
		
		public event WindowCollectionChangedHandler WindowCollectionChanged;
		public void OnWindowCollectionChanged() {
			if (WindowCollectionChanged != null)
				WindowCollectionChanged ();
		}		

		
		// document
		
		public void getWindows () {
			if (document == null) return;
			Windows = document.Window.Frames;
		}

		public void getDocumentElement () {
			if (document == null) return;
			lastNodeFetched = document.DocumentElement;
		}

		public void getTitle () {
			if (document == null) return;
			retVal = document.Title;
			OnTextChanged (retVal);			
		}
		
		public void setTitle (string text) {
			if (document == null) return;
			document.Title = text;
		}

		public void getBody () {
			if (document == null) return;
			lastNodeFetched = document.Body;
		}
		
		public void getActiveElement () {
			if (document == null) return;
			lastNodeFetched = document.Active;			
		}
		
		public void getElementById (string id) {
			if (document == null) return;
			lastNodeFetched = document.GetElementById (id);			
		}

		public void getElement (int x, int y) {
			if (document == null) return;
			lastNodeFetched = document.GetElement (x, y);
		}

		public void getCookie () {
			if (document == null) return;
			retVal = document.Cookie;
			OnTextChanged (retVal);
		}

		public void setCookie (string cookie) {
			if (document == null) return;
			document.Cookie = cookie;
		}


		public void getApplets () {
			if (document == null) return;
			ElementCollection = document.Applets;
		}
		
		public void getAnchors () {
			if (document == null) return;
			ElementCollection = document.Anchors;
		}

		public void getForms () {
			if (document == null) return;
			ElementCollection = document.Forms;
		}

		public void getImages () {
			if (document == null) return;
			ElementCollection = document.Images;
		}

		public void getLinks () {
			if (document == null) return;
			ElementCollection = document.Links;
		}
		
		public void getStylesheets () {
			if (document == null) return;
			StylesheetList = document.Stylesheets;
		}

		public void getUrl () {
			if (document == null) return;
			retVal = document.Url;
			OnTextChanged (retVal);
		}
		
		public void getCharset () {
			if (document == null) return;
			retVal = document.Charset;
			OnTextChanged (retVal);
		}
		
		public void setCharset (string charset) {
			if (document == null) return;
			document.Charset = charset;
		}


		public string invokeScript (string script)
		{
			if (document == null) return String.Empty;
			return document.InvokeScript (script);
		}

		public void getScrollbars() {
			retVal = document.InvokeScript ("document.body.style.overflow != 'hidden';") ;
			OnTextChanged (retVal);
		}
		
		public void setScrollbars (bool enabled) {
			if (!enabled)
				document.InvokeScript ("document.body.style.overflow='hidden';");
			else
				document.InvokeScript ("document.body.style.overflow='auto';");
		}

		
		public bool RightToLeft {
			get { 
				if (document == null) return false;
				IAttribute dir = document.Attributes["dir"];
				retVal = (dir != null && dir.Value == "rtl") ? "true" : "false";
				OnTextChanged (retVal);
				return retVal == "true";
			}
			set {
				if (document == null) return;
				IAttribute dir = document.Attributes["dir"];
				if (dir == null && value) {
					IAttribute attr = document.CreateAttribute ("dir");
					attr.Value = "rtl";
					document.AppendChild (attr);
				} else if (dir != null && !value) {
					document.RemoveChild (dir);
				}
			}
		}	
		
		
		// Element
		
		
		public void getInnerText () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).InnerText;
			OnTextChanged (retVal);
		}
		
		public void getInnerHTML () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).InnerHTML;
			OnTextChanged (retVal);
		}
		
		public void getOuterText () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).OuterText;
			OnTextChanged (retVal);
		}
		
		public void getOuterHTML () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).OuterHTML;
			OnTextChanged (retVal);
		}

		public void setOuterHTML (string html) {
			if (!(lastNodeFetched is IElement)) return;
			((IElement)lastNodeFetched).OuterHTML = html;
		}

		public void hasAttribute (string name) {
			if (!(lastNodeFetched is IElement)) return;
			if (name.Equals (String.Empty)) return;
			retVal = ((IElement)lastNodeFetched).HasAttribute (name).ToString();			
			OnTextChanged (retVal);
		}

		public void getAttribute (string name) {
			if (!(lastNodeFetched is IElement)) return;
			if (name.Equals (String.Empty)) return;
			retVal = ((IElement)lastNodeFetched).GetAttribute (name);
			OnTextChanged (retVal);
		}

		public void setAttribute (string name, string val)
		{
			if (!(lastNodeFetched is IElement)) return;
			if (name.Equals (String.Empty)) return;
			((IElement) lastNodeFetched).SetAttribute (name, val);
		}

		public void getChildren () {
			if (!(lastNodeFetched is IElement)) return;
			OnRootNodeChanged ();			
		}

		public void getTabIndex () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).TabIndex.ToString ();
			OnTextChanged (retVal);
		}

		public void setTabIndex (string tabIndex) {
			if (!(lastNodeFetched is IElement)) return;
			int ret;
			if (!int.TryParse (tabIndex, out ret)) return;
			((IElement)lastNodeFetched).TabIndex = ret;
		}
		
		public void getStyle () {
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).Style;
			OnTextChanged (retVal);
		}

		public void setStyle (string style) {
			if (!(lastNodeFetched is IElement)) return;
			((IElement)lastNodeFetched).Style = style;
		}
		
		
		// node

		public void getAttributes () {
			if (!(lastNodeFetched is INode)) return;
			AttributeCollection = lastNodeFetched.Attributes;
		}		
		
		public void getFirstChild () {
			if (!(lastNodeFetched is INode)) return;
			lastNodeFetched = lastNodeFetched.FirstChild;
		}


		public void getLocalName () {
			if (!(lastNodeFetched is INode)) return;
			retVal = lastNodeFetched.LocalName;
			OnTextChanged (retVal);
		}

		public void getValue () {
			if (!(lastNodeFetched is INode)) return;
			retVal = lastNodeFetched.Value;
			OnTextChanged (retVal);			
		}

		public void getDisabled()
		{
			if (!(lastNodeFetched is IElement)) return;
			retVal = ((IElement)lastNodeFetched).Disabled.ToString();
			OnTextChanged (retVal);
		}

		public void getType () {
			if (!(lastNodeFetched is INode)) return;
			retVal = lastNodeFetched.Type.ToString();
			OnTextChanged (retVal);			
		}		
		
		public void Click (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " Click";
			OnTextChanged (retVal);
		}
		
		public void DoubleClick (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " DoubleClick";
			OnTextChanged (retVal);
		}
		public void KeyDown (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " KeyDown";
			OnTextChanged (retVal);
		}
		public void KeyPress (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " KeyPress";
			OnTextChanged (retVal);
		}
		public void KeyUp (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " KeyUp";
			OnTextChanged (retVal);
		}
		public void MouseDown (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseDown";
			OnTextChanged (retVal);
		}
		public void MouseEnter (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseEnter";
			OnTextChanged (retVal);
		}
		public void MouseLeave (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseLeave";
			OnTextChanged (retVal);
		}
		public void MouseMove (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseMove";
			OnTextChanged (retVal);
		}
		public void MouseOver (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseOver";
			OnTextChanged (retVal);
		}
		public void MouseUp (object sender, EventArgs e) 
		{
			INode node = (INode) sender;
			retVal = node.LocalName + " MouseUp";
			OnTextChanged (retVal);
		}
		
		public void fireEvent (string name)
		{
			lastNodeFetched.FireEvent (name);
		}
	}
}
