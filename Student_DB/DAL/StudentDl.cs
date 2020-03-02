using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    /// <summary>
    /// This class is responsible for interacting with the Database and to perform required operation...
    /// </summary>
   public class StudentDl
    {
       // Object creation of Entity model Student class..
        Student stentity = new Student();

        /// <summary>
        /// This method will add Student data into database...
        /// </summary>
     
        public void AddStudentData(Student stentity)
        {

            using (var context = new TestDbEntities1())
            {
                context.Students.Add(stentity);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// This method will get Student data into datatable...
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
            TestDbEntities1 context = new TestDbEntities1();
            DataTable dt = addcolm();
            var dto = (from d in context.Students select d);
            // This loop will add Values into the rows of datagrid..
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
        /// <summary>
        /// This method will add Columns to the datagrid..
        /// </summary>
        /// <returns></returns>
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
        /// This method will delete Student data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteStudent(int Id)
        {
            stentity.Studentid = Id;
            TestDbEntities1 context = new TestDbEntities1();
            var dto = (from d in context.Students where d.Studentid == Id select d).Single();
            context.Students.Remove(dto);
            context.SaveChanges();
        }
        /// <summary>
        /// This method will update Student data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateStudent(Student stentity, int Id)
        {
            stentity.Studentid = Id;
            TestDbEntities1 context = new TestDbEntities1();
            var student = (from d in context.Students where d.Studentid == Id select d).Single();
            student.State = stentity.State;
            student.Country = stentity.Country;
            context.SaveChanges();
        }
    }
}
