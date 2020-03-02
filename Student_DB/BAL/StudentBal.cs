
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
    public class StudentBal
    {
        // This object is created for accessing the methods of DAL class..
        StudentDl stdal = new StudentDl();
        // This is created  for accessing properties of dto class..
        Studentdto stdto = new Studentdto();
        StudentMaper maps = new StudentMaper();
        
        /// <summary>
        /// This method will add Student data into database...
        /// </summary>
        public void AddStudentData(Studentdto stdto)
        {
            stdal.AddStudentData(maps.GetmapperSt(stdto));
        }

        /// <summary>
        /// This method will get Student data into datatable...
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
             DataTable dt = new DataTable();
            dt = stdal.getData();
            return dt;
        }
        /// <summary>
        /// This method will delete student data from database...
        /// </summary>
        /// <param name="Id"></param>
        public void deleteStudent(int Id)
        {
            stdto.stud_id = Id;
            stdal.deleteStudent(Id);
        }
        /// <summary>
        /// This method will Update Student data into database...
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateStudent(Studentdto stdto, int Id)
        {
            stdto.stud_id = Id;
            stdal.UpdateStudent(maps.GetmapperSt(stdto), Id);
        }

    }
}

