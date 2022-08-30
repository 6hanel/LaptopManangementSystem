using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace GroupAssignment
{
    public partial class ServiceReport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public ServiceReport()
        {
            InitializeComponent();
        }


        private void BtnSReportMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            this.Close();
        }

        private void BtnSReportContinue_Click(object sender, EventArgs e)
        {
            string month = CbSReportMonth.SelectedIndex.ToString();
            if (CbSReportMonth.Text == "")
            {
                MessageBox.Show("Please Select a month in the list box.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbSReportMonth.Focus();
                return;
            }
            else
            {
                con.Open();
                SqlDataAdapter ReportData = new SqlDataAdapter("Select * From service where Month(servicedate) = '" + month + "'", con);
                DataTable DataGridService = new DataTable();
                ReportData.Fill(DataGridService);
                DataGridServiceRpt.DataSource = DataGridService;
                con.Close();
            }
        }

        private void ServiceReport_Load(object sender, EventArgs e)
        {

        }
    }
}
