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
                    new GuidFilter(),
                    new ObjectFilter(),

                    new DateFilter(),
                    new TimeSpanFilter(),
                    new DateTimeOffsetFilter(),

                    new BoolFilter(),

                    new IntFilter(),
                    new LongFilter(),
                    new DecimalFilter(),
                    new ShortFilter(),
                    new FloatFilter(),
                    new DoubleFilter(),
                    new ByteFilter(),
                };
            }

            return instance;
        }
    }
}
