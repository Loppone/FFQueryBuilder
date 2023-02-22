namespace FFQueryBuilder
{
    public class FilterItem
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public CompareOperator Operator { get; set; }
    }
}