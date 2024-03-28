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
        ucLogin ucLogin1;
        public FContainer()
        {

            InitializeComponent();

        }
        
        private void UserControl_Hidden(object sender, EventArgs e)
        {
            //Create ucMainMenu then show it in container
            //The ucMainMenu parameter is the Account got from login
            //This parameter is used to take value from user (Name, Age, CCCC...)
            ucMainMenu ucMainMenu = new ucMainMenu(ucLogin1.GetAccount());
            ucMainMenu.Dock = DockStyle.Fill;
            ucLogin1.Hide();
            this.Controls.Add(ucMainMenu);
            //When this event executes, make it run other event from passed Function
            ucMainMenu.turnOff += turnOffForm;
            ucMainMenu.logOut += logOut;
        }
        private void turnOffForm(object sender, EventArgs e)
        {
            //Close the container Form
            this.Close();
        }
        private void logOut(object sender, EventArgs e)
        {
            //When loggout to login then show ucLogin again
            ucLogin1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openUcLogin(sender,e);
        }
        public void openUcLogin(object sender, EventArgs e)
        {
            //Create new ucLogin form then show it in container Form
            ucLogin ucLogin1 = new ucLogin();
            //Fill the Uc in the container form
            ucLogin1.Dock = DockStyle.Fill;
            this.ucLogin1 = ucLogin1;
            //Add or show it 
            this.Controls.Add(this.ucLogin1);
            ucLogin1.LoginHidden += UserControl_Hidden;
            //Take this data to attribute above.
            //ucLogin1.Hide();
            
        }

    }
}
