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
    

     readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;

    }
    

    public bool AddEmployee(EmployeeRequest emp)
    {
        Employess newEmp = new();
        newEmp.FullName=emp.Name;
        newEmp.Salary = 20000;
        employeeRepository.AddEmployee(newEmp);
        return true;
    }

    public async Task<IEnumerable<EmployeeResponse>> GetAllEmployee()
    {   
        var employeelist= await employeeRepository.GetAllEmployee();
        List<EmployeeResponse> employeeResponse = new();

        foreach (var emp in employeelist)
        {
            EmployeeResponse empResponse = new();

            empResponse.AnnualSalary = emp.Salary*12;

            empResponse.Name=$"EMP-{emp.FullName}";

            empResponse.EmployeeId = emp.EmpID;

            employeeResponse.Add(empResponse);
        }

        return employeeResponse;
    }

    
}
