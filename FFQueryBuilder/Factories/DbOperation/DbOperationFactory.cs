using FFQueryBuilder;
using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
using FFQueryBuilder.Repository;

public class DbOperationFactory : ICreateFactory<DbOperation>
{
    private readonly DbContextFactory _contextFactory;
    private readonly IDbContextManager _contextManager;
    private readonly ICreateFactory<EntityManager> _entityManagerFactory;
    private readonly IReadableRepository _readableRepository;
    private readonly IWriteableRepository _writableRepository;

    public DbOperationFactory(
        DbContextFactory contextFactory, 
        IDbContextManager contextManager, 
        ICreateFactory<EntityManager> entityManagerFactory,
        IReadableRepository readableRepository, 
        IWriteableRepository writableRepository)
    {
        _contextFactory = contextFactory;
        _contextManager = contextManager;
        _entityManagerFactory = entityManagerFactory;
        _readableRepository = readableRepository;
        _writableRepository = writableRepository;
    }

    public DbOperation Create(string contextName, string entityName)
    {
        return new DbOperation(
            _contextFactory, 
            _contextManager, 
            _entityManagerFactory,
            _readableRepository, 
            _writableRepository, 
            contextName, 
            entityName);
    }
}
