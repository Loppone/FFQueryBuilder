using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDocumentoDm10f24
    {
        public string CodiceRda { get; set; }
        public string SapBpid { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string NomeDocumento { get; set; }
        public DateTime? DataValidazione { get; set; }
        public DateTime? DataOraValidazione { get; set; }
        public string UtenteValidatore { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public DateTime? DataOraCaricamento { get; set; }
        public Guid? IdFornitore { get; set; }
        public decimal IdDocumento { get; set; }
        public int? MeseRichiestaF24 { get; set; }
        public int? AnnoRichiestaF24 { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public DateTime? DataOraRichiesta { get; set; }
        public string DocumentState { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string NomeFile { get; set; }
        public string DescrizioneStatoDocumento { get; set; }
        public int? IdStatoDocumento { get; set; }
        public int? StatoDocumento { get; set; }
        public string MotivoRifiuto { get; set; }
    }
}
