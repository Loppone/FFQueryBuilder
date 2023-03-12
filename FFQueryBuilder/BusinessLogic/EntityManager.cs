using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    public class EntityManager
    {
        private readonly DbContextFactory _dbContextFactory;

        public EntityManager(DbContextFactory dbContextFactory, string contextName, string entityName)
        {
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

            // TODO
            // Invertire la dipendenza o spostare GetDbSet
            var cm = new DbContextManager(_dbContextFactory);

            Entity = cm.GetDbSet(Context, EntityName);
        }
    }
}
