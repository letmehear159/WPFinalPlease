using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFinalPlease
{
    internal class Utility
    {
         static WorkerDao  workerDao=new WorkerDao();
        public static bool checkValidPersonal(Account account)
        {
            if (string.IsNullOrEmpty((account.getCCCD()))){
                return false; 
            }
            return true;
        }
        public static bool CheckNullInfoCustomer(Person p)
        {
            if (string.IsNullOrEmpty(p.GetName()) || string.IsNullOrEmpty(p.GetGender()) || string.IsNullOrEmpty(p.GetAddress()) || 
                string.IsNullOrEmpty(p.GetCCCD()) || string.IsNullOrEmpty(p.GetPhone()) || string.IsNullOrEmpty(p.GetEmail()) ||
                p == null)
            {
                return false;
            }
            return true;
        }
        public static bool CheckNullInfoWorker(Worker p)
        {
            if (!CheckAccountInfoCustomer(p))
            {
                return false;
            }
            if (string.IsNullOrEmpty(p.GetOccupation()) || string.IsNullOrEmpty(p.GetCertificate()) || p.GetExperiencedYear() < 0 ||
                p.GetExpectedPrice() < 0)
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
        public static bool ValidatePhone(Person p)
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
        public static bool ValidateEmail(Person p)
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
        public static void fillInformationAccountForWorker(Worker worker,ucAccount ucAccount)
        {
            ucAccount.drdOccupation.SelectedItem = worker.GetOccupation();
            ucAccount.drdCertificate.SelectedItem = worker.GetCertificate();
            ucAccount.txtExperience.Text=worker.GetExperiencedYear().ToString();
            ucAccount.txtSalary.Text=worker.GetExpectedPrice().ToString();
            ucAccount.txtSkill.Text=worker.GetSkills().ToString();   
            ucAccount.tbBio.Text=worker.GetBio();
        }
        public static void fillInformationAccountForUser(Person p,ucAccount ucAccount)
        {
            ucAccount.txtAddress.Text=p.GetAddress();
            ucAccount.txtCCCD.Text=p.GetCCCD();
            ucAccount.txtEmail.Text=p.GetEmail();
            ucAccount.txtGender.Text=p.GetGender();
            ucAccount.txtName.Text=p.GetName();
            ucAccount.txtPhone.Text=p.GetPhone();
            ucAccount.dtpBirthdate.Value = p.GetBirth();
        }
        public static void fillInWorkerDetail(Worker worker,ucWorkerDetail ucWorker)
        {
            ucWorker.lblName.Text=worker.GetName();
            ucWorker.lblAddress.Text=worker.GetAddress();
            ucWorker.lblAge.Text = (DateTime.Now.Year - worker.GetBirth().Year).ToString();
            ucWorker.lblCCCD.Text=worker.GetCCCD();
            ucWorker.lblCertificate.Text=worker.GetCertificate();
            ucWorker.lblEmail.Text=worker.GetEmail();
            ucWorker.lblExperience.Text=worker.GetExperiencedYear().ToString();
            ucWorker.lblGender.Text=worker.GetGender();
            ucWorker.lblOccupation.Text=worker.GetOccupation();
            ucWorker.lblPhone.Text=worker.GetPhone();
            ucWorker.lblReview.Text = worker.GetReviewAmount().ToString();
            ucWorker.lblSkills.Text=worker.GetSkills();
            ucWorker.lblStar.Text = worker.GetStarRate().ToString() + "/5";
            ucWorker.lblExpectedPrice.Text=worker.GetExpectedPrice().ToString();  
            ucWorker.lblIntroduce.Text=worker.GetBio().ToString();
            DataTable workHistoryList = workerDao.getWorkingHistory(worker.GetCCCD());
            foreach (DataRow row in workHistoryList.Rows)
            {
                ucWorkHistory uCWorkHistory = new ucWorkHistory();
                uCWorkHistory.receiveInfo(row);
                uCWorkHistory.Margin = new Padding(3);
                ucWorker.flowPanelWorkHistory.Controls.Add(uCWorkHistory);
            }


        }
        public static bool ValidateBirth(Person p)
        {
            int age = DateTime.Now.Year - p.GetBirth().Year;
            if (age < 17)
            {
                return false;
            }
            return true;
        }
        public static bool CheckAccountInfoCustomer(Person p)
        {
            if (!CheckNullInfoCustomer(p))
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
