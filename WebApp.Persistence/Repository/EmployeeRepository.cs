using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entities.Employees;
using WebApp.Persistence.Interface;

namespace WebApp.Persistence.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly List<Employess> EmployeeList=new List<Employess>();

    public EmployeeRepository()
    {
        Employess employees1 = new() { Id = 1, Name = "Kamran", Salary = 30000 };
        Employess employees2 = new() { Id = 2, Name = "Logic Hub", Salary = 40000 };
        Employess employees3 = new() { Id = 3, Name = "Kamran Wani", Salary = 60000 };

        EmployeeList.Add(employees1);
        EmployeeList.Add(employees2);
        EmployeeList.Add(employees3);
    }
    public bool AddEmployee(Employess emp)
    {
       

        EmployeeList.Add(emp);

        return true;

    }

    public List<Employess> GetAllEmployee()
    {
        return EmployeeList;
    }
}
