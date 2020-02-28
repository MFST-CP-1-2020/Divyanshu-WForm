using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BAL.Mapper
{
    class EmployeMaper
    {
        public DAL.Employee GetMapper(Employeedto et)
        {
            DAL.Employee emply = new DAL.Employee();
            emply.Employeid = et.emp_id;
            emply.Firstname = et.First_name;
            emply.Lastname = et.Last_name;
            emply.Phoneno = et.Phone_no;
            emply.Gender = et.gender;
            emply.State = et.State;
            emply.Country = et.Country;
            return emply;

        }
    }
}
