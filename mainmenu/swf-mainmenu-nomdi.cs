// project created on 7/31/2003 at 1:13 PM
//
// Sample used instead of swf-mainmenu but without mdi
//
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{
        //
        //Define the controls
        //
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.Form fOne;
		private System.Windows.Forms.Form fTwo;
		private System.Windows.Forms.Form fThree;
		private System.Windows.Forms.MenuItem miStandard;
		private System.Windows.Forms.MenuItem miDivided;
		private System.Windows.Forms.MenuItem miHierarchical;
		private System.Windows.Forms.MenuItem miWindow;

		//  Standard			
		private System.Windows.Forms.MenuItem miSub0 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub1 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub2 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub3 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub4 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub5 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub6 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub7 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub8 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub9 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub10 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub11 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub12 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub13 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub14 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub15 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub16 = new MenuItem();
		private System.Windows.Forms.MenuItem miSub17 = new MenuItem();

		//  Divided
		private System.Windows.Forms.MenuItem miDash = new MenuItem();
		private System.Windows.Forms.MenuItem miDash2 = new MenuItem();
		private System.Windows.Forms.MenuItem miDash3 = new MenuItem();
		private System.Windows.Forms.MenuItem miDash4 = new MenuItem();
		private System.Windows.Forms.MenuItem miDash5 = new MenuItem();
		private System.Windows.Forms.MenuItem miDash6 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided0 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided1 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided2 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided3 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided4 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided5 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided6 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided7 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided8 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided9 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided10 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided11 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided12 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided13 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided14 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided15 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided16 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided17 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided18 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided19 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided20 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubDivided21 = new MenuItem();
			
		//  Hierarchical
		private System.Windows.Forms.MenuItem miSubHierarchical0 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical1 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical2 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical3 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical4 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical5 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical6 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical7 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical8 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical9 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical10 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical11 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical12 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical13 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical14 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical15 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical16 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical17 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical18 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical19 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical20 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical21 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical22 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical23 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical24 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical25 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical26 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical27 = new MenuItem();
		private System.Windows.Forms.MenuItem miSubHierarchical28 = new MenuItem();

		//  Window
		private System.Windows.Forms.MenuItem miWindow0 = new MenuItem();
		private System.Windows.Forms.MenuItem miWindow1 = new MenuItem();
		
		public MainForm()
		{
			InitializeComponent();
		}
	
        //
        // Initialize the controls and set their properties
        //
		void InitializeComponent()
		{
			//
			//Standard menu example menu items
			//
			miSub0.Text = "&Normal";
			miSub1.Text = "&Checked_true";
			miSub1.Checked = true;
			miSub2.Text = "&Checked_false";
			miSub2.Checked = false;
			miSub3.Text = "&RadioCheck_true";
			miSub3.RadioCheck = true;
			miSub4.Text = "&RadioCheck_false";
			miSub4.RadioCheck = false;
			miSub5.Text = "&RadioCheck_true_Checked_true";
			miSub5.RadioCheck = true;
			miSub5.Checked = true;
			miSub6.Text = "&RadioCheck_false_Checked_true";
			miSub6.RadioCheck = false;
			miSub6.Checked = true;
			miSub7.Text = "&RadioCheck_true_Checked_false";
			miSub7.RadioCheck = true;
			miSub7.Checked = false;
			miSub8.Text = "&RadioCheck_false_Checked_false";
			miSub8.RadioCheck = false;
			miSub8.Checked = false;
			miSub9.Text = "&Default_true";
			miSub9.DefaultItem = true;
			miSub10.Text = "&Default_false";
			miSub10.DefaultItem = false;
			miSub11.Text = "&Enabled_true";
			miSub11.Enabled = true;
			miSub12.Text = "&Enabled_false";
			miSub12.Enabled = false;
			miSub13.Text = "&Shortcut(CtrlS)";
			miSub13.Shortcut = Shortcut.CtrlS;
			miSub14.Text = "&Shortcut(CtrlS)_ShowShortcut_false";
			miSub14.Shortcut = Shortcut.CtrlS;
			miSub14.ShowShortcut = false;
			miSub15.Text = "&Shortcut(CtrlS)_ShowShortcut_true";
			miSub15.Shortcut = Shortcut.CtrlS;
			miSub15.ShowShortcut = true;
			miSub16.Text = "&Shortcut(CtrlT)_ShowShortcut_false";
			miSub16.Shortcut = Shortcut.CtrlT;
			miSub16.ShowShortcut = false;
			miSub17.Text = "&Shortcut(CtrlU)_ShowShortcut_true";
			miSub17.Shortcut = Shortcut.CtrlU;
			miSub17.ShowShortcut = true;

			//
			//Divided menu example menu items
			//
			miDash.Text = "-";
			miDash2.Text = "-";
			miDash2.Enabled = true;
			miDash3.Text = "-";
			miDash3.Enabled = false;
			miDash4.Text = "-";
			miDash4.Checked = true;
			miDash5.Text = "-";
			miDash5.RadioCheck = true;
			miDash5.Checked = true;
			miDash6.Text = "-";
			miDash6.DefaultItem = true;
			miSubDivided0.Text = "&Normal";
			miSubDivided1.Text = "&Checked_true";
			miSubDivided1.Checked = true;
			miSubDivided2.Text = "&Checked_false";
			miSubDivided2.Checked = false;
			miSubDivided3.Text = "&RadioCheck_true";
			miSubDivided3.RadioCheck = true;
			miSubDivided4.Text = "&RadioCheck_false";
			miSubDivided4.RadioCheck = false;
			miSubDivided5.Text = "&RadioCheck_true_Checked_true";
			miSubDivided5.RadioCheck = true;
			miSubDivided5.Checked = true;
			miSubDivided6.Text = "&RadioCheck_false_Checked_true";
			miSubDivided6.RadioCheck = false;
			miSubDivided6.Checked = true;
			miSubDivided7.Text = "&RadioCheck_true_Checked_false";
			miSubDivided7.RadioCheck = true;
			miSubDivided7.Checked = false;
			miSubDivided8.Text = "&RadioCheck_false_Checked_false";
			miSubDivided8.RadioCheck = false;
			miSubDivided8.Checked = false;
			miSubDivided9.Text = "&Default_true";
			miSubDivided9.DefaultItem = true;
			miSubDivided10.Text = "&Default_false";
			miSubDivided10.DefaultItem = false;
			miSubDivided11.Text = "&Enabled_true";
			miSubDivided11.Enabled = true;
			miSubDivided12.Text = "&Enabled_false";
			miSubDivided12.Enabled = false;
			miSubDivided13.Text = "&Shortcut(CtrlS)";
			miSubDivided13.Shortcut = Shortcut.CtrlS;
			miSubDivided14.Text = "&Shortcut(CtrlS)_ShowShortcut_false";
			miSubDivided14.Shortcut = Shortcut.CtrlS;
			miSubDivided14.ShowShortcut = false;
			miSubDivided15.Text = "&Shortcut(CtrlS)_ShowShortcut_true";
			miSubDivided15.Shortcut = Shortcut.CtrlS;
			miSubDivided15.ShowShortcut = true;
			miSubDivided16.Text = "&Shortcut(CtrlT)_ShowShortcut_false";
			miSubDivided16.Shortcut = Shortcut.CtrlT;
			miSubDivided16.ShowShortcut = false;
			miSubDivided17.Text = "&Shortcut(CtrlU)_ShowShortcut_true";
			miSubDivided17.Shortcut = Shortcut.CtrlU;
			miSubDivided17.ShowShortcut = true;
			miSubDivided18.Text = "&BarBreak_true";
			miSubDivided18.BarBreak = true;
			miSubDivided19.Text = "&BarBreak_false";
			miSubDivided19.BarBreak = false;
			miSubDivided20.Text = "&Break_true";
			miSubDivided20.Break = true;
			miSubDivided21.Text = "&Break_false";
			miSubDivided21.Break = false;

			//
			//Hierarchical menu example menu items
			//
			miSubHierarchical0.Text = "&Normal";
			miSubHierarchical1 = new MenuItem("&Checked", new MenuItem[] 
			                                  {miSubHierarchical2,
			                                  miSubHierarchical3});
			miSubHierarchical2.Text = "&Checked_true";
			miSubHierarchical2.Checked = true;
			miSubHierarchical3.Text = "&Checked_false";
			miSubHierarchical3.Checked = false;
			miSubHierarchical4 = new MenuItem("&RadioCheck", new MenuItem[] 
			                                  {miSubHierarchical5,
			                                  miSubHierarchical6, 
			                                  miSubHierarchical7,
			                                  miSubHierarchical8, 
			                                  miSubHierarchical9,
			                                  miSubHierarchical10});
			miSubHierarchical5.Text = "&RadioCheck_true";
			miSubHierarchical5.RadioCheck = true;
			miSubHierarchical6.Text = "&RadioCheck_false";
			miSubHierarchical6.RadioCheck = false;
			miSubHierarchical7.Text = "&RadioCheck_true_Checked_true";
			miSubHierarchical7.RadioCheck = true;
			miSubHierarchical7.Checked = true;
			miSubHierarchical8.Text = "&RadioCheck_false_Checked_true";
			miSubHierarchical8.RadioCheck = false;
			miSubHierarchical8.Checked = true;
			miSubHierarchical9.Text = "&RadioCheck_true_Checked_false";
			miSubHierarchical9.RadioCheck = true;
			miSubHierarchical9.Checked = false;
			miSubHierarchical10.Text = "&RadioCheck_false_Checked_false";
			miSubHierarchical10.RadioCheck = false;
			miSubHierarchical10.Checked = false;
			miSubHierarchical11 = new MenuItem("&Default", new MenuItem[] 
			                                   {miSubHierarchical12,
			                                   miSubHierarchical13});
			miSubHierarchical12.Text = "&Default_true";
			miSubHierarchical12.DefaultItem = true;
			miSubHierarchical13.Text = "&Default_false";
			miSubHierarchical13.DefaultItem = false;
			miSubHierarchical14 = new MenuItem("&Default_Default(true)", new MenuItem[] 
			                                   {miSubHierarchical15,
			                                   miSubHierarchical16});
			miSubHierarchical14.DefaultItem = true;
			miSubHierarchical15.Text = "&Default_true";
			miSubHierarchical15.DefaultItem = true;
			miSubHierarchical16.Text = "&Default_false";
			miSubHierarchical16.DefaultItem = false;
			miSubHierarchical17 = new MenuItem("&Enabled", new MenuItem[] 
			                                   {miSubHierarchical18,
			                                   miSubHierarchical19});
			miSubHierarchical18.Text = "&Enabled_true";
			miSubHierarchical18.Enabled = true;
			miSubHierarchical19.Text = "&Enabled_false";
			miSubHierarchical19.Enabled = false;
			miSubHierarchical20 = new MenuItem("&Enabled_Enabled(false)", new MenuItem[] 
			                                   {miSubHierarchical21,
			                                   miSubHierarchical22});
			miSubHierarchical20.Enabled = false;
			miSubHierarchical21.Text = "&Enabled_true";
			miSubHierarchical21.Enabled = true;
			miSubHierarchical22.Text = "&Enabled_false";
			miSubHierarchical22.Enabled = false;
			miSubHierarchical23 = new MenuItem("&ShortCut", new MenuItem[] 
			                                   {miSubHierarchical24,
			                                   miSubHierarchical25, 
			                                   miSubHierarchical26, 
			                                   miSubHierarchical27,
			                                   miSubHierarchical28});
			miSubHierarchical24.Text = "&Shortcut(CtrlS)";
			miSubHierarchical24.Shortcut = Shortcut.CtrlS;
			miSubHierarchical25.Text = "&Shortcut(CtrlS)_ShowShortcut_false";
			miSubHierarchical25.Shortcut = Shortcut.CtrlS;
			miSubHierarchical25.ShowShortcut = false;
			miSubHierarchical26.Text = "&Shortcut(CtrlS)_ShowShortcut_true";
			miSubHierarchical26.Shortcut = Shortcut.CtrlS;
			miSubHierarchical26.ShowShortcut = true;
			miSubHierarchical27.Text = "&Shortcut(CtrlT)_ShowShortcut_false";
			miSubHierarchical27.Shortcut = Shortcut.CtrlT;
			miSubHierarchical27.ShowShortcut = false;
			miSubHierarchical28.Text = "&Shortcut(CtrlU)_ShowShortcut_true";
			miSubHierarchical28.Shortcut = Shortcut.CtrlU;
			miSubHierarchical28.ShowShortcut = true;

			//
			//Window menu example menu items
			//
			miWindow0.Text = "&Window_MdiList_false";			
			miWindow1.Text = "&Window_MdiList_true";
			

			//
			//Add the menu items to the Standard example
			//
			miStandard = new MenuItem("&Standard", new MenuItem[] {miSub0, 
			                          miSub1, miSub2, miSub3, miSub4, miSub5, 
			                          miSub6, miSub7, miSub8, miSub9, miSub10, 
			                          miSub11, miSub12, miSub13, miSub14,
			                          miSub15, miSub16, miSub17});

			//
			//Add the menu items to the Divided example
			//
			miDivided = new MenuItem("&Divided", new MenuItem[] {miSubDivided0, 
			                         miDash, miSubDivided1, miSubDivided2, 
			                         miDash2, miSubDivided3, miSubDivided4, 
			                         miDash3, miSubDivided5, miSubDivided6, 
			                         miSubDivided7, miSubDivided8, miDash4, 
			                         miSubDivided9, miSubDivided10, miDash5, 
			                         miSubDivided11, miSubDivided12, miDash6, 
			                         miSubDivided13, miSubDivided14, miSubDivided15,
			                         miSubDivided16, miSubDivided17, miSubDivided18, 
			                         miSubDivided19, miSubDivided20, miSubDivided21});

			//
			//Add the menu items to the Hierarchical example
			//
			miHierarchical = new MenuItem("&Hierarchical", new MenuItem[] 
			                              {miSubHierarchical0, miSubHierarchical1, 
			                              miSubHierarchical4, miSubHierarchical11,
			                              miSubHierarchical14, miSubHierarchical17, 
			                              miSubHierarchical20, miSubHierarchical23});

			//
			//Add the menu items to the Window example
			//
			miWindow = new MenuItem("&Window", new MenuItem[] {miWindow0, miWindow1});
			

			//
			//Add the examples to the mainMenu
			//
			mainMenu = new MainMenu(new MenuItem[] {miStandard, miDivided, 
			                        miHierarchical, miWindow});
			
            //
            // MainForm (Add the controls to the form and set its properties)
            //
			this.SuspendLayout();			
			this.Name = "MainForm";
			this.Text = "SWF-MainMenu";
			this.Size = new System.Drawing.Size(600, 450);
			this.Menu = this.mainMenu;
			this.ResumeLayout(false);			

		}
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
	}		
}
