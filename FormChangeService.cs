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
    public partial class FormChangeService : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());

        private readonly SelectedServices _selectedServices;

        public static string SetValueForText1 = "";

        public static string UserIC = "";
        public static string ServiceName = "";
        public static string ServicePrice = "";
        public static string Duration = "";
        public static string DurationPrice = "";

        public FormChangeService()
        {
            InitializeComponent();
            _selectedServices = new SelectedServices();
            SqlCommand sql1 = new SqlCommand("Select receiptid, Orderdate, UserIC, pricetotal, serviceclass from Receipt where UserIC = '" + Name + "'", con);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormCustomerDashboard formCustomerDashboard = new FormCustomerDashboard();
            this.Hide();
            formCustomerDashboard.ShowDialog();
            this.Close();
        }

        private void txtNorU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSrvcType_TextChanged(object sender, EventArgs e)
        {

        }

        public class SelectedServices
        {
            public string Service { get; set; }
            public string NormalOrUrgent { get; set; }
            public string ServicePrice { get; set; }
            public string DurationPrice { get; set; }
            public string TotalPrice { get; set; }

            public string Format() => $"{Service} {ServicePrice} {NormalOrUrgent} {DurationPrice} {TotalPrice}";


        }
        public string GetNorUPrice(string sNorU)
        {
            string sNorUPrice = "0.00";

            if (sNorU == "Normal")
                sNorUPrice = "15.00";

            if (sNorU == "Urgent")
                sNorUPrice = "30.00";

            return sNorUPrice;
        }
        public string GetTypePrice(string sType)
        {
            string sTypePrice = "0.00";

            if (sType == "Remove Virus")
                sTypePrice = "10.00";

            if (sType == "Troubleshoot")
                sTypePrice = "20.00";

            if (sType == "Screen Replace")
                sTypePrice = "30.00";

            if (sType == "Keyboard Replace")
                sTypePrice = "40.00";

            if (sType == "Battery Replace")
                sTypePrice = "50.00";

            if (sType == "OS Format")
                sTypePrice = "60.00";

            if (sType == "Data Backup")
                sTypePrice = "70.00";

            if (sType == "Wifi Fix")
                sTypePrice = "80.00";

            return sTypePrice;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetTotalPrice()
        {
            double num1 = 0;
            double num2 = 0;
            double.TryParse(txtServicePrice.Text, out num1);
            double.TryParse(txtDurationPrice.Text, out num2);

            txtTotal.Text = (num1 + num2).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void FormChangeService_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveVirus_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnRemoveVirus.Text;
            btnRemoveVirus.Tag = "Remove Virus";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnTroubleshoot_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnTroubleshoot.Text;
            btnTroubleshoot.Tag = "Troubleshoot";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnSrcReplace_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnSrcReplace.Text;
            btnSrcReplace.Tag = "Screen Replace";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnKbReplace_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnKbReplace.Text;
            btnKbReplace.Tag = "Keyboard Replace";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnBtryReplace_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnBtryReplace.Text;
            btnBtryReplace.Tag = "Battery Replace";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnOSFormat_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnOSFormat.Text;
            btnOSFormat.Tag = "OS Format";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnDTbackup_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnDTbackup.Text;
            btnDTbackup.Tag = "Data Backup";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnWifiFix_Click_1(object sender, EventArgs e)
        {
            txtSrvcType.Text = btnWifiFix.Text;
            btnWifiFix.Tag = "Wifi Fix";

            if (_selectedServices.Service != null)
                _selectedServices.ServicePrice = GetTypePrice(_selectedServices.Service);
            txtServicePrice.Text = _selectedServices.ServicePrice;

            var button = (Button)sender;
            _selectedServices.Service = button.Tag.ToString();
            _selectedServices.TotalPrice = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            txtNorU.Text = btnNormal.Text;
            btnNormal.Tag = "Normal";

            if (_selectedServices.NormalOrUrgent != null)
                _selectedServices.DurationPrice = GetNorUPrice(_selectedServices.NormalOrUrgent);
            txtDurationPrice.Text = _selectedServices.DurationPrice;

            var button = (Button)sender;
            _selectedServices.NormalOrUrgent = button.Tag.ToString();

            GetTotalPrice();
        }

        private void btnUrgent_Click_1(object sender, EventArgs e)
        {
            txtNorU.Text = btnUrgent.Text;
            btnUrgent.Tag = "Urgent";

            if (_selectedServices.NormalOrUrgent != null)
                _selectedServices.DurationPrice = GetNorUPrice(_selectedServices.NormalOrUrgent);
            txtDurationPrice.Text = _selectedServices.DurationPrice;

            var button = (Button)sender;
            _selectedServices.NormalOrUrgent = button.Tag.ToString();

            GetTotalPrice();
        }

        private void txtNorU_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = txtTotal.Text;
            ServiceName = txtSrvcType.Text;
            ServicePrice = txtServicePrice.Text;
            Duration = txtNorU.Text;
            DurationPrice = txtDurationPrice.Text;


            Services serv = new Services(ServiceName, ServicePrice, Duration, DurationPrice);

            serv.newService();

            FormCheckout frmcheckout = new FormCheckout();
            this.Hide();
            frmcheckout.ShowDialog();
            this.Show();
        }
    }
}
