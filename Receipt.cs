using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //for accessing database
using System.Configuration; //for accessing configuration file

namespace GroupAssignment
{
    public partial class Receipt : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString()); 
        public Service servicesObj;
        public Customer customerObj;
        public Receipt(Service services, Customer customer)
        {
            InitializeComponent();
            servicesObj = services;
            customerObj = customer;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            con.Open();
            string invoice = null;
            string Price = null;
            RtxtOrders.Text = servicesObj.DisplayService();
            LblShowdate.Text = servicesObj.Date;

            SqlCommand invoiceID = new SqlCommand("select invoiceId from Service where UserIC = '" + customerObj.CusID + "'", con);

            object test = invoiceID.ExecuteScalar();
            try
            {
                if (test != null)
                {
                    invoice = test.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
            LblShowinvid.Text = "IV" + invoice;

            SqlCommand price = new SqlCommand("select price from service where UserIC = '" + customerObj.CusID + "'", con);

            object test2 = price.ExecuteScalar();
            try
            {
                if (test2 != null)
                {
                    Price = test2.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
            LblDsptotal.Text = "RM" + Price;
            LblDsppaid.Text = "RM" + Price;

            con.Close();
        }

        private void RtxtOrders_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RtxtOrders_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainRecep mainRecep = new MainRecep();
            this.Hide();
            mainRecep.ShowDialog();
            this.Close();
        }
    }
}
