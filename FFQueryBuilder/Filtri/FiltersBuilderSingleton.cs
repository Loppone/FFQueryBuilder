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
                    new StringFilter(),
                    new CharFilter(),
                    new DateFilter(),
                    new GuidFilter(),
                    
                    new BoolFilter(),

                    new IntFilter(),
                    new DecimalFilter(),
                    new ShortFilter(),
                    new DoubleFilter(),
                };
            }

            return instance;
        }
    }
}
