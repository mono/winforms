//
// swf-simple-binding.cs
//  - A very simple databinding sample
//
// Copyright (c) 2004-2005 Novell, Inc.
//
// Authors:
//	Jackson Harper (jackson@ximian.com)

using System;
using System.Data;
using System.Windows.Forms;


public class SimpleBinding : Form {

	public struct Employee {

		private string name;
		private string title;

		public Employee (string name, string title)
		{
			this.name = name;
			this.title = title;
		}

		public object Name {
			get { return name; }
		}

		public string Title {
			get { return title; }
		}
	}

	public Employee [] EmployeeList = new Employee [] {
		new Employee ("Roxy", "Dog"),
		new Employee ("Jackson", "Rockstar"),
		new Employee ("Zafo", "Alien"),
	};

	private TextBox text_box;
	private Button next_button;
	private Button back_button;

	public SimpleBinding ()
	{
		text_box = new TextBox ();
		text_box.Left = 10;
		text_box.Top = 10;
		text_box.Width = Width - 20;
		
		next_button = new Button ();
		next_button.Text = "Next";
		next_button.Left = Width - 10 - next_button.Width;
		next_button.Top = text_box.Bottom + 5;
		
		back_button = new Button ();
		back_button.Text = "Back";
		back_button.Left = 10;
		back_button.Top = text_box.Bottom + 5;

		next_button.Click += new EventHandler (NextClick);
		back_button.Click += new EventHandler (BackClick);

		Controls.Add (text_box);
		Controls.Add (next_button);
		Controls.Add (back_button);

		text_box.DataBindings.Add ("Text", EmployeeList, "Name");
	}

	public void NextClick (object sender, EventArgs e)
	{
		BindingContext [EmployeeList].Position++;
	}

	public void BackClick (object sender, EventArgs e)
	{
		BindingContext [EmployeeList].Position--;
	}

	public static void Main ()
	{
		Application.Run (new SimpleBinding ());
	}
}

