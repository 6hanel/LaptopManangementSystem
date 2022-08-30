using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GroupAssignment
{
    class Services
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FixComp"].ToString());
        private string Servicetype, servicePrice, duraTion, durationprice;

        public string ServiceType { get => Servicetype; set => Servicetype = value; }
        public string Serviceprice { get => servicePrice; set => servicePrice = value; }
        public string duration { get => duraTion; set => duraTion = value; }
        public string Durationprice { get => durationprice; set => durationprice = value; }
        public Services(string ServiceType, string Serviceprice, string duration, string Durationprice)
        {
            this.Servicetype = ServiceType;
            this.servicePrice = Serviceprice;
            this.duraTion = duration;
            this.durationprice = Durationprice;
        }
        public void newService()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Services(ServiceType, Servicesprice, Duration, Durationprice)values(@ServiceType,@ServicesPrice,@Duration,@Durationprice)", con);
            cmd.Parameters.AddWithValue("@ServiceType", ServiceType);
            cmd.Parameters.AddWithValue("@ServicesPrice", Serviceprice);
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Durationprice", Durationprice);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
