using FFQueryBuilder.Context;
using FFQueryBuilder.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder.DataAccess
{
    public class PagingQuery : IPaging
    {
        public dynamic GetData(string contextName, string tableName, Paging page)
        {
            var context = DbContextFactory.GetDbContext(contextName);
            var dbSet = DbContextExtensionMethods.GetDbSet(context, tableName);
            return GetDataInternal(context, dbSet, page);
        }

        private List<T> GetDataInternal<T>(DbContext db, DbSet<T> _, Paging page) where T : class
        {
            var q = db.Set<T>()
            .FilterBy(page.Filters)
            .Skip(page.CurrentPage)
            .Take(page.ItemPerPage);

            return q.ToList();
        }
    }
}
