using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnTipoDocumentoLibero
    {
        public decimal Id { get; set; }
        public string CodiceDocumento { get; set; }
        public string NomeDocumento { get; set; }
        public string Descrizione { get; set; }
    }
}
