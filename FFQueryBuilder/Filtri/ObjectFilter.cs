using System;

namespace FFQueryBuilder
{
    internal class ObjectFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return TypeOfValue.Equals(typeof(object));
        }

        public object GetValue(string value)
        {
            return value.ToString();
        }
    }
}