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
    public partial class Form2 : Form
    {
        AccountDao accountDao = new AccountDao();
        
        public Form2()
        {
            InitializeComponent();
            ucLogin1.LoginHidden += UserControl_Hidden;
            
        }
        private void UserControl_Hidden(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn Form khi UserControl được ẩn
        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
