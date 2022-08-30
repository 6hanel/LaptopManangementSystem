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
    
    public partial class MainAdmin : Form
    {
        public static int count = 0;
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void BtnTech_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccTechnician CT = new CreateAccTechnician();
            CT.ShowDialog();
            Close();
        }

        private void BtnRecep_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccReception cr = new CreateAccReception();
            cr.ShowDialog();
            this.Close();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceReport sr = new ServiceReport();
            sr.ShowDialog();
            this.Close();
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalIncome ti = new TotalIncome();
            ti.ShowDialog();
            this.Close();
        }

        private void BtnLogoutAdmin_Click(object sender, EventArgs e)
        {
            count = 1;
            this.Hide();
            ConfirmationLogout cl = new ConfirmationLogout();
            cl.ShowDialog();
            this.Close();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lblGreet_Click(object sender, EventArgs e)
        {
            lblGreet.Text = "Welcome back, " + LoginForm.SetValueForText2;
        }
    }
}
