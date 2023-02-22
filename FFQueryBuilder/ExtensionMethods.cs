using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    public static class FFQueryBuilderExtensionMethods
    {
        public static IQueryable<T> FilterBy<T>(this IQueryable<T> query, List<FilterItem> filters) where T : class
        {
            if (filters == null || filters.Count == 0)
                return query;

            foreach (var item in filters)
            {
                // NOTA: il valore passato può essere null. Ad esempio quando si filtra con IS NULL/IS NOT NULL
                if (!string.IsNullOrEmpty(item.Field))
                {
                    var param = Expression.Parameter(typeof(T), "x");
                    var prop = Expression.PropertyOrField(param, item.Field);
                    var valueType = prop.Type;

                    var filterHandlers = FilterFactory.CreateFilters();
                    var filterHandler = filterHandlers.FirstOrDefault(x => x.CanHandle(valueType));
                    var value = filterHandler.GetValue(item.Value);

                    var conditionOperatorHandlers = ConditionOperatorFactory.CreateConditionOperators(item.Operator);
                    var conditionOperatorHandler = conditionOperatorHandlers.Get(prop, value);

                    var lambda = Expression.Lambda<Func<T, bool>>(conditionOperatorHandler, param);

                    return query.Where(lambda);
                }
            }

            return query;
        }
    }
}