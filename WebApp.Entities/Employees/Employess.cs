using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Entities.Employees
{
    public class Employess
    {
        public int EmpID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public double PhoneNumber { get; set; }


    }
}
