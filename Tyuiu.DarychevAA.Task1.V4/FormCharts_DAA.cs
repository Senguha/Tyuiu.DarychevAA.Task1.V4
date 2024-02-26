using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace Tyuiu.DarychevAA.Task1.V4
{
    public partial class FormCharts_DAA : Form
    {
        public FormCharts_DAA()
        {
            InitializeComponent();
        }

        private void FormCharts_DAA_Load(object sender, EventArgs e)
        {
            MainForm_DAA main = this.Owner as MainForm_DAA;

            int cheapBooks = Convert.ToInt32(main.books.Compute("Count(Price)", "Price<250"));
            int midBooks = Convert.ToInt32(main.books.Compute("Count(Price)", "Price>250 AND Price<500"));
            int expensiveBooks = Convert.ToInt32(main.books.Compute("Count(Price)", "Price>500"));
            cartesianChart1.Series = new ISeries[]
            {
                new ColumnSeries<int>
                {
                    Values = new int[] {cheapBooks, midBooks, expensiveBooks},
                    Fill = new SolidColorPaint(SKColors.Blue)
                }

            };
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Price range",
                    Labels = new List<string> { "0-250₽", "250-500₽", "500+₽" }
                }
            };
            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Amount of books"
                }
            };
        }
    }
}
