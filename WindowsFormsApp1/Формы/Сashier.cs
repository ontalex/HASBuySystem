using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Формы.Окна_кассира;

namespace WindowsFormsApp1.Формы
{
    public partial class Сashier : Form
    {
        string id_user;
        int count_sessions = 1;
        int count_products = 0;
        int cost_sum = 0;

        public Сashier(string id)
        {
            id_user = id;
            InitializeComponent();

            counter_sessions.Text = count_sessions.ToString();

            tableBox.Columns.Add("id_product", "ID Товар");
            tableBox.Columns.Add("name", "Имя");
            tableBox.Columns.Add("cost", "Стоимость");
        }

        private void чекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переход в таблицу с чеками
            this.Hide();
            new Receipts().Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переход в таблицу с товарами
            this.Hide();
            new ProductsCashir().Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Выйти из аккаунта
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Кнопка добавить позицию товара
            // Получить данные из формы
            string id_product = input_id_product.Text;
            // Сделать запрос
            // Соединение
            string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
            OleDbConnection con = new OleDbConnection(conString);

            // Запрос к БД
            con.Open();
            string str = $"SELECT id_товар, Имя, Стоимость FROM Товары WHERE id_товар={id_product}";
            OleDbCommand cmd = new OleDbCommand(str, con);
            // Получить необходимые данные
            OleDbDataReader reader = cmd.ExecuteReader(); // Read data

            // Проверяем данные
            if (reader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка!");
            }
            else
            {
                while (reader.Read())
                {
                    tableBox.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                    
                    // обновляем колличесво продуктов в корзине
                    count_products = count_products + 1;
                    counter_products.Text = count_products.ToString();

                    // обновляем итоговую сумму
                    cost_sum = cost_sum + int.Parse(reader[2].ToString());
                    counter_cost.Text = cost_sum.ToString();
                }
            }

            // Закрытваем соединения
            con.Close();
            cmd.Dispose();
            reader.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            // Проверка на выделение строки
            // Удалить из таблицы строку 
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            // Проверить наличие данных в таблице (или проверить счётчик позиций)
            // Войти в цикл отправки пакета данных в БД
            
            // Обновить сессию
            // Стереть данные из поля, таблицы
            // Обнулить счётчик позиций, сумму чека
        }
    }
}
