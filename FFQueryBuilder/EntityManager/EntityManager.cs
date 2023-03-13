using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    public class EntityManager
    {
        private readonly IDbContextManager _dbContextManager;
        private readonly DbContextFactory _dbContextFactory;

        public EntityManager(IDbContextManager dbContextManager, DbContextFactory dbContextFactory, string contextName, string entityName)
        {
            _dbContextManager = dbContextManager;
            _dbContextFactory = dbContextFactory;
            ContextName = contextName;
            EntityName = entityName;
        }

        public string ContextName { get; }
        public string EntityName { get; }
        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }
        public dynamic EntityValues { get; set; }

        public void CreateEntityInstance(Dictionary<string, object> properties)
        {
            var builder = new EntityBuilderSerialization
            {
                EntityName = EntityName,
                SourceFields = properties
            };

            EntityValues = builder.Build();

            Context = _dbContextFactory.GetDbContext(ContextName);

            Entity = _dbContextManager.GetDbSet(Context, EntityName);
        }
    }
}
