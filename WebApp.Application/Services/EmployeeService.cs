using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Application.Abstraction;
using WebApp.Entities.Employees;
using WebApp.Persistence.Interface;
using WebApp.Persistence.Repository;

namespace WebApp.Application.Services;

public class EmployeeService : IEmployeeService

{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();

    }


    public bool AddEmployee(Employess emp)
    {
        employeeRepository.AddEmployee(emp);
        return true;
    }

    public List<Employess> GetAllEmployee()
    {
        return employeeRepository.GetAllEmployee();
    }
}
