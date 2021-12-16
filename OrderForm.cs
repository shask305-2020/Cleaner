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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            TableView();
        }
        
        DataSet set = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Антон\Source\Repos\Cleaner\Cleaner.mdf;Integrated Security=True");
        string com = (@"SELECT * FROM [Order]");     //команда для выбора заказов
        

        private void TableView()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(com, con);
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
