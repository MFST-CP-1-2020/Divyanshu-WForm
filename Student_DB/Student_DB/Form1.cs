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

namespace Student_DB
{
    public partial class Form1 : Form
    {
        Student st = new Student();
        /// <summary>
        /// this method will add textbox data into corresponding fields..
        /// </summary>
        public void AddStudent()
        {
            try
            {
                st.stud_id = int.Parse(txtStudentid.Text);
                st.Phone_no = txtPhoneNo.Text;
            }
            catch (Exception)
            { }
            st.First_name = txtFirstName.Text;
            st.Last_name = txtLastName.Text;
            st.gender = txtGender.Text;
            st.State = txtState.Text;
            st.Country = txtCountry.Text;
        }

        public Form1()
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
            st.AddStudentData();
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
            st.UpdateStudent(int.Parse(txtStudentid.Text));
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

        private void FormHeading_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Student
    {
        // Declaring all the fields..
        public int stud_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string gender { get; set; }
        public string Phone_no { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        //Creating sqlHelper class object..
        SqlHelper sh = new SqlHelper();

        /// <summary>
        /// This method will add parameter for Add method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameter(Student st)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(st.stud_id));
            sh.sqlparameter("@firstname", SqlDbType.NVarChar, ParameterDirection.Input, (st.First_name));
            sh.sqlparameter("@lastname", SqlDbType.NVarChar, ParameterDirection.Input, (st.Last_name));
            sh.sqlparameter("@gender", SqlDbType.NVarChar, ParameterDirection.Input, (st.gender));
            sh.sqlparameter("@phoneno", SqlDbType.BigInt, ParameterDirection.Input, Convert.ToInt32(st.Phone_no));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (st.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (st.Country));
        }
        /// <summary>
        /// This method will add parameter for delete method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameterdel(Student st)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(st.stud_id));
        }
        /// <summary>
        /// This method will add parameter for Update method..
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public void Addparameterdupdt(Student st)
        {
            sh.sqlparameter("@studentid", SqlDbType.Int, ParameterDirection.Input, Convert.ToInt32(st.stud_id));
            sh.sqlparameter("@state", SqlDbType.NVarChar, ParameterDirection.Input, (st.State));
            sh.sqlparameter("@country", SqlDbType.NVarChar, ParameterDirection.Input, (st.Country));
        }

        public void AddStudentData()
        {
            SqlCommand cmd = new SqlCommand();
            Addparameter(this);
            string val = sh.Executescalar("Addstudents",true);
            MessageBox.Show("Record inserted successfully. Stud_ID = " + val);
        }


        public DataTable getData()
        {
            DataTable dt= sh.Dataadapter("GetStudentdata");
            return dt;
        }

        public void deleteStudent(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            this.stud_id = Id;
            Addparameterdel(this);
            sh.Executequery("Deletestudent1",true);
        }

        public void UpdateStudent(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            this.stud_id =Id;
            Addparameterdupdt(this);
            sh.Executequery("Updateprocedure",true);
        }

    }
}
