using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPFinalPlease
{
    internal class PersonDao
    {
        DBconnection dBconnection = new DBconnection();

        //Khi người dùng lần đầu đăng nhập vào menu thì họ phải nhập những thông tin này 
        //Sau khi đã tạo 1 bảng thông tin trong worker tương ứng với những thứ này thì nhớ thêm cccd của worker này 
        public void addPersonalInformationCustome(Person person)
        {
            string sqlStr = string.Format("Insert into worker (name,gender,cccd,address,phone,email,birthdate) values" +
                " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", person.GetName(), person.GetGender(), person.GetCCCD(),
                  person.GetAddress(), person.GetPhone(), person.GetEmail(), person.GetBirth());
            dBconnection.execute(sqlStr);
        }
        public Person getInformationFromCCCD(string ccCD)
        {
            string sqlStr = string.Format("Select * from worker where cccd = '{0}'", ccCD);
            //Nhớ kiểm tra thằng này null hay không 
            return dBconnection.GetPerson(sqlStr);
        }
        public void adjustInformation(Person person,string oldCCCD)
        {
            string sqlStr = string.Format("UPDATE worker SET Name = '{0}', Address = '{1}', Birthdate='{2}'" +
                     ", Phone='{3}', Email='{4}', gender='{5}', cccd='{6}' WHERE cccd = '{7}'",person.GetName(),
                     person.GetAddress(),person.GetBirth(),person.GetPhone(),person.GetEmail(),person.GetGender()
                     ,person.GetCCCD(),oldCCCD);
            dBconnection.execute(sqlStr);
        }

    }
}
