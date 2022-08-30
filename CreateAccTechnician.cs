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
    public partial class CreateAccTechnician : Form
    {

        public CreateAccTechnician()
        {

            InitializeComponent();
        }

        private void BtnRFContinueTech_Click(object sender, EventArgs e)
        {
            //For Name
            if (TxtNameTech.Text == "")
            {
                MessageBox.Show("Name cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNameTech.Focus();
                return;
            }
            // For IC
            if (TxtICTech.Text == "")
            {
                MessageBox.Show("IC cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtICTech.Focus();
                return;
            }
            // For Age
            if (TxtAgeTech.Text == "")
            {
                MessageBox.Show("Age cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAgeTech.Focus();
                return;
            }
            else if (Int32.Parse(TxtAgeTech.Text) > 100 || Int32.Parse(TxtAgeTech.Text) < 12)
            {
                MessageBox.Show("Please Enter a Valid Age. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAgeTech.Focus();
            }
            if (CbGenderTech.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Your Gender. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbGenderTech.Focus();
                return;
            }
            //For Pass
            if (TxtPassTech.Text == "" || TxtPassTech.Text == "")
            {
                MessageBox.Show("Password cannot be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassTech.Focus();
                return;
            }
            else if (TxtPassTech.Text != TxtPassCfmTech.Text)
            {
                MessageBox.Show("Your Password doesn't match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassTech.Clear();
                TxtPassCfmTech.Clear();
                return;
            }
            else if (TxtPassTech.TextLength < 7 || TxtPassTech.TextLength > 12)
            {
                MessageBox.Show("Your Length of Your Password should be around 7 to 12 Letters. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassTech.Focus();
                return;
            }
            //For Email
            if (TxtEmailTech.Text == "")
            {
                MessageBox.Show("Email cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEmailTech.Focus();
                return;
            }
            //For Phone Number
            if (TxtNumberTech.Text == "")
            {
                MessageBox.Show("Email cannot be empty. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumberTech.Focus();
                return;
            }
            else if (TxtNumberTech.TextLength < 7 || TxtNumberTech.TextLength > 12)
            {
                MessageBox.Show("Your Phone Number is invalid, Please Try Again. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumberTech.Focus();
                return;
            }
            bool ValidName = NameValid(TxtNameTech.Text);
            if (ValidName == false)
            {
                MessageBox.Show("Your Name can't consist of numbers. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNameTech.Focus();
                return;
            }
            //Check IC is valid or not
            bool ValidIC = ICValid(TxtICTech.ToString());
            if (ValidIC == false)
            {
                MessageBox.Show("Your IC is incorrect. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtICTech.Focus();
                return;
            }
            //Check Email is valid or not
            bool ValidEmail = EmailCheckValid(TxtEmailTech.Text);
            if (ValidEmail == false)
            {
                MessageBox.Show("Your email is invalid. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEmailTech.Focus();
                return;
            }
            string role = "Technician";
            User obj1 = new User(TxtICTech.Text, TxtNameTech.Text, int.Parse(TxtAgeTech.Text), CbGenderTech.Text.ToString(), TxtPassTech.Text, TxtEmailTech.Text, TxtNumberTech.Text, role);
            obj1.RegisterUser();
            MessageBox.Show("Registration Successfull. ");
            Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            Close();
        }
        private void BtnRFCancelTech_Click(object sender, EventArgs e)
        {
            Hide();
            MainAdmin ma = new MainAdmin();
            ma.ShowDialog();
            Close();
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

        private void CreateAccTechnician_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtNameTech;
        }
    }
}
