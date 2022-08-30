using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Technician
    {
        private string userIC;
        private string password;
        private string name;
        private string email;
        private string age;
        private string gender;
        private string phonenumber;

        public Technician(string techIC, string techName, string techEmail, string techPass, string techAge, string techGender, string techPhone)
        {
        this.UserIC = techIC;
        this.password = techPass;
        this.name = techName;
        this.email = techEmail;
        this.age = techAge;
        this.gender = techGender;
        this.phonenumber = techPhone;
        }
        public Technician(string techIC, string techPass)
        {
            this.UserIC = techIC;
            this.password = techPass;
        }
        public string UserIC
        {
            get { return userIC; }
            set { userIC = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        public string Phonenumber
        {
            get { return Phonenumber; }
            set { Gender = value; }
        }

    }
}
