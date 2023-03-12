using FF3DContexts.OracleModels;
using FF3DContexts.SqlModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.Context
{
    public class DbContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DbContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public DbContext GetDbContext(string contextName)
        {
            return contextName switch
            {
                "SqlServer" => _serviceProvider.GetService<FORNITORIContext>(),
                "Oracle" => _serviceProvider.GetService<ModelContext>(),
                _ => throw new ArgumentException($"Contesto '{contextName}' non trovato"),
            };
        }

        internal IDictionary<string, DbContext> GetAll()
        {
            return new Dictionary<string, DbContext>()
            {
                { "SqlServer", _serviceProvider.GetService<FORNITORIContext>() },
                { "Oracle", _serviceProvider.GetService<ModelContext>() }
            };
        }
    }
}
