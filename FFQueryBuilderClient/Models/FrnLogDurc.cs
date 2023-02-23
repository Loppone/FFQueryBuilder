using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogDurc
    {
        public decimal Id { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public DateTime? Data { get; set; }
        public string Stato { get; set; }
        public string Messaggio { get; set; }
        /// <summary>
        /// DURC oppure FORZATURA
        /// </summary>
        public string TipoInvio { get; set; }
    }
}
