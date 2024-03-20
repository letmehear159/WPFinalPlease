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
    public partial class ucBriefPersonalInfor : UserControl
    {
        public ucBriefPersonalInfor()
        {
            InitializeComponent();
        }
        public void receiveInfor(DataRow frow)
        {
            lblAddress.Text = frow["Address"].ToString();
            lblBio.Text = frow["bio"].ToString();
            lblExpectedPrice.Text = frow["Expected_Price"].ToString();
            lblOccupation.Text = frow["occupation"].ToString();
            lblSkill.Text = frow["skills"].ToString();
            lblExperienceYear.Text = frow["Experience_Year"].ToString();
            lblStar.Text = frow["Star_rate"].ToString();
        }
    }
}
