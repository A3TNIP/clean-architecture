using CleanArchitecture.Application.Common;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence;

public class ApplicationDbContext: DbContext, IApplicationDbContext
{
    private readonly IDateTime _dateTime;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTime dateTime) : base(options)
    {
        _dateTime = dateTime;
    }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<SalaryOrBonus> SalaryOrBonus { get; set; }
}