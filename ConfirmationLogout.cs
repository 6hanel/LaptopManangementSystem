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
    public partial class ConfirmationLogout : Form
    {
        public ConfirmationLogout()
        {
            InitializeComponent();
        }

        private void ConfirmationLogout_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (MainTech.count == 4)
            {
                MainTech mainTech = new MainTech();
                this.Hide();
                mainTech.ShowDialog();
                this.Close();
            } else if (MainRecep.count == 3)
            {
                MainRecep mainRecep = new MainRecep();
                this.Hide();
                mainRecep.ShowDialog();
                this.Close();
            } else if (FormCustomerDashboard.count == 2)
            {
                FormCustomerDashboard formCustomer = new FormCustomerDashboard();
                this.Hide();
                formCustomer.ShowDialog();
                this.Close();
            } else if (MainAdmin.count == 1)
            {
                MainAdmin mainAdmin = new MainAdmin();
                this.Hide();
                mainAdmin.ShowDialog();
                this.Close();
            };
        }
    }
}
