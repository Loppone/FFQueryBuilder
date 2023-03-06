﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.Factories.Contexts
{
    internal interface IDbContextFactory
    {
        DbContext CreateDbContext(string dbContextName);
    }

    public class DbContextFactory : IDbContextFactory
    {
        private readonly IDictionary<string, DbContext> _dbContexts;

        private static readonly Lazy<DbContextFactory> _lazyInstance = 
            new Lazy<DbContextFactory>(() => new DbContextFactory());

        public static DbContextFactory Instance => _lazyInstance.Value;

        private DbContextFactory()
        {
            _dbContexts = new Dictionary<string, DbContext>
            {
                //{ "Oracle", new MyDbContextOracle() },
                //{ "SqlServer", new MyDbContextSqlServer() }
                // Aggiungi qui altri DbContext con i rispettivi alias
            };
        }

        public DbContext CreateDbContext(string databaseAlias)
        {
            if (!_dbContexts.TryGetValue(databaseAlias, out DbContext dbContext))
            {
                throw new ArgumentException($"Database alias '{databaseAlias}' non riconosciuto.");
            }

            return dbContext;
        }
    }
}