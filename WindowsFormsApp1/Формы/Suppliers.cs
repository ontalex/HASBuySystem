using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }


        private void delete_Click(object sender, EventArgs e)
        {
            // Проверка на колличество выбранных строк
            if (tableBox.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну сторку!", "Внимание!");
                return;
            }

            int index = tableBox.SelectedRows[0].Index;

            if (
                tableBox.Rows[index].Cells[0].Value == null
            )
            {
                MessageBox.Show("Не все данных введены!", "Внимание!");
                return;
            }

            // Счиываем данные
            string id = tableBox.Rows[index].Cells[0].Value.ToString();

            // Соединение
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
            OleDbConnection con = new OleDbConnection(conString);

            // Запрос к БД
            con.Open();
            string str = $"DELETE FROM Поставщики WHERE id_поставщик = {id}";
            OleDbCommand cmd = new OleDbCommand(str, con);


            // Выполняем запрос
            if (cmd.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                // Удаляем данные из таблицы на стороне клиента
                tableBox.Rows.RemoveAt(index);
            }

            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Проверка на колличество выбранных строк
            if (tableBox.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну сторку!", "Внимание!");
                return;
            }

            int index = tableBox.SelectedRows[0].Index;

            if (
                tableBox.Rows[index].Cells[0].Value == null ||
                tableBox.Rows[index].Cells[1].Value == null ||
                tableBox.Rows[index].Cells[2].Value == null
            )
            {
                MessageBox.Show("Не все данных введены!", "Внимание!");
                return;
            }

            // Счиываем данные
            string id = tableBox.Rows[index].Cells[0].Value.ToString();
            string name = tableBox.Rows[index].Cells[1].Value.ToString();
            string inn = tableBox.Rows[index].Cells[2].Value.ToString();

            // Соединение
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
            OleDbConnection con = new OleDbConnection(conString);

            // Запрос к БД
            con.Open();
            string str = $"INSERT INTO Поставщики VALUES ({id}, '{name}', {inn})";
            OleDbCommand cmd = new OleDbCommand(str, con);

            // Выполняем запрос
            if (cmd.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
            }

            con.Close();
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            // Проверка на колличество выбранных строк
            if (tableBox.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну сторку!", "Внимание!");
                return;
            }

            int index = tableBox.SelectedRows[0].Index;

            if (
                tableBox.Rows[index].Cells[0].Value == null ||
                tableBox.Rows[index].Cells[1].Value == null 
            )
            {
                MessageBox.Show("Не все данных введены!", "Внимание!");
                return;
            }

            // Счиываем данные
            string id = tableBox.Rows[index].Cells[0].Value.ToString();
            string name = tableBox.Rows[index].Cells[1].Value.ToString();
            string inn = tableBox.Rows[index].Cells[2].Value.ToString();

            // Соединение
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
            OleDbConnection con = new OleDbConnection(conString);

            // Запрос к БД
            con.Open();
            string str = $"UPDATE Поставщики SET Наименование='{name}', ИНН={inn} WHERE id_поставщик = {id}";
            OleDbCommand cmd = new OleDbCommand(str, con);


            // Выполняем запрос
            if (cmd.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
            }

            con.Close();
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            // Соединение
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
            OleDbConnection con = new OleDbConnection(conString);

            // Запрос к БД
            con.Open();
            string str = "SELECT * FROM Поставщики";
            OleDbCommand cmd = new OleDbCommand(str, con);
            OleDbDataReader reader = cmd.ExecuteReader(); // Read data

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "поставщики");

            // Проверяем данные
            if (reader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка!");
            }
            else
            {
                while (reader.Read())
                {
                    tableBox.DataSource = ds.Tables[0].DefaultView;
                }
            }

            reader.Close();
            con.Close();
        }



        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPeople().Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductsWin().Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Deliveries().Show();
        }

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manufacturers().Show();
        }
    }
}
