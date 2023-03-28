namespace CleanArchitecture.Application.Common;

public interface IAddToDb<T>
{
    public T Add(T entity);
}