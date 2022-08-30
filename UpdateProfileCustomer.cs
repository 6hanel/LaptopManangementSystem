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
    public partial class UpdateProfileCustomer : Form
    {
        SqlConnection sqlCus = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        private SqlCommand cmdCus;
        public UpdateProfileCustomer()
        {
            InitializeComponent();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            Binding();
        }

        public void Binding()
        {
            sqlCus.Open();
            string IC = LoginForm.SetValueForText1;
            SqlCommand sql1 = new SqlCommand("Select Name, Email, password, age, phonenumber, UserIC, gender from Userdetail where UserIC = '" + IC + "'", sqlCus);
            SqlDataReader dataReader = sql1.ExecuteReader();
            while (dataReader.Read())
            {
                TxtOldName.Text = dataReader.GetValue(0).ToString();
                TxtOldAge.Text = dataReader.GetValue(3).ToString();
                TxtOldPass.Text = dataReader.GetValue(2).ToString();
                TxtOldEmail.Text = dataReader.GetValue(1).ToString();
                TxtOldNum.Text = dataReader.GetValue(4).ToString();
                TxtOldGender.Text = dataReader.GetValue(6).ToString();
                TxtOldIC.Text = dataReader.GetValue(5).ToString();
            }
            sqlCus.Close();
        }

        private void BtnRFContinueRec_Click(object sender, EventArgs e)
        {
            sqlCus.Open();
            string IC = LoginForm.SetValueForText1;
            cmdCus = new SqlCommand("UPDATE Userdetail SET Name=@a1, Email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlCus);
            cmdCus.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmdCus.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmdCus.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmdCus.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmdCus.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmdCus.ExecuteNonQuery(); cmdCus = new SqlCommand("UPDATE Customer SET name=@a1, email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlCus);
            cmdCus.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmdCus.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmdCus.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmdCus.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmdCus.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmdCus.ExecuteNonQuery();
            MessageBox.Show("Update Succesful. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            sqlCus.Close();
            Binding();
            this.Hide();
            FormCustomerDashboard mainCus = new FormCustomerDashboard();
            mainCus.ShowDialog();
            this.Close();
        }

        private void BtnRFCancelRec_Click(object sender, EventArgs e)
        {
            FormCustomerDashboard mainCus = new FormCustomerDashboard();
            this.Hide();
            mainCus.ShowDialog();
            this.Close();
        }
    }
}
