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
        WorkerDao workerDao = new WorkerDao();
        public ucWorkerList()
        {
            InitializeComponent();
        }



        private void ucWorkerList_Load(object sender, EventArgs e)
        {
            DataTable workerList = workerDao.load();
            DataRow frow = workerList.Rows[0];
            ucBriefPerson1.receiveInfor(frow);
        }
    }
}
