using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFinalPlease
{
  public   class Account
    {
        private string userName;
        private string password;
        private string role;
        private string CCCD;
        private string email;
        public Account() { }
        public Account(string userName, string password, string role, string cCCD,string email)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
            CCCD = cCCD;
            this.email = email;
        }
          
        public Account(string userName,string password) : this(userName, password, null, null,null) 
        {
        }
        public Account(string userName, string password,string email) : this(userName, password, null, null, email)
        {
        }
        public string getUserName()
        {
            return userName;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
        public string getCCCD()
        {
            return CCCD;
        }
        public string getEmail()
        {
            return email;
        }


    }
}
