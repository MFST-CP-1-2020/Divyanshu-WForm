using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// This class will contains all the properties of Employee class..
    /// </summary>
   public class Employeedto
    {
        public int emp_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string gender { get; set; }
        public long Phone_no { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
