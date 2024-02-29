using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DarychevAA.Task1.V4
{
    public partial class FormFilter_DAA : Form
    {

        public FormFilter_DAA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm_DAA main = this.Owner as MainForm_DAA;
            if (comboBoxFilterAttribite_DAA.Text == "" || comboBoxFilterColumn_DAA.Text == "" || textBoxFilterValue_DAA.Text == "")
            {
                MessageBox.Show("Select filter options and fill in the filter value");
                return;
            }
            if (main.dataGridOutTable_DAA.DataSource == main.books)
                main.books.DefaultView.RowFilter = comboBoxFilterColumn_DAA.Text + " " + comboBoxFilterAttribite_DAA.Text + " " + textBoxFilterValue_DAA.Text;
            else
                main.readers.DefaultView.RowFilter = comboBoxFilterColumn_DAA.Text + " " + comboBoxFilterAttribite_DAA.Text + "  #" + Convert.ToDateTime(textBoxFilterValue_DAA.Text).ToString("yyyy/MM/dd") + "#";

            this.Close();
        }

        private void FormFilter_DAA_Load(object sender, EventArgs e)
        {
            MainForm_DAA main = this.Owner as MainForm_DAA;
            comboBoxFilterColumn_DAA.Items.Clear();
            if (main.dataGridOutTable_DAA.DataSource == main.readers)
            {
                comboBoxFilterColumn_DAA.Items.AddRange(new string[] { "DateOfIssue", "DateOfReturn" });
                buttonShowReturnedBooks_DAA.Visible = true;
            }              
            else
            {
                comboBoxFilterColumn_DAA.Items.AddRange(new string[] { "Year", "Price" });
                buttonShowReturnedBooks_DAA.Visible = false;
            }
                
        }

        private void buttonShowReturnedBooks_DAA_Click(object sender, EventArgs e)
        {
            MainForm_DAA main = this.Owner as MainForm_DAA;
            main.readers.DefaultView.RowFilter = "DateOfReturn IS NOT NULL";
            this.Close();
        }
    }
}
