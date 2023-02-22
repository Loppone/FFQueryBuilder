using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class IsNullComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.IsNull;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.Equal(expression, Expression.Constant(null, expression.Type));
        }
    }
}
