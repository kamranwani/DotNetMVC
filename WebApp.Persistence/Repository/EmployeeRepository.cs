using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entities.Employees;
using WebApp.Persistence.Interface;

namespace WebApp.Persistence.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private string ConnectionDB = "Server=.\\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";


    public EmployeeRepository()
    {
    }
    public bool AddEmployee(Employess emp)
    { 

        return true;

    }

    public async Task<IEnumerable<Employess>> GetAllEmployee()
    {
        using SqlConnection con = new SqlConnection(ConnectionDB);
        //con.Open();
        SqlCommand cmd = new SqlCommand("Select * from Employees");
        SqlDataReader rdr=await cmd.ExecuteReaderAsync();
        List < Employess > employees= new List<Employess>();
        Employess emp;
        while (await rdr.ReadAsync()) {
            emp = new Employess();
            emp.EmpID = Convert.ToInt32(rdr[0]);
            emp.FullName= Convert.ToString(rdr[1]);
            emp.Email = Convert.ToString(rdr[2]);
            emp.Department = Convert.ToString(rdr[3]);
            emp.Salary = Convert.ToDecimal(rdr[4]);

            employees.Add(emp);
        }
        return employees;
    }
}
