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
    public partial class CreateAccReception : Form
    {
        public CreateAccReception()
        {
            InitializeComponent();
        }

        private static bool NameValid(string Name)
        {
            // returns true if the input is a valid Name
            return Regex.IsMatch(Name, @"^[\p{L}\p{M}' \.\-]+$");
        }
        private static bool EmailCheckValid(string email)
        {
            // returns true if the input is a valid email
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        private static bool ICValid(string IC)
        {
            // returns true if the input is a valid IC
            return Regex.IsMatch(IC, @"(([[0-9]{2})(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01]))-([0-9]{2})-([0-9]{4})");
        }

        private void CreateAccReception_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = TxtNameRec;
        }

        private void BtnRFCancelRec_Click_1(object sender, EventArgs e)
        {
            Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            Close();
        }

        private void BtnRFContinueRec_Click_1(object sender, EventArgs e)
        {
            //For Name
            if (TxtNameRec.Text == "")
            {
                MessageBox.Show("Name cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNameRec.Focus();
                return;
            }
            // For IC
            if (TxtICRec.Text == "")
            {
                MessageBox.Show("IC cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtICRec.Focus();
                return;
            }
            // For Age
            if (TxtAgeRec.Text == "")
            {
                MessageBox.Show("Age cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAgeRec.Focus();
                return;
            }
            else if (Int32.Parse(TxtAgeRec.Text) > 100 || Int32.Parse(TxtAgeRec.Text) < 12)
            {
                MessageBox.Show("Please Enter a Valid Age. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAgeRec.Focus();
            }
            if (CbGenderRec.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Your Gender. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbGenderRec.Focus();
                return;
            }
            //For Pass
            if (TxtPassRec.Text == "" || TxtPassRec.Text == "")
            {
                MessageBox.Show("Password cannot be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassRec.Focus();
                return;
            }
            else if (TxtPassRec.Text != TxtPassCfmRec.Text)
            {
                MessageBox.Show("Your Password doesn't match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassRec.Clear();
                TxtPassCfmRec.Clear();
                return;
            }
            else if (TxtPassRec.TextLength < 7 || TxtPassRec.TextLength > 12)
            {
                MessageBox.Show("Your Length of Your Password should be around 7 to 12 Letters. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassRec.Focus();
                return;
            }
            //For Email
            if (TxtEmailRec.Text == "")
            {
                MessageBox.Show("Email cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEmailRec.Focus();
                return;
            }
            //For Phone Number
            if (TxtNumberRec.Text == "")
            {
                MessageBox.Show("Email cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumberRec.Focus();
                return;
            }
            else if (TxtNumberRec.TextLength < 7 || TxtNumberRec.TextLength > 12)
            {
                MessageBox.Show("Your Phone Number length is too long or too short. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumberRec.Focus();
                return;
            }
            //Check Name is valid or not
            bool ValidName = NameValid(TxtNameRec.Text);
            if (ValidName == false)
            {
                MessageBox.Show("Your Name can't consist of numbers. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNameRec.Focus();
                return;
            }
            //Check IC is valid or not
            bool ValidIC = ICValid(TxtICRec.ToString());
            if (ValidIC == false)
            {
                MessageBox.Show("Your IC is incorrect. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtICRec.Focus();
                return;
            }
            //Check Email is valid or not
            bool ValidEmail = EmailCheckValid(TxtEmailRec.Text);
            if (ValidEmail == false)
            {
                MessageBox.Show("Your email is invalid. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumberRec.Focus();
                return;
            }
            string role = "Receptionist";
            User obj1 = new User(TxtICRec.Text, TxtNameRec.Text, int.Parse(TxtAgeRec.Text), CbGenderRec.Text.ToString(), TxtPassRec.Text, TxtEmailRec.Text, TxtNumberRec.Text, role);
            obj1.RegisterUser();
            MessageBox.Show("Registration Succesfull. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            Close();
        }
    }
}
