using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BAL.Mapper
{
    class StudentMaper
    {
        public Student GetmapperSt(Studentdto dta)
        {
            Student stii = new Student();
            stii.Studentid = dta.stud_id;
            stii.First_name = dta.First_name;
            stii.Last_name = dta.Last_name;
            stii.Phone_no = dta.Phone_no;
            stii.Gender = dta.gender;
            stii.State = dta.State;
            stii.Country = dta.Country;
            return stii;
        }
    }
}
