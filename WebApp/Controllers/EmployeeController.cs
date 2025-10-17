using Microsoft.AspNetCore.Mvc;
using WebApp.Application.Abstraction;
using WebApp.Application.Services;
using WebApp.Entities.Employees;
using WebApp.Models;

namespace WebApp.Controllers;

public class EmployeeController : Controller
{
    public ViewResult Index()
    {
        Employee employee1 = new()
        {
            Name="Kamran",
            EmployeeId= 1,
            Password="Kammy"
        };
        Employee employee2 = new()
        {
            Name = "Aqib",
            EmployeeId = 2,
            Password = "Aqi"
        };

        Employee employee3 = new()
        {
            Name = "Amaan",
            EmployeeId = 3,
            Password = "Ammu"
        };


        List<Employee> employees = new() {
           employee1,
           employee2, 
           employee3
        };

        ViewBag.EmployeeList=employees;

        return View();
    }

    public ViewResult Employees()
    {
        IEmployeeService EmpService = new EmployeeService();

        Employess newemp = new() { Id = 4, Name = "TempName", Salary = 90000 };

        EmpService.AddEmployee(newemp);

        var employeeList = EmpService.GetAllEmployee();

        return View(employeeList);
    }
}
