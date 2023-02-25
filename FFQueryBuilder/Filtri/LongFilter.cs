using System;

namespace FFQueryBuilder
{
    internal class LongFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(long))) || (TypeOfValue.Equals(typeof(long?)));
        }

        public object GetValue(string value)
        {
            return long.Parse(value);
        }
    }
}