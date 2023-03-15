using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
using FFQueryBuilder.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder
{
    /// <summary>
    /// Classe di Business per le operazioni di alto livello esposte al client
    /// <remarks>Tutte le operazioni di business sul database passano da qua</remarks>
    public class DbOperation
    {
        private readonly string _contextName;
        private readonly string _entityName;

        private readonly DbContextFactory _contextFactory;
        private readonly IDbContextManager _contextManager;
        private readonly ICreateFactory<EntityManager> _entityManagerFactory;
        private readonly IReadableRepository _readableRepository;
        private readonly IWriteableRepository _writeableRepository;
        private readonly EntityManager _entityManagerInstance;

        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }

        /// <summary>
        /// Inizializza le proprietà e crea un'istanza di EntityManager (quindi con i riferimenti di DbContext e DbSet)
        /// </summary>
        /// <param name="contextName"></param>
        /// <param name="entityName"></param>
        public DbOperation(
            DbContextFactory contextFactory,
            IDbContextManager contextManager,
            ICreateFactory<EntityManager> entityManagerFactory,
            IReadableRepository readableRepository,
            IWriteableRepository writableRepository,
            string contextName, 
            string entityName)
        {
            _contextFactory = contextFactory;
            _contextManager = contextManager;
            _entityManagerFactory = entityManagerFactory;
            _readableRepository = readableRepository;
            _writeableRepository = writableRepository; 
            _contextName = contextName;
            _entityName = entityName;
            
            _entityManagerInstance = _entityManagerFactory.Create(_contextName, _entityName);
        }

        public dynamic FirstByFilters(Dictionary<string, object> filter)
        {
            _readableRepository.Context = _entityManagerInstance.Context;
            _readableRepository.Entity = _entityManagerInstance.Entity;
            _readableRepository.ContextName = _contextName;
            _readableRepository.EntityName = _entityName;

            var data = _readableRepository.First(filter);

            if (data == null)
                return null;

            var dynMap = new DynamicMapper(_contextManager);
            var map = dynMap.Map(data, _entityManagerInstance.Context, _entityManagerInstance.Entity, _contextName, _entityName);

            return map;
        }

        public object Add(Dictionary<string, object> row)
        {
            _entityManagerInstance.CreateEntityInstance(row);

            _writeableRepository.Context = _entityManagerInstance.Context;
            _writeableRepository.Entity = _entityManagerInstance.Entity;

            return _writeableRepository.Add(_entityManagerInstance.EntityValues);
        }

        public dynamic Delete(Dictionary<string, object> row)
        {
            _writeableRepository.Context = _entityManagerInstance.Context;
            _writeableRepository.Entity = _entityManagerInstance.Entity;
            _writeableRepository.ContextName = _contextName;
            _writeableRepository.EntityName = _entityName;

            var deletedEntity = _writeableRepository.Delete(row);

            if (deletedEntity == null)
                throw new Exception("Impossibile eliminare il record");

            var dynMap = new DynamicMapper(_contextManager);
            var map = dynMap.Map(deletedEntity, _entityManagerInstance.Context, _entityManagerInstance.Entity, _contextName, _entityName);

            return map;
        }
    }
}
