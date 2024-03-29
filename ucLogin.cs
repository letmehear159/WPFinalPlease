﻿using System;
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
        private Account account;
        public event EventHandler LoginHidden;
        AccountDao accountDao =new AccountDao();
        DBconnection dBconnection = new DBconnection();
        public ucLogin()
        {
            InitializeComponent();
        }
        public Account GetAccount()
        {
            return account;
        }
        //Phương thức để ẩn UserControl và thông báo cho Form
        public void HideUserControl()
        {
            // Execute for switching to menu form
            LoginHidden?.Invoke(this, EventArgs.Empty);
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
                //This function is used to refresh data.
               accountDao.rememberMe(username, password,checkBRemember);
                //Hide the red error message 
                if (lblErrorMessLG.Visible)  
                {
                    lblErrorMessLG.Visible=false;
                }
                //Save the data to pass it to ucMainMenu
                this.account = getAccount;
                //
                HideUserControl();
                //Hide uclogin form
                //this.Hide();
            }
            // If account is null it means the user loggin wrong and show error message.
            else
            {
                lblErrorMessLG.Text = "Failed"; //
                lblErrorMessLG.Visible = true;
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
        /// <summary>
        /// Sign up 
        /// </summary>
        private void btnSignupSU_Click(object sender, EventArgs e)
        {
            string username=txtUsernameSU.Text;
            string password=txtPasswordSU.Text; 
            string retypePassword=txtCfPasswordSU.Text;
            string email=txtEmailSU.Text;
            //Trường hợp không trùng password thì không tiếp tục
            if (!retypePassword.Equals(password))
            {
                lblErrorMessSU.Text = "Password not matches";
                lblErrorMessSU.Visible = true;
                return;
            }
            //Kiểm tra mấy thằng này có thằng này null không có thì hủy tạo acc
            //Kiểm tra luôn retypepass 
            Account newAccount = new Account(username, password, email);
            //Nếu add thành công thì chuyển còn không thì hiện lỗi ở else thêm chú thích ở lblErrorText cho rõ vào 
            if (accountDao.addAccount(newAccount))
            {
                tabctrlLogin.SelectedIndex = 2;
                if (lblErrorMessSU.Visible)
                {
                    lblErrorMessSU.Visible=false;
                }
            }
            else
            {
                lblErrorMessSU.Text = "Error to create your account!";
                lblErrorMessSU.Visible = true;
            }

        }

        private void btnBackFP1_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 0;
        }

        private void btnBackFP2_Click(object sender, EventArgs e)
        {
            tabctrlLogin.SelectedIndex = 3;
        }
        /// <summary>
        /// 
        /// </summary>
        private void btnNextFP2_Click(object sender, EventArgs e)
        {
            // Mật không không khớp 
            string password=txtPasswordFP.Text;
            string cfPassword=txtCfPasswordFP.Text;
            if (!password.Equals(cfPassword))
            {
                lblErrorMessPW.Text = "Failed";
                lblErrorMessPW.Visible = true;
                return;
                //inform
            }
            //Trường hợp chạy sql cập nhật data mới không thành công 
            if (!accountDao.resetPassword(txtUsernameFP.Text, password))
            {
                lblErrorMessPW.Text = "Failed";
                lblErrorMessPW.Visible = true;
                return;
            }
            //Switch to next tab page
            tabctrlLogin.SelectedIndex = 5;
            if (lblErrorMessPW.Visible)
                lblErrorMessPW.Visible = false;
        }

        private void btnNextFP1_Click(object sender, EventArgs e)
        {
            string username= txtUsernameFP.Text;
            string email= txtEmailFP.Text;
            //Chạy trong database sql xem username và email có chuẩn với account cụ thể nào chứa
            if(accountDao.checkForgotAccount(username, email))
            {
                //Thêm thông báo thành công 
                tabctrlLogin.SelectedIndex = 4;
                if (lblErrorMessFP.Visible)
                {
                    lblErrorMessFP.Visible = false;
                }
            }
            else
            {
                //Thông báo thất bại
                lblErrorMessFP.Text = "Failed";
                lblErrorMessFP.Visible = true;
                return;
            }
            

        }

        private void btnFinishFP_Click(object sender, EventArgs e)
        {
            // After finish forgot password then clear all text in FP textbox
            txtCfPasswordFP.Text = string.Empty;
            txtUsernameFP.Text = string.Empty;
            txtEmailFP.Text = string.Empty;
            txtPasswordFP.Text = string.Empty;
            tabctrlLogin.SelectedIndex = 1;
        }

        private void linkFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabctrlLogin.SelectedIndex = 3;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
