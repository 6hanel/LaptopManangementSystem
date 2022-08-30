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
    public partial class CompletionDate : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        public CompletionDate()
        {
            InitializeComponent();
        }

        private void CompletionDate_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            sqlConnection.Open();
            SqlDataAdapter servicelist = new SqlDataAdapter("Select * From Progress", sqlConnection);
            DataTable dt = new DataTable();
            servicelist.Fill(dt);
            dtCollectionDate.DataSource = dt;
            sqlConnection.Close();
        }

        private void BtnLCReturnMain_Click(object sender, EventArgs e)
        {
            MainTech mainTech = new MainTech();
            this.Hide();
            mainTech.ShowDialog();
            this.Close();
        }

        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            AddCompletionDate addCompletionDate = new AddCompletionDate();
            this.Hide();
            addCompletionDate.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagridServiceRequested_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlConnection.Open();
                int IC = Convert.ToInt32(dtCollectionDate.Rows[e.RowIndex].Cells["UserIC"].FormattedValue.ToString());
                SqlCommand sqlCommand = new SqlCommand("Delete Progress where UserIC = '" + IC + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                BindGrid();
            }

        }

        private void dtCollectionDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
