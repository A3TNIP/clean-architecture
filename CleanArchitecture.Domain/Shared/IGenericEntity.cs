namespace CleanArchitecture.Domain.Shared;

public interface IGenericEntity<T>
{
    T Update(T source);
}