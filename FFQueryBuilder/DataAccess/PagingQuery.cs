using FFQueryBuilder.Context;
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
        private List<T> GetDataInternal<T>(DbContext db, DbSet<T> _, Paging page) where T : class
        {
            var q = db.Set<T>()
            .FilterBy(page.Filters)
            .Skip(page.CurrentPage)
            .Take(page.ItemPerPage);

            //var qs = q.ToQueryString();

            return q.ToList();
        }

        private static dynamic GetDbSet(DbContext context, string table)
        {
            var dbSet = context.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0])
                .FirstOrDefault(x=>x.Name == table);

            Type intenalType = typeof(InternalDbSet<>).MakeGenericType(dbSet);

            return Activator.CreateInstance(intenalType, context, dbSet.Name);
        }

        public dynamic GetData(string contextName, string tableName, Paging page)
        {
            var context = DbContextFactory.GetDbContext(contextName);
            var dbSet = GetDbSet(context, tableName);
            return GetDataInternal(context, dbSet, page);
        }
    }
}
