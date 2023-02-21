using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnDocumentoCommesse
    {
        public decimal IdDocumento { get; set; }
        public Guid IdCommessa { get; set; }

        public virtual FrnTipiDocumento IdDocumentoNavigation { get; set; }
    }
}
