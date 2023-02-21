using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaValidaDocumentiGenerica
    {
        public decimal? Id { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public string NomeDocumento { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string CodiceRda { get; set; }
    }
}
