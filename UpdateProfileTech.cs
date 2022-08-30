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
    public partial class UpdateProfileTech : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        private SqlCommand cmd;
        public UpdateProfileTech()
        {
            InitializeComponent();
        }

        public void UpdateProfile_Load(object sender, EventArgs e)
        {
            Binding();
        }

        public void Binding()
        {
            sqlConnection.Open();
            string IC = LoginForm.SetValueForText1;
            SqlCommand sql1 = new SqlCommand("Select Name, Email, password, age, phonenumber, UserIC, gender from Userdetail where UserIC = '" + IC + "'", sqlConnection);
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
            sqlConnection.Close();
        }

        private void BtnRFContinueRec_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string IC = LoginForm.SetValueForText1;
            cmd = new SqlCommand("UPDATE Userdetail SET Name=@a1, Email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlConnection);
            cmd.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmd.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmd.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmd.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmd.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE Technician SET Name=@a1, Email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlConnection);
            cmd.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmd.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmd.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmd.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmd.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Succesfull. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            sqlConnection.Close();
            Binding();
            this.Hide();
            MainTech mainTech = new MainTech();
            mainTech.ShowDialog();
            this.Close();
        }

        private void BtnRFCancelRec_Click(object sender, EventArgs e)
        {
            MainTech mainTech = new MainTech();
            this.Hide();
            mainTech.ShowDialog();
            this.Close();
        }
    }
}
