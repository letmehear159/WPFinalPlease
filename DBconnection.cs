using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFinalPlease
{
    internal class DBconnection
    {
        SqlConnection conn = new
SqlConnection(Properties.Settings.Default.connStr);
        public void execute(string sqlStr)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Executed Successfully!");
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Failed To Execute" + ex);

            }
            finally

            {
                conn.Close();
            }
        }
        public DataTable loadAndRef(string sqlStr)
        {
            try
            {
                // Ket noi

                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);

                DataTable dtSinhVien = new DataTable();

                adapter.Fill(dtSinhVien);

                return dtSinhVien;
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

                return null;
            }

            finally

            {
                conn.Close();
            }
        }

        public DataTable refresh(string sqlStr)
        {
            return loadAndRef(sqlStr);

        }
        public DataTable load(string sqlStr)
        {

            return loadAndRef(sqlStr);

        }
    }
}
