using System;

namespace FFQueryBuilder
{
    internal class GuidFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(Guid))) || (TypeOfValue.Equals(typeof(Guid?)));
        }

        public object GetValue(string value)
        {
            return Guid.Parse(value);
        }
    }
}