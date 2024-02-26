using System.Data;
using System.Runtime.CompilerServices;

namespace Tyuiu.DarychevAA.Task1.V4
{
    public partial class MainForm_DAA : Form
    {
        public DataTable books = new DataTable("Books");
        public MainForm_DAA()
        {
            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;

            DataColumn authorColumn = new DataColumn("Author", typeof(string));
            DataColumn nameColumn = new DataColumn("Name", typeof(string));
            DataColumn yearColumn = new DataColumn("Year", typeof(int));
            DataColumn priceColumn = new DataColumn("Price", typeof(double));
            DataColumn publisherColumn = new DataColumn("IsNewPublisher", typeof(bool));
            DataColumn anotationColumn = new DataColumn("Anotation", typeof(string));

            books.Columns.Add(idColumn);
            books.Columns.Add(authorColumn);
            books.Columns.Add(nameColumn);
            books.Columns.Add(yearColumn);
            books.Columns.Add(priceColumn);
            books.Columns.Add(publisherColumn);
            books.Columns.Add(anotationColumn);

            InitializeComponent();
            dataGridOutTable_DAA.DataSource = books;
            openFileDialogOpenTable_DAA.InitialDirectory = System.IO.Path.Combine(Application.ExecutablePath, "Resources");
            saveFileDialogSaveTable_DAA.InitialDirectory = System.IO.Path.Combine(Application.ExecutablePath, "Resources");
        }

        private void toolStripMenuItemOpenFile_DAA_Click(object sender, EventArgs e)
        {
            books.Rows.Clear();
            StreamReader reader = new StreamReader("Resources\\DB.csv");
            string[] line;
            for (int i = 0; i < System.IO.File.ReadAllLines("Resources\\DB.csv").Length; i++)
            {
                line = reader.ReadLine().Split('|');
                for (int j = 0; j < 6; j++)
                {
                    if (line[j] == "")
                        line[j] = null;
                }
                books.Rows.Add(new object[] { null, line[1], line[2], Convert.ToInt32(line[3]), Convert.ToDouble(line[4]), Convert.ToBoolean(line[5]), line[6] });
            }
            reader.Close();
        }

        private void dataGridOutTable_DAA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressInt);
            if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 3)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressInt);
            }
            if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 4)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressDouble);
            }
            if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 0)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressNone);
            }

        }
        private void Column_KeyPressInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void Column_KeyPressDouble(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ','))
                e.Handled = true;
        }
        private void Column_KeyPressNone(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormFilter_DAA f1 = new FormFilter_DAA();
            f1.Owner = this;
            f1.ShowDialog();
        }

        private void toolStripButtonRefreshTable_DAA_Click(object sender, EventArgs e)
        {
            books.DefaultView.RowFilter = "";
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            books.DefaultView.RowFilter = $"Name LIKE '%{toolStripTextBoxSearch_DAA.Text}%' OR Author LIKE '%{toolStripTextBoxSearch_DAA.Text}%'";
        }
        private void UpdateStatusStripText()
        {
            if (dataGridOutTable_DAA.SelectedRows.Count == 0)
            {
                return;
            }

            double sumTotal = 0;
            int selectedCellsTotal = dataGridOutTable_DAA.SelectedRows.Count;

            for (int i = 0; i < selectedCellsTotal; i++)
            {
                if (dataGridOutTable_DAA.SelectedRows[i].Cells["Price"].Value != null)
                    if (dataGridOutTable_DAA.SelectedRows[i].Cells["Price"].Value.ToString().Length != 0)
                        sumTotal += double.Parse(dataGridOutTable_DAA.SelectedRows[i].Cells["Price"].Value.ToString());
            }

            double maxPrice = dataGridOutTable_DAA.SelectedRows.Cast<DataGridViewRow>().Max(x => Convert.ToDouble(x.Cells["Price"].Value));
            double minPrice = dataGridOutTable_DAA.SelectedRows.Cast<DataGridViewRow>().Min(x => Convert.ToDouble(x.Cells["Price"].Value));

            toolStripStatusLabelSumPrice_DAA.Text = "Price Sum: " + Math.Round(sumTotal, 2).ToString();
            toolStripStatusLabelCountRows_DAA.Text = "Count: " + selectedCellsTotal.ToString();
            toolStripStatusLabelAvgPrice_DAA.Text = "Price Avg: " + Math.Round((sumTotal / selectedCellsTotal), 2).ToString();
            toolStripStatusLabelMaxPrice_DAA.Text = "Price Max: " + maxPrice.ToString();
            toolStripStatusLabelMinPrice_DAA.Text = "Price Min: " + minPrice.ToString();
        }

        private void dataGridOutTable_DAA_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusStripText();
        }

        private void toolStripButtonShowCharts_Click(object sender, EventArgs e)
        {
            FormCharts_DAA fc = new FormCharts_DAA();
            fc.Owner = this;
            fc.ShowDialog();
        }

        private void toolStripButtonSave_DAA_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSaveTable_DAA.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialogSaveTable_DAA.FileName;
            StreamWriter writer = new StreamWriter(filename);
            foreach (DataRow r in books.Rows)
            {
                foreach (var cell in r.ItemArray)
                {
                    writer.Write(cell + "|");
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        private void toolStripButtonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpenTable_DAA.ShowDialog() == DialogResult.Cancel)
                return;
            books.Rows.Clear();
            string filename = openFileDialogOpenTable_DAA.FileName;
            StreamReader reader = new StreamReader(filename);
            string[] line;
            for (int i = 0; i < System.IO.File.ReadAllLines(filename).Length; i++)
            {
                line = reader.ReadLine().Split('|');
                for (int j = 0; j < 6; j++)
                {
                    if (line[j] == "")
                        line[j] = null;
                }
                books.Rows.Add(new object[] { null, line[1], line[2], Convert.ToInt32(line[3]), Convert.ToDouble(line[4]), Convert.ToBoolean(line[5]), line[6] });
            }
            reader.Close();
        }
    }
}