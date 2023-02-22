using System;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class GreaterThanOrEqualComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.MaggioreUguale;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.GreaterThanOrEqual(expression, Expression.Constant(value, expression.Type));
        }
    }
}
