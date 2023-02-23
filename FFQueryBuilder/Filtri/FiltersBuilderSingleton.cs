using System.Collections.Generic;

namespace FFQueryBuilder
{
    internal static class FiltersBuilderSingleton
    {
        private static List<IFilterValue> instance;

        public static List<IFilterValue> GetInstance()
        {
            if (instance == null)
            {
                instance = new List<IFilterValue>
                {
                    new DateFilter(),
                    new IntFilter(),
                    new StringFilter(),
                    new BoolFilter(),
                    new GuidFilter(),
                    new DecimalFilter()
                };
            }

            return instance;
        }
    }
}
