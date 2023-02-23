using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnControlloRegolaritaContributiva
    {
        public decimal Id { get; set; }
        public Guid IdFornitore { get; set; }
        public int Anno { get; set; }
        public DateTime? DataOraUltimoInvio { get; set; }
    }
}
