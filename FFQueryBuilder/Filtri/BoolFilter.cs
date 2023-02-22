using System;

namespace FFQueryBuilder
{
    internal class BoolFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(bool))) || (TypeOfValue.Equals(typeof(bool?)));
        }

        public object GetValue(string value)
        {
            return bool.Parse(value);
        }
    }
}