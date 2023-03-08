using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace FFQueryBuilder
{
    internal static class DbContextExtensionMethods
    {
        internal static dynamic GetDbSet(DbContext context, string table)
        {
            var dbSet = context.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0])
                .FirstOrDefault(x => x.Name == table);

            Type intenalType = typeof(InternalDbSet<>).MakeGenericType(dbSet);

            return Activator.CreateInstance(intenalType, context, dbSet.Name);
        }
    }
}
