using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы
{
    public partial class Сashier : Form
    {
        string id_user;

        public Сashier(string id)
        {
            InitializeComponent();
            id_user = id;
        }

        private void чекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переход в таблицу с чеками
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переход в таблицу с товарами
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Выйти из аккаунта
        }
    }
}
