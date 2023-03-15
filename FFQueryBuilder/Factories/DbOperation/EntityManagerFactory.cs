using FFQueryBuilder;
using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;

public class EntityManagerFactory : ICreateFactory<EntityManager>
{
    private readonly IDbContextManager _dbContextManager;
    private readonly DbContextFactory _dbContextFactory;

    public EntityManagerFactory(
        IDbContextManager dbContextManager, 
        DbContextFactory dbContextFactory
        )
    {
        _dbContextManager = dbContextManager;
        _dbContextFactory = dbContextFactory;
    }

    public EntityManager Create(string contextName, string entityName)
    {
        var instance = new EntityManager(
            _dbContextManager,
            _dbContextFactory);

        instance.ContextName = contextName;
        instance.EntityName = entityName;

        return instance;
    }
}
