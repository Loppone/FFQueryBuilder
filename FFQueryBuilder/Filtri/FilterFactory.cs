using System.Collections.Generic;

namespace FFQueryBuilder
{
    internal static class FilterFactory
    {
        public static List<IFilterValue> CreateFilters()
        {
            return new List<IFilterValue>
            {
                new DateFilter(),
                new IntFilter(),
                new StringFilter(),
                new BoolFilter(),
                new GuidFilter(),
                new DecimalFilter()
            };
        }
    }
}
