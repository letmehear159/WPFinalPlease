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
    public partial class FContainer : Form
    {
        ucLogin ucLogin1 = new ucLogin();
        public FContainer()
        {

            InitializeComponent();

        }
        private void UserControl_Hidden(object sender, EventArgs e)
        {
            ucMainMenu ucMainMenu = new ucMainMenu();
            ucMainMenu.Dock = DockStyle.Fill;
            this.Controls.Add(ucMainMenu);
            ucMainMenu.turnOff += turnOffForm;
            ucMainMenu.logOut += logOut;
        }
        private void turnOffForm(object sender, EventArgs e)
        {
            this.Close();
        }
        private void logOut(object sender, EventArgs e)
        {
            //openUcLogin(sender, e);
            ucLogin1.Show();

        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {
            ucLogin1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openUcLogin(sender,e);
        }
        public void openUcLogin(object sender, EventArgs e)
        {
            ucLogin ucLogin1 = new ucLogin();
            ucLogin1.Dock = DockStyle.Fill;
            this.Controls.Add(ucLogin1);
            ucLogin1.LoginHidden += UserControl_Hidden;
            this.ucLogin1= ucLogin1;
        }
    }
}
