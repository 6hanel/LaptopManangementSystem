using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace GroupAssignment
{
    class User
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["groupassignment"].ToString());
        private string ic, name, email, password,repepass, gender, phone, role ;
        private int age;

        public string IC
        {
            get { return ic; }
            set { ic = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string RepePass
        {
            get { return repepass; }
            set { repepass = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public User(string IC,string Name, int Age, string Gender, string Pass, string Email, string Number,string Role)
        {
            this.name = Name;
            this.ic = IC;
            this.age = Age;
            this.gender = Gender;
            this.password = Pass;
            this.email = Email;
            this.phone = Number;
            this.role = Role;
        }

        public User(string email)
        {
            this.email = Email;
        }

        public void RegisterUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Userdetail(Useric,name,email,password,age,gender,phonenumber,usertype) values(@Useric,@name,@email,@password,@age,@gender,@phonenumber,@usertype)", con);
            SqlCommand cmd2 = new SqlCommand("insert into Technician(Useric,name,email,password,age,gender,phonenumber) values (@Useric,@name,@email,@password,@age,@gender,@phonenumber)", con);
            SqlCommand cmd3 = new SqlCommand("insert into Receptionist(Useric,name,email,password,age,gender,phonenumber) values (@Useric,@name,@email,@password,@age,@gender,@phonenumber)", con);
            SqlCommand cmd4 = new SqlCommand("insert into Customer(name,email,password,age,gender,phonenumber) values (@name,@email,@password,@age,@gender,@phonenumber)", con);
            cmd.Parameters.AddWithValue("@Useric", IC);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@phonenumber", Phone);
            cmd.Parameters.AddWithValue("@usertype", Role);
            cmd.ExecuteNonQuery();
            if (Role == "Technician")
            {
                cmd2.Parameters.AddWithValue("@Useric", IC);
                cmd2.Parameters.AddWithValue("@name", Name);
                cmd2.Parameters.AddWithValue("@email", Email);
                cmd2.Parameters.AddWithValue("@password", Password);
                cmd2.Parameters.AddWithValue("@age", Age);
                cmd2.Parameters.AddWithValue("@gender", Gender);
                cmd2.Parameters.AddWithValue("@phonenumber", Phone);
                cmd2.ExecuteNonQuery();
            }
            else if (Role == "Receptionist")
            {
                cmd3.Parameters.AddWithValue("@Useric", IC);
                cmd3.Parameters.AddWithValue("@name", Name);
                cmd3.Parameters.AddWithValue("@email", Email);
                cmd3.Parameters.AddWithValue("@Password", Password);
                cmd3.Parameters.AddWithValue("@age", Age);
                cmd3.Parameters.AddWithValue("@gender", Gender);
                cmd3.Parameters.AddWithValue("@phonenumber", Phone);
                cmd3.ExecuteNonQuery();
            }
            else if (Role == "Customer")
            {
                cmd3.Parameters.AddWithValue("@recepname", Name);
                cmd3.Parameters.AddWithValue("@email", Email);
                cmd3.Parameters.AddWithValue("@Password", Password);
                cmd3.Parameters.AddWithValue("@age", Age);
                cmd3.Parameters.AddWithValue("@gender", Gender);
                cmd3.Parameters.AddWithValue("@phonenumber", Phone);
                cmd3.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
