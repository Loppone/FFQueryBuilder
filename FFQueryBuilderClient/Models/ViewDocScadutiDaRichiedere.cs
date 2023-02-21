using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ViewDocScadutiDaRichiedere
    {
        public string DataAutorizzazioneSubappalto { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public decimal IdTipoDoc { get; set; }
        public bool? NonVisibile { get; set; }
        public decimal Id { get; set; }
        public DateTime? FineValidita { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string CodiceRda { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodicefornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string EMailReferenteprimario { get; set; }
        public DateTime? DataFineRda { get; set; }
        public DateTime? DatafineRdAoriginale { get; set; }
    }
}
