using System;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal interface IComparisonOperator
    {
        CompareOperator Operator { get; }
        Expression Get(Expression expression, object value);
    }
}
