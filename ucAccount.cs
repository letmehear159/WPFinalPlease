using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPFinalPlease
{
    public partial class ucAccount : UserControl
    {
        PersonDao personDao = new PersonDao();
        public Account account=new Account();
        private AccountDao accountDao = new AccountDao();
        WorkerDao workerDao = new WorkerDao();
        public ucAccount()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime yourAge = dtpBirthdate.Value;
            string gender = txtGender.Text;
            string cccd = txtCCCD.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            Person person = new Person(name, cccd, address, gender, phone, email, yourAge);
            if (!Utility.CheckAccountInfoCustomer(person))
            {
                return;
            }
            //Tạo dữ liệu người dùng trong worker
            if (account.getCCCD() == null)
            {
                personDao.addPersonalInformationCustome(person);
            }
            else
            {
                personDao.adjustInformation(person, account.getCCCD());
            }
            setCCCCFromUserToAccount();

        }
        public void setCCCCFromUserToAccount()
        {
            string cccd = txtCCCD.Text;
            string username = account.getUserName();
            accountDao.addCCCDToAccount(username, cccd);
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string occupation = drdOccupation.SelectedItem.ToString();
            string certificate = drdCertificate.SelectedItem.ToString();
            int experience = int.Parse(txtExperience.Text);
            float expectedSalary = float.Parse(txtSalary.Text);
            string skill=txtSkill.Text;
            string bio=tbBio.Text;
            Worker worker = new Worker(occupation, experience, expectedSalary, certificate,skill,bio);
            workerDao.changeFromUserToWorker(worker, account.getCCCD());
        }

        private void ucAccount_Load_1(object sender, EventArgs e)
        {
            if (account.getCCCD() == null)
            {
                return;
            }
            else
            {
                if (account.getRole() == "User")
                {
                    drdOccupation.SelectedIndex = 0;
                    drdCertificate.SelectedIndex = 0;
                }
                else
                {
                    Worker worker = workerDao.getInformationFromCCCD(account.getCCCD());
                    Utility.fillInformationAccountForWorker(worker, this);
                }
                Person person = personDao.getInformationFromCCCD(account.getCCCD());
                Utility.fillInformationAccountForUser(person, this);
            }
            
        }
    }
}
