﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPFinalPlease
{
    internal class AccountDao
    {
        DBconnection dBconnection = new DBconnection();
        public DataRow getAccountFromUsername(string username)
        {
           string sqlStr = string.Format("SELECT *FROM {0} WHERE username = '{1}'", "Account",username);
           DataTable list= dBconnection.load(sqlStr);
            return list.Rows[0];
            
        }
      
        public Account getAccountFromLogin(string username,string password)
        {
            string sqlStr = string.Format("Select * from {0} where username = '{1}'","Account",username);
            DataRow getAccount = getAccountFromUsername(username);
            //Check null hay không 
            //Nếu không null thì bắt đầu lấy giá trị đổ ra 
            //Tiếp tục check nếu dữ liệu lấy ra có password trùng với password trên người dùng nhập vào hay không
            string CCCD= getAccount["CCCD"].ToString();
            string role= getAccount["role"].ToString();
            Account newAccount = new Account(username,password,CCCD,role);
            return newAccount;
            //Trả về newAccount chứa giá trị của user này 
        }
        public void rememberMe(string username, string password,Bunifu.UI.WinForms.BunifuCheckBox checkBox)
        {
            string sqlStr = string.Format("delete from {0}", "remember");
            dBconnection.execute(sqlStr);
            if (checkBox.Checked)
            {
                 sqlStr = string.Format("Insert into Remember values ('{0}','{1}')", username, password);
                dBconnection.execute(sqlStr);
            }
        }
        //Return the value from remember table in database
        //If table remember has value return Account 
        //Else return null
        public Account getInformationFromRemem()
        {
            string sqlStr = string.Format("SELECT *FROM {0}", "Remember");
            string sqlStrGetCount = string.Format("SELECT COUNT(*) FROM Remember");
            if (!dBconnection.isEmpty(sqlStrGetCount))
            {
                return null;
            }
            DataTable list = dBconnection.load(sqlStr);
            DataRow userInfor= list.Rows[0];
            string user = userInfor["username"].ToString();
            string password = userInfor["password"].ToString();
            Account newAccount=new Account(user,password);
            return newAccount!=null ? newAccount : null;
        }
    }
}