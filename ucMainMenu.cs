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
    public partial class ucMainMenu : UserControl
    {
        public event EventHandler turnOff;
        public event EventHandler logOut;
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
            ucJobList newJobList = new ucJobList();

            // Thêm ucJobList mới vào Controls của Form
            this.Controls.Add(newJobList);

            // Cài đặt vị trí và kích thước cho ucJobList mới
            newJobList.Location = new Point(220, 0);
            newJobList.Size = new Size(980, 800);

            // Hiển thị ucJobList mới
            newJobList.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logOut?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            //Thông báo message yes no turn off 
            turnOff?.Invoke(this, EventArgs.Empty);
        }
    }
}
