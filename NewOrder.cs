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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            DeliveryOff();
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeliveryOff()
        {
            radio1.Checked = true;
            textCity.Enabled = false;
            textStreet.Enabled = false;
            textHouse.Enabled = false;
            textApartment.Enabled = false;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                textCity.Enabled = false;
                textStreet.Enabled = false;
                textHouse.Enabled = false;
                textApartment.Enabled = false;
            }
            else
            {
                textCity.Enabled = true;
                textStreet.Enabled = true;
                textHouse.Enabled = true;
                textApartment.Enabled = true;

            }
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cleanerDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.cleanerDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cleanerDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.cleanerDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cleanerDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.cleanerDataSet.Category);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
    }
}
