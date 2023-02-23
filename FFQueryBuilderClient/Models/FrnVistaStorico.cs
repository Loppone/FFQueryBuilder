using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaStorico
    {
        public decimal? IdDocumento { get; set; }
        public decimal? IdDocumentoStorico { get; set; }
        public string CodiceRda { get; set; }
        public decimal? IdTipoDocumento { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public string DescrizioneStato { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string Societa { get; set; }
        public string Buyer { get; set; }
        public string UtenteBo { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public string UtenteValidatore { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string NomeDocumento { get; set; }
    }
}
