using Microsoft.EntityFrameworkCore;
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

            foreach (var filter in filters)
            {
                // NOTA: il valore passato può essere null. Ad esempio quando si filtra con IS NULL/IS NOT NULL
                if (!string.IsNullOrEmpty(filter.Field))
                {
                    var param = Expression.Parameter(typeof(T), "x");
                    var prop = Expression.PropertyOrField(param, filter.Field);

                    var filterHandler = FilterFactory.CreateFilters(prop.Type);
                    var value = filterHandler.GetValue(filter.Value);

                    var conditionOperatorHandler = ConditionOperatorFactory.CreateConditionOperators(filter.Operator);
                    var @operator = conditionOperatorHandler.Get(prop, value);

                    var lambda = Expression.Lambda<Func<T, bool>>(@operator, param);

                    query = query.Where(lambda);
                }
            }

            return query;
        }

        public static T FirstOrDefaultByIdPrimaryKey<T>(this IQueryable<T> query, string propertyName, object propertyValue) where T : class
        {
            if (!string.IsNullOrEmpty(propertyName))
            {
                var param = Expression.Parameter(typeof(T), "x");
                var prop = Expression.PropertyOrField(param, propertyName);

                var filterHandler = FilterFactory.CreateFilters(prop.Type);
                var value = filterHandler.GetValue(propertyValue.ToString());

                var conditionOperatorHandler = ConditionOperatorFactory.CreateConditionOperators(CompareOperator.Uguale);
                var @operator = conditionOperatorHandler.Get(prop, value);

                var lambda = Expression.Lambda<Func<T, bool>>(@operator, param);

                return query.FirstOrDefault(lambda);
            }

            return null;
        }

        public static IQueryable<T> OrderByField<T>(this IQueryable<T> query, OrderItem order)
        {
            if (order == null || string.IsNullOrEmpty(order.Field))
                return query;

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, order.Field);
            var lambda = Expression.Lambda(property, parameter);
            var isDescending = order.TypeOfOrder == OrderType.Discendente;

            string methodName = isDescending ? "OrderByDescending" : "OrderBy";

            var resultExpression = Expression.Call(
                typeof(Queryable),
                methodName,
                new[] { typeof(T), property.Type },
                query.Expression,
                Expression.Quote(lambda)
            );

            return query.Provider.CreateQuery<T>(resultExpression);
        }
    }
}