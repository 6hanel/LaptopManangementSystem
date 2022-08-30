using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAssignment
{
    public partial class MainTech : Form
    {
        public static int count = 0;
        public MainTech()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainTech_Load(object sender, EventArgs e)
        {
            LblGreet.Text = "Welcome back, " + LoginForm.SetValueForText2;
        }

        private void BtnDescript_Click(object sender, EventArgs e)
        {
            CompletionDate completionDate = new CompletionDate();
            this.Hide(); //hide maintech
            completionDate.ShowDialog(); //show servicerequested form
            this.Close(); //close maintech
        }

        private void BtnUpdateTech_Click(object sender, EventArgs e)
        {
            UpdateProfileTech updateProfile = new UpdateProfileTech();
            this.Hide();
            updateProfile.ShowDialog();
            this.Close();
        }

        private void BtnLogoutTech_Click(object sender, EventArgs e)
        {
            count = 4;
            ConfirmationLogout confirmation = new ConfirmationLogout();
            this.Hide(); 
            confirmation.ShowDialog(); 
            this.Close(); 
        }

        private void BtnRequestedTech_Click(object sender, EventArgs e)
        {
            ServiceRequest serviceRequest = new ServiceRequest();
            this.Hide(); //hide maintech
            serviceRequest.ShowDialog(); //show servicerequested form
            this.Close(); //close maintech
        }
    }
}
