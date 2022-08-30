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
    public partial class ForgotPass : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public ForgotPass()
        {
            InitializeComponent();
        }


        private void BtnForgotPass_Click(object sender, EventArgs e)
        {
            if (TxtForgotPass.Text == "")
            {
                MessageBox.Show("Please type in your IC in the text box. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtForgotPass.Focus();
                return;
            }
            //Check IC is valid or not
            bool ValidIC = ICValid(TxtForgotPass.ToString());
            if (ValidIC == false)
            {
                MessageBox.Show("Your IC is incorrect. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtForgotPass.Focus();
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) From Userdetail where UserIC='" + TxtForgotPass.Text + "'", con);
            int Count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (Count > 0)
            {
                Hide();
                ResetPass rp = new ResetPass();
                rp.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("The email you have type in doesn't exist in the Database, Please Try Again. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtForgotPass.Focus();
                return;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm l = new LoginForm();
            l.ShowDialog();
            Close();
        }
        private static bool ICValid(string IC)
        {
            // returns true if the input is a valid IC
            return Regex.IsMatch(IC, @"(([[0-9]{2})(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01]))-([0-9]{2})-([0-9]{4})");
        }
    }
}
