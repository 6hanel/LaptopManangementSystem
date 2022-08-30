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
    public partial class ServiceRequest : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public ServiceRequest()
        {
            InitializeComponent();
        }

        private void ServiceRequest_Load(object sender, EventArgs e)
        {

        }

        private void BtnSRequestMainCus_Click(object sender, EventArgs e)
        {
            MainTech mainTech = new MainTech();
            this.Hide();
            mainTech.ShowDialog();
            this.Close();
        }

        private void BtnSRequestContinueCus_Click(object sender, EventArgs e)
        {
            string month = CbSRequestMonthTech.SelectedIndex.ToString();
            if (CbSRequestMonthTech.Text == "")
            {
                MessageBox.Show("Please Select a month in the combo box.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbSRequestMonthTech.Focus();
                return;
            } else
            {
                sqlConnection.Open();
                SqlDataAdapter datedata = new SqlDataAdapter("Select * From service where Month(serviceDate) = '" + month + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                datedata.Fill(dataTable);
                datagridServiceRequested.DataSource = dataTable;
                sqlConnection.Close();
            }
        }
    }
}
