using System;

namespace FFQueryBuilder
{
    internal class DateFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(DateTime))) || (TypeOfValue.Equals(typeof(DateTime?)));
        }

        public object GetValue(string value)
        {
            return DateTime.Parse(value);
        }
    }
}