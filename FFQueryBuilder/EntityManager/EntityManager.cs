using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    /// <summary>
    /// Classe di gestione delle entità (DbSet).
    public class EntityManager : IEntityManager
    {
        private readonly IDbContextManager _dbContextManager;
        private readonly DbContextFactory _dbContextFactory;
        private DbContext _context;
        private dynamic _entity;

        public EntityManager(IDbContextManager dbContextManager, DbContextFactory dbContextFactory)
        {
            _dbContextManager = dbContextManager;
            _dbContextFactory = dbContextFactory;
        }

        public DbContext Context
        {
            get { return _dbContextFactory.GetDbContext(ContextName); }
            set { _context = value; }
        }

        public dynamic Entity
        {
            get { return _dbContextManager.GetEntityFrameworkDbSet(Context, EntityName); }
            set { _entity = value; }
        }

        public dynamic EntityValues { get; set; }

        public string ContextName { get; set; }

        public string EntityName { get; set; }

        /// <summary>
        /// Crea un istanza di oggetto "EntityValues" di tipo dinamico a partire da un dizionario di proprietà coi relativi valori
        /// <param name="properties"></param>
        public void CreateEntityInstance(Dictionary<string, object> properties)
        {
            var builder = new EntityBuilderSerialization
            {
                EntityName = EntityName,
                SourceFields = properties
            };

            EntityValues = builder.Build();
        }
    }
}
