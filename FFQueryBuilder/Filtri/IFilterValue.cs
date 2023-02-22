using System;

namespace FFQueryBuilder
{
    internal interface IFilterValue
    {
        bool CanHandle(Type TypeOfValue);
        object GetValue(string value);
    }
}
