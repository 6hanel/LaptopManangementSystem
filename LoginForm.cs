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
using System.Text.RegularExpressions;

namespace GroupAssignment
{
    public partial class LoginForm : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            if (TxtLoginIC.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter IC number to proceed.");
                return false;
            } else if (TxtLoginPass.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter password to proceed.");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MainTech.count = 0;
            MainAdmin.count = 0;
            MainRecep.count = 0;
            FormCustomerDashboard.count = 0;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bool ValidIC = ICValid(TxtLoginIC.ToString());
                if (ValidIC == false)
                {
                    MessageBox.Show("Your IC is incorrect. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtLoginIC.Focus();
                    return;
                }
                User obj1 = new User(TxtLoginIC.Text, TxtLoginPass.Text);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Userdetail where UserIC ='" + obj1.IC + "' and password = '" + obj1.Password + "'", sqlConnection);
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                sqlConnection.Close();


                if (count > 0)
                {
                    sqlConnection.Open();
                    SqlCommand cmd2 = new SqlCommand("Select name from Userdetail where UserIC ='" + obj1.IC
                    + "'", sqlConnection);

                    SqlCommand cmd3 = new SqlCommand("Select usertype from Userdetail where UserIC ='" + obj1.IC
                    + "'", sqlConnection);

                    string userName = cmd2.ExecuteScalar().ToString();
                    string userType = cmd3.ExecuteScalar().ToString();
                    sqlConnection.Close();
                    SetValueForText1 = TxtLoginIC.Text;
                    SetValueForText2 = userName;

                    if (userType == "Admin")
                    {
                        MainAdmin a = new MainAdmin();
                        this.Hide();
                        a.ShowDialog();
                        this.Close();
                    }
                    else if (userType == "Receptionist")
                    {
                        MainRecep R = new MainRecep();
                        this.Hide();
                        R.ShowDialog();
                        this.Close();
                    }
                    else if (userType == "Technician")
                    {
                        MainTech T = new MainTech();
                        this.Hide();
                        T.ShowDialog();
                        this.Close();
                    }
                    else if (userType == "Customer")
                    {
                        FormCustomerDashboard C = new FormCustomerDashboard();
                        this.Hide();
                        C.ShowDialog();
                        this.Close();
                    }
                    else
                {
                    MessageBox.Show("Incorrect Username/Password");
                }
                }

            }
        }
            private void LinkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass pass = new ForgotPass();
            this.Hide();
            pass.ShowDialog();
            this.Close();
        }
        private static bool ICValid(string IC)
        {
            // returns true if the input is a valid IC
            return Regex.IsMatch(IC, @"(([[0-9]{2})(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01]))-([0-9]{2})-([0-9]{4})");
        }

        private void TxtLoginIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
