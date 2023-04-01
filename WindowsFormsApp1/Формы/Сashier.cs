using System;
using System.Data.OleDb;
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
                        // проверить оле на пустоту
                        if (input_id_product.Text == "")
                        {
                                MessageBox.Show("Введите значение в поле!", "Внимание!");
                                return;
                        }

                        string id_product = input_id_product.Text;

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

                        input_id_product.Text = string.Empty;
                }

                private void btn_del_Click(object sender, EventArgs e)
                {
                        // Проверка на колличество выбранных строк
                        if (tableBox.SelectedRows.Count != 1)
                        {
                                MessageBox.Show("Выберите одну сторку!", "Внимание!");
                                return;
                        }

                        int index = tableBox.SelectedRows[0].Index;

                        if (tableBox.Rows[index].Cells[0].Value == null)
                        {
                                MessageBox.Show("Не все данных введены!", "Внимание!");
                                return;
                        }

                        tableBox.Rows.RemoveAt(index);

                        // обновляем колличесво продуктов в корзине
                        count_products = count_products - 1;
                        counter_products.Text = count_products.ToString();

                        // обновляем итоговую сумму
                        cost_sum = 0;
                        for (int i = 0; i < tableBox.Rows.Count - 1; i++)
                        {
                                cost_sum = cost_sum + int.Parse(tableBox.Rows[i].Cells[2].Value.ToString());
                        }
                        counter_cost.Text = cost_sum.ToString();
                }

                private void btn_end_Click(object sender, EventArgs e)
                {
                        OleDbDataReader reader;
                        int saleLastID = int.Parse(DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
                        string chequeLastID = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

                        // Проверить наличие данных в таблице (или проверить счётчик позиций)
                        if (count_products== 0) {
                                MessageBox.Show("Невозможно завершить сессию! Список пуст!", "Внимание!");
                                return; 
                        }

                        // открываем соедиение с БД
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection conEnd = new OleDbConnection(conString);
                        conEnd.Open();

                        // формирование чека и отправка в БД
                        string sqlСhequeCreate = $"INSERT INTO Чеки VALUES ({chequeLastID}, {id_user}, {cost_sum}, '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
                        OleDbCommand cmdСhequeCreate = new OleDbCommand(sqlСhequeCreate, conEnd);
                        if (cmdСhequeCreate.ExecuteNonQuery() != 1)
                        {
                                MessageBox.Show("cmdСhequeCreate errror SQL Reqvest", "Ошибка!");
                                return;
                        }

                        // цикл записи продаж в БД
                        for(int i = 0; i < tableBox.Rows.Count - 1; i++) {
                                string sqlSaleCreate = $"INSERT INTO Продажи VALUES ({saleLastID+i}, {tableBox.Rows[i].Cells[0].Value.ToString()}, {chequeLastID})";
                                OleDbCommand cmdSaleCreate = new OleDbCommand(sqlSaleCreate, conEnd);
                                if (cmdSaleCreate.ExecuteNonQuery() != 1)
                                {
                                        MessageBox.Show("cmdSaleCreate errror SQL Reqvest", "Ошибка!");
                                        return;
                                }
                        }
                        conEnd.Close();

                        // Обновить данные на фронте
                        count_sessions = count_sessions + 1;
                        count_products = 0;
                        cost_sum = 0;

                        counter_cost.Text = cost_sum.ToString();
                        counter_products.Text = count_products.ToString();
                        counter_sessions.Text =count_sessions.ToString();

                        tableBox.Rows.Clear();
                }
        }
}
