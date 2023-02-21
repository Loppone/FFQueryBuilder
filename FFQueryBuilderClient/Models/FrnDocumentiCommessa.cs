using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnDocumentiCommessa
    {
        public decimal Id { get; set; }
        public decimal Idtipodocumento { get; set; }
        public string Faci { get; set; }
        public string Cartella { get; set; }
        public bool? Originalenecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? Rialascioordine { get; set; }
        public bool? Firmadigitaleobbligatoria { get; set; }
        public Guid? IdDocumentoOld { get; set; }
        public Guid? IdCommessaOld { get; set; }
        public Guid? IdTipoDocumentoOld { get; set; }
        public DateTime? UpdateStamp { get; set; }

        public virtual FrnTipiDocumento IdtipodocumentoNavigation { get; set; }
    }
}
