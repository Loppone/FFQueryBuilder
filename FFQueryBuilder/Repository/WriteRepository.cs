using Microsoft.EntityFrameworkCore;

namespace FFQueryBuilder.Repository
{
    public class WriteRepository : IWriteableRepository
    {
        public WriteRepository()
        {

        }

        public int? Add(DbContext context, dynamic dbSet, dynamic entity)
        {
            AddEntity(context,dbSet,entity);
            context.SaveChanges();

            return 0; // Per ora
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
    }
}
