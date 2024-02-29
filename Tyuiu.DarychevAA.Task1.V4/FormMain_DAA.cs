using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Tyuiu.DarychevAA.Task1.V4
{
    public partial class MainForm_DAA : Form
    {
        public DataTable books = new DataTable("Books");
        public DataTable readers = new DataTable("Readers");
        public MainForm_DAA()
        {
            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 0;
            idColumn.AutoIncrementStep = 1;

            DataColumn authorColumn = new DataColumn("Author", typeof(string));
            DataColumn nameColumn = new DataColumn("Title", typeof(string));
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

            DataColumn userIdColumn = new DataColumn("Id", typeof(int));
            DataColumn userFullName = new DataColumn("Full name", typeof(string));
            DataColumn userAddress = new DataColumn("Address", typeof(string));
            DataColumn userPhoneNumber = new DataColumn("PhoneNumber", typeof(string));
            DataColumn userBookID = new DataColumn("BookId", typeof(int));
            DataColumn userDateOfIssue = new DataColumn("DateOfIssue", typeof(DateTime));
            DataColumn userDateOfReturn = new DataColumn("DateOfReturn", typeof(DateTime));

            readers.Columns.Add(userIdColumn);
            readers.Columns.Add(userFullName);
            readers.Columns.Add(userAddress);
            readers.Columns.Add(userPhoneNumber);
            readers.Columns.Add(userBookID);
            readers.Columns.Add(userDateOfIssue);
            readers.Columns.Add(userDateOfReturn);

            InitializeComponent();
            dataGridOutTable_DAA.DataSource = books;
        }


        private void dataGridOutTable_DAA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressInt);
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressDouble);
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressLetterOrDigit);
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressLetter);
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPressNone);

            if (dataGridOutTable_DAA.DataSource == books)
            {
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 3)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressInt);
                }
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 1)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressLetter);
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
            else 
            {
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex >= 5)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressDouble);
                }
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 3 || dataGridOutTable_DAA.CurrentCell.ColumnIndex == 4|| dataGridOutTable_DAA.CurrentCell.ColumnIndex == 0)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressInt);
                }
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 2)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressLetterOrDigit);
                }
                if (dataGridOutTable_DAA.CurrentCell.ColumnIndex == 1)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                        textBox.KeyPress += new KeyPressEventHandler(Column_KeyPressLetter);
                }
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
        private void Column_KeyPressLetter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == '.') && (!char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
        private void Column_KeyPressLetterOrDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == '.')&&(!char.IsWhiteSpace(e.KeyChar)))
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
            readers.DefaultView.RowFilter = "";
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridOutTable_DAA.DataSource == books)
                books.DefaultView.RowFilter = $"Title LIKE '%{toolStripTextBoxSearch_DAA.Text}%' OR Author LIKE '%{toolStripTextBoxSearch_DAA.Text}%'";
            else
                readers.DefaultView.RowFilter = $"Full name Like '%{toolStripTextBoxSearch_DAA.Text}%' OR CONVERT(BookId, System.String) LIKE '%{toolStripTextBoxSearch_DAA.Text}%' OR PhoneNumber Like '%{toolStripTextBoxSearch_DAA.Text}%'";
        }
        private void UpdateStatusStripText()
        {
            if (dataGridOutTable_DAA.SelectedRows.Count == 0 || dataGridOutTable_DAA.DataSource==readers)
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
            saveFileDialogSaveTable_DAA.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Resources\");
            if (saveFileDialogSaveTable_DAA.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialogSaveTable_DAA.FileName;
            StreamWriter writer = new StreamWriter(filename);

            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd,MM,yyyy";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            if (dataGridOutTable_DAA.DataSource == books)
            {
                writer.WriteLine("BOOKS");
                foreach (DataRow r in books.Rows)
                {
                    foreach (var cell in r.ItemArray)
                    {
                        writer.Write(cell + "|");
                    }
                    writer.WriteLine();
                }
            }             
            else
            {
                writer.WriteLine("READERS");
                foreach (DataRow r in readers.Rows)
                {
                    foreach (var cell in r.ItemArray)
                    {
                        writer.Write(cell + "|");
                    }
                    writer.WriteLine();
                }
            }
            writer.Close();
        }

        private void toolStripButtonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            openFileDialogOpenTable_DAA.InitialDirectory = System.IO.Path.Combine(Application.StartupPath,@"Resources\");
            if (openFileDialogOpenTable_DAA.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialogOpenTable_DAA.FileName;
            StreamReader reader = new StreamReader(filename);
            string fileType = reader.ReadLine();
            string[] line;
            if (fileType=="BOOKS")
            {
                books.Rows.Clear();
                for (int i = 0; i < System.IO.File.ReadAllLines(filename).Length-1; i++)
                {
                    line = reader.ReadLine().Split('|');
                    for (int j = 0; j < 6; j++)
                    {
                        if (line[j] == "")
                            line[j] = null;
                    }
                    books.Rows.Add(new object[] { Convert.ToInt32(line[0]), line[1], line[2], Convert.ToInt32(line[3]), Convert.ToDouble(line[4]), Convert.ToBoolean(line[5]), line[6] });
                }
                reader.Close();
            }
            else
            {
                readers.Rows.Clear();
                for (int i = 0; i < System.IO.File.ReadAllLines(filename).Length-1; i++)
                {
                    line = reader.ReadLine().Split('|');
                    for (int j = 0; j < 6; j++)
                    {
                        if (line[j] == "")
                            line[j] = null;
                    }
                    line[5] = line[5].Replace(" ", "");
                    line[6] = line[6].Replace(" ", "");
                    if (line[6]=="")
                        readers.Rows.Add(new object[] { Convert.ToInt32(line[0]), line[1], line[2], line[3], Convert.ToInt32(line[4]), Convert.ToDateTime(line[5]) });
                    else
                        readers.Rows.Add(new object[] { Convert.ToInt32(line[0]), line[1], line[2], line[3], Convert.ToInt32(line[4]), Convert.ToDateTime(line[5]), Convert.ToDateTime(line[6]) });

                }
                reader.Close();
            } 
        }
        private void buttonChangeToBooks_DAA_Click(object sender, EventArgs e)
        {
            dataGridOutTable_DAA.DataSource = books;
            buttonChangeToBooks_DAA.BackColor = SystemColors.ControlLightLight;
            buttonChangeToReaders.BackColor = SystemColors.Control;
        }

        private void buttonChangeToReaders_Click(object sender, EventArgs e)
        {
            dataGridOutTable_DAA.DataSource = readers;
            buttonChangeToBooks_DAA.BackColor = SystemColors.Control;
            buttonChangeToReaders.BackColor = SystemColors.ControlLightLight;
        }  
    }
}