using FFQueryBuilder;

public interface ICreateFactory<T>
{
    T Create(string contextName, string entityName);
}
