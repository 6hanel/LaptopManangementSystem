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
    public partial class UpdateProfileRecep : Form
    {
        SqlConnection sqlRecep = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        private SqlCommand cmdRecep;
        public UpdateProfileRecep()
        {
            InitializeComponent();
        }

        private void UpdateProfileRecep_Load(object sender, EventArgs e)
        {
            Binding();
        }

        public void Binding()
        {
            sqlRecep.Open();
            string IC = LoginForm.SetValueForText1;
            SqlCommand sql1 = new SqlCommand("Select Name, Email, password, age, phonenumber, UserIC, gender from Userdetail where UserIC = '" + IC + "'", sqlRecep);
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
            sqlRecep.Close();
        }

        private void BtnRFContinueRec_Click(object sender, EventArgs e)
        {
            sqlRecep.Open();
            string IC = LoginForm.SetValueForText1;
            cmdRecep = new SqlCommand("UPDATE Userdetail SET Name=@a1, Email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlRecep);
            cmdRecep.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmdRecep.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmdRecep.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmdRecep.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmdRecep.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmdRecep.ExecuteNonQuery();
            cmdRecep.ExecuteNonQuery(); cmdRecep = new SqlCommand("UPDATE Receptionist SET name=@a1, email=@a2, password=@a3, age=@a4, phonenumber=@a5 WHERE UserIC ='" + IC + "'", sqlRecep);
            cmdRecep.Parameters.AddWithValue("a1", TxtNewName.Text);
            cmdRecep.Parameters.AddWithValue("a2", TxtNewEmail.Text);
            cmdRecep.Parameters.AddWithValue("a3", TxtNewPass.Text);
            cmdRecep.Parameters.AddWithValue("a4", TxtNewAge.Text);
            cmdRecep.Parameters.AddWithValue("a5", TxtNewNum.Text);
            cmdRecep.ExecuteNonQuery();
            MessageBox.Show("Update Succesfull. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            sqlRecep.Close();
            Binding();
            this.Hide();
            MainRecep mainRecep = new MainRecep();
            mainRecep.ShowDialog();
            this.Close();
        }

        private void BtnRFCancelRec_Click(object sender, EventArgs e)
        {
            MainRecep mainRecep = new MainRecep();
            this.Hide();
            mainRecep.ShowDialog();
            this.Close();
        }
    }
}
