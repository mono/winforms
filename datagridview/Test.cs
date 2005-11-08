using System;
using System.Windows.Forms;
using System.Drawing;


public class DataGridViewTest : Form {

	DataGridView myDataGridView;
	Button ledgerStyleButton;
	Button deleteRowButton;
	Button addNewRowButton;

	public DataGridViewTest () {
		this.Closed += OnClosed;
		addNewRowButton = new Button();
		addNewRowButton.Text = "Nuevo";
		addNewRowButton.Click += new EventHandler(AddNewRowButtonClick);
		this.Controls.Add(addNewRowButton);
		deleteRowButton = new Button();
		deleteRowButton.Text = "Borrar";
		deleteRowButton.Location = new Point(100, 0);
		deleteRowButton.Click += new EventHandler(DeleteRowButtonClick);
		this.Controls.Add(deleteRowButton);
		ledgerStyleButton = new Button();
		ledgerStyleButton.Text = "Estilo";
		ledgerStyleButton.Location = new Point(200, 0);
		ledgerStyleButton.Click += new EventHandler(LedgerStyleButtonClick);
		this.Controls.Add(ledgerStyleButton);
		myDataGridView = new DataGridView();
		myDataGridView.ColumnCount = 5;
		DataGridViewCellStyle style = myDataGridView.ColumnHeadersDefaultCellStyle;
		style.BackColor = Color.Navy;
		style.ForeColor = Color.White;
		style.Font = new Font(myDataGridView.Font, FontStyle.Bold);
		myDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
		myDataGridView.Name = "myDataGridView";
		//myDataGridView.Location = new Point(0, 250);
		myDataGridView.Location = new Point(50, 50);
		myDataGridView.Size = new Size(500,500);
		//myDataGridView.Size = new Size(550,250);
		myDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
		myDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
		myDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
		myDataGridView.GridColor = SystemColors.ActiveBorder;
		myDataGridView.RowHeadersVisible = false;
		myDataGridView.Columns[0].Name = "Release Date";
		myDataGridView.Columns[1].Name = "Track";
		myDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		myDataGridView.Columns[2].Name = "Title";
		myDataGridView.Columns[3].Name = "Artist";
		myDataGridView.Columns[4].Name = "Album";
		myDataGridView.Columns[4].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
		myDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;	
		myDataGridView.MultiSelect = false;
		myDataGridView.BackgroundColor = Color.Honeydew;
		//myDataGridView.Dock = DockStyle.Fill;
		myDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(MyDataGridViewCellFormatting);
		myDataGridView.CellParsing += new DataGridViewCellParsingEventHandler(MyDataGridViewCellParsing);
		myDataGridView.CellValidating += new DataGridViewCellValidatingEventHandler(MyDataGridViewCellValidating);
		this.Controls.Add(myDataGridView);

		// Rellenar el DataGrid
		DataGridViewRowCollection rows = this.myDataGridView.Rows;
		rows.Add(new string[] {"11/22/1968", "29", "Revolution 9", "Beatles", "The Beatles [White Album]"});
		rows.Add(new string[] {"4/4/1960", "6", "Fools Rush In", "Frank Sinatra", "Nice 'N' Easy"});
		rows.Add(new string[] {"11/11/1971", "1", "One of These Days", "Pink Floyd", "Meddle"});
		rows.Add(new string[] {"4/4/1988", "7", "Where Is MY Mind?", "Pixies", "Surfer Rosa"});
		rows.Add(new string[] {"5/1981", "9", "Can't Find My Mind", "Cramps", "Psychedelic Jungle"});
		rows.Add(new string[] {"6/10/2003", "13", "Scatterbrain. (As Dead As Leaves.)", "Radiohead", "Hail to the Thief"});
		rows.Add(new string[] {"6/30/1992", "3", "Dress", "P J Harvey", "Dry"});
		DataGridViewColumnCollection columns = this.myDataGridView.Columns;
		columns[0].DisplayIndex = 3;
		columns[1].DisplayIndex = 4;
		columns[2].DisplayIndex = 0;
		columns[3].DisplayIndex = 1;
		columns[4].DisplayIndex = 2;
	}

	void MyDataGridViewCellValidating (object sender, EventArgs args) {
	}

	void MyDataGridViewCellParsing (object sender, EventArgs args) {
	}

	void MyDataGridViewCellFormatting (object sender, EventArgs args) {
	}

	void AddNewRowButtonClick (object sender, EventArgs args) {
	}

	void DeleteRowButtonClick (object sender, EventArgs args) {
	}

	void LedgerStyleButtonClick (object sender, System.EventArgs e) {
		DataGridViewCellStyle style = new DataGridViewCellStyle();
		{
			style.BackColor = Color.Beige;
			style.ForeColor = Color.Brown;
			style.Font = new Font("Verdana", 8);
		}
		myDataGridView.AlternatingRowsDefaultCellStyle = style;
		ledgerStyleButton.Enabled = false;
	}

	void OnClosed (object o, EventArgs e) {
		Console.WriteLine("Closed");
		Application.Exit();
	}

	public static void Main (string[] args) {
		DataGridViewTest p = new DataGridViewTest();
		Application.Run(p);
	}

}
