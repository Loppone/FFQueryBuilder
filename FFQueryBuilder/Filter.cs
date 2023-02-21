using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    public static class Filter
    {
        public static IQueryable<T> FilterBy<T>(this IQueryable<T> query, List<FilterItem> filters) where T : class
        {
            if (filters == null || filters.Count == 0)
                return query;

            foreach (var item in filters)
            {
                if (!string.IsNullOrEmpty(item.Field) && !string.IsNullOrEmpty(item.Value))
                {
                    var param = Expression.Parameter(typeof(T), "x");
                    var prop = Expression.PropertyOrField(param, item.Field);
                    var valueType = prop.Type;

                    var filterHandlers = FilterFactory.CreateFilters();
                    var filterHandler = filterHandlers.FirstOrDefault(x => x.CanHandle(valueType));

                    var value = filterHandler.GetValue(item.Value);
                    var condition = Expression.Equal(prop, Expression.Constant(value, valueType));

                    var lambda = Expression.Lambda<Func<T, bool>>(condition, param);

                    return query.Where(lambda);
                }
            }

            return query;
        }
    }
}



//object value;

//if (valueType == typeof(DateTime) || valueType == typeof(DateTime?))
//{
//    value = DateTime.Parse(item.Value);
//}
//else if (valueType == typeof(int))
//{
//    value = int.Parse(item.Value);
//}
//else if (valueType == typeof(string))
//{
//    value = item.Value;
//}
//else
//{
//    // Aggiungere altre conversioni a seconda dei tipi di proprietà supportati
//    throw new NotSupportedException($"Il tipo di proprietà {valueType.Name} non è supportato.");
//}

// var condition = Expression.Equal(prop, Expression.Constant(Convert.ChangeType(item.Valore, valueType), valueType));
