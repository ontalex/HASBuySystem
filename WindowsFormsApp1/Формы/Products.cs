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
    public partial class ProductsWin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb");
        string str = "SELECT * FROM Товары";

        AdminPeople adminPeople = new AdminPeople();

        public ProductsWin()
        {
            InitializeComponent();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Товары");
            tableBox.DataSource = ds.Tables[0].DefaultView;
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Очистка форм
            inputName.Text = string.Empty;
            inputCost.Text = string.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPeople.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Deliveries().Show();
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
    }
}
