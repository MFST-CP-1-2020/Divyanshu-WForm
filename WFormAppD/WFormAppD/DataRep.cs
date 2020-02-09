using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormAppD
{
    public partial class DataRep : Form
    {
        public DataRep()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();


        void insert_col()
        {
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Date of birth");
            dt.Columns.Add("Email_id");
            dt.Columns.Add("Phone_no");
            dt.Columns.Add("Roll_no");
            dt.Columns.Add("Nationality");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Blood group");
            dt.Columns.Add("Address");
            dt.Columns.Add("State");
            dt.Columns.Add("Country");
            dt.Columns.Add("Pincode");
        }
        private void DataRep_Load(object sender, EventArgs e)
        {
            insert_col();
        }
    }
}
