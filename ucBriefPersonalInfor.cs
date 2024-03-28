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
        public bool selected=false;
        public event EventHandler<ButtonActivatedEventArgs> ButtonActivated;
        public class ButtonActivatedEventArgs : EventArgs
        {
            public string Data { get; set; } // Ví dụ: Dữ liệu bạn muốn truyền
        }
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
            lblSkills.Text = frow["skills"].ToString();
            lblExperience.Text = frow["Experience_Year"].ToString();
            lblStar.Text = frow["Star_rate"].ToString();
            lblCCCD.Text = frow["CCCD"].ToString() ;
            lblName.Text = frow["Name"].ToString();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.selected=true;
            ButtonActivated?.Invoke(this, new ButtonActivatedEventArgs { Data = lblCCCD.Text });
        }
    }
    
  
}
