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

        // This object will help to access the methods of BAL class..
        Employee emp = new Employee();
        // This object will help in accessing fields of DTO class..
        Employeedto empdto = new Employeedto();

        /// <summary>
        /// this method will add textbox data into corresponding fields..
        /// </summary>
        public void AddEmployee()
        {
            try
            {
                empdto.emp_id = int.Parse(txtEmployeid.Text);
                empdto.Phone_no = long.Parse(txtPhoneno.Text);
            }
            catch (Exception)
            { }
            empdto.First_name = txtFirstname.Text;
            empdto.Last_name = txtLastname.Text;
            empdto.gender = txtGender.Text;
            empdto.State = txtState.Text;
            empdto.Country = txtCountry.Text;
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
            emp.AddEmployeeData(empdto);
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
            emp.deleteEmployee(empdto, int.Parse(txtEmployeid.Text));
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
            emp.UpdateEmployee(empdto, int.Parse(txtEmployeid.Text));
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
