using System;

namespace FFQueryBuilder
{
    internal class ByteFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(byte))) || (TypeOfValue.Equals(typeof(byte?)));
        }

        public object GetValue(string value)
        {
            return byte.Parse(value);
        }
    }
}