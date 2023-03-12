using FFQueryBuilder.Context;
using FFQueryBuilder.Factories.Singleton;
using FFQueryBuilder.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder
{
    public class DbContextManager : IDbContextManager
    {
        private readonly DbContextFactory _dbContextFactory;

        public DbContextManager(DbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public IEnumerable<ConfiguredContexts> GetConfiguredContexts()
        {
            var configuration = new List<ConfiguredContexts>();

            var contexts = _dbContextFactory.GetAll();

            foreach (var context in contexts)
            {
                var dbSets = ConfiguredDbSets(contexts.FirstOrDefault(x => x.Key == context.Key).Value);

                configuration.Add(new ConfiguredContexts
                {
                    ContextName = context.Key,
                    Entities = dbSets.Select(x => x.Name)
                });
            }

            return configuration;
        }

        public IEnumerable<ModelInfo> EntityInformation(string contextName, string entityName)
        {
            var context = _dbContextFactory.GetDbContext(contextName);

            var internalEntityName = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == entityName);

            var columns = context.Model.FindEntityType(internalEntityName).GetProperties().ToList();

            return AutoMapperSingleton.Instance.Mapper
                .Map<List<Microsoft.EntityFrameworkCore.Metadata.IProperty>, List<ModelInfo>>(columns);
        }

        internal dynamic GetDbSet(DbContext context, string table)
        {
            var dbSet = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == table);

            Type intenalType = typeof(InternalDbSet<>).MakeGenericType(dbSet);

            return Activator.CreateInstance(intenalType, context, dbSet.Name);
        }

        internal dynamic GetDbSet(string contextName, string entityName)
        {
            var context = _dbContextFactory.GetDbContext(contextName);

            return GetDbSet(context, entityName);
        }

        internal dynamic GetEntity(string contextName, string entityName)
        {
            var dbSet = GetDbSet(contextName, entityName);
            
            return dbSet.FullName;
        }

        public IList<Type> ConfiguredDbSets(DbContext context)
        {
            return ConfiguredDbSetsQuery(context)
                .ToList();
        }

        private static IEnumerable<Type> ConfiguredDbSetsQuery(DbContext context)
        {
            return context.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0]);
        }
    }

    public interface IDbContextManager
    {
        IEnumerable<ConfiguredContexts> GetConfiguredContexts();
        IEnumerable<ModelInfo> EntityInformation(string contextName, string entityName);
      //  IList<Type> ConfiguredDbSets(DbContext context);
    }
}
