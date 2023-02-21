using System;

namespace FFQueryBuilder
{
    internal class DecimalFactory : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(decimal))) || (TypeOfValue.Equals(typeof(decimal?)));
        }

        public object GetValue(string value)
        {
            return decimal.Parse(value);
        }
    }
}