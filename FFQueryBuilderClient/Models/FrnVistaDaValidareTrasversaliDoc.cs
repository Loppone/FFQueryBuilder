using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDaValidareTrasversaliDoc
    {
        public decimal IdTipoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string NomeDocumento { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string SapBpid { get; set; }
        public DateTime? DataUpload { get; set; }
        public string Faci { get; set; }
    }
}
