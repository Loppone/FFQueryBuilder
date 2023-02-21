using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDocumentiLiberi
    {
        public decimal Id { get; set; }
        public bool? Periodico { get; set; }
        public decimal? DurataMesi { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public bool? DocumentoLibero { get; set; }
        public bool? RichiestaPresaVisione { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public Guid? IdFornitore { get; set; }
        public string IdFileSharepoint { get; set; }
        public DateTime? DataValidazione { get; set; }
        public string UtenteValidatore { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public string UtenteRifiuto { get; set; }
        public int? StatoDocumento { get; set; }
        public DateTime? DataUpload { get; set; }
        public string UtenteUpload { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string NomeFileUpload { get; set; }
        public string UtenteInserimento { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public int? ConfermaPresaVisione { get; set; }
        public DateTime? DataPresaVisione { get; set; }
        public string DescrizioneStato { get; set; }
        public string NomeFileTemplate { get; set; }
        public string CodiceRda { get; set; }
        public string DescrizioneStatoDocumento { get; set; }
        public decimal? IdGruppoValidazione { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
    }
}
