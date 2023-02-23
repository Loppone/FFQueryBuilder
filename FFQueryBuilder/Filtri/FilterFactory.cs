using System;
using System.Linq;

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
