using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    public class EntityManager
    {
        public EntityManager(string contextName, string entityName)
        {
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
            var builder = new EntityBuilderSerialization();
            builder.EntityName = EntityName;
            builder.SourceFields = properties;

            EntityValues = builder.Build();

            Context = DbContextFactory.Instance.GetDbContext(ContextName);
            Entity = DbContextHelper.GetDbSet(Context, EntityName);
        }
    }
}
