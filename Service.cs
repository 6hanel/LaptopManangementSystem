using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    public class Service
    {
        //private int cusID;
        //private int invoiceID;
        private string serviceType;
        private double price;
        private string priority;
        private string date;

        public Service(string aService, double aPrice, string aPriority, string aDate)
        {

            serviceType = aService;
            price = aPrice;
            priority = aPriority;
            date = aDate;

        }

        public string ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Priority
        {
            get { return priority; }
            set
            { priority = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public string DisplayService()
        {
            return $"Service:\t\t{serviceType}\nPriority:\t\t{priority}\nCost:\tRM{price.ToString()}";
        }

    }
}
