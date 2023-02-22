using System;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class EqualComparer : IComparisonOperator
    {
        public CompareOperator Operator 
        { 
            get 
            { 
                return CompareOperator.Uguale; 
            } 
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.Equal(expression, Expression.Constant(value, expression.Type));
        }
    }
}
