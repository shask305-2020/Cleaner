using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChimChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            //Создаем строку подключения к БД
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Антон\Source\Repos\Cleaner\Cleaner.mdf;Integrated Security=True");
            
            //Создаем команду для проверки связки Логин+Пароль. Логин и пароль берем из полей ввода на форме авторизации
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT RealName FROM Login WHERE Username='" + txtLogin.Text + "' AND Password='" + txtPass.Text + "' ", connection);
            
            //Заполняем данные из БД в набор данных, используя DataTable
            DataTable table = new DataTable();
            
            //Заполняем данные в таблицу, которая будет храниться в оперативной памяти
            adapter.Fill(table);

            //Создаем массив типа Object, в который помещаем данные из первой строки (индекс у нее - 0)
            object[] login = table.Rows[0].ItemArray;

            //Передаем первый элемент массива в строковую переменную, используем конвертер в строку (ToString())
            string realName = login[0].ToString();

            //Если связка Логин+Пароль верные. то запрос вернет ровно одну строку (так как не может быть так, что логин один, а паролей два и более)
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Добро пожаловать, " + realName);
                MainForm mainForm = new MainForm(realName);
                mainForm.Show();
                this.Hide();
            }
            else  //Иначе, сбрасываем поля ввода и уведомляем пользователя о неверных данных
            {
                MessageBox.Show("Логин или пароль неверен");
                txtLogin.Text = "";
                txtPass.Text = "";
                txtLogin.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
