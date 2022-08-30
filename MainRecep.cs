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
    public partial class MainRecep : Form
    {
        public static int count = 0;
        public MainRecep()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainRecep_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccCustomer newCus = new CreateAccCustomer();
            newCus.ShowDialog();
            this.Close();
        }

        private void lblGreet_Click(object sender, EventArgs e)
        {
            lblGreet.Text = "Welcome back, " + LoginForm.SetValueForText2;
        }

        private void BtnUpdateRec_Click(object sender, EventArgs e)
        {
            UpdateProfileRecep update = new UpdateProfileRecep();
            this.Hide();
            update.ShowDialog();
            this.Close();
        }

        private void ButtonLogoutRec_Click(object sender, EventArgs e)
        {
            count = 3;
            ConfirmationLogout confirmation = new ConfirmationLogout();
            this.Hide();
            confirmation.ShowDialog();
            this.Close();
        }
    }
}
