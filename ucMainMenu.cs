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
        private AccountDao accountDao=new AccountDao();
        public ucMainMenu()
        {
            InitializeComponent();
        }
        public ucMainMenu(Account account)
        {
            InitializeComponent();
            this.account = account;
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
            //tabMainMenu.SelectTab(0);
            tabMainMenu.SelectedIndex = 0;
            
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
            tabMainMenu.SelectedIndex = 0;
            this.ucWorkerList1.ucMainMenu = this;
            
        }

        private void btnWorkerList_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
            tabMainMenu.SelectedIndex = 1;
            //ucWorkerList ucWorkerList = new ucWorkerList();
            //this.tpWorkerList. Controls.Add(ucWorkerList);
          

        }

        private void btnOngoingWork_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
            tabMainMenu.SelectedIndex = 2;
            //ucCreateJob ucCreateJob = new ucCreateJob();
            //this.tpOngoingWork.  Controls.Add( ucCreateJob);

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (!Utility.checkValidPersonal(account))
            {
                MessageBox.Show("You haven't had enough personal information to continue. Please fill this in Account setting");
                return;
            }
            tabMainMenu.SelectedIndex=3;
            //ucNotification ucNotification = new ucNotification();
            //this. tpNotification.Controls.Add(ucNotification);

        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            tabMainMenu.SelectedIndex=4;
            //ucAccount ucAccount = new ucAccount();
            //this. tpAccountSetting.Controls.Add(ucAccount);


        }
        private void ucJobList1_Load(object sender, EventArgs e)
        {
            ucAccount1.account = this.account;
        }

        
    }
}
