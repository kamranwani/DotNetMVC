using Microsoft.AspNetCore.Mvc;
using WebApp.Application.Abstraction;
using WebApp.Application.RRModels.Employee;
using WebApp.Application.Services;
using WebApp.Entities.Employees;
using WebApp.Models;

namespace WebApp.Controllers;

[Route("emps")]
public class EmployeeController : Controller
{
   readonly IEmployeeService EmpService;
    public EmployeeController(IEmployeeService EmpService)
    {
        this.EmpService = EmpService;
    }

    [Route("")]
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

    [Route("employee-list")]
    public async Task<ViewResult> Employees()
    {
        
        //try
        //{
            //EmployeeRequest newemp = new() { Name = "TempName" };

            //EmpService.AddEmployee(newemp);
            Console.WriteLine("i am triggered");

            var employeeList = await EmpService.GetAllEmployee();

            return View(employeeList);
        //}
        //catch (Exception ex)
        //{
        //    ViewBag.Error = "Something went wrong: " + ex.Message;
        //    return View("Error");
        //}
    }

    [HttpGet ("create")]
    public ViewResult CreateEmployee() { 
    return View();
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateEmployeePost([FromForm] EmployeeRequest model)
    {
        EmpService.AddEmployee(model);
        var employees=await EmpService.GetAllEmployee();
        return RedirectToAction("Employees");
    }

}


