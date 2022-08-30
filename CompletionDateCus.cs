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
    public partial class FormPurchasesList : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public FormPurchasesList()
        {
            InitializeComponent();
            SqlCommand sql1 = new SqlCommand("Select receiptid, Orderdate, CustomerID, pricetotal, serviceclass from Receipt where CustomerID = '" + Name + "'", con);
        }

        private void FormPurchasesList_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());

            sqlConnection.Open();
            SqlCommand sql1 = new SqlCommand("Select receiptid, Orderdate, CustomerID, pricetotal, serviceclass from Receipt where CustomerID = '" + Name + "'", con);
            SqlDataAdapter servicelist = new SqlDataAdapter("Select * From Progress", sqlConnection);
            DataTable dt = new DataTable();
            servicelist.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            DataGridLaptopCmpAndClt.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnReturnDash_Click(object sender, EventArgs e)
        {
            FormCustomerDashboard formCustomerDashboard = new FormCustomerDashboard();
            this.Hide();
            formCustomerDashboard.ShowDialog();
            this.Close();
        }

        private void DataGridLaptopCmpAndClt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
