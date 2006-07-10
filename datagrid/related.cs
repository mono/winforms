
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


public class T : Form {

	private DataSet dataset;

	void textchanged (object sender, EventArgs args)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	void bindingchanged (object sender, EventArgs args)
	{
		Console.WriteLine (Environment.StackTrace);
	}

	public T ()
	{
		TextBox athlete = new TextBox ();
		TextBox sport = new TextBox ();
		DataGrid dg = new DataGrid ();
		Button next = new Button ();
		Button prev = new Button ();

		athlete.BindingContextChanged += new EventHandler (bindingchanged);
		athlete.TextChanged += new EventHandler (textchanged);

		BuildDataSet ();

		athlete.Top = 20;
		sport.Top = athlete.Bottom + 10;

		athlete.DataBindings.Add ("Text", dataset, "Sports.AthletesSports.AthleteName");
		sport.DataBindings.Add ("Text", dataset, "Sports.AthletesSports.Sport");

		next.Text = "next";
		prev.Text = "prev";
		next.Click += new EventHandler (NextHandler);
		prev.Click += new EventHandler (PrevHandler);
		prev.Location = new Point (3, sport.Bottom + 10);
		next.Location = new Point (prev.Right + 10, sport.Bottom + 10);

		dg.DataSource = dataset;
		dg.DataMember = "Sports.AthletesSports"; // "Sports.AthletesSports";
		dg.Location = new Point (3, next.Bottom + 10);
		dg.Height = Bottom - dg.Top -3;
		dg.Width = Right - dg.Left;

		Controls.Add (next);
		Controls.Add (prev);
		Controls.Add (athlete);
		Controls.Add (sport);
		Controls.Add (dg);

		Console.WriteLine ("BINDINGS:   {0}", BindingContext [dataset, "Sports.AthletesSports"]);
		Console.WriteLine ("BINDINGS:   {0}", BindingContext [dataset, "Sports.AthletesSports.AthleteName"]);
		Console.WriteLine ("BINDINGS:   {0}", BindingContext [dataset, "Sports.AthletesSports.Sport"]);
	}

	private void NextHandler (object sender, EventArgs e)
	{
		CurrencyManager cm = BindingContext [dataset, "Sports.AthletesSports"] as CurrencyManager;
		cm.Position++;
		Console.WriteLine ("CM POSITION:   {0}   {1}", cm.Position, cm);

		BindingManagerBase scm = BindingContext [dataset, "Sports.AthletesSports.AthleteName"] as BindingManagerBase;
		Console.WriteLine ("BINDINGS:   {0}  {1}", scm, (scm != null ? scm.Position : -666));
		
	}

	private void PrevHandler (object sender, EventArgs e)
	{
		CurrencyManager cm = BindingContext [dataset, "Sports.AthletesSports"] as CurrencyManager;
		cm.Position--;
		Console.WriteLine ("CM POSITION:   {0}   {1}", cm.Position, cm);
		
		BindingManagerBase scm = BindingContext [dataset, "Sports.AthletesSports.AthleteName"] as BindingManagerBase;
		Console.WriteLine ("BINDINGS:   {0}  {1}", scm, (scm != null ? scm.Position : -666));
		
	}

	private void BuildDataSet ()
	{
		dataset = new DataSet ();
		DataTable sports = new DataTable ("Sports");
		DataTable athletes = new DataTable ("Athletes");
		
		DataColumn column;
		DataRow row;

		column = new DataColumn ();
		column.DataType = typeof (int);
		column.ColumnName = "SportID";
		column.Unique = true;
		sports.Columns.Add (column);

		column = new DataColumn ();
		column.DataType = typeof (string);
		column.ColumnName = "SportName";
		sports.Columns.Add (column);


		string [] sports_names = new string [] { "Hockey", "Baseball", "Basketball", "Football", "Boxing", "Surfing" };
		for (int i = 0; i < sports_names.Length; i++) {
			row = sports.NewRow ();
			row ["SportID"] = i;
			row ["SportName"] = sports_names [i];
			sports.Rows.Add (row);
		}
		
		
		// Athletes table
		column = new DataColumn ();
		column.DataType = typeof (int);
		column.ColumnName = "AthleteID";
		column.Unique = true;
		athletes.Columns.Add (column);

		column = new DataColumn ();
		column.DataType = typeof (int);
		column.ColumnName = "Sport";
		athletes.Columns.Add (column);

		column = new DataColumn ();
		column.DataType = typeof (string);
		column.ColumnName = "AthleteName";
		athletes.Columns.Add (column);


		string [] athlete_names = new string [] { "@alp", "@lupus", "@tjfontaine", "duncan", "marv", "WindowsUninstall",
						       "@jackson", "@migHome", "_Synced[work]", "GodZhila", "Raboo",
						       "@jchambers", "@mkestner", "barbosa", "IzeBurn", "squinky86",
						       "@kangaroo",  "@paco", "Demian", "logiclrd", "tenshiKur0" };
		for (int i = 0; i < athlete_names.Length; i++) {
			row = athletes.NewRow ();
			row ["AthleteID"] = i;
			row ["Sport"] = i % sports_names.Length;
			row ["AthleteName"] = athlete_names [i];
			athletes.Rows.Add (row);
		}

		dataset.Tables.Add (sports);
		dataset.Tables.Add (athletes);
		dataset.Relations.Add ("AthletesSports", sports.Columns ["SportID"], athletes.Columns ["Sport"]);

		//	DataSource = dataset;
	}

	public static void Main ()
	{
		Application.Run (new T ());
	}

}

