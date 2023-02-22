using System;

namespace FFQueryBuilder
{
    internal class IntFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(int))) || (TypeOfValue.Equals(typeof(int?)));
        }

        public object GetValue(string value)
        {
            return int.Parse(value);
        }
    }
}