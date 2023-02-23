using System;

namespace FFQueryBuilder
{
    internal class ShortFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(short))) || (TypeOfValue.Equals(typeof(short?)));
        }

        public object GetValue(string value)
        {
            return short.Parse(value);
        }
    }
}