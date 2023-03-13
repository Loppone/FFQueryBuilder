using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.Repository
{
    public class WriteRepository : IWriteableRepository
    {
        private readonly IDbContextManager _dbContextManager;

        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }

        public WriteRepository(IDbContextManager dbContextManager)
        {
            _dbContextManager = dbContextManager;
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
            throw new System.NotImplementedException();
        }

        public dynamic Update(dynamic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
