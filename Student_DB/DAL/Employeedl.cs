using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
        public class Employeedl
        {
            // Declaring all the fields..
          /*  public int emp_id { get; set; }
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public string gender { get; set; }
            public string Phone_no { get; set; }
            public string State { get; set; }
            public string Country { get; set; }*/

            //Creating sqlHelper class object..
            //SqlHelper sh = new SqlHelper();
            Employeedto et = new Employeedto();
            Employee eti = new Employee();
       // DTO.Employee empl = new DTO.Employee();
          



        /// <summary>
        /// This method will add parameter for Add method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        /*  public void Addparameter(DTO.Employee empl)
              {
               //   sh.sqlparameter("@Employeid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(emp.emp_id));
                  sh.sqlparameter("@firstname", SqlDbType.NVarChar, ParameterDirection.Input, (empl.Firstname));
                  sh.sqlparameter("@lastname", SqlDbType.NVarChar, ParameterDirection.Input, (empl.Lastname));
                  sh.sqlparameter("@gender", SqlDbType.NVarChar, ParameterDirection.Input, (empl.Gender));
                  sh.sqlparameter("@phoneno", SqlDbType.BigInt, ParameterDirection.Input, Convert.ToInt32(empl.Phoneno));
                  sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (empl.State));
                  sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (empl.Country));
              }
              /// <summary>
              /// This method will add parameter for delete method..
              /// </summary>
              /// <param name="st"></param>
              /// <returns></returns>
              public void Addparameterdel(DTO.Employee empl)
              {
                  sh.sqlparameter("@Employeid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(empl.Employeid));
              }
              /// <summary>
              /// This method will add parameter for Update method..
              /// </summary>
              /// <param name="st"></param>
              /// <returns></returns>
              public void Addparameterdupdt(DTO.Employee empl)
              {
                  sh.sqlparameter("@Employeid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(empl.Employeid));
                  sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (empl.State));
                  sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (empl.Country));
              }*/
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

        public void AddEmployeeData(Employee eti)
        {

            using (var dbCtx = new TestDbEntities1())
            {

                //Add Student object into Students DBset
                dbCtx.Employees.Add(eti);

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
            TestDbEntities1 context = new TestDbEntities1();
            DataTable dt = addcol();
            var dto = (from d in context.Employees select d);
            foreach (var rowobject in dto)
            {
                DataRow dr = dt.NewRow();
                dr["Employeid"] = rowobject.Employeid;
                dr["Firstname"] = rowobject.Firstname;
                dr["Lastname"] = rowobject.Lastname;
                dr["Phoneno"] = rowobject.Phoneno;
                dr["Gender"] = rowobject.Gender;
                dr["State"] = rowobject.State;
                dr["Country"] = rowobject.Country;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private DataTable addcol()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Employeid");
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
        public void deleteEmployee(int Id)
            {
                //SqlCommand cmd = new SqlCommand();
                eti.Employeid = Id;
            TestDbEntities1 context = new TestDbEntities1();
            var dto = (from d in context.Employees where d.Employeid == Id select d).Single();
            context.Employees.Remove(dto);
            context.SaveChanges();

            //  Addparameterdel(empl);
            // sh.Executequery("DeleteEmployees", true);

        }
        /// <summary>
        /// This method will update Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateEmployee(Employee eti, int Id)
            {
              //  SqlCommand cmd = new SqlCommand();
                eti.Employeid = Id;
                TestDbEntities1 context = new TestDbEntities1();
            

                var student = (from d in context.Employees where d.Employeid == eti.Employeid select d).Single();
                // student = emp;
                student.State = eti.State;
                student.Country = eti.Country;

                context.SaveChanges();

                //  using (var dbCtx = new TestDbEntities())

                // Addparameterdupdt(empl);
                // sh.Executequery("UpdateEmployees", true);
            }

        }
    }
