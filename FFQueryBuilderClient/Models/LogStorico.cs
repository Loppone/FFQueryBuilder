using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class LogStorico
    {
        public decimal Id { get; set; }
        public decimal? IdFrnDocumento { get; set; }
        public decimal? IdFrnDocumentoStorico { get; set; }
        public string Stato { get; set; }
        public string Errore { get; set; }
        public DateTime? Datainserimento { get; set; }
    }
}
