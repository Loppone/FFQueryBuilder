﻿using System;
using System.Linq.Expressions;

namespace FFQueryBuilder
{
    internal class LessThanComparer : IComparisonOperator
    {
        public CompareOperator Operator
        {
            get
            {
                return CompareOperator.Minore;
            }
        }

        public Expression Get(Expression expression, object value)
        {
            return Expression.LessThan(expression, Expression.Constant(value, expression.Type));
        }
    }
}
