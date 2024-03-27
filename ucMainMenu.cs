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
    public partial class ucMainMenu : UserControl
    {
        //These event is used when turn off button clicked, to active specific function
        public event EventHandler turnOff;
        public event EventHandler logOut;
        //Store the user information passed from login
        private Account account;
        public ucMainMenu()
        {
            InitializeComponent();
        }
        public ucMainMenu(Account account)
        {
            InitializeComponent();
            this.account = account;
        }
       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

       

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của ucJobList
            //ucJobList newJobList = new ucJobList();

            // Thêm ucJobList mới vào Controls của Form
            //this.Controls.Add(newJobList);

            // Cài đặt vị trí và kích thước cho ucJobList mới
            //newJobList.Location = new Point(220, 0);
            //newJobList.Size = new Size(980, 800);

            // Hiển thị ucJobList mới
            //newJobList.Show();
            tabControl.SelectTab(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Execute another event which is passed in Form container
            logOut?.Invoke(this, EventArgs.Empty);
            //When loggout to loggin form then hide this uc
            this.Hide();
        }
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            //Thông báo message yes no turn off 
            turnOff?.Invoke(this, EventArgs.Empty);
        }

        private void ucMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkerList_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
         tabControl.SelectTab(1);

        }

        private void btnOngoingWork_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
            tabControl.SelectTab(2);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
            tabControl.SelectTab(3);
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(4);
        }
    }
}
