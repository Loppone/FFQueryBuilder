using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDocumentiPerRdaBase
    {
        public decimal Id { get; set; }
        public string Cartella { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public string CodiceRda { get; set; }
        public DateTime? DataOraRichiesta { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public DateTime? DataOraUpload { get; set; }
        public DateTime? DataUpload { get; set; }
        public int? StatoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string Nome { get; set; }
        public string NomeDocumento { get; set; }
        public string CodiceDocumento { get; set; }
        public bool? NonVisibile { get; set; }
        public bool? Scaduto { get; set; }
    }
}
