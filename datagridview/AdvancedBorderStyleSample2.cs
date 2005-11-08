using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataGridViewAdvancedBorderStyleSample
{
    class Form1 : Form
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        public Form1()
        {
            //this.AutoSize = true;
			DataGridView dgv = new CustomDataGridView();
			dgv.Size = new Size(500,500);
            //this.Controls.Add(new CustomDataGridView());
            this.Controls.Add(dgv);
            this.Text = "DataGridView advanced border styles demo";
        }
    }

    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            this.RowTemplate = new DataGridViewCustomRow();
            this.Columns.Add(new DataGridViewCustomColumn());
            this.Columns.Add(new DataGridViewCustomColumn());
            this.Columns.Add(new DataGridViewCustomColumn());
            this.RowCount = 4;
            this.EnableHeadersVisualStyles = false;
            this.AutoSize = true;
        }

        public override DataGridViewAdvancedBorderStyle AdjustedTopLeftHeaderBorderStyle
        {
            get
            {
                DataGridViewAdvancedBorderStyle newStyle =
                    new DataGridViewAdvancedBorderStyle();
                newStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                newStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                newStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Outset;
                newStyle.Right = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
                return newStyle;
            }
        }

        public override DataGridViewAdvancedBorderStyle AdjustColumnHeaderBorderStyle(
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput,
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceHolder,
            bool firstDisplayedColumn,
            bool lastVisibleColumn)
        {
            // Customize the left border of the first column header and the
            // bottom border of all the column headers. Use the input style for 
            // all other borders.
            dataGridViewAdvancedBorderStylePlaceHolder.Left = firstDisplayedColumn ?
                DataGridViewAdvancedCellBorderStyle.OutsetDouble :
                DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewAdvancedBorderStylePlaceHolder.Bottom =
                DataGridViewAdvancedCellBorderStyle.Single;

            dataGridViewAdvancedBorderStylePlaceHolder.Right =
                dataGridViewAdvancedBorderStyleInput.Right;
            dataGridViewAdvancedBorderStylePlaceHolder.Top =
                dataGridViewAdvancedBorderStyleInput.Top;

            return dataGridViewAdvancedBorderStylePlaceHolder;
        }
    }

    public class DataGridViewCustomColumn : DataGridViewColumn
    {
        public DataGridViewCustomColumn()
        {
            this.CellTemplate = new DataGridViewCustomCell();
        }
    }

    public class DataGridViewCustomCell : DataGridViewTextBoxCell
    {
    }

    public class DataGridViewCustomRow : DataGridViewRow
    {
        public override DataGridViewAdvancedBorderStyle AdjustRowHeaderBorderStyle(
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput,
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceHolder,
            bool singleVerticalBorderAdded,
            bool singleHorizontalBorderAdded,
            bool isFirstDisplayedRow,
            bool isLastDisplayedRow)
        {
            // Customize the top border of the first row header and the
            // right border of all the row headers. Use the input style for 
            // all other borders.
            dataGridViewAdvancedBorderStylePlaceHolder.Top = isFirstDisplayedRow ?
                DataGridViewAdvancedCellBorderStyle.InsetDouble :
                DataGridViewAdvancedCellBorderStyle.None;
            dataGridViewAdvancedBorderStylePlaceHolder.Right =
                DataGridViewAdvancedCellBorderStyle.OutsetDouble;

            dataGridViewAdvancedBorderStylePlaceHolder.Left =
                dataGridViewAdvancedBorderStyleInput.Left;
            dataGridViewAdvancedBorderStylePlaceHolder.Bottom =
                dataGridViewAdvancedBorderStyleInput.Bottom;

            return dataGridViewAdvancedBorderStylePlaceHolder;
        }
    }
}
