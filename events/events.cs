//
// event order test app
//
//

using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class MainForm : System.Windows.Forms.Form {
	public static MainForm			test;
	public TestControl			one;
	public TestControl			two;
	public TestControl			three;
	public TestControl			four;
	public TestControl			five;
	public System.Windows.Forms.Timer	t;

	public class TestControl : Control {
		public ArrayList calls = new ArrayList();
		public ArrayList events = new ArrayList();
		public ArrayList messages = new ArrayList(10000);

		protected override bool IsInputChar(char charCode) {
			calls.Add(String.Format("IsInputChar {0:X}", charCode));
			return base.IsInputChar (charCode);
		}

		protected override bool IsInputKey(Keys keyData) {
			calls.Add(String.Format("IsInputKey {0}", keyData));
			return base.IsInputKey (keyData);
		}

		protected override void NotifyInvalidate(Rectangle invalidatedArea) {
			calls.Add(String.Format("NotifyInvalidate {0}", invalidatedArea));
			base.NotifyInvalidate (invalidatedArea);
		}

		protected override void OnBackColorChanged(EventArgs e) {
			calls.Add(String.Format("OnBackColorChanged"));
			base.OnBackColorChanged (e);
		}

		protected override void OnBackgroundImageChanged(EventArgs e) {
			calls.Add(String.Format("OnBackgroundImageChanged"));
			base.OnBackgroundImageChanged (e);
		}

		protected override void OnBindingContextChanged(EventArgs e) {
			calls.Add(String.Format("OnBindingContextChanged"));
			base.OnBindingContextChanged (e);
		}

		protected override void OnCausesValidationChanged(EventArgs e) {
			calls.Add(String.Format("OnCausesValidationChanged"));
			base.OnCausesValidationChanged (e);
		}

		protected override void OnChangeUICues(UICuesEventArgs e) {
			calls.Add(String.Format("OnChangeUICues"));
			base.OnChangeUICues (e);
		}

		protected override void OnClick(EventArgs e) {
			calls.Add(String.Format("OnClick"));
			base.OnClick (e);
		}

		protected override void OnContextMenuChanged(EventArgs e) {
			calls.Add(String.Format("OnContextMenuChanged"));
			base.OnContextMenuChanged (e);
		}

		protected override void OnControlAdded(ControlEventArgs e) {
			calls.Add(String.Format("OnControlAdded [Control \"{0}\"]", CT(e.Control)));
			base.OnControlAdded (e);
		}

		protected override void OnControlRemoved(ControlEventArgs e) {
			calls.Add(String.Format("OnControlRemoved [Control \"{0}\"]", CT(e.Control)));
			base.OnControlRemoved (e);
		}

		protected override void OnCreateControl() {
			calls.Add(String.Format("OnCreateControl"));
			base.OnCreateControl ();
		}

		protected override void OnCursorChanged(EventArgs e) {
			calls.Add(String.Format("OnCursorChanged"));
			base.OnCursorChanged (e);
		}

		protected override void OnDockChanged(EventArgs e) {
			calls.Add(String.Format("OnDockChanged"));
			base.OnDockChanged (e);
		}

		protected override void OnDoubleClick(EventArgs e) {
			calls.Add(String.Format("OnDoubleClick"));
			base.OnDoubleClick (e);
		}

		protected override void OnDragDrop(DragEventArgs drgevent) {
			calls.Add(String.Format("OnDragDrop"));
			base.OnDragDrop (drgevent);
		}

		protected override void OnDragEnter(DragEventArgs drgevent) {
			calls.Add(String.Format("OnDragEnter"));
			base.OnDragEnter (drgevent);
		}

		protected override void OnDragLeave(EventArgs e) {
			calls.Add(String.Format("OnDragLeave"));
			base.OnDragLeave (e);
		}

		protected override void OnDragOver(DragEventArgs drgevent) {
			calls.Add(String.Format("OnDragOver"));
			base.OnDragOver (drgevent);
		}

		protected override void OnEnabledChanged(EventArgs e) {
			calls.Add(String.Format("OnEnabledChanged"));
			base.OnEnabledChanged (e);
		}

		protected override void OnEnter(EventArgs e) {
			calls.Add(String.Format("OnEnter"));
			base.OnEnter (e);
		}

		protected override void OnFontChanged(EventArgs e) {
			calls.Add(String.Format("OnFontChanged"));
			base.OnFontChanged (e);
		}

		protected override void OnForeColorChanged(EventArgs e) {
			calls.Add(String.Format("OnForeColorChanged"));
			base.OnForeColorChanged (e);
		}

		protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent) {
			calls.Add(String.Format("OnGiveFeedback"));
			base.OnGiveFeedback (gfbevent);
		}

		protected override void OnGotFocus(EventArgs e) {
			calls.Add(String.Format("OnGotFocus"));
			base.OnGotFocus (e);
		}

		protected override void OnHandleCreated(EventArgs e) {
			calls.Add(String.Format("OnHandleCreated"));
			base.OnHandleCreated (e);
		}

		protected override void OnHandleDestroyed(EventArgs e) {
			calls.Add(String.Format("OnHandleDestroyed"));
			base.OnHandleDestroyed (e);
		}

		protected override void OnHelpRequested(HelpEventArgs hevent) {
			calls.Add(String.Format("OnHelpRequested"));
			base.OnHelpRequested (hevent);
		}

		protected override void OnImeModeChanged(EventArgs e) {
			calls.Add(String.Format("OnImeModeChanged"));
			base.OnImeModeChanged (e);
		}

		protected override void OnInvalidated(InvalidateEventArgs e) {
			calls.Add(String.Format("OnInvalidated"));
			base.OnInvalidated (e);
		}

		protected override void OnKeyDown(KeyEventArgs e) {
			calls.Add(String.Format("OnKeyDown"));
			base.OnKeyDown (e);
		}

		protected override void OnKeyPress(KeyPressEventArgs e) {
			calls.Add(String.Format("OnKeyPress"));
			base.OnKeyPress (e);
		}

		protected override void OnKeyUp(KeyEventArgs e) {
			calls.Add(String.Format("OnKeyUp"));
			base.OnKeyUp (e);
		}

		protected override void OnLayout(LayoutEventArgs levent) {
			calls.Add(String.Format("OnLayout [Control \"{0}\", Property \"{1}\"]", CT(levent.AffectedControl), levent.AffectedProperty));
			base.OnLayout (levent);
		}

		protected override void OnLeave(EventArgs e) {
			calls.Add(String.Format("OnLeave"));
			base.OnLeave (e);
		}

		protected override void OnLocationChanged(EventArgs e) {
			calls.Add(String.Format("OnLocationChanged"));
			base.OnLocationChanged (e);
		}

		protected override void OnLostFocus(EventArgs e) {
			calls.Add(String.Format("OnLostFocus"));
			base.OnLostFocus (e);
		}

		protected override void OnMouseDown(MouseEventArgs e) {
			calls.Add(String.Format("OnMouseDown"));
			base.OnMouseDown (e);
		}

		protected override void OnMouseEnter(EventArgs e) {
			calls.Add(String.Format("OnMouseEnter"));
			base.OnMouseEnter (e);
		}

		protected override void OnMouseHover(EventArgs e) {
			calls.Add(String.Format("OnMouseHover"));
			base.OnMouseHover (e);
		}

		protected override void OnMouseLeave(EventArgs e) {
			calls.Add(String.Format("OnMouseLeave"));
			base.OnMouseLeave (e);
		}

		protected override void OnMouseMove(MouseEventArgs e) {
			calls.Add(String.Format("OnMouseMove"));
			base.OnMouseMove (e);
		}

		protected override void OnMouseUp(MouseEventArgs e) {
			calls.Add(String.Format("OnMouseUp"));
			base.OnMouseUp (e);
		}

		protected override void OnMouseWheel(MouseEventArgs e) {
			calls.Add(String.Format("OnMouseWheel"));
			base.OnMouseWheel (e);
		}

		protected override void OnMove(EventArgs e) {
			calls.Add(String.Format("OnMove"));
			base.OnMove (e);
		}

		protected override void OnNotifyMessage(Message m) {
			calls.Add(String.Format("OnNotifyMessage"));
			base.OnNotifyMessage (m);
		}

		protected override void OnPaint(PaintEventArgs e) {
			calls.Add(String.Format("OnPaint"));
			base.OnPaint (e);
		}

		protected override void OnPaintBackground(PaintEventArgs pevent) {
			calls.Add(String.Format("OnPaintBackground"));
			base.OnPaintBackground (pevent);
		}

		protected override void OnParentBackColorChanged(EventArgs e) {
			calls.Add(String.Format("OnParentBackColorChanged"));
			base.OnParentBackColorChanged (e);
		}

		protected override void OnParentBackgroundImageChanged(EventArgs e) {
			calls.Add(String.Format("OnParentBackgroundImageChanged"));
			base.OnParentBackgroundImageChanged (e);
		}

		protected override void OnParentBindingContextChanged(EventArgs e) {
			calls.Add(String.Format("OnParentBindingContextChanged"));
			base.OnParentBindingContextChanged (e);
		}

		protected override void OnParentChanged(EventArgs e) {
			calls.Add(String.Format("OnParentChanged [Parent \"{0}\"]", CT(Parent)));
			base.OnParentChanged (e);
		}

		protected override void OnParentEnabledChanged(EventArgs e) {
			calls.Add(String.Format("OnParentEnabledChanged"));
			base.OnParentEnabledChanged (e);
		}

		protected override void OnParentFontChanged(EventArgs e) {
			calls.Add(String.Format("OnParentFontChanged"));
			base.OnParentFontChanged (e);
		}

		protected override void OnParentForeColorChanged(EventArgs e) {
			calls.Add(String.Format("OnParentForeColorChanged"));
			base.OnParentForeColorChanged (e);
		}

		protected override void OnParentRightToLeftChanged(EventArgs e) {
			calls.Add(String.Format("OnParentRightToLeftChanged"));
			base.OnParentRightToLeftChanged (e);
		}

		protected override void OnParentVisibleChanged(EventArgs e) {
			calls.Add(String.Format("OnParentVisibleChanged"));
			base.OnParentVisibleChanged (e);
		}

		protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent) {
			calls.Add(String.Format("OnQueryContinueDrag"));
			base.OnQueryContinueDrag (qcdevent);
		}

		protected override void OnResize(EventArgs e) {
			calls.Add(String.Format("OnResize"));
			base.OnResize (e);
		}

		protected override void OnRightToLeftChanged(EventArgs e) {
			calls.Add(String.Format("OnRightToLeftChanged"));
			base.OnRightToLeftChanged (e);
		}

		protected override void OnSizeChanged(EventArgs e) {
			calls.Add(String.Format("OnSizeChanged"));
			base.OnSizeChanged (e);
		}

		protected override void OnStyleChanged(EventArgs e) {
			calls.Add(String.Format("OnStyleChanged"));
			base.OnStyleChanged (e);
		}

		protected override void OnSystemColorsChanged(EventArgs e) {
			calls.Add(String.Format("OnSystemColorsChanged"));
			base.OnSystemColorsChanged (e);
		}

		protected override void OnTabIndexChanged(EventArgs e) {
			calls.Add(String.Format("OnTabIndexChanged"));
			base.OnTabIndexChanged (e);
		}

		protected override void OnTabStopChanged(EventArgs e) {
			calls.Add(String.Format("OnTabStopChanged"));
			base.OnTabStopChanged (e);
		}

		protected override void OnTextChanged(EventArgs e) {
			calls.Add(String.Format("OnTextChanged"));
			base.OnTextChanged (e);
		}

		protected override void OnValidated(EventArgs e) {
			calls.Add(String.Format("OnValidated"));
			base.OnValidated (e);
		}

		protected override void OnValidating(System.ComponentModel.CancelEventArgs e) {
			calls.Add(String.Format("OnValidating"));
			base.OnValidating (e);
		}

		protected override void OnVisibleChanged(EventArgs e) {
			calls.Add(String.Format("OnVisibleChanged, [Visible \"{0}\"]", Visible));
			base.OnVisibleChanged (e);
		}

		public override bool PreProcessMessage(ref Message msg) {
			calls.Add(String.Format("PreProcessMessage"));
			return base.PreProcessMessage (ref msg);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
			calls.Add(String.Format("ProcessCmdKey"));
			return base.ProcessCmdKey (ref msg, keyData);
		}

		protected override bool ProcessDialogChar(char charCode) {
			calls.Add(String.Format("ProcessDialogChar"));
			return base.ProcessDialogChar (charCode);
		}

		protected override bool ProcessDialogKey(Keys keyData) {
			calls.Add(String.Format("ProcessDialogKey"));
			return base.ProcessDialogKey (keyData);
		}

		protected override bool ProcessKeyEventArgs(ref Message m) {
			calls.Add(String.Format("ProcessKeyEventArgs"));
			return base.ProcessKeyEventArgs (ref m);
		}

		protected override bool ProcessKeyMessage(ref Message m) {
			calls.Add(String.Format("ProcessKeyMessage"));
			return base.ProcessKeyMessage (ref m);
		}

		protected override bool ProcessKeyPreview(ref Message m) {
			calls.Add(String.Format("ProcessKeyPreview"));
			return base.ProcessKeyPreview (ref m);
		}

		protected override bool ProcessMnemonic(char charCode) {
			calls.Add(String.Format("ProcessMnemonic"));
			return base.ProcessMnemonic (charCode);
		}

		protected override void WndProc(ref Message m) {
			messages.Add(m);
			base.WndProc (ref m);
		}


		public ArrayList Calls {
			get {
				return calls;
			}

			set {
				calls.Clear();
			}
		}

		public new ArrayList Events {
			get {
				return events;
			}

			set {
				events.Clear();
			}
		}

		public ArrayList Messages {
			get {
				return messages;
			}

			set {
				messages.Clear();
			}
		}
	}

	public string [] ArrayListToString (ArrayList arrlist) {
		string [] retval = new string [arrlist.Count];
		for (int i = 0; i < arrlist.Count; i++) {
			retval[i] = (string)arrlist[i];
		}

		return retval;
	}

	public static string CT(Control control) {
		if (control == null) {
			return "null";
		}

		if (control.Text == "") {
			return "<empty string>";
		}

		return control.Text;
	}

	public void PrintList(string name, ArrayList list) {
		Console.WriteLine("{0}", name);
		for (int i = 0; i < list.Count; i++) {
			Console.WriteLine("   {0}", list[i]);
		}
		Console.WriteLine("");
	}

	public MainForm() {
		one = new TestControl();
		two = new TestControl();
		three = new TestControl();
		four = new TestControl();
		five = new TestControl();

		Text = "form";
		one.Text = "one";
		two.Text = "two";
		three.Text = "three";
		four.Text = "four";
		five.Text = "five";

		this.Controls.Add(one);

		t = new System.Windows.Forms.Timer();
		t.Interval = 2000;
		t.Tick += new EventHandler(t_Tick);
		t.Start();
	}

	public void ClearCalls() {
		one.Calls = null;
		two.Calls = null;
		three.Calls = null;
		four.Calls = null;
		five.Calls = null;
	}

	// Check events sent when moving a child from one to another control
	public void ReparentTest() {
		ClearCalls();

		// Removing from parent one, moving to parent three
		three.Controls.Add(two);
		PrintList("Reparent, One Calls", one.Calls);
		PrintList("Reparent, Two Calls", two.Calls);
		PrintList("Reparent, Three Calls", three.Calls);
	}

	// Check events that are sent when a control is added as a child
	public void ControlsAddTest() {
		two.Parent = null;
		three.Controls.Clear();
		ClearCalls();
		three.Controls.Add(two);
		PrintList("Add, New parent calls", three.Calls);
		PrintList("Add, Child calls", two.Calls);
	}

	// Check events that are sent when a child of a control is removed
	public void ControlsRemoveTest() {
		three.Controls.Add(two);
		ClearCalls();
		three.Controls.Remove(two);
		PrintList("Remove, Former parent calls", three.Calls);
		PrintList("Add, Child calls", two.Calls);
	}

	// Check events that are sent when all children of a control are removed
	public void ControlsClearTest() {
		one.Cursor = Cursors.SizeNWSE;	// Check for CursorChanged event
		one.Controls.Add(two);
		one.Controls.Add(three);
		one.Controls.Add(four);
		one.Controls.Add(five);

		ClearCalls();
		one.Controls.Clear();
		PrintList("Clear, Former parent calls", one.Calls);
		PrintList("Clear, Child two calls", two.Calls);
		PrintList("Clear, Child two calls", three.Calls);
		PrintList("Clear, Child four calls", four.Calls);
		PrintList("Clear, Child five calls", five.Calls);
	}

	// Check events sent when 
	public void ControlsAddSame() {
		three.Controls.Add(two);
		ClearCalls();
		three.Controls.Add(two);
		PrintList("Re-Add, parent", three.Calls);
		PrintList("Re-Add, child", two.Calls);
	}

	static void Main() {
		test = new MainForm();
		Application.Run(test);
		test.PrintList("Exit, One Calls", test.one.Calls);
		test.PrintList("Exit, Two Calls", test.two.Calls);
	}

	private void t_Tick(object sender, EventArgs e) {
		t.Stop();

		//PrintList("Creation One Calls", one.Calls);
		//PrintList("Creation Two Calls", two.Calls);

		//ReparentTest();
		ControlsClearTest();
		//ControlsAddSame();
	}
}
