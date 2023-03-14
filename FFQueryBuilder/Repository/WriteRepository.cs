using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.Repository
{
    public class WriteRepository : IWriteableRepository
    {
        private readonly IDbContextManager _dbContextManager;
        private readonly IReadableRepository _readableRepository;

        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }
        public string ContextName { get; set; }
        public string EntityName { get; set; }

        public WriteRepository(IDbContextManager dbContextManager, IReadableRepository readableRepository)
        {
            _dbContextManager = dbContextManager;
            _readableRepository = readableRepository;
        }

        public object Add(dynamic values)
        {
            // TODO: validazione Context e Entity

            DbContextManager.SetEntity(Context, Entity)
                .Add(values);

            Context.SaveChanges();

            // Reperisco il campo PK. In questa versione viene ritornato un object per un singolo valore di PK.
            // Per le tabelle fatte male con più campi di PK non torna la prima pk che trova.
            // Andrebbe considerato di non trattare le anagrafiche con pk multipla e meglio se con id numerico
            return _dbContextManager.PrimaryKeyValue(Context, values).Value;
        }

        public dynamic Delete(object id)
        {
            Initialize();

            // Get della riga
            dynamic entityToRemove = _readableRepository.GetById(id);

            if (entityToRemove == null)
            {
                return null; // TODO: Per ora torno null quando non viene trovato il record
            }

            // Delete
            DbContextManager.SetEntity(Context, Entity)
                .Remove(entityToRemove);

            Context.SaveChanges();

            return entityToRemove;
        }

        private void Initialize()
        {
            _readableRepository.ContextName = ContextName;
            _readableRepository.EntityName = EntityName;

            if (Context != null)
                _readableRepository.Context = Context;

            if (Entity != null)
                _readableRepository.Entity = Entity;
        }

        public dynamic Update(dynamic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
