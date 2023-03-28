using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Common.IService;

public interface IEmployeeService: IGetFromDb<Employee>, IAddToDb<Employee>, IUpdateEntity<Employee>
{
    
}