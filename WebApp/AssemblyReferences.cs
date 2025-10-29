using WebApp.Application;
using WebApp.Persistence;
namespace WebApp;

public static class AssemblyReferences
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddApplicationServices();
        services.AddPersistenceServices();
        return services;
    }
}
