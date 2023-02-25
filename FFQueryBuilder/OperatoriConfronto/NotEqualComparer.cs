using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class NotEqualComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.Diverso;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.NotEqual(expression, Expression.Constant(value, expression.Type));
        }
    }
}

