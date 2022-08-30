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
using System.Text.RegularExpressions;


namespace GroupAssignment
{
    public partial class CreateAccCustomer : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());

        string serviceTypes;


        public CreateAccCustomer()
        {
            InitializeComponent();
        }

        private void BtnRFCancel_Click(object sender, EventArgs e)
        {
            MainRecep mainRecep = new MainRecep();
            this.Hide();
            mainRecep.ShowDialog();
            this.Close();
        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            string priority = null;
            double Price = 0;
            string date;
            string id;
            string gender = CbGender.SelectedItem.ToString();
            date = DateTime.Now.ToString("dd/MM/yyyy");

            if (radNormal.Checked == true)
            {
                priority = "Normal";

                switch (serviceTypes)
                {
                    case "Remove Virus":
                        Price = 50;
                        break;
                    case "Troubleshoot":
                        Price = 60;
                        break;
                    case "Screen Replacement":
                        Price = 380;
                        break;
                    case "Keyboard Replacement":
                        Price = 160;
                        break;
                    case "Battery Replacement":
                        Price = 180;
                        break;
                    case "OS Format":
                        Price = 100;
                        break;
                    case "Data Backup":
                        Price = 80;
                        break;
                    case "Internet Fix":
                        Price = 70;
                        break;
                }
            }
            if (radUrgent.Checked == true)
            {
                priority = "Urgent";

                switch (serviceTypes)
                {
                    case "Remove Virus":
                        Price = 80;
                        break;
                    case "Troubleshoot":
                        Price = 90;
                        break;
                    case "Screen Replacement":
                        Price = 430;
                        break;
                    case "Keyboard Replacement":
                        Price = 200;
                        break;
                    case "Battery Replacement":
                        Price = 210;
                        break;
                    case "OS Format":
                        Price = 150;
                        break;
                    case "Data Backup":
                        Price = 130;
                        break;
                    case "Internet Fix":
                        Price = 100;
                        break;
                }
            }
            if (radUrgent.Checked != true && radNormal.Checked != true)
            {
                MessageBox.Show("Please select your service duration.");
            }
            else if (TxtIC.Text == "" || TxtName.Text == "" || TxtAge.Text == "" || TxtEmail.Text == "" || TxtPass.Text == ""
          || TxtNumber.Text == "" || TxtPassCfm.Text == "" || CbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill up all information", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (TxtPass.Text != TxtPassCfm.Text)
            {
                LblMatchpass.Text = "Your Password doesn't match. Please try again";
                TxtPassCfm.Clear();
            }
            else if (TxtPass.TextLength < 7 || TxtPass.TextLength > 12)
            {
                MessageBox.Show("Your Length of Your Password should be around 7 to 12 Letters. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPass.Clear();
                TxtPass.Focus();
                return;
            }
            else if (TxtNumber.TextLength < 7 || TxtNumber.TextLength > 12)
            {
                MessageBox.Show("Your Phone Number length is too long or too short. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumber.Clear();
                TxtNumber.Focus();
                return;
            }
            else
            {
                //Check Name is valid or not
                bool ValidName = NameValid(TxtName.Text);
                if (ValidName == false)
                {
                    MessageBox.Show("Your Name can't consist of numbers. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtName.Focus();
                    return;
                } //Check IC is valid or not
                bool ValidIC = ICValid(TxtIC.ToString());
                if (ValidIC == false)
                {
                    MessageBox.Show("Your IC is incorrect. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtIC.Focus();
                    return;
                } //Check Email is valid or not
                bool ValidEmail = EmailCheckValid(TxtEmail.Text);
                if (ValidEmail == false)
                {
                    MessageBox.Show("Your email is invalid. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtEmail.Focus();
                    return;
                }

                con.Open();
                SqlCommand check_UserIC = new SqlCommand("select count(*) from customer where([UserIC] = @UserIC)", con);
                check_UserIC.Parameters.AddWithValue("@UserIC", TxtIC.Text);
                int idExist = (int)check_UserIC.ExecuteScalar();
                con.Close();
                if (idExist > 0)
                {
                    LblIdexist.Text = "IC exists. Please enter a different user IC.";
                    TxtIC.Clear();
                }
                else if (Int32.Parse(TxtAge.Text) > 100 || Int32.Parse(TxtAge.Text) < 12)
                {
                    LblAgevalidation.Text = "Please enter a valid age";
                    TxtAge.Clear();
                }
                else
                {
                    id = TxtIC.Text;


                    Customer obj1 = new Customer(id, TxtName.Text, Int32.Parse(TxtAge.Text), TxtEmail.Text, gender, TxtPass.Text, TxtNumber.Text);
                    Service obj2 = new Service(serviceTypes, Price, priority, date);
                    FormCheckout checkout = new FormCheckout(obj2, obj1);
                    checkout.ShowDialog();
                }
            }
        }

        private void BtnRmvvirus_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Remove Virus";
        }

        private void BtnTrbsht_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Troubleshoot";
        }

        private void BtnScrnrep_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Screen Replacement";
        }

        private void BtnKybdrep_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Keyboard Replacement";
        }

        private void BtnBtryrep_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Battery Replacement";
        }

        private void BtnOsformat_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "OS Format";
        }

        private void BtnDatabkp_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Data Backup";
        }

        private void BtnWififix_Click_1(object sender, EventArgs e)
        {
            serviceTypes = "Internet Fix";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccCustomer_Load(object sender, EventArgs e)
        {

        }


        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radUrgent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblMatchpass_Click(object sender, EventArgs e)
        {

        }

        private void LblAgevalidation_Click(object sender, EventArgs e)
        {

        }

        private void LblIdexist_Click(object sender, EventArgs e)
        {

        }

        private void LblNotemail_Click(object sender, EventArgs e)
        {

        }
    }
}