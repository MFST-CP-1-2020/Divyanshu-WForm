using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;
namespace PresentationLayer
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        DTO.Employee et = new DTO.Employee();
        BAL.Employee emp = new BAL.Employee();
       // Employeedto et = new Employeedto();
        /// <summary>
        /// this method will add textbox data into corresponding fields..
        /// </summary>
        public void AddEmployee()
        {
            try
            {
                et.Employeid = int.Parse(txtEmployeid.Text);
                et.Phoneno = int.Parse(txtPhoneno.Text);
            }
            catch (Exception)
            { }
            et.Firstname = txtFirstname.Text;
            et.Lastname = txtLastname.Text;
            et.Gender = txtGender.Text;
            et.State = txtState.Text;
            et.Country = txtCountry.Text;
        }

        /// <summary>
        /// This button click will add the data into database and datatable, which is given by the user..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            AddEmployee();
            emp.AddEmployeeData(et);
            dt = emp.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }

        /// <summary>
        /// This button click will delete data from database and datagrid..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            emp.deleteEmployee(et,int.Parse(txtEmployeid.Text));
            dt = emp.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }
        /// <summary>
        /// This button click will update data from database and datagrid..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            AddEmployee();
            emp.UpdateEmployee(et,int.Parse(txtEmployeid.Text));
            dt = emp.getData();
            dataGridView1.DataSource = dt;
            clearStudentData();
        }
        /// <summary>
        /// This button click will show all the data into the datatable from the database..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void getData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = emp.getData();
            dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// This method will clear all the fields from datatable..
        /// </summary>
        public void clearStudentData()
        {
            txtEmployeid.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtGender.Text = "";
            txtPhoneno.Text = "";
            txtCountry.Text = "";
            txtState.Text = "";
        }
    }
}
