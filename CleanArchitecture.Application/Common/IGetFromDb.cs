namespace CleanArchitecture.Application.Common;

public interface IGetFromDb<T>
{
    public Task<List<T>> GetAll();
    public Task<T> GetById(int id);
}