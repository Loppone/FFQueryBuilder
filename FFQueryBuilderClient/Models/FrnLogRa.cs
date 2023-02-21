using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogRa
    {
        public decimal Id { get; set; }
        public string CodiceRda { get; set; }
        public string NumeroRichiesta { get; set; }
        public decimal? ImportoAutorizzato { get; set; }
        public DateTime? DataInvioRas { get; set; }
        public string UserId { get; set; }
        public DateTime? DataOra { get; set; }
    }
}
