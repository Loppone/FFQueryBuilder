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

            AddEntity(Context, Entity, values);
            Context.SaveChanges();

            //Reperisco il campo PK. In questa versione viene ritornato un object per un singolo valore di PK.
            //Per le tabelle fatte male con più campi di PK non torna la prima pk che trova.
            return _dbContextManager.PrimaryKeyValue(Context, values).Value;
        }

        private static void AddEntity<T>(DbContext db, DbSet<T> _, T entity) where T : class
        {
            var q = db.Set<T>()
                .Add(entity);
        }

        public dynamic Delete()
        {
            throw new System.NotImplementedException();
        }

        public dynamic Update(dynamic entity)
        {
            throw new System.NotImplementedException();
        }

        public int? Add(DbContext context, dynamic dbSet, dynamic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
