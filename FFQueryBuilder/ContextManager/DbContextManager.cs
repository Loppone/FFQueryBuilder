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
    /// <summary>
    /// Gestore dei DbContext. Contiene le informazioni di accesso al DbContext e ai suoi DbSet.
    /// </summary>
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

            var columns = context.Model.FindEntityType(internalEntityName)
                .GetProperties()
                .ToList();

            return AutoMapperSingleton.Instance.Mapper
                .Map<List<Microsoft.EntityFrameworkCore.Metadata.IProperty>, List<ModelInfo>>(columns);
        }

        public KeyValuePair<string,object> PrimaryKeyValue(DbContext context, dynamic entity)
        {
            var entityName = entity.GetType().Name;

            var internalEntityName = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == entityName);

            var pkColumn = context.Model.FindEntityType(internalEntityName)
                .GetProperties()
                .FirstOrDefault(x => x.IsPrimaryKey())
                .Name;

            var entVal = entity.GetType().GetProperty(pkColumn).GetValue(entity, null);
            var res = new KeyValuePair<string, object>(pkColumn, entVal);

            return res;
        }

        public dynamic GetEntityFrameworkDbSet(DbContext context, string table)
        {
            var dbSet = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == table);

            Type intenalType = typeof(InternalDbSet<>).MakeGenericType(dbSet);

            return Activator.CreateInstance(intenalType, context, dbSet.Name);
        }

        public dynamic GetInternalType(DbContext context, string table)
        {
            var dbSet = ConfiguredDbSets(context)
                .FirstOrDefault(x => x.Name == table);

            var obj = Activator.CreateInstance(dbSet.Assembly.GetName().Name, dbSet.FullName);

            return obj.Unwrap();
        }

        public IList<Type> ConfiguredDbSets(DbContext context)
        {
            return ConfiguredDbSetsQuery(context)
                .ToList();
        }
     
        /// <summary>
        /// Torna un DbSet<T> agganciato al contesto
        /// </summary>
        /// <typeparam name="T">tipo del DbSet</typeparam>
        /// <param name="contesto">Contesto</param>
        /// <param name="_">DbSet tipizzato, ma passato come dynamic</param>
        /// <returns></returns>
        public static DbSet<T> SetEntity<T>(DbContext contesto, DbSet<T> _) where T : class
        {
            return contesto.Set<T>();
        }

        private static IEnumerable<Type> ConfiguredDbSetsQuery(DbContext context)
        {
            return context.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0]);
        }

    }
}
