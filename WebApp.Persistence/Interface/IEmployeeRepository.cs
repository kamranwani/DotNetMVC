using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entities.Employees;

namespace WebApp.Persistence.Interface;

 public interface IEmployeeRepository
{
    bool AddEmployee(Employess emp);

    List<Employess> GetAllEmployee();
}
