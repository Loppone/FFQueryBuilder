using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class TmpDocumentiDettRdum
    {
        public Guid IdRda { get; set; }
        public Guid IdSocieta { get; set; }
        public Guid IdCommessa { get; set; }
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
    }
}
