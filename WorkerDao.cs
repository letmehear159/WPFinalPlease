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

    }
}
