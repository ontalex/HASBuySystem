using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

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
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\DB.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT должность FROM users WHERE логин='" + usr + "' AND пароль='" + psw + "'";
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
                    MessageBox.Show("Вы - Админимстратор");
                    winAP.Show();
                }
                if (dt.Rows[0][0].ToString().ToLower() == "кассир")
                {
                    MessageBox.Show("Вы - Кассир");
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
