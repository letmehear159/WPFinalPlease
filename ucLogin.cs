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
    public partial class ucLogin : UserControl
    {
        AccountDao accountDao=new AccountDao();
        DBconnection dBconnection = new DBconnection();
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thêm check account với password ở đây xem có null hay không 
            string username = txtUsernameLG.Text;
            string password = txtPasswordLG.Text;
            Account getAccount = accountDao.getAccountFromLogin(username, password);
            //Check getAccount nếu không null có nghĩa là có tài khoản
            //Chuyển đến phần menu
            if (getAccount != null)
            {
               accountDao.rememberMe(username, password,checkBRemember);
                FMenu fMenu = new FMenu(getAccount);
                fMenu.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }


        private void ucLogin_Load(object sender, EventArgs e)
        {
            //If this checkbox is checked then find the value in remember table to get the value
            //If it has value then fill that value on user/password textbox.
            if(checkBRemember.Checked)
            {
                Account newAccount = accountDao.getInformationFromRemem();
                if (newAccount != null)
                {
                    txtUsernameLG.Text=newAccount.getUserName();
                    txtPasswordLG.Text=newAccount.getPassword();
                }
            }
        }

        private void btnSignupLG_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 1;

        }

        private void btnBackSU_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 0;
        }

        private void btnFinishSU_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 0;
        }

        private void btnSignupSU_Click(object sender, EventArgs e)
        {

        }

        private void btnBackFP1_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 0;
        }

        private void btnBackFP2_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 3;
        }

        private void btnNextFP2_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 5;
        }

        private void btnNextFP1_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 4;
        }

        private void btnFinishFP_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 1;
        }
    }
}
