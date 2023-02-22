using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class IsNotNullComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.IsNotNull;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.NotEqual(Expression.Property(expression, "prop"), Expression.Constant(null, expression.Type));
        }
    }
}
