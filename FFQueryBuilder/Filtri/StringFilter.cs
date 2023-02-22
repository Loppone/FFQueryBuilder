using System;

namespace FFQueryBuilder
{
    internal class StringFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return TypeOfValue.Equals(typeof(string));
        }

        public object GetValue(string value)
        {
            return value;
        }
    }
}