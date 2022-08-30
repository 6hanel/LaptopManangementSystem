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
    public partial class FormCheckout : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public Service servicesObj;
        public Customer customerObj;

        public FormCheckout()
        {
            InitializeComponent();
        }

        public FormCheckout(Service services, Customer customer)
        {
            InitializeComponent();

            servicesObj = services;
            customerObj = customer;
        }


        private void Checkout_Load(object sender, EventArgs e)
        {
            LblDsptotal.Text = servicesObj.Price.ToString();
            RtxtOrders.Text = servicesObj.DisplayService();
        }


        private void RtxtOrders_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RtxtOrders_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnConfirmpay_Click_1(object sender, EventArgs e)
        {
            con.Open();

            if (radAgreed.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into Customer (UserIC, name, email, password, age, gender, phonenumber) values(@id, @name, @email, @password, @age, @gender, @phonenumber)", con);

                cmd.Parameters.AddWithValue("@id", customerObj.CusID);
                cmd.Parameters.AddWithValue("@name", customerObj.Name);
                cmd.Parameters.AddWithValue("@email", customerObj.Email);
                cmd.Parameters.AddWithValue("@password", customerObj.Password);
                cmd.Parameters.AddWithValue("@age", customerObj.Age);
                cmd.Parameters.AddWithValue("@gender", customerObj.Gender);
                cmd.Parameters.AddWithValue("@phonenumber", customerObj.Phone);

                //Service obj2 = new Service(servicetypes, Price, priority, date);
                SqlCommand cmd2 = new SqlCommand("insert into Service (UserIC, service, price, priority, serviceDate) values(@UserIC, @service, @price, @priority, @serviceDate)", con);

                cmd2.Parameters.AddWithValue("@UserIC", customerObj.CusID);
                cmd2.Parameters.AddWithValue("@service", servicesObj.ServiceType);
                cmd2.Parameters.AddWithValue("@price", servicesObj.Price);
                cmd2.Parameters.AddWithValue("@priority", servicesObj.Priority);
                cmd2.Parameters.AddWithValue("@serviceDate", servicesObj.Date);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Registration Successful.");
                }
                else
                {
                    MessageBox.Show("Registration unsuccessful. Please try again.");
                    con.Close();
                }

                cmd2.ExecuteNonQuery();

                this.Hide();
                Receipt receipt = new Receipt(servicesObj, customerObj);
                receipt.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please agree with the terms and conditions below.");
            }
            con.Close();
        }

        private void BtnRmvsrvc_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radAgreed_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
