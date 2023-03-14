using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    public class EntityManager
    {
        private readonly IDbContextManager _dbContextManager;
        private readonly DbContextFactory _dbContextFactory;
        private string _contextName;
        private string _entityName;
        private DbContext _context;
        private dynamic _entity;

        public EntityManager(IDbContextManager dbContextManager, DbContextFactory dbContextFactory, string contextName, string entityName)
        {
            _dbContextManager = dbContextManager;
            _dbContextFactory = dbContextFactory;
            _contextName = contextName;
            _entityName = entityName;
        }

        public DbContext Context
        {
            get { return _dbContextFactory.GetDbContext(_contextName); }
            set { _context = value; }
        }

        public dynamic Entity
        {
            get { return _dbContextManager.GetEntityFrameworkDbSet(Context, _entityName); }
            set { _entity = value; }
        }

        public dynamic EntityValues { get; set; }

        public void CreateEntityInstance(Dictionary<string, object> properties)
        {
            var builder = new EntityBuilderSerialization
            {
                EntityName = _entityName,
                SourceFields = properties
            };

            EntityValues = builder.Build();
        }
    }
}
