﻿using System;
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
                        int chequeLastID, chequeCreate, saleLastID, saleCreate;

                        // Проверить наличие данных в таблице (или проверить счётчик позиций)
                        if (count_products== 0) {
                                MessageBox.Show("Невозможно завершить сессию! Список пуст!", "Внимание!");
                                return; 
                        }

                        // Войти в цикл отправки пакета данных в БД
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        con.Open();

                        // Запрос на получение последенего ID
                        string sqlChequeLastID = $"SELECT MAX(id_чек) FROM Чеки";
                        OleDbCommand cmdChequeLastID = new OleDbCommand(sqlChequeLastID, con);
                        if (cmdChequeLastID.ExecuteNonQuery() != 1)
                        {
                                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
                                return;
                        }
                        reader = cmdChequeLastID.ExecuteReader();
                        chequeLastID = int.Parse(reader[0].ToString());


                        string sqlСhequeCreate = $"INSERT INTO Чеки VALUES ({chequeLastID+1}, {id_user}, {cost_sum}, {DateTime.Now.ToString("H:mm:ss")})";
                        OleDbCommand cmdСhequeCreate = new OleDbCommand(sqlСhequeCreate, con);
                        if (cmdСhequeCreate.ExecuteNonQuery() != 1)
                        {
                                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
                                return;
                        }


                        // Запрос на получение полседней продажи
                        string sqlSaleLastID = $"SELECT MAX(id_продажа) FROM Продажи";
                        OleDbCommand cmdSaleLastID = new OleDbCommand(sqlSaleLastID, con);
                        if (cmdSaleLastID.ExecuteNonQuery() != 1)
                        {
                                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
                                return;
                        }
                        reader = cmdSaleLastID.ExecuteReader();
                        saleLastID = int.Parse(reader[0].ToString());


                        // Обернуть в цикл обхода таблицы для создания запроса 
                        string sqlSaleCreate = $"";
                        OleDbCommand cmdSaleCreate = new OleDbCommand(sqlSaleCreate, con);
                        if (cmdSaleCreate.ExecuteNonQuery() != 1)
                        {
                                MessageBox.Show("Ошибка ваполнения запроса!", "Ошибка!");
                                return;
                        }


                        // Обновить сессию
                        // Стереть данные из поля, таблицы
                        // Обнулить счётчик позиций, сумму чека
                }
        }
}
