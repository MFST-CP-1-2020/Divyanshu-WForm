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

        newStudent st = new newStudent();
        //  Studentdto dta = new Studentdto();
        DTO.Student dta = new DTO.Student();
           
        /// <summary>
        /// this method will add textbox data into corresponding fields..
        /// </summary>
        public void AddStudent()
        {
            try
            {
                dta.Studentid = int.Parse(txtStudentid.Text);
                dta.Phone_no = int.Parse(txtPhoneNo.Text);
            }
            catch (Exception)
            { }
            dta.First_name = txtFirstName.Text;
            dta.Last_name = txtLastName.Text;
            dta.Gender = txtGender.Text;
            dta.State = txtState.Text;
            dta.Country = txtCountry.Text;
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
            st.AddStudentData(dta);
            dt = st.getData();
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
            st.deleteStudent(int.Parse(txtStudentid.Text));
            dt = st.getData();
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
            st.UpdateStudent(dta,int.Parse(txtStudentid.Text));
            dt = st.getData();
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
            dt = st.getData();
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
