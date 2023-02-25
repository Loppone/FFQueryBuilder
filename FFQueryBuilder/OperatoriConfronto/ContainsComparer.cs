using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class ContainsComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.Contiene;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            var methodInfo = typeof(string).GetMethod("Contains", new[] { typeof(string) });

            return Expression.Call(expression, methodInfo, Expression.Constant(value, expression.Type));

        }
    }
}


