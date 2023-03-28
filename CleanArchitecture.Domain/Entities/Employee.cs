using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Shared;

namespace CleanArchitecture.Domain.Entities;

public class Employee: BaseEntity, IGenericEntity<Employee>
{
    public int Id { get; set; }
    public DateTime JoinDate { get; set; }
    public string Designation { get; set; }
    public Employee Update(Employee source)
    {
        this.Designation = source.Designation;
        return this;
    }
}