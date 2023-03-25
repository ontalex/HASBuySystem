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
using WindowsFormsApp1.Формы;

namespace WindowsFormsApp1
{
    public partial class AdminPeople : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb");
        string str = "SELECT * FROM users";

        public AdminPeople()
        {
            InitializeComponent();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "users");
            tableBox.DataSource = ds.Tables[0].DefaultView;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Очистка формы
            inputLogin.Text = string.Empty;
            inputPass.Text = string.Empty;
            inputRule.Text = string.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Очистка формы
            inputLogin.Text = string.Empty;
            inputPass.Text = string.Empty;
            inputRule.Text = string.Empty;
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
