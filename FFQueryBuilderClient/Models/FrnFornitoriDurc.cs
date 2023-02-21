using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnFornitoriDurc
    {
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public DateTime? ValidoFinoA { get; set; }
        public DateTime? ValidoFinoAdataInvioSap { get; set; }
        public DateTime? ForzatoFinoA { get; set; }
        public DateTime? ForzatoFinoAdataInvioSap { get; set; }
        public string ForzatoUser { get; set; }
        public DateTime? ForzatoData { get; set; }
    }
}
