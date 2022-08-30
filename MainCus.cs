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
    
    public partial class FormCustomerDashboard : Form
    {
        public static int count = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public FormCustomerDashboard()
        {
            InitializeComponent();
        }

        private void MainCus_Load(object sender, EventArgs e)
        {
            lblGreet.Text = "Welcome back, " + LoginForm.SetValueForText2;
        }

        private void lblGreet_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdateCus_Click(object sender, EventArgs e)
        {
            UpdateProfileCustomer update = new UpdateProfileCustomer();
            this.Hide();
            update.ShowDialog();
            this.Close();
        }

        private void BtnLogoutCus_Click(object sender, EventArgs e)
        {
            count = 2;
            this.Hide();
            ConfirmationLogout cl = new ConfirmationLogout();
            cl.ShowDialog();
            this.Close();
        }

        private void btnChangeServ_Click(object sender, EventArgs e)
        {
            SqlCommand sql2 = new SqlCommand("Select receiptid, Orderdate, CustomerID, pricetotal, serviceclass from Receipt where CustomerID = '" + Name + "'", con);

            FormChangeService frmchgservc = new FormChangeService();
            this.Hide();
            frmchgservc.ShowDialog();
            this.Show();
        }

        private void btnReqedService_Click(object sender, EventArgs e)
        {
            FormPurchasesList FrmPurchaseDisplay = new FormPurchasesList();
            this.Hide();
            FrmPurchaseDisplay.ShowDialog();
            this.Show();
        }

        private void btnPendingPay_Click(object sender, EventArgs e)
        {
            FormPaymentPending frmpaymentpend = new FormPaymentPending();
            this.Hide();
            frmpaymentpend.ShowDialog();
            this.Show();
        }
    }
}
