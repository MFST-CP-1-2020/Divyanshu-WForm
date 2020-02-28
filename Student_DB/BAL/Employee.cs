
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BAL
{
    public class Employee
    {
        // Declaring all the fields..
       /* public int emp_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string gender { get; set; }
        public string Phone_no { get; set; }
        public string State { get; set; }
        public string Country { get; set; }*/

        //Creating sqlHelper class object..
        SqlHelper sh = new SqlHelper();
        DTO.Employee empl = new DTO.Employee();
        DAL.Employee emp = new DAL.Employee();
        //Employeedto et = new Employeedto();

        /// <summary>
        /// This method will add parameter for Add method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        
      /*  public void Addparameter(DTO.Employee empl)
        {
           // sh.sqlparameter("@Employeid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(emp.emp_id));
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
        public void AddEmployeeData(DTO.Employee empl)
        {
            //SqlCommand cmd = new SqlCommand();
            //Addparameter(et);
            // string val = sh.Executescalar("AddEmployees", true);
            // MessageBox.Show("Record inserted successfully. Stud_ID = " + val);
            emp.AddEmployeeData(empl);
        }

        /// <summary>
        /// This method will get Employee data into datatable...
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {

            DataTable dt = new DataTable();
            dt =emp.getData();
            return dt;
            //return emp.getData();
        }

        /// <summary>
        /// This method will delete Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteEmployee(DTO.Employee empl, int Id)
        {
           // SqlCommand cmd = new SqlCommand();
            empl.Employeid = Id;
            emp.deleteEmployee(Id);
           // emp.Addparameterdel(et);
           // sh.Executequery("DeleteEmployees", true);
        }

        /// <summary>
        /// This method will update Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateEmployee(DTO.Employee empl, int Id)
        {
           // SqlCommand cmd = new SqlCommand();
            empl.Employeid = Id;
            emp.UpdateEmployee(empl,Id);
           // Addparameterdupdt(et);
           // sh.Executequery("UpdateEmployees", true);
        }
    }
}
