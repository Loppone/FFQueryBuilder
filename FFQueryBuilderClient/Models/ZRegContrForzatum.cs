using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZRegContrForzatum
    {
        public Guid IdRegContrForzata { get; set; }
        public Guid IdFornitore { get; set; }
        public DateTime DataUltimaForzatura { get; set; }
    }
}
