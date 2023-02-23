using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnDocumentiStornoValidazione
    {
        public decimal Id { get; set; }
        public decimal? IdDocumento { get; set; }
        public string Utente { get; set; }
        public string Motivo { get; set; }
        public DateTime? Data { get; set; }
    }
}
