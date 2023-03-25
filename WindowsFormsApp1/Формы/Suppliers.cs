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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\AlexB\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\DB.mdb");
        string str = "SELECT * FROM Поставщики";

        public Suppliers()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(str, con);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Поставки");
            tableBox.DataSource = ds.Tables[0].DefaultView;
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
