using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы
{
        public partial class Deliveries : Form
        {
                public Deliveries()
                {
                        InitializeComponent();
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

                private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        this.Hide();
                        new Suppliers().Show();
                }

                private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
                {
                        this.Hide();
                        new Manufacturers().Show();
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
                        string str = $"DELETE FROM Поставки WHERE id_поставка = {id}";
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
                        string id_manufactur = tableBox.Rows[index].Cells[1].Value.ToString();
                        string id_supplier = tableBox.Rows[index].Cells[2].Value.ToString();
                        string date = tableBox.Rows[index].Cells[3].Value.ToString();

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"INSERT INTO Поставки VALUES ({id}, {id_manufactur}, {id_supplier}, {date})";
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
                        string id_manufactur = tableBox.Rows[index].Cells[1].Value.ToString();
                        string id_supplier = tableBox.Rows[index].Cells[2].Value.ToString();
                        string date = tableBox.Rows[index].Cells[3].Value.ToString();

                        // Соединение
                        string conString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb";
                        OleDbConnection con = new OleDbConnection(conString);

                        // Запрос к БД
                        con.Open();
                        string str = $"UPDATE Поставки SET id_производитель={id_manufactur}, id_поставщик={id_supplier}, дата_поставки={date} WHERE id_поставка = {id}";
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
                        string str = "SELECT * FROM Поставки";
                        OleDbCommand cmd = new OleDbCommand(str, con);
                        OleDbDataReader reader = cmd.ExecuteReader(); // Read data

                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, "поставки");

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
                                        tableBox.Rows.Add(ds.Tables[0].DefaultView);
                                }
                        }

                        reader.Close();
                        con.Close();
                }
        }
}
