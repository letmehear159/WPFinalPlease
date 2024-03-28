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
    public partial class ucWorkerDetail : UserControl
    {
       public ucMainMenu ucMainMenu;
        public ucWorkerDetail()
        {
            InitializeComponent();
        }
        private void ucWorkerDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMainMenu.tabMainMenu.SelectedIndex = 1;
        }
    }
}
