using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы.Окна_кассира
{
        public partial class ProductsCashir : Form
        {
                string id_user;
                public ProductsCashir(string id)
                {
                        InitializeComponent();
                        this.id_user = id;

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"SELECT id_товар, Имя, Стоимость FROM Товары";

                        OleDbDataAdapter adapter = new OleDbDataAdapter(str, con);

                        DataSet dataSet = new DataSet();

                        adapter.Fill(dataSet, "Товары");

                        tableBox.DataSource = dataSet.Tables[0].DefaultView;
                }

                private void кассаToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                }

                private void чекиToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        new Receipts(id_user).Show();
                }
        }
}
