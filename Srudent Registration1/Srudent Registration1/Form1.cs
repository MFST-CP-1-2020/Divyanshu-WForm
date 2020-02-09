using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srudent_Registration1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Creating datatable object
        DataTable dt = new DataTable();

        // Creating a method for inserting columns into grid
        void insert_col()
        {
            dt.Columns.Add("First_name");
            dt.Columns.Add("Last_name");
            dt.Columns.Add("Father_name");
            dt.Columns.Add("Email_id");
            dt.Columns.Add("Phone_no");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Blood Group");
            dt.Columns.Add("Nationality");
            dt.Columns.Add("Address");
            dt.Columns.Add("State");
            dt.Columns.Add("Country");
            dt.Columns.Add("Pin_Code");
        }

        // Now call thiss method in the form
        private void Form1_Load(object sender, EventArgs e)
        {
            insert_col();
        }

        // Now assigning the values to the rows of grid 
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr[0] = txtbox1.Text;
            dr[1] = txtbox2.Text;
            dr[2] = txtbox3.Text;
            dr[3] = txtbox4.Text;
            dr[4] = txtbox5.Text;
            dr[5] = comBox1.Text;
            dr[6] = comBox2.Text;
            dr[7] = txtbox6.Text;
            dr[8] = txtbox7.Text;
            dr[9] = txtbox8.Text;
            dr[10] =txtbox9.Text;
            dr[11] =txtbox10.Text;
            dt.Rows.Add(dr);
            MessageBox.Show("Data saved successfuly");

            // binding the data to the grid
            datagrid.DataSource = dt;


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // this method will reset all the values of the textboxes
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtbox1.Clear();
            txtbox2.Clear();
            txtbox3.Clear();
            txtbox4.Clear();
            txtbox5.Clear();
            comBox1.ResetText();
            comBox2.ResetText();
            txtbox6.Clear();
            txtbox7.Clear();
            txtbox8.Clear();
            txtbox9.Clear();
            txtbox10.Clear();
            MessageBox.Show("Data is resetted");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
