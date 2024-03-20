using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFinalPlease
{
    internal class Utility
    {
        public static bool CheckNullAccount(Person p)
        {
            if (string.IsNullOrEmpty(p.GetName()) || string.IsNullOrEmpty(p.GetGender()) || string.IsNullOrEmpty(p.GetAddress()) || 
                string.IsNullOrEmpty(p.GetCCCD()) || string.IsNullOrEmpty(p.GetPhone()) || string.IsNullOrEmpty(p.GetEmail()) || p == null)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateName(Person p)
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
        public static bool ValidateCCCD(Person p)
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
        public static bool ValidatePhone(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    return false;
                }
            }
            if (!phone[0].Equals('0'))
            {
                return false;
            }
            if (phone.Length != 10)
            {
                return false;
            }
            return true;
        }
    }
}
