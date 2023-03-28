using CleanArchitecture.Domain.Shared;

namespace CleanArchitecture.Domain.Entities;

public class SalaryOrBonus: BaseEntity
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public bool IsAnnual { get; set; }
}