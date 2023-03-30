using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WindowsFormsApp1.Формы;

namespace WindowsFormsApp1
{
        public partial class AdminPeople : Form
        {
                public AdminPeople()
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
                        string str = $"DELETE FROM users WHERE id_сотрудник = {id}";
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
                            tableBox.Rows[index].Cells[2].Value == null ||
                            tableBox.Rows[index].Cells[3].Value == null
                        )
                        {
                                MessageBox.Show("Не все данных введены!", "Внимание!");
                                return;
                        }

                        // Счиываем данные
                        string id = tableBox.Rows[index].Cells[0].Value.ToString();
                        string login = tableBox.Rows[index].Cells[1].Value.ToString();
                        string pass = tableBox.Rows[index].Cells[2].Value.ToString();
                        string work = tableBox.Rows[index].Cells[3].Value.ToString();

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"INSERT INTO users VALUES ({id}, '{login}', '{pass}', '{work}')";
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
                            tableBox.Rows[index].Cells[1].Value == null ||
                            tableBox.Rows[index].Cells[2].Value == null ||
                            tableBox.Rows[index].Cells[3].Value == null
                        )
                        {
                                MessageBox.Show("Не все данных введены!", "Внимание!");
                                return;
                        }

                        // Счиываем данные
                        string id = tableBox.Rows[index].Cells[0].Value.ToString();
                        string login = tableBox.Rows[index].Cells[1].Value.ToString();
                        string pass = tableBox.Rows[index].Cells[2].Value.ToString();
                        string work = tableBox.Rows[index].Cells[3].Value.ToString();

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"UPDATE users SET логин='{login}', пароль='{pass}', должность='{work}' WHERE id_сотрудник = {id}";
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
                        string str = "SELECT * FROM users";
                        OleDbCommand cmd = new OleDbCommand(str, con);
                        OleDbDataReader reader = cmd.ExecuteReader(); // Read data

                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, "users");

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



                private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        ProductsWin productsWin = new ProductsWin();
                        this.Hide();
                        productsWin.Show();
                }

                private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        this.Hide();
                        new Suppliers().Show();
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
