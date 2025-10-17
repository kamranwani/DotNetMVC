using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entities.Employees;

namespace WebApp.Application.Abstraction;

public interface IEmployeeService
{
    bool AddEmployee(Employess emp);

    List<Employess> GetAllEmployee();
}
