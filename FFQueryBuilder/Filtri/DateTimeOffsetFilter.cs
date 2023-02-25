using System;

namespace FFQueryBuilder
{
    internal class DateTimeOffsetFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(DateTimeOffset))) || (TypeOfValue.Equals(typeof(DateTimeOffset?)));
        }

        public object GetValue(string value)
        {
            return DateTimeOffset.Parse(value);
        }
    }

}