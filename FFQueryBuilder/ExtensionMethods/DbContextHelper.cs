using AutoMapper;
using AutoMapper.QueryableExtensions;
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

            var r = DbContextFactory.GetAll();

            foreach (var context in r)
            {
                var dbSets = ConfiguredDbSets(r.FirstOrDefault(x => x.Key == context.Key).Value);

                configuration.Add(new ConfiguredContexts
                {
                    ContextName = context.Key,
                    Entities = dbSets.Select(x => x.Name),
                    InternalEntitiesNames = SetInternalDbSetNames(dbSets)
                });
            }

            return configuration;
        }
        
        public static List<ModelInfo> EntityInformation(string contextName, string entityName)
        {
            var context = DbContextFactory.GetDbContext(contextName);
            var columns = context.Model.FindEntityType(entityName).GetProperties().ToList();

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
        
        private static Dictionary<string, string> SetInternalDbSetNames(IList<Type> dbSets)
        {
            var internalNames = new Dictionary<string, string>();

            foreach (var dbSet in dbSets)
            {
                internalNames.Add(dbSet.Name, dbSet.FullName);
            }

            return internalNames;
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
