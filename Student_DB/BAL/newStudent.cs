
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
   public  class newStudent
    {
        // Declaring all the fields..
        /* public int stud_id { get; set; }
         public string First_name { get; set; }
         public string Last_name { get; set; }
         public string gender { get; set; }
         public string Phone_no { get; set; }
         public string State { get; set; }
         public string Country { get; set; } */

       // Studentdto dta = new Studentdto();
        DAL.Student dtn = new DAL.Student();
        DTO.Student dta = new DTO.Student();
        //Creating sqlHelper class object..
        //SqlHelper sh = new SqlHelper();

        /// <summary>
        /// This method will add parameter for Add method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
      /*  public void Addparameter(DAL.Student dta)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(dta.Studentid));
            sh.sqlparameter("@firstname", SqlDbType.NVarChar, ParameterDirection.Input, (dta.First_name));
            sh.sqlparameter("@lastname", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Last_name));
            sh.sqlparameter("@gender", SqlDbType.NVarChar, ParameterDirection.Input, (dta.gender));
            sh.sqlparameter("@phoneno", SqlDbType.BigInt, ParameterDirection.Input, Convert.ToInt32(dta.Phone_no));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (dta.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Country));
        }*/


        /// <summary>
        /// This method will add parameter for delete method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
      /*  public void Addparameterdel(Studentdto dta)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(dta.stud_id));
        }
        /// <summary>
        /// This method will add parameter for Update method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameterdupdt(Studentdto dta)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(dta.stud_id));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (dta.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (dta.Country));
        }*/
        /// <summary>
        /// This method will add Student data into database...
        /// </summary>
        public void AddStudentData(DTO.Student dta)
        {
            //  SqlCommand cmd = new SqlCommand();
            /// Addparameter(dta);
            // string val = sh.Executescalar("Addstudents", true);
            //  MessageBox.Show("Record inserted successfully. Stud_ID = " + val);
            dtn.AddStudentData(dta);
        }

        /// <summary>
        /// This method will get Student data into datatable...
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
            // DataTable dt = sh.Dataadapter("GetStudentdata");
             DataTable dt = new DataTable();
            dt = dtn.getData();
            return dt;
           // return dtn.getData();
        }
        /// <summary>
        /// This method will delete student data from database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteStudent(int Id)
        {
           // SqlCommand cmd = new SqlCommand();
            dta.Studentid = Id;
            // Addparameterdel(dta);
            // sh.Executequery("Deletestudent1", true);
            dtn.deleteStudent(Id);
        }
        /// <summary>
        /// This method will Update Student data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateStudent(DTO.Student dta,int Id)
        {
          //  SqlCommand cmd = new SqlCommand();
            dta.Studentid = Id;
            // Addparameterdupdt(dta);
            // sh.Executequery("Updateprocedure", true);
            dtn.UpdateStudent(dta,Id);
        }

    }
}


