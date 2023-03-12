using FFQueryBuilder.Context;
using FFQueryBuilder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder.DataAccess
{
    public class PagingQuery : IPaging
    {
        private readonly DbContextFactory _dbContextFactory;

        public PagingQuery(DbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        public dynamic GetData(string contextName, string tableName, Paging page)
        {
            var context = _dbContextFactory.GetDbContext(contextName);

            // TODO
            // Invertire la dipendenza o spostare GetDbSet

            var dm = new DbContextManager(_dbContextFactory);

            var dbSet = dm.GetDbSet(context, tableName);
            return GetDataInternal(context, dbSet, page);
        }

        private List<T> GetDataInternal<T>(DbContext db, DbSet<T> _, Paging page) where T : class
        {
            var q = db.Set<T>()
            .FilterBy(page.Filters)
            .Skip(page.CurrentPage - 1)
            .Take(page.ItemPerPage);

            var qr = q.ToQueryString();

            return q.ToList();
        }
    }
}
