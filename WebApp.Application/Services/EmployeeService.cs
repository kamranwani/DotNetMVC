using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Application.Abstraction;
using WebApp.Application.RRModels.Employee;
using WebApp.Entities.Employees;
using WebApp.Persistence.Interface;
using WebApp.Persistence.Repository;

namespace WebApp.Application.Services;

public class EmployeeService : IEmployeeService

{
    List<EmployeeResponse> employeeResponse = new();

    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();

    }
    

    public bool AddEmployee(EmployeeRequest emp)
    {
        Employess newEmp = new();
        newEmp.Name=emp.Name;
        newEmp.Salary = 20000;
        employeeRepository.AddEmployee(newEmp);
        return true;
    }

    public IEnumerable<EmployeeResponse> GetAllEmployee()
    {   
        var employeelist=employeeRepository.GetAllEmployee();

        foreach (var emp in employeelist)
        {
            EmployeeResponse empResponse = new();

            empResponse.AnnualSalary = emp.Salary*12;

            empResponse.Name=$"EMP-{emp.Name}";

            empResponse.EmployeeId = emp.Id;

            employeeResponse.Add(empResponse);
        }

        return employeeResponse;
    }

    
}
