using CleanArchitecture.Application.Common.IService;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Services;

public class EmployeeService: IEmployeeService
{
    private readonly ApplicationDbContext _context;
    
    public EmployeeService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<List<Employee>> GetAll()
    {
        return _context.Set<Employee>().ToListAsync();
    }

    public async Task<Employee> GetById(int id)
    {
        return await _context.Set<Employee>().FindAsync(id);
    }

    public Employee Add(Employee entity)
    {
        var dbInstance = _context.Set<Employee>().Add(entity).Entity;
        _context.SaveChanges();
        return dbInstance;
    }

    public Employee Update(Employee entity, int id)
    {
        // Find entity by id
        var dbInstance = _context.Set<Employee>().Find(id);
        
        // Set the entity as the new entity
        dbInstance.Update(entity);
        _context.Set<Employee>().Update(dbInstance);
        
        // Save changes
        _context.SaveChanges();
        return entity;
    }
}