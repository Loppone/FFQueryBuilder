using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class GreaterThanComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.Maggiore;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.GreaterThan(expression, Expression.Constant(value, expression.Type));
        }
    }
}
