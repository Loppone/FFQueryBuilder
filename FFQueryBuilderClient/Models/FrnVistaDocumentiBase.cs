using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDocumentiBase
    {
        public string Nome { get; set; }
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string DocumentState { get; set; }
        public Guid? IdFornitore { get; set; }
        public Guid? IdDocumentoQuietanza { get; set; }
    }
}
