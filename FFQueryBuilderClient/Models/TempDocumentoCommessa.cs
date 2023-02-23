using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempDocumentoCommessa
    {
        public Guid IdDocumentoCommessa { get; set; }
        public Guid IdCommessa { get; set; }
        public Guid IdTipoDocumento { get; set; }
        public string Gruppo { get; set; }
        public bool? OriginaleNecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? RilascioOrdine { get; set; }
        public bool? AlertAttivo { get; set; }
        public decimal? IdTipoDocumentoNew { get; set; }
        public string CodiceDocumento { get; set; }
        public string CodiceCommessa { get; set; }
    }
}
