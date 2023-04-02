using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WindowsFormsApp1.Формы;

namespace WindowsFormsApp1
{
        public partial class Form1 : Form
        {
                OleDbConnection con;
                OleDbCommand cmd;
                OleDbDataAdapter adapter;
                OleDbDataReader dr;

                public Form1()
                {
                        InitializeComponent();
                }

                private void btnSignIn_Click(object sender, EventArgs e)
                {
                        string usr = inputLogin.Text;
                        string psw = inputPassword.Text;
                        con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb");
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        string str = "SELECT должность, id_сотрудник FROM users WHERE логин='" + usr + "' AND пароль='" + psw + "'";
                        cmd.CommandText = str;

                        AdminPeople winAP = new AdminPeople();

                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                                OleDbDataAdapter ada = new OleDbDataAdapter(str, con);
                                DataTable dt = new DataTable();
                                ada.Fill(dt);

                                if (dt.Rows[0][0].ToString().ToLower() == "администратор")
                                {
                                        winAP.Show();
                                }
                                if (dt.Rows[0][0].ToString().ToLower() == "кассир")
                                {
                                        new WindowsFormsApp1.Формы.Окна_кассира.Сashier(dt.Rows[0][1].ToString()).Show();
                                }

                        }
                        else
                        {
                                MessageBox.Show("Неправильный логин или пароль");
                        }

                        con.Close();
                }
        }
}
