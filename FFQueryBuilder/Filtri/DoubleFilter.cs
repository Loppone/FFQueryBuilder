using System;

namespace FFQueryBuilder
{
    internal class DoubleFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(double))) || (TypeOfValue.Equals(typeof(double?)));
        }

        public object GetValue(string value)
        {
            return double.Parse(value);
        }
    }
}