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
            string sqlStr = string.Format("Update worker set Occupation ='{0}', Experience_Year ='{1}', Expected_Price='{2}',  Certificate ='{3}', skills='{5}', bio='{6}' where cccd='{4}' ", worker.GetOccupation(), worker.GetExperiencedYear(), worker.GetExpectedPrice(),
            worker.GetCertificate(), cccd,worker.GetSkills(),worker.GetBio());
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
            string skill = workerRow.Field<String>("Skills");
            string bio = workerRow.Field<String>("bio");
            return new Worker(occupation,experience,expectedPrice, certificate,skill,bio);
        }
        public new Worker getFullInformationFromCCCD(string cccd)
        {
            string sqlCheck = string.Format("Select count(*) from worker where cccd='{0}'", cccd);
            string sqlStr = string.Format("Select * from worker where cccd='{0}'", cccd);
            DataRow workerRow = dBconnection.getValueFromCCCD(sqlStr, sqlCheck);
            string occupation = workerRow.Field<String>("Occupation");
            string certificate = workerRow.Field<String>("certificate");
            int experience = workerRow.Field<int>("Experience_Year");
            double expectedPrice = workerRow.Field<double>("Expected_Price");
            string skill = workerRow.Field<String>("Skills");
            string bio = workerRow.Field<String>("bio");
            string name= workerRow.Field<String>("name");
            string address= workerRow.Field<String>("address");
            string gender = workerRow.Field<String>("Gender");
            string phone=workerRow.Field<String>("Phone");
            string email= workerRow.Field<String>("email");
            DateTime birth= workerRow.Field<DateTime>("BirthDate");
            int review= workerRow.Field<int>("Review");
            double star = workerRow.Field<double>("Star_rate");
            return new Worker(name, cccd, address, gender, phone, email, birth, occupation, experience, expectedPrice, certificate, star
                , review, skill, bio);
        }

    }
}
