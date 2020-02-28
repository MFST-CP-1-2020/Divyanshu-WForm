using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Student_DB
{
    /// <summary>
    /// This class will contain all the methods that are required for database connectivity and operations...
    /// </summary>
     public class SqlHelper
    {
        // Adding connection string
        private string connectionString;
        private List<SqlParameter> parameters = new List<SqlParameter>();
        public SqlHelper()
        {
            connectionString = @"Database=TestDb;server=DIVYANSHU-PC\SQLEXPRESS;user= sa;password=mindfire@1";
        }
        /// <summary>
        /// ExecuteNonQuery returns no rows, any output parameters or return values mapped to 
        /// parameters are populated with data.
        /// statements like UPDATE, INSERT, or DELETE can be used.
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="cmdtxt"></param>
        public void Executequery(string query, bool isProcedure)
        {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
                cmd.CommandText = query;
               // cmd.Parameters.Clear();
                // Add sql parameters into Sql Command.
                if (parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                cmd.ExecuteNonQuery();
              con.Close();
            parameters.Clear();
        }

        /// <summary>
        /// The DataReader  allows you to retrieve data from database
        /// in read-only and forward-only mode. It means you can only 
        /// read and display data  but can’t update or delete data.  
        /// </summary>
        /// <param name="qry"></param>
        /// <returns></returns>
        public SqlDataReader Datareader(string qry)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
            return dr;
        }
        /// <summary>
        /// This function is use to get the data from Database and fill it into 
        /// Datatable with the help of SqlDataAdapter and return table
        /// </summary>
        /// <returns></returns>

        public DataTable Dataadapter(string query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// The Scalar() executes SQL statements as well as Stored Procedure and returned a scalar value
        /// on first column of first row in the returned Result Set.
        /// If the Result Set contains more than one columns or rows , it will take only the value of
        /// first column of the first row,
        /// and all other values will ignore.If the Result Set is empty it will return a NULL reference.
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>

        public string Executescalar(string query,bool isProcedure)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
            cmd.CommandText = query;
            // Add sql parameters into Sql Command.
            if (parameters.Count > 0)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }
           string val= cmd.ExecuteScalar().ToString();
            con.Close();
            parameters.Clear();
            return val;

        }
        /// <summary>
        /// This function is use to create Sql Parameters for execute query.
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="sdt"></param>
        /// <param name="pd"></param>
        /// <param name="ob"></param>
        /// <param name="cmd"></param>
        public void sqlparameter(string pn, SqlDbType sdt, ParameterDirection pd, object ob)
        {
            SqlParameter obj = new SqlParameter();
            obj.ParameterName = pn;
            obj.SqlDbType = sdt;
            obj.Direction = pd;
            obj.Value = ob;
            parameters.Add(obj);
        }

    }
}
