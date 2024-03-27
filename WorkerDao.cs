using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFinalPlease
{
    class WorkerDao : PersonDao
    {
        DBconnection dBconnection = new DBconnection();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT *FROM {0}", "Worker");
            return dBconnection.load(sqlStr);
        }
        public void changeFromUserToWorker(Worker worker,string cccd)
        {
            string sqlStr = string.Format("Update worker set Occupation ='{0}', Experience_Year ='{1}', Expected_Price='{2}',  Certificate ='{3}' where cccd='{4}' ", worker.GetOccupation(), worker.GetExperiencedYear(), worker.GetExpectedPrice(),
            worker.GetCertificate(), cccd);
            if (dBconnection.executeNoMessage(sqlStr))
            {
                sqlStr = string.Format("Update account set role = 'Worker' where cccd= '{0}'", cccd);
                dBconnection.execute(sqlStr);
            }
         
        }
        public new Worker getInformationFromCCCD(string cccd)
        {
            string sqlCheck = string.Format("Select count(*) from worker where cccd='{0}'", cccd);
            string sqlStr = string.Format("Select * from worker where cccd='{0}'", cccd);
            DataRow workerRow=dBconnection.getValueFromCCCD(sqlStr,sqlCheck);
            string occupation = workerRow.Field<String>("Occupation");
            string certificate = workerRow.Field<String>("certificate");
            int experience= workerRow.Field<int>("Experience_Year");
            double expectedPrice= workerRow.Field<double>("Expected_Price");
            return new Worker(occupation,experience,expectedPrice, certificate);
        }

    }
}
