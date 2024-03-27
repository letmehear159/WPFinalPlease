using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFinalPlease
{
    internal class Person
    {
        protected string name;
        protected string cccd;
        protected string address;
        protected string gender;
        protected string phone;
        protected string email;
        protected DateTime birth;
        public Person(string name, string cccd, string address, string gender, string phone, string email, DateTime birth)
        {
            this.name = name;
            this.cccd = cccd;
            this.address = address;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.birth = birth;
        }

        // Get methods for each protected property
        public string GetName()
        {
            return name;
        }

        public string GetCCCD()
        {
            return cccd;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetGender()
        {
            return gender;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }

        public DateTime GetBirth()
        {
            return birth;
        }
    }
}
