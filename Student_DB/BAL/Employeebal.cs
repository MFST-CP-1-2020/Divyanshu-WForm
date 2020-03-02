
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BAL.Mapper;
namespace BAL
{
    /// <summary>
    /// This class contains buisness logic code for data manipulation...
    /// </summary>
    public class Employee
    {
        // This object is created for accessing the methods of DAL class..
        Employeedl emp = new DAL.Employeedl();
        EmployeMaper map = new EmployeMaper();
        // This is created  for accessing properties of dto class
        Employeedto empdto = new Employeedto();

       

        /// <summary>
        /// This method will add Employee data into database...
        /// </summary>
        public void AddEmployeeData(Employeedto empdto)
        {
            emp.AddEmployeeData(map.GetMapper(empdto));
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
        }

        /// <summary>
        /// This method will delete Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteEmployee(Employeedto empdto, int Id)
        {
            empdto.emp_id = Id;
            emp.deleteEmployee(Id);
        }

        /// <summary>
        /// This method will update Employee data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateEmployee(Employeedto empdto, int Id)
        {
            empdto.emp_id = Id;
            emp.UpdateEmployee(map.GetMapper(empdto),Id);
        }
    }
}
