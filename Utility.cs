using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFinalPlease
{
    internal class Utility
    {
        public static bool CheckNullInfo(Worker p)
        {
            if (string.IsNullOrEmpty(p.GetName()) || string.IsNullOrEmpty(p.GetGender()) || string.IsNullOrEmpty(p.GetAddress()) || 
                string.IsNullOrEmpty(p.GetCCCD()) || string.IsNullOrEmpty(p.GetPhone()) || string.IsNullOrEmpty(p.GetEmail()) ||
                p == null)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateName(Worker p)
        {
            for (int i = 0; i < p.GetName().Length; i++)
            {
                if (char.IsDigit(p.GetName()[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateCCCD(Worker p)
        {
            for (int i = 0; i < p.GetCCCD().Length; i++)
            {
                if (!char.IsDigit(p.GetCCCD()[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidatePhone(Worker p)
        {
            for (int i = 0; i < p.GetPhone().Length; i++)
            {
                if (!char.IsDigit(p.GetPhone()[i]))
                {
                    return false;
                }
            }
            if (!p.GetPhone()[0].Equals('0'))
            {
                return false;
            }
            if (p.GetPhone().Length != 10)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateEmail(Worker p)
        {
            if (!p.GetEmail().Contains("@"))
            {
                return false;
            }
            string[] str = p.GetEmail().Split('@');
            string mail_name = str[0].ToLower();
            string mail_domain = str[1].ToLower();
            string[] domain = new string[]
            {
                "gmail.com","yahoo.com","outlook.com","hotmail.com"
                ,"aol.com","icloud.com","zoho.com","mail.com","gmx.com"
            };
            bool domain_check = false;
            foreach (string domain_name in domain)
            {
                if (mail_domain.Contains(domain_name))
                {
                    domain_check = true;
                    break;
                }
            }
            if (!domain_check)
            {
                return false;
            }
            string special_character = " :,.;\"'/[]{}()<>";
            foreach (var check in special_character)
            {
                if (mail_name.Contains(check))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateBirth(Worker p)
        {
            int age = DateTime.Now.Year - p.GetBirth().Year;
            if (age < 17)
            {
                return false;
            }
            return true;
        }
        public static bool CheckAccountInfo(Worker p)
        {
            if (!CheckNullInfo(p))
            {
                MessageBox.Show("Please fill in all information!");
                return false;
            }
            if (!ValidateName(p))
            {
                MessageBox.Show("Invalid Name!\n Please fill in a proper name (Names do not contain numbers)");
                return false;
            }
            if (!ValidateCCCD(p))
            {
                MessageBox.Show("Invalid CCCD!\n Please fill in a proper CCCD (CCCDs only contain numbers)");
                return false;
            }
            if (!ValidatePhone(p))
            {
                MessageBox.Show("Invalid phone number!\n Please fill in a proper phone number (0xx-xxxx-xxx)");
                return false;
            }
            if (!ValidateBirth(p))
            {
                MessageBox.Show("Invalid age!\n Please fill in a proper date of birth (Must be over 17 years old)");
                return false;
            }
            if (!ValidateEmail(p))
            {
                MessageBox.Show("Invalid Email!\n Please fill in a proper email (xxx@xxx.com)");
                return false;
            }
            return true;
        }
    }
}
