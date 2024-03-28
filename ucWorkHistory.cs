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
    public partial class ucWorkHistory : UserControl
    {
        public ucWorkHistory()
        {
            InitializeComponent();
        }

        public void receiveInfo(DataRow row)
        {
            lblComment.Text = row["Comment"].ToString();
            lblObjective.Text = row["Objective"].ToString();
            lblPaid.Text = row["Paid"].ToString();
            lblProgress.Text = row["Progress"].ToString();
            lblTimeFinish.Text = row["Time_Finish"].ToString();
        }
    }
}
