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
using static WPFinalPlease.ucBriefPersonalInfor;

namespace WPFinalPlease
{
    public partial class ucWorkerList : UserControl
    {
        SqlConnection conn = new
 SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dBconnection = new DBconnection();
        WorkerDao workerDao = new WorkerDao();
       public ucMainMenu ucMainMenu;
        ucWorkerDetail ucWorkerDetail;
        public ucWorkerList()
        {
            InitializeComponent();
           
        }

        private void UserControlB_ButtonActivated(object sender, ucBriefPersonalInfor.ButtonActivatedEventArgs e)
        {
            ucBriefPersonalInfor userControlB = sender as ucBriefPersonalInfor;
            string cccd = e.Data; // Dữ liệu được truyền từ UserControl B

            // Bây giờ bạn có thể làm gì đó với dữ liệu từ UserControl B
            MessageBox.Show(cccd);
            ucMainMenu.tabMainMenu.SelectedIndex = 5;
        Worker worker=    workerDao.getFullInformationFromCCCD(cccd);

            Utility.fillInWorkerDetail(worker, ucWorkerDetail);
        }

        private void ucWorkerList_Load(object sender, EventArgs e)
        {
            ucWorkerDetail ucWorker = new ucWorkerDetail();
            ucMainMenu.tpWorkerDetail.Controls.Add(ucWorker);
            this.ucWorkerDetail = ucWorker;
            DataTable workerList = workerDao.load();
            foreach (DataRow row in workerList.Rows)
            {
                ucBriefPersonalInfor ucBriefPersonalInfor = new ucBriefPersonalInfor();
                ucBriefPersonalInfor.receiveInfor(row);
                ucBriefPersonalInfor.Margin = new Padding(15);
                flowPanel.Controls.Add(ucBriefPersonalInfor);
            }
            foreach(ucBriefPersonalInfor uc in flowPanel.Controls)
            {
                uc.ButtonActivated += UserControlB_ButtonActivated;
            }

            
        }

        





    }
}
