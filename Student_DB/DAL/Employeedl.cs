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
       /// <summary>
       /// This Class is responsible for interacting with Database and perform CRUD operation..
       /// </summary>
        public class Employeedl
        {
            //Employeedto et = new Employeedto();
           // Object creation of entity Model Employee class..
            Employee emp = new Employee();
            
        /// <summary>
        /// This method will add Employee data into database...
        /// </summary>
        public void AddEmployeeData(Employee emp)
        {

            using (var context = new TestDbEntities1())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
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
            // this loop will add rows into datagrid..
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
        /// <summary>
        /// This method will add columns to the datagrid..
        /// </summary>
        /// <returns></returns>
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
                emp.Employeid = Id;
            TestDbEntities1 context = new TestDbEntities1();
            var dto = (from d in context.Employees where d.Employeid == Id select d).Single();
            context.Employees.Remove(dto);
            context.SaveChanges();
        }
        /// <summary>
        /// This method will update Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateEmployee(Employee emp, int Id)
            {
                emp.Employeid = Id;
                TestDbEntities1 context = new TestDbEntities1();
                var student = (from d in context.Employees where d.Employeid == emp.Employeid select d).Single();
                student.State = emp.State;
                student.Country = emp.Country;

                context.SaveChanges();
            }

        }
    }
