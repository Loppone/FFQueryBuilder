using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaCommesse
    {
        public Guid IdCommessa { get; set; }
        public string CodiceCommessa { get; set; }
        public string CodiceRda { get; set; }
        public decimal? IdDocumento { get; set; }
    }
}
