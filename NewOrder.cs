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
    }
}
