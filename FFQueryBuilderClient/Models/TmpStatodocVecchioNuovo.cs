using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class TmpStatodocVecchioNuovo
    {
        public string CodiceRda { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public DateTime? DataValidazione { get; set; }
        public DateTime? Datarespingimento { get; set; }
        public Guid IdDocumento { get; set; }
    }
}
