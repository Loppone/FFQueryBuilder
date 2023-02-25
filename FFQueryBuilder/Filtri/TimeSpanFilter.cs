using System;

namespace FFQueryBuilder
{
    internal class TimeSpanFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(TimeSpan))) || (TypeOfValue.Equals(typeof(TimeSpan?)));
        }

        public object GetValue(string value)
        {
            return TimeSpan.Parse(value);
        }
    }
}