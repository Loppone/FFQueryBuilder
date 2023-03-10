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
    public static class DbContextHelper
    {
        public static IEnumerable<ConfiguredContexts> GetConfiguredContexts()
        {
            var configuration = new List<ConfiguredContexts>();

            var contexts = DbContextFactory.Instance.GetAll();

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

        public static IEnumerable<ModelInfo> EntityInformation(string contextName, string entityName)
        {
            var context = DbContextFactory.Instance.GetDbContext(contextName);

            var internalEntityName = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == entityName);

            var columns = context.Model.FindEntityType(internalEntityName).GetProperties().ToList();

            return AutoMapperSingleton.Instance.Mapper
                .Map<List<Microsoft.EntityFrameworkCore.Metadata.IProperty>, List<ModelInfo>>(columns);
        }

        internal static dynamic GetDbSet(DbContext context, string table)
        {
            var dbSet = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == table);

            Type intenalType = typeof(InternalDbSet<>).MakeGenericType(dbSet);

            return Activator.CreateInstance(intenalType, context, dbSet.Name);
        }

        internal static dynamic GetDbSet(string contextName, string entityName)
        {
            var context = DbContextFactory.Instance.GetDbContext(contextName);

            return GetDbSet(context, entityName);
        }

        internal static dynamic GetEntity(string contextName, string entityName)
        {
            var dbSet = GetDbSet(contextName, entityName);
            
            return dbSet.FullName;
        }

        private static IList<Type> ConfiguredDbSets(DbContext context)
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
}
