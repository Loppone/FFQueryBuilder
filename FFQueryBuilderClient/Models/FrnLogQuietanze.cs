using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogQuietanze
    {
        public decimal Id { get; set; }
        public Guid? IdDocumentoquietanza { get; set; }
        public decimal? IdDocumento { get; set; }
        public string Stato { get; set; }
        public string Errore { get; set; }
        public DateTime? Data { get; set; }
    }
}
