using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogDurc
    {
        public decimal Id { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public DateTime? Data { get; set; }
        public string Stato { get; set; }
        public string Messaggio { get; set; }
        public string TipoInvio { get; set; }
    }
}
