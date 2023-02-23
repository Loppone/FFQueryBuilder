using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempAllType
    {
        public long? BigInt { get; set; }
        public byte[] Binary { get; set; }
        public bool? Bit { get; set; }
        public string Char { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Datetime { get; set; }
        public DateTime? Datetime2 { get; set; }
        public decimal? Decimal { get; set; }
        public double? Float { get; set; }
        public byte[] Image { get; set; }
        public int? Int { get; set; }
        public decimal? Money { get; set; }
        public string Nchar { get; set; }
        public string Ntext { get; set; }
        public decimal? Numeric { get; set; }
        public string NvarChar { get; set; }
        public float? Real { get; set; }
        public DateTime? SmallDatetime { get; set; }
        public short? SmallInt { get; set; }
        public decimal? SmallMoney { get; set; }
        public object SqlVariant { get; set; }
        public string Text { get; set; }
        public TimeSpan? Time { get; set; }
        public byte[] Timestamp { get; set; }
        public byte? TinyInt { get; set; }
        public Guid? UniqueIdentifier { get; set; }
        public byte[] VarBinary { get; set; }
        public string Varchar { get; set; }
        public string Xml { get; set; }
        public DateTimeOffset? DatetimeOffset { get; set; }
    }
}
