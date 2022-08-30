using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    public class Customer
    {
        private string cusID;
        private string name;
        private string email;
        private string password;
        private int age;
        private string gender;
        private string phone;

        public string CusID
        {
            get { return cusID; }
            set { cusID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Customer(string anID, string aName, int anAge, string aEmail, string aGender, string aPassword, string aPhone)
        {
            cusID = anID;
            name = aName;
            age = anAge;
            email = aEmail;
            gender = aGender;
            password = aPassword;
            phone = aPhone;
        }

    }
}
