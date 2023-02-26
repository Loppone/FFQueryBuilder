using System;

namespace FFQueryBuilder
{
    internal class FloatFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(float))) || (TypeOfValue.Equals(typeof(float?)));
        }

        public object GetValue(string value)
        {
            return float.Parse(value);
        }
    }
}