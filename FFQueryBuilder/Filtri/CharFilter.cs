using System;

namespace FFQueryBuilder
{
    internal class CharFilter : IFilterValue
    {
        public bool CanHandle(Type TypeOfValue)
        {
            return (TypeOfValue.Equals(typeof(char))) || (TypeOfValue.Equals(typeof(char?)));
        }

        public object GetValue(string value)
        {  
            return char.Parse(value);
        }
    }
}