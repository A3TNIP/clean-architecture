using CleanArchitecture.Application.Common.IService;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers;
[ApiController]
[Route("Api/[controller]")]
public class EmployeeController:ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<List<Employee>> List()
    {
        return await _employeeService.GetAll();
    }

    [HttpGet("{id}")]
    public async Task<Employee> GetOne(int id)
    {
        return await _employeeService.GetById(id);
    }

    [HttpPost]
    public Employee Save(Employee employee)
    {
        return _employeeService.Add(employee);
    }
    
    [HttpPut("{id}")]
    public Employee Update(Employee employee, int id)
    {
        return _employeeService.Update(employee, id);
    }
}