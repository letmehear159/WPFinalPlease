using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFinalPlease
{
    public partial class ucAccount : UserControl
    {
        public ucAccount()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            DateTime yourAge = dtpBirthdate.Value;
            string gender=txtGender.Text;
            string cccd = txtCCCD.Text;
            string address=txtAddress.Text;
            string phone=txtPhone.Text;
            string email=txtEmail.Text;
            Person person = new Person(name, cccd, address, gender, phone, email,yourAge);


        }
    }
}
