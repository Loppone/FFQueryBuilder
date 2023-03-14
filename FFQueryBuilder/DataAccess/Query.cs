using Microsoft.EntityFrameworkCore;

namespace FFQueryBuilder.DataAccess
{
    public static class Query
    {
        /// <summary>
        /// Ricerca un record data la sua PK
        /// <remarks>Non può essere trasformato in Extension Method perchè i tipi dinamici non sono supportati</remarks>
        public static T GetById<T>(DbContext db, DbSet<T> _, string pk, object id) where T : class
        {
            return db.Set<T>()
                .FirstOrDefaultByIdPrimaryKey(pk, id);
        }
    }
}
