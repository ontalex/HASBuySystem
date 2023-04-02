using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы.Окна_кассира
{
        public partial class Receipts : Form
        {
                public Receipts()
                {
                        InitializeComponent();
                }

                private void кассаToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                }

                private void товарыToolStripMenuItem_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                }

                private void search_input_TextChanged(object sender, System.EventArgs e)
                {
                        (tableBox.DataSource as DataTable).DefaultView.RowFilter = $"id_чек LIKE '%{search_input.Text}%' ";
                }
        }
}
