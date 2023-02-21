using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaTipiDocumentoCommesse
    {
        public decimal Id { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Validatore { get; set; }
        public decimal? IdGruppoValidazione { get; set; }
        public bool? SpecificoPerCommessa { get; set; }
        public bool? SpecificoPerRda { get; set; }
        public bool? Periodico { get; set; }
        public decimal? DurataMesi { get; set; }
        public bool? RegolaritaContributiva { get; set; }
        public string Faci { get; set; }
        public string NomeFile { get; set; }
        public string IdFileSharepoint { get; set; }
        public string TipologiaFaci { get; set; }
        public bool? NotificaValidatore { get; set; }
        public string EmailValidatore { get; set; }
        public bool? DefaultRegolarita { get; set; }
        public bool? Disabilitato { get; set; }
        public bool? DaSollecitare { get; set; }
        public bool? DocumentoLibero { get; set; }
        public Guid? IdOld { get; set; }
        public bool? RichiestaPresaVisione { get; set; }
        public string CodiciCommesse { get; set; }
        public string DescrizioniCommesse { get; set; }
        public bool? Tracciabilita { get; set; }
        public string EmailTracciabilita { get; set; }
    }
}
