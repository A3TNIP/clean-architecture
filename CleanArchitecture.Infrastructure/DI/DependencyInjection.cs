using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Common.IService;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient);

        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        services.AddTransient<IDateTime, DateTimeService>();
        services.AddTransient<IEmployeeService, EmployeeService>();
        
        return services;
    }
}