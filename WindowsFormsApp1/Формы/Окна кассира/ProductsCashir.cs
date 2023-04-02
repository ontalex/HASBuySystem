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
                        OleDbCommand cmd = new OleDbCommand(str, con);

                        // Получить необходимые данные
                        // OleDbDataReader reader = cmd.ExecuteReader(); // Read data

                }

                private void кассаToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        new WindowsFormsApp1.Формы.Окна_кассира.Сashier(id_user).Show();
                }

                private void чекиToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        new Receipts(id_user).Show();
                }
        }
}
