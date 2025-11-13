using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Application.RRModels.Employee
{
    public class EmployeeResponse
    {
        public string Name { get; set; }
        public decimal AnnualSalary { get; set; }   

        public int EmployeeId { get; set; }
    }
}
