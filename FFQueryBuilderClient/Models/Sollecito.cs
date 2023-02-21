using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class Sollecito
    {
        public Sollecito()
        {
            FrnDocumentos = new HashSet<FrnDocumento>();
        }

        public decimal Id { get; set; }
        public DateTime DataAttivazione { get; set; }
        public bool? IsActive { get; set; }
        public int IdStato { get; set; }
        public DateTime? DataUltimoInvio { get; set; }
        public DateTime? DataProssimoInvio { get; set; }
        public int? TipoSollecitoUltimoInvio { get; set; }
        public int NumeroSollecitiInviati { get; set; }
        public int? NumeroMassimoSolleciti { get; set; }

        public virtual ICollection<FrnDocumento> FrnDocumentos { get; set; }
    }
}
