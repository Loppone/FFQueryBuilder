using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZDocumentoRdum
    {
        public Guid IdDocumentoRda { get; set; }
        public Guid IdRda { get; set; }
        public Guid IdDocumento { get; set; }
        public string Gruppo { get; set; }
        public bool? OriginaleNecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? RilascioOrdine { get; set; }
        public bool? SpecificoPerRegContr { get; set; }
        public Guid? IdStoricoDocumento { get; set; }
        public bool? Chiusura { get; set; }
        public string CodiceRda { get; set; }
    }
}
