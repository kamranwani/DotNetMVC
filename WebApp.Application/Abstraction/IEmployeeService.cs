using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Application.RRModels.Employee;
using WebApp.Entities.Employees;

namespace WebApp.Application.Abstraction;

public interface IEmployeeService
{
    bool AddEmployee(EmployeeRequest emp);

    IEnumerable<EmployeeResponse> GetAllEmployee();
}
