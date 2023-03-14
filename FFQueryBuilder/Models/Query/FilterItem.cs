using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilder
{
    public class FilterItem
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public CompareOperator Operator { get; set; }

        public static List<FilterItem> ConvertFrom(Dictionary<string, object> filters)
        {
            List<FilterItem> filterItems = filters.Select(pair => new FilterItem
            {
                Field = pair.Key,
                Value = pair.Value?.ToString(),
                Operator = CompareOperator.Uguale
            }).ToList();

            return filterItems;
        }
    }
}