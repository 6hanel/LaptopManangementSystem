using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GroupAssignment
{
    internal class ReceiptDetail
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        private string receiptid, orderdate, customerid, pricetotal, serviceclass;

        public string ReceiptID { get => receiptid; set => receiptid = value; }
        public string OrderDate { get => orderdate; set => orderdate = value; }
        public string CustomerID { get => customerid; set => customerid = value; }
        public string PriceTotal { get => pricetotal; set => pricetotal = value; }
        public string ServiceClass { get => serviceclass; set => serviceclass = value; }
        public ReceiptDetail(string receiptid, string orderdate, string customerid, string pricetotal, string serviceclass)
        {
            this.ReceiptID = receiptid;
            this.OrderDate = orderdate;
            this.CustomerID = customerid;
            this.PriceTotal = pricetotal;
            this.ServiceClass = serviceclass;
        }
        public void newReceiptDetails()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into ReceiptDetail(ReceiptID, OrderDate, CustomerID, PriceTotal, ServiceClass)values(@ReceiptID,@OrderDate,@CustomerID,@PriceTotal, @ServiceClass)", con);
            cmd.Parameters.AddWithValue("@ReceiptID", ReceiptID);
            cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@DPriceTotal", PriceTotal);
            cmd.Parameters.AddWithValue("@ServiceClass", ServiceClass);
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}
