using FFQueryBuilder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder.DataAccess
{
    public class PagingQuery : IPaging
    {
        public dynamic GetData(DbContext db, List<Type> tipi, string tabella, Paging page)
        {
            var dbSet = GetDbSet(db, tipi, tabella);
            return GetDataInternal(db, dbSet, page);
        }

        private List<T> GetDataInternal<T>(DbContext db, DbSet<T> _, Paging page) where T : class
        {
            var q = db.Set<T>()
            .FilterBy(page.Filters)
            .Skip(page.CurrentPage)
            .Take(page.ItemPerPage);

            var qs = q.ToQueryString();

            return q.ToList();
        }

        private static dynamic GetDbSet(DbContext context, List<Type> entities, string tabella)
        {
            var entityType = entities.FirstOrDefault(x => x.Name.Contains(tabella));
            Type tipoInternoEFForSql0 = typeof(InternalDbSet<>).MakeGenericType(entityType);
            return Activator.CreateInstance(tipoInternoEFForSql0, context, entityType.Name);
        }
    }
}
