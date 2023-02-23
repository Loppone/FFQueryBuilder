using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogAzioniDocumenti
    {
        public decimal Id { get; set; }
        public decimal IdDocumento { get; set; }
        public string Utente { get; set; }
        public DateTime? DataOra { get; set; }
        public string Azione { get; set; }
        public string Nota { get; set; }
    }
}
