using System.Collections.Generic;

namespace FFQueryBuilder.Models
{
    public class Paging
    {
        public List<FilterItem> Filters { get; set; }
        public OrderItem Order { get; set; }

        public int CurrentPage { get; set; }
        public int ItemPerPage { get; set; }
    }
}
