using System.Data;

namespace Tyuiu.DarychevAA.Task1.V4
{
    public partial class MainForm_DAA : Form
    {
        DataTable books = new DataTable("Books");
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


            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });
            books.Rows.Add(new object[] { null, "Антонов А.А", "Книжка", 2013, 20.15, true, "Книжка о чём-то аааааааааааааааааааааааааааааааааа" });


            InitializeComponent();
            dataGridOutTable_DAA.DataSource = books;
        }

        private void toolStripMenuItemSaveFile_DAA_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("DB.csv");
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
    }
}