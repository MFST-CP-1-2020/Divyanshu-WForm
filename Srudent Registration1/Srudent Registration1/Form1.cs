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
        int indexRow;
        // Defining Datatable
        DataTable st = new DataTable();
        DataTable cn = new DataTable();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        // Binding the content of comboBox
        void bindContents()
        {
            State();
            Country();
        }
        // Assigning States to comboBox
        void State()
        {
            st.Columns.Add("Id", typeof(int));
            st.Columns.Add("Name", typeof(string));
    
            st.Rows.Add(1, "Delhi");
            st.Rows.Add(2, "up");
            st.Rows.Add(3, "Gujrat");
            st.Rows.Add(4, "patna");
            state_txt.DataSource = st;
            state_txt.DisplayMember = "Name";
            state_txt.ValueMember = "Id";
        }
        // Assigning Countries to comboBox
        void Country()
        {
            cn.Columns.Add("id", typeof(int));
            cn.Columns.Add("name", typeof(string));

            cn.Rows.Add(1, "India");
            cn.Rows.Add(2, "USA");
            cn.Rows.Add(3, "Australia");
            cn.Rows.Add(4, "Canada");
            country_txt.DisplayMember = "name";
            country_txt.ValueMember = "id";
            country_txt.DataSource = cn;
        }




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
            bindContents();
            //Disabling the update button
            upd_butt.Enabled = false;
        }

        // Now assigning the values to the rows of grid 
        void Add_rows()
        {
            DataRow dr = dt.NewRow();

            dr[0] = fn_txt.Text;
            dr[1] = ln_txt.Text;
            dr[2] = fa_txt.Text;
            dr[3] = Ei_txt.Text;
            dr[4] = phn_txt.Text;
            bool x = male_bttn.Checked;
            if (x)
                dr["Sex"] = male_bttn.Text;
            else
                dr["Sex"] = Female_btn.Text;
            dr[6] = Rn_txt.Text;
            dr[7] = Nation_txt.Text;
            dr[8] = addr_txt.Text;
            dr[9] = state_txt.Text;
            dr[10] = country_txt.Text;
            dr[11] = pc_txt.Text;
            dt.Rows.Add(dr);
            MessageBox.Show("Data saved successfuly");
        }
        private void Sumbit_btn(object sender, EventArgs e)
        {
            Add_rows();

            // binding the data to the grid
            datagrid.DataSource = dt;
            bind_edit();
            reset_text();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // this method will reset all the values of the textboxes

            void reset_text()
        {
            fn_txt.Clear();
            ln_txt.Clear();
            fa_txt.Clear();
            Ei_txt.Clear();
            phn_txt.Clear();
            Rn_txt.Clear();
            Nation_txt.Clear();
            addr_txt.Clear();
            state_txt.ResetText();
            country_txt.ResetText();
            pc_txt.Clear();
        }
         
        // This method will assign values to grid via textbox
           void txtbox_to_grid()
        {
            DataGridViewRow newDataRow = datagrid.Rows[indexRow];
            newDataRow.Cells[0].Value = fn_txt.Text;
            newDataRow.Cells[1].Value = ln_txt.Text;
            newDataRow.Cells[2].Value = fa_txt.Text;
            newDataRow.Cells[3].Value = Ei_txt.Text;
            newDataRow.Cells[4].Value = phn_txt.Text;
            bool x = male_bttn.Checked;
            if (x)
                newDataRow.Cells[5].Value = male_bttn.Text;
            else
                newDataRow.Cells[5].Value = Female_btn.Text;
            newDataRow.Cells[6].Value = Rn_txt.Text;
            newDataRow.Cells[7].Value = Nation_txt.Text;
            newDataRow.Cells[8].Value = addr_txt.Text;
            newDataRow.Cells[9].Value = state_txt.Text;
            newDataRow.Cells[10].Value = country_txt.Text;
            newDataRow.Cells[11].Value = pc_txt.Text;
            reset_text();
        }
        private void Update_btn(object sender, EventArgs e)
        {
            txtbox_to_grid();
            upd_butt.Enabled = false;
            Add_bttn.Enabled = true;
        }

        // Adding edit button in the grid
        public void bind_edit()
        {
            DataGridViewButtonColumn bttn = new DataGridViewButtonColumn();
            bttn.HeaderText = "Edit_column";
            bttn.Name = "bttn_edit";
            bttn.Text = "Edit";
            bttn.UseColumnTextForButtonValue = true;
            // This condition will add only one edit coulmn
            if (datagrid.Columns.Contains(bttn.Name = "bttn_edit"))
            {

            }
            else
            {
                datagrid.Columns.Add(bttn);
            }
        }



        private void label10_Click(object sender, EventArgs e)
        {

        }
        // This method will put the values back to the textbox from datagrid to allow editing
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = datagrid.Rows[indexRow];
            fn_txt.Text = row.Cells[0].Value.ToString();
            ln_txt.Text = row.Cells[1].Value.ToString();
            fa_txt.Text = row.Cells[2].Value.ToString();
            Ei_txt.Text = row.Cells[3].Value.ToString();
            phn_txt.Text = row.Cells[4].Value.ToString();
            String Y= row.Cells[5].Value.ToString();
            if (Y.Equals(Female_btn.Text))
                Female_btn.Checked = true;
            else
                male_bttn.Checked = true;
            Rn_txt.Text = row.Cells[6].Value.ToString();
            Nation_txt.Text = row.Cells[7].Value.ToString();
            addr_txt.Text = row.Cells[8].Value.ToString();
            state_txt.Text = row.Cells[9].Value.ToString();
            country_txt.Text = row.Cells[10].Value.ToString();
            pc_txt.Text = row.Cells[11].Value.ToString();
            // Enabling update button
            upd_butt.Enabled = true;
            //  Disabling Add button
            Add_bttn.Enabled = false;
        }

    }
}
