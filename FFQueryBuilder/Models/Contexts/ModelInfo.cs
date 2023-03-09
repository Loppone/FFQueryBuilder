namespace FFQueryBuilder.Models.Contexts
{
    public class ModelInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsNullable { get; set; }
        public bool IsPrimaryKey { get; set; }
        public int? MaxLength { get; set; }
    }
}
