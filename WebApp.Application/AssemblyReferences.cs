using Microsoft.Extensions.DependencyInjection;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using WebApp.Application.Abstraction;
using WebApp.Application.Services;

namespace WebApp.Application;

public static class AssemblyReferences
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        return services;
    }
}
