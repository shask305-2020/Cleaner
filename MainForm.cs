using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChimChi
{
    public partial class MainForm : Form
    {
        public MainForm(string data)    //Изменили конструктор создания формы (добавили строковую переменную)
        {
            InitializeComponent();
            UserName.Text = data;       //Присвоим объекту Label (где у нас будет имя пользователя) значение,
        }                               //полученное в предыдущем окне


        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Закрываем приложение полностью
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();     //Закрываем приложение полностью
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();      //Создаем окно OrderForm
            orderForm.Show();                           //Отображаем созданное окно
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();         //Создаем окно NewOrder
            newOrder.Show();                            //Отображаем созданное окно
        }
    }
}
