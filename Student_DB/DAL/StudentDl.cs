using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
   public class StudentDl
    {
        SqlHelper sh = new SqlHelper();
        //  Employeedto et = new Employeedto();
        Student dta = new Student();

        /// <summary>
        /// This method will add parameter for Add method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
       /* public void Addparameter(DTO.Student dta)
        {
            //   sh.sqlparameter("@Employeid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(emp.emp_id));
            sh.sqlparameter("@firstname", SqlDbType.NVarChar, ParameterDirection.Input, (dta.First_name));
            sh.sqlparameter("@lastname", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Last_name));
            sh.sqlparameter("@gender", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Gender));
            sh.sqlparameter("@phoneno", SqlDbType.BigInt, ParameterDirection.Input, Convert.ToInt32(dta.Phone_no));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (dta.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Country));
        }
        /// <summary>
        /// This method will add parameter for delete method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameterdel(DTO.Student dta)
        {
            sh.sqlparameter("@Studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(dta.Studentid));
        }
        /// <summary>
        /// This method will add parameter for Update method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameterdupdt(DTO.Student dta)
        {
            sh.sqlparameter("@Studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(dta.Studentid));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (dta.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Country));
        }
        /// <summary>
        /// This method will add Employee data into database...
        /// </summary>
        /* public void AddEmployeeData(Employeedto et)
             {
                // SqlCommand cmd = new SqlCommand();
                 Addparameter(et);
                 string val = sh.Executescalar("AddEmployees", true);
                 // MessageBox.Show("Record inserted successfully. Stud_ID = " + val);
             }*/

        public void AddStudentData(Student dta)
        {

            using (var dbCtx = new TestDbEntities1())
            {

                //Add Student object into Students DBset
                dbCtx.Students.Add(dta);

                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
                // SqlCommand cmd = new SqlCommand();
                //Addparameter(dto);
                //string val = sh.Executescalar("AddEmployees", true);
                // MessageBox.Show("Record inserted successfully. Stud_ID = " + val);
            }
        }
        /// <summary>
        /// This method will get Employee data into datatable...
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
            // DataTable dt = sh.Dataadapter("GetStudentdata");
            // DataTable dt = new DataTable();
            TestDbEntities1 context = new TestDbEntities1();
            DataTable dt = addcolm();
            var dto = (from d in context.Students select d);
            foreach (var rowobject in dto)
            {
                DataRow dr = dt.NewRow();
                dr["Studentid"] = rowobject.Studentid;
                dr["Firstname"] = rowobject.First_name;
                dr["Lastname"] = rowobject.Last_name;
                dr["Phoneno"] = rowobject.Phone_no;
                dr["Gender"] = rowobject.Gender;
                dr["State"] = rowobject.State;
                dr["Country"] = rowobject.Country;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private DataTable addcolm()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Studentid");
            dt.Columns.Add("Firstname");
            dt.Columns.Add("Lastname");
            dt.Columns.Add("Phoneno");
            dt.Columns.Add("Gender");
            dt.Columns.Add("State");
            dt.Columns.Add("Country");
            return dt;
        }

        /// <summary>
        /// This method will delete Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteStudent(int Id)
        {
            //SqlCommand cmd = new SqlCommand();
            dta.Studentid = Id;
            TestDbEntities1 context = new TestDbEntities1();
            var dto = (from d in context.Students where d.Studentid == Id select d).Single();
            context.Students.Remove(dto);
            context.SaveChanges();
            // Addparameterdel(dta);
            //sh.Executequery("DeleteEmployees", true);
        }
        /// <summary>
        /// This method will update Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateStudent(Student dta, int Id)
        {
            //  SqlCommand cmd = new SqlCommand();
            dta.Studentid = Id;
            TestDbEntities1 context = new TestDbEntities1();


            var student = (from d in context.Students where d.Studentid == Id select d).Single();
            // student = emp;
            student.State = dta.State;
            student.Country = dta.Country;

            context.SaveChanges();
            //Addparameterdupdt(dta);
            //sh.Executequery("UpdateEmployees", true);
        }
    }
}
