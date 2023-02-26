using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FFQueryBuilder
{
    internal static class FilterFactory
    {
        public static IFilterValue CreateFilters(Type type)
        {
            var filters = FiltersBuilderSingleton.GetInstance();
            return filters.FirstOrDefault(x=>x.CanHandle(type));
        }
    }
}
