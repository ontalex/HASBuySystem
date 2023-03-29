using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Формы.Окна_кассира;

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
            // Кнопка добавить позицию товара
            // Сделать запрос
            // Получить необходимые данные
            // Записать данныхе в таблицу
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            // Проверка на выделение строки
            // Удалить из таблицы строку 
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            // Проверить наличие данных в таблице (или проверить счётчик позиций)
            // Войти в цикл отправки пакета данных в БД
            
            // Обновить сессию
            // Стереть данные из поля, таблицы
            // Обнулить счётчик позиций, сумму чека
        }
    }
}
