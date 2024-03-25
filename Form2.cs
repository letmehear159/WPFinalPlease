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
        ucMainMenu ucMainMenu = new ucMainMenu();
        ucLogin ucLogin1 = new ucLogin();
        public Form2()
        {

            InitializeComponent();
            ucMainMenu.turnOff += turnOffForm;
            ucLogin1.btnLogin.Click += UserControl_Hidden;

        }
        private void UserControl_Hidden(object sender, EventArgs e)
        {
            ucMainMenu ucMainMenu = new ucMainMenu();
            ucMainMenu.Dock = DockStyle.Fill;
            this.Controls.Add(ucMainMenu);
            this.ucMainMenu= ucMainMenu;
        }
        private void turnOffForm(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ucLogin ucLogin1 = new ucLogin();
            ucLogin1.Dock = DockStyle.Fill;
            this.Controls.Add(ucLogin1);
            this.ucLogin1= ucLogin1;
            ucLogin1.LoginHidden += UserControl_Hidden;
        }
    }
}
