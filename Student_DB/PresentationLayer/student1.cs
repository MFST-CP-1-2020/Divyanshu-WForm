using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;
namespace PresentationLayer
{
    public partial class student1: Form
    {
        public student1()
        {
            InitializeComponent();
        }

        // This object will help to access the methods of BAL class..
        StudentBal stbal = new StudentBal();
        // This object will help in accessing fields of DTO class
          Studentdto stdto = new Studentdto();
           
        /// <summary>
        /// this method will add textbox data into corresponding fields..
        /// </summary>
        public void AddStudent()
        {
            try
            {
                stdto.stud_id = int.Parse(txtStudentid.Text);
                stdto.Phone_no = int.Parse(txtPhoneNo.Text);
            }
            catch (Exception)
            { }
            stdto.First_name = txtFirstName.Text;
            stdto.Last_name = txtLastName.Text;
            stdto.gender = txtGender.Text;
            stdto.State = txtState.Text;
            stdto.Country = txtCountry.Text;
        }

        public void Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button click will add the data into database and datatable, which is given by the user..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            AddStudent();
            stbal.AddStudentData(stdto);
            dt = stbal.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }

        /// <summary>
        /// This button click will delete data from database and datagrid..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            stbal.deleteStudent(int.Parse(txtStudentid.Text));
            dt = stbal.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }
        /// <summary>
        /// This button click will update data from database and datagrid..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            AddStudent();
            stbal.UpdateStudent(stdto, int.Parse(txtStudentid.Text));
            dt = stbal.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }
        /// <summary>
        /// This button click will show all the data into the datatable from the database..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void getbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = stbal.getData();
            dataGridView1.DataSource = dt;

        }
        /// <summary>
        /// This method will clear all the fields from datatable..
        /// </summary>
        public void clearStudentData()
        {
            txtStudentid.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGender.Text = "";
            txtPhoneNo.Text = "";
            txtCountry.Text = "";
            txtState.Text = "";
        }
    }
}
