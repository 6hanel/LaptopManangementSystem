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
using System.Configuration;

namespace GroupAssignment
{

    public partial class FormPaymentPending : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public FormPaymentPending()
        {
            InitializeComponent();
        }

        private void PendingPayment_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
            sqlConnection.Open();
            SqlCommand sql1 = new SqlCommand("Select receiptid, Orderdate, CustomerID, pricetotal, serviceclass from Receipt where CustomerID = '" + Name + "'", con);
            SqlDataAdapter servicelist = new SqlDataAdapter("Select * From Services", sqlConnection);
            DataTable dt = new DataTable();
            servicelist.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridViewPaymentPending.DataSource = dt;
            sqlConnection.Close();
        }

        private void dataGridViewPaymentPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlDataAdapter PurchaseHistoryData = new SqlDataAdapter("Select * From Services = ", con);
            DataTable dataGridViewPaymentPending = new DataTable();
            PurchaseHistoryData.Fill(dataGridViewPaymentPending);
            con.Close();
        }

        private void btnReturnDash_Click(object sender, EventArgs e)
        {
            FormCustomerDashboard formCustomerDashboard = new FormCustomerDashboard();
            this.Hide();
            formCustomerDashboard.ShowDialog();
            this.Close();
        }
    }
}
