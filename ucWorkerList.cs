using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFinalPlease
{
    public partial class ucWorkerList : UserControl
    {
        SqlConnection conn = new
 SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dBconnection = new DBconnection();
        public ucWorkerList()
        {
            InitializeComponent();
        }



        private void ucWorkerList_Load(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT *FROM {0}", "Worker");
            DataTable workerList = dBconnection.load(sqlStr);
            DataRow frow = workerList.Rows[0];
            ucBriefPerson1.lblAddress.Text = frow["Address"].ToString();
            ucBriefPerson1.lblBio.Text = frow["bio"].ToString();
            ucBriefPerson1.lblExpectedPrice.Text = frow["Expected_Price"].ToString();
            ucBriefPerson1.lblOccupation.Text = frow["occupation"].ToString();
            ucBriefPerson1.lblSkill.Text = frow["skills"].ToString();
            ucBriefPerson1.lblExperienceYear.Text = frow["Experience_Year"].ToString();
            ucBriefPerson1.lblStar.Text = frow["Star_rate"].ToString();
        }
    }
}
