using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
	public static void Main() {
		Application.EnableVisualStyles();
		Application.Run(new Form1());
	}

	DataGridView dgv;

	public Form1() {
		//this.AutoSize = true;
		dgv = new DataGridView();
		Console.WriteLine("AdvancedCellBorderStyle: " + dgv.AdvancedCellBorderStyle.ToString());
		//dgv.Size = new Size(500,250);
		dgv.Location = new Point(10,10);
		dgv.RowTemplate = new DataGridViewRow();
		DataGridViewColumn col = new DataGridViewColumn();
		col.CellTemplate = new DataGridViewTextBoxCell();
		dgv.Columns.Add(col);
		DataGridViewColumn col2 = col.Clone() as DataGridViewColumn;
		col2.CellTemplate = col.CellTemplate;
		dgv.Columns.Add(col2);
		DataGridViewColumn col3 = col.Clone() as DataGridViewColumn;
		col3.CellTemplate = col.CellTemplate;
		dgv.Columns.Add(col3);
		dgv.RowCount = 4;
		dgv.EnableHeadersVisualStyles = false;
		dgv.AutoSize = true;
		dgv.CellPainting += OnCellPainting;
		this.Controls.Add(dgv);
		this.Text = "DataGridView advanced border styles demo";
	}

	public void OnCellPainting (object sender, DataGridViewCellPaintingEventArgs e) {
		Console.WriteLine(e.CellBounds);
		Console.WriteLine(e.RowIndex);
		Console.WriteLine(e.ColumnIndex);
		foreach (DataGridViewCell cell in dgv.Rows[e.RowIndex].Cells) {
			Console.WriteLine("\t" + cell.RowIndex);
			Console.WriteLine("\t" + cell.ColumnIndex);
			Console.WriteLine("\t" + cell.ContentBounds);
		}
		//Console.WriteLine(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ContentBounds);
		Console.WriteLine("----------------------");
		Rectangle newRect = new Rectangle(e.CellBounds.X,
			e.CellBounds.Y, e.CellBounds.Width / 2,
			e.CellBounds.Height / 2);

		using (
			Brush gridBrush = new SolidBrush(dgv.GridColor),
			backColorBrush = new SolidBrush(e.CellStyle.BackColor))
		{
			using (Pen gridLinePen = new Pen(gridBrush))
			{
				// Erase the cell.
				e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

				// Draw the grid lines (only the right and bottom lines;
				// DataGridView takes care of the others).
				/*e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
					e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
					e.CellBounds.Bottom - 1);
					*/
				e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
					e.CellBounds.Top, e.CellBounds.Right - 1,
					e.CellBounds.Bottom);

				// Draw the inset highlight box.
				e.Graphics.DrawRectangle(Pens.Blue, newRect);

				// Draw the text content of the cell, ignoring alignment.
				if (e.Value != null)
				{
					e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
						Brushes.Crimson, e.CellBounds.X + 2,
						e.CellBounds.Y + 2, StringFormat.GenericDefault);
				}
				e.Handled = true;
			}
		}
	}

}
