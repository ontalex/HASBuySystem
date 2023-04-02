using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы.Окна_кассира
{
        public partial class Receipts : Form
        {
                string id_user;
                public Receipts(string id)
                {
                        InitializeComponent();
                        this.id_user = id;

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"SELECT * FROM Чеки WHERE id_сотрудник = {id}";
                        //OleDbCommand cmd = new OleDbCommand(str, con);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(str, con);

                        DataSet dataSet = new DataSet();

                        adapter.Fill(dataSet, "Чеки");

                        tableBox.DataSource= dataSet.Tables[0].DefaultView;

                        
                }

                private void кассаToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        new WindowsFormsApp1.Формы.Окна_кассира.Сashier(id_user).Show();
                }

                private void товарыToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        new ProductsCashir(id_user).Show();
                }
        }
}
