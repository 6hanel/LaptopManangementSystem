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
    public partial class TotalIncome : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public TotalIncome()
        {
            InitializeComponent();
        }

        private void BtnTotalMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            this.Close();
        }

        private void BtnTotalContinue_Click(object sender, EventArgs e)
        {
            string month = CbTotalMonth.SelectedIndex.ToString();
            string Month = CbTotalMonth.Text.ToString();
            if (CbTotalMonth.Text == "")
            {
                MessageBox.Show("Please Select a month in the list box.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbTotalMonth.Focus();
                return;
            }
            else
            {
                con.Open();
                SqlDataAdapter ReportData = new SqlDataAdapter("Select id,service,price,priority,serviceDate From service where Month(serviceDate) = '" + month + "'", con);
                DataTable DataGridServiceTotalIn = new DataTable();
                SqlCommand cmd = new SqlCommand("Select SUM(price) As TotalIncome From service where Month(serviceDate) = '" + month + "'", con);
                SqlCommand cmd2 = new SqlCommand("Select count(*) From service where Month(serviceDate) = '" + month + "'", con);
                int count = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                if (count == 0)
                {
                    MessageBox.Show("There is no transaction on this month.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    return;
                }
                else
                {
                    int Sum = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    TxtTotal.Clear();
                    TxtTotal.Text = "The Total Income of " + Month + " is RM " + Sum;
                    ReportData.Fill(DataGridServiceTotalIn);
                    DataGridTotalIncome.DataSource = DataGridServiceTotalIn;
                    con.Close();
                }
            }
        }
    }
}
   
