using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder.Context
{
    //public interface IDbContextFactory
    //{
    //    DbContext GetDbContext(string dbContextName);
    //    void AddDbContext(string dbContextName, DbContext context);
    //}

    public class DbContextFactory 
    {
        private static readonly IDictionary<string, DbContext> _dbContexts = new Dictionary<string,DbContext>();

        private DbContextFactory()
        {
        }

        public static DbContext GetDbContext(string databaseAlias)
        {
            if (!_dbContexts.TryGetValue(databaseAlias, out DbContext dbContext))
            {
                throw new ArgumentException($"Database alias '{databaseAlias}' non riconosciuto.");
            }

            return dbContext;
        }

        public static IDictionary<string, DbContext> AddDbContext(string dbContextName, DbContext context)
        {
            if (_dbContexts.ContainsKey(dbContextName))
            {
                throw new ArgumentException($"Database '{dbContextName}' già presente.");
            }

            _dbContexts.Add(new KeyValuePair<string, DbContext>(dbContextName, context));

            return _dbContexts;
        }
    }
}