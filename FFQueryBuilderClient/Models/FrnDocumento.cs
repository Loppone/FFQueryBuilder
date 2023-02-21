using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnDocumento
    {
        public decimal Id { get; set; }
        public string CodiceRda { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string Faci { get; set; }
        public string Cartella { get; set; }
        public bool? OriginaleNecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? RilascioOrdine { get; set; }
        public bool? FirmaDigitaleObbligatoria { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public DateTime? DataUpload { get; set; }
        public string UtenteUpload { get; set; }
        public int? StatoDocumento { get; set; }
        public string NomeDocumento { get; set; }
        public DateTime? DataValidazione { get; set; }
        public string UtenteValidatore { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public string UtenteRifiuto { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public Guid? IdFornitore { get; set; }
        public int? AnnoRichiestaF24 { get; set; }
        public int? MeseRichiestaF24 { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public DateTime? DataEmissione { get; set; }
        public bool? AbilitaCaricamentoFornitore { get; set; }
        public Guid? IdDocumentoQuietanza { get; set; }
        public decimal? IdSollecito { get; set; }
        public decimal? IdDocumentoLibero { get; set; }
        public string UtenteInserimento { get; set; }
        public Guid? IdOld { get; set; }
        public bool? ConfermaPresaVisione { get; set; }
        public DateTime? DataPresaVisione { get; set; }
        public DateTime? QuietanzaDataInvioSap { get; set; }
        public string MotivoRifiuto { get; set; }
        public string Urlrelativa { get; set; }
        public bool? DaCaricareSuSp { get; set; }
        public bool? GeneratoDaScaduto { get; set; }
        public int? UpdateVersion { get; set; }
        public string UpdateNote { get; set; }
        public Guid? IdDocumentoRda { get; set; }
        public string GuidUpload { get; set; }
        public string GuidValidazione { get; set; }
        public string GuidRifiuto { get; set; }
        public bool? Scaduto { get; set; }
        public DateTime? DataInvioSollecito { get; set; }
        public DateTime? DataPrevistaProssimoSollecito { get; set; }
        public int? NumeroSolleciti { get; set; }

        public virtual Sollecito IdSollecitoNavigation { get; set; }
        public virtual FrnTipiDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual FrnStatoDocumento StatoDocumentoNavigation { get; set; }
    }
}
