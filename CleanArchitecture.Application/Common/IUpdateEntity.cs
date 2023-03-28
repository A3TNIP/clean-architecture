namespace CleanArchitecture.Application.Common;

public interface IUpdateEntity<T>
{
    T Update(T entity, int id);
}