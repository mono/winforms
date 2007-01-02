using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace ListStyles
{
	public class MainForm : System.Windows.Forms.Form
	{
		[STAThread]
		public static void Main (string[] args)
		{
			Application.Run (new MainForm());
		}

		public MainForm()
		{
			// Label
			Label label = new Label ();
			label.Parent = this;
			PrintControlStyles (label);
	
			label.BorderStyle = BorderStyle.FixedSingle;
			PrintControlStyles (label, "FixedSingle border");
	
			label.BorderStyle = BorderStyle.Fixed3D;
			PrintControlStyles (label, "Fixed3D border");

			// LinkLabel
			Label linklabel = new LinkLabel ();
			linklabel.Parent = this;
			PrintControlStyles (linklabel);
	
			linklabel.BorderStyle = BorderStyle.FixedSingle;
			PrintControlStyles (linklabel, "FixedSingle border");
	
			linklabel.BorderStyle = BorderStyle.Fixed3D;
			PrintControlStyles (linklabel, "Fixed3D border");

			// TextBox
			TextBox textbox = new TextBox ();
			textbox.Parent = this;
			PrintControlStyles (textbox);
			
			// ToolBar
			ToolBar toolbar = new ToolBar ();
			toolbar.Parent = this;
			PrintControlStyles (toolbar);
			
			Application.Exit ();
		}
		
		private void PrintControlStyles (Control control) {
			PrintControlStyles (control, "Default");
		}
		
		private void PrintControlStyles (Control control, String text) {
			Console.WriteLine ("{0} - {1}", control.GetType ().Name, text);
			Console.WriteLine ("");
			
			// This properties is present in all controls under win but not
			// in Mono MWF:
			// WS_EX_DLGMODALFRAME, WS_EX_NOPARENTNOTIFY, WS_EX_TOPMOST
			
			PrintStyle (control, WindowExStyles.WS_EX_DLGMODALFRAME);
			PrintStyle (control, WindowExStyles.WS_EX_DRAGDETECT);
			PrintStyle (control, WindowExStyles.WS_EX_NOPARENTNOTIFY);
			PrintStyle (control, WindowExStyles.WS_EX_TOPMOST);
			PrintStyle (control, WindowExStyles.WS_EX_ACCEPTFILES);
			PrintStyle (control, WindowExStyles.WS_EX_TRANSPARENT);
			PrintStyle (control, WindowExStyles.WS_EX_MDICHILD);
			PrintStyle (control, WindowExStyles.WS_EX_TOOLWINDOW);
			PrintStyle (control, WindowExStyles.WS_EX_WINDOWEDGE);
			PrintStyle (control, WindowExStyles.WS_EX_CLIENTEDGE);
			PrintStyle (control, WindowExStyles.WS_EX_CONTEXTHELP);
			PrintStyle (control, WindowExStyles.WS_EX_RIGHT);
			//PrintStyle (control, WindowExStyles.WS_EX_LEFT);
			PrintStyle (control, WindowExStyles.WS_EX_RTLREADING);
			//PrintStyle (control, WindowExStyles.WS_EX_LTRREADING);
			PrintStyle (control, WindowExStyles.WS_EX_LEFTSCROLLBAR);
			PrintStyle (control, WindowExStyles.WS_EX_LAYERED);
			//PrintStyle (control, WindowExStyles.WS_EX_RIGHTSCROLLBAR);
			PrintStyle (control, WindowExStyles.WS_EX_CONTROLPARENT);
			PrintStyle (control, WindowExStyles.WS_EX_STATICEDGE);
			PrintStyle (control, WindowExStyles.WS_EX_APPWINDOW);
			PrintStyle (control, WindowExStyles.WS_EX_NOINHERITLAYOUT);
			PrintStyle (control, WindowExStyles.WS_EX_LAYOUTRTL);
			PrintStyle (control, WindowExStyles.WS_EX_COMPOSITED);
			PrintStyle (control, WindowExStyles.WS_EX_NOACTIVATE);
			
			PrintStyle (control, WindowStyles.WS_BORDER);
				
			Console.WriteLine ("");
		}
		
		public void PrintStyle (Control control, WindowExStyles s)
		{
			CreateParams cp = (CreateParams) control.GetType().GetProperty("CreateParams", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(control, null);
			if ((cp.Style & (int) s) == (int) s) {
				Console.WriteLine ("=>Style: {0}:{1}", PlanStyle(s), (int)s);
			}
			if ((cp.ExStyle & (int) s) == (int) s) {
				Console.WriteLine ("=>ExStyle: {0}:{1}", PlanStyle(s), (int)s);
			}
		}
		
		public void PrintStyle (Control control, WindowStyles s)
		{
			CreateParams cp = (CreateParams) control.GetType().GetProperty("CreateParams", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(control, null);
			if ((cp.Style & (int) s) == (int) s) {
				Console.WriteLine ("=>Style: {0}:{1}", PlanStyle(s), (int)s);
			}
			if ((cp.ExStyle & (int) s) == (int) s) {
				Console.WriteLine ("=>ExStyle: {0}:{1}", PlanStyle(s), (int)s);
			}
		}

		private string PlanStyle (WindowExStyles style) {
			return style.ToString ().Replace ("WS_EX_LEFT, WS_EX_RIGHTSCROLLBAR, ", "");
		}		
		
		private string PlanStyle (WindowStyles style) {
			return style.ToString ().Replace ("WS_EX_LEFT, WS_EX_RIGHTSCROLLBAR, ", "");
		}		
	}
	
	[Flags]
	public enum WindowExStyles : int {
		// Extended Styles
		WS_EX_DLGMODALFRAME	= 0x00000001,
		WS_EX_DRAGDETECT	= 0x00000002,
		WS_EX_NOPARENTNOTIFY	= 0x00000004,
		WS_EX_TOPMOST		= 0x00000008,
		WS_EX_ACCEPTFILES	= 0x00000010,
		WS_EX_TRANSPARENT	= 0x00000020,

		WS_EX_MDICHILD		= 0x00000040,
		WS_EX_TOOLWINDOW	= 0x00000080,
		WS_EX_WINDOWEDGE	= 0x00000100,
		WS_EX_CLIENTEDGE	= 0x00000200,
		WS_EX_CONTEXTHELP	= 0x00000400,

		WS_EX_RIGHT		= 0x00001000,
		WS_EX_LEFT		= 0x00000000,
		WS_EX_RTLREADING	= 0x00002000,
		WS_EX_LTRREADING	= 0x00000000,
		WS_EX_LEFTSCROLLBAR	= 0x00004000,
		WS_EX_LAYERED		= 0x00080000,
		WS_EX_RIGHTSCROLLBAR	= 0x00000000,

		WS_EX_CONTROLPARENT	= 0x00010000,
		WS_EX_STATICEDGE	= 0x00020000,
		WS_EX_APPWINDOW		= 0x00040000,
		WS_EX_NOINHERITLAYOUT	= 0x00100000,
		WS_EX_LAYOUTRTL		= 0x00400000,
		WS_EX_COMPOSITED	= 0x02000000,
		WS_EX_NOACTIVATE	= 0x08000000,

		WS_EX_OVERLAPPEDWINDOW	= WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,
		WS_EX_PALETTEWINDOW	= WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST
	}
	
	public enum WindowStyles : int {
		WS_OVERLAPPED		= 0x00000000,
		WS_POPUP		= unchecked((int)0x80000000),
		WS_CHILD		= 0x40000000,
		WS_MINIMIZE		= 0x20000000,
		WS_VISIBLE		= 0x10000000,
		WS_DISABLED		= 0x08000000,
		WS_CLIPSIBLINGS		= 0x04000000,
		WS_CLIPCHILDREN		= 0x02000000,
		WS_MAXIMIZE		= 0x01000000,
		WS_CAPTION		= 0x00C00000,
		WS_BORDER		= 0x00800000,
		WS_DLGFRAME		= 0x00400000,
		WS_VSCROLL		= 0x00200000,
		WS_HSCROLL		= 0x00100000,
		WS_SYSMENU		= 0x00080000,
		WS_THICKFRAME		= 0x00040000,
		WS_GROUP		= 0x00020000,
		WS_TABSTOP		= 0x00010000,
		WS_MINIMIZEBOX		= 0x00020000,
		WS_MAXIMIZEBOX		= 0x00010000,
		WS_TILED		= 0x00000000,
		WS_ICONIC		= 0x20000000,
		WS_SIZEBOX		= 0x00040000,
		WS_POPUPWINDOW		= unchecked((int)0x80880000),
		WS_OVERLAPPEDWINDOW	= WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
		WS_TILEDWINDOW		= WS_OVERLAPPEDWINDOW,
		WS_CHILDWINDOW		= WS_CHILD,
	}
}
