using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common;

public interface IApplicationDbContext
{
    DbSet<Employee> Employee { get; }
    DbSet<Department> Department { get; }
    DbSet<SalaryOrBonus> SalaryOrBonus { get; }
}