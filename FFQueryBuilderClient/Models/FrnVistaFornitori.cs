using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaFornitori
    {
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string SapBpid { get; set; }
        public string RagioneSociale { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Localita { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public string PartitaIvaInternazionale { get; set; }
        public string NomeReferentePrimario { get; set; }
        public string EMailReferentePrimario { get; set; }
        public string Telefono { get; set; }
        public string Cellulare { get; set; }
        public string Fax { get; set; }
        public bool? SoggettoRegContributiva { get; set; }
        public bool? IsActiveAlert { get; set; }
        public string UrlPortaleSpecifico { get; set; }
        public string UtenteAd { get; set; }
        public string UrlAreaRiservata { get; set; }
        public string Lingua { get; set; }
        public string PartitaIvaStenr { get; set; }
        public DateTime? DataUltimoOdaBem { get; set; }
        public string OrganizzAcquisti { get; set; }
        public bool? InvioRegConSap { get; set; }
        public DateTime? UltimoInvioRegConSap { get; set; }
    }
}
