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
            main.books.DefaultView.RowFilter = comboBoxFilterColumn_DAA.Text+" "+comboBoxFilterAttribite_DAA.Text+" "+textBoxFilterValue_DAA.Text;
            this.Close();
        }
    }
}
