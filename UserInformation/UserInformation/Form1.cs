using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> user = new List<User>();
        User ur = new User();

        private void Form1_Load(object sender, EventArgs e)
        {
            newcol();
            Country();
            add_col();
            add_states();



        }
        void newcol()
        {
            ur.First_name = firstn_txt.Text;
            ur.Last_name = ln_txt.Text;
            ur.Father_name = fn_txt.Text;
            ur.Phn_no = pn_txt.Text;
            ur.Roll_no = Rn_txt.Text;
            if (male_radiobtn.Checked)
            {
                ur.Gender = male_radiobtn.Text;
            }
            else
            {
                ur.Gender = female_radiobtn.Text;
            }
            ur.Address = Address_txt.Text;
            ur.state = st_combo.Text;
            ur.country = cn_combobox.Text;
            ur.Pin_code = pc_txt.Text;
        }
        DataTable st = new DataTable();
        DataTable cn = new DataTable();

        void add_col()
        {
            st.Columns.Add("Id", typeof(int));
            st.Columns.Add("Name", typeof(string));

        }
        void State()
        {
            /*st.Rows.Add(1, "Delhi");
            st.Rows.Add(2, "up");
            st.Rows.Add(3, "Gujrat");
            st.Rows.Add(4, "patna");*/
            add_states();
            st_combo.DataSource = st;
            st_combo.DisplayMember = "Name";
            st_combo.ValueMember = "Id";
        }

        void add_states()
        {
            st.Clear();
            if (cn_combobox.SelectedIndex == 0)
            {
                st.Rows.Add(1, "Up");
                st.Rows.Add(2, "Delhi");
                st.Rows.Add(3, "Gujrat");
                st.Rows.Add(4, "patna");
            }
            else if (cn_combobox.SelectedIndex == 1)
            {
                st.Rows.Add(5, "California");
                st.Rows.Add(6, "Texas");
                st.Rows.Add(7, "new york");
                st.Rows.Add(8, "florida");
            }
            else if (cn_combobox.SelectedIndex == 2)
            {
                st.Rows.Add(9, "Victoria");
                st.Rows.Add(10, "Queensland");
                st.Rows.Add(11, "Tasmania");
                st.Rows.Add(12, "New south Wales");
            }
            else
            {
                st.Rows.Add(13, "Alberta");
                st.Rows.Add(14, "Ontario");
                st.Rows.Add(15, "Manitoba");
                st.Rows.Add(16, "Quebec");
            }
            st_combo.DisplayMember = "Name";
            st_combo.ValueMember = "Id";
            st_combo.DataSource = st;
        }


        // Assigning Countries to comboBox
        void Country()
        {
            cn.Columns.Add("Id", typeof(int));
            cn.Columns.Add("Name", typeof(string));
            cn.Rows.Add(1, "India");
            cn.Rows.Add(2, "USA");
            cn.Rows.Add(3, "Australia");
            cn.Rows.Add(4, "Canada");
            cn_combobox.DisplayMember = "name";
            cn_combobox.ValueMember = "id";
            cn_combobox.DataSource = cn;
        }



        private void label12_Click(object sender, EventArgs e)
        {
            user.Add(ur);
            var sour = new BindingSource();
            sour.DataSource = user;
            DataGrid.DataSource = sour;

        }

        private void cn_combobox_DropDownClosed(object sender, EventArgs e)
        {
            State();
        }
    }
    class User
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Father_name { get; set; }
        public string Roll_no { get; set; }
        public string Address { get; set; }
        public string Phn_no{ get; set; }
        public string Gender { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string Pin_code { get; set; }
}
}
