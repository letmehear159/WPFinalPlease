using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace WPFinalPlease
{
    internal class DBconnection
    {
        SqlConnection conn = new
SqlConnection(Properties.Settings.Default.connStr);
        public DataRow getValueFromCCCD(string sqlStr,string sqlCheckHas)
        {
            if(!isEmpty(sqlCheckHas)) return null;
            DataTable value = load(sqlStr);
            if(value == null) return null;
            return value.Rows[0];
        }
        public DataTable getWorkHistory(string sqlStr, string sqlCheckHas)
        {
            if (!isEmpty(sqlCheckHas)) return null;
            DataTable value = load(sqlStr);
            if (value == null) return null;
            return value;
        }
        public Account checkAccount( string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if(dataReader.Read())
                {
                    string username=dataReader.GetString(0);
                    string password=dataReader.GetString(1);
                    string email=dataReader.GetString(4);
                    return new Account(username, password, email);  
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to find value account !");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public Person GetPerson(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
        //             protected string name;
        //protected string cccd;
        //protected string address;
        //protected string gender;
        //protected string phone;
        //protected string email;
        //protected DateTime birth;
                    string name = dataReader.GetString(0);
                    string cccd=dataReader.GetString(3);
                    string address= dataReader.GetString(1);
                    string gender= dataReader.GetString(2);
                    string phone= dataReader.GetString(7);
                    string email= dataReader.GetString(8);
                    DateTime birth= dataReader.GetDateTime(14);
                    return new Person(name, cccd, address, gender, phone, email, birth);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to find value account !");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool executeNoMessage(string sqlStr)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Failed To Execute" + ex);
                return false;

            }
            finally

            {
                conn.Close();
            }
        }
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
        // Return true if has value
        //False if empty
        public bool isEmpty(string sqlStr)
        {
            try
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand(sqlStr, conn);
               object result = cmd.ExecuteScalar();
               int rowNumb= int.Parse(result.ToString());
               if(rowNumb > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Failed To Execute" + ex);
                return false;

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
