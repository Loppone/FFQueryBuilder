﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.Context
{
    public class DbContextFactory
    {
        private static readonly Lazy<DbContextFactory> _lazy = new Lazy<DbContextFactory>(() => new DbContextFactory());
        private static readonly IDictionary<string, DbContext> _dbContexts = new Dictionary<string, DbContext>();

        public static DbContextFactory Instance => _lazy.Value;

        private DbContextFactory()
        {
        }

        public DbContext GetDbContext(string databaseAlias)
        {
            if (!_dbContexts.TryGetValue(databaseAlias, out DbContext dbContext))
            {
                throw new ArgumentException($"Database alias '{databaseAlias}' non riconosciuto.");
            }

            return dbContext;
        }

        public IDictionary<string, DbContext> AddDbContext(string dbContextName, DbContext context)
        {
            if (_dbContexts.ContainsKey(dbContextName))
            {
                throw new ArgumentException($"Database '{dbContextName}' già presente.");
            }

            _dbContexts.Add(new KeyValuePair<string, DbContext>(dbContextName, context));

            return _dbContexts;
        }

        internal IDictionary<string, DbContext> GetAll()
        {
            return _dbContexts;
        }
    }
}