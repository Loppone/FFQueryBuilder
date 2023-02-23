using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogInvioRasSap
    {
        public decimal Id { get; set; }
        public string CodiceRda { get; set; }
        public string NumeroRichiesta { get; set; }
        public string ImportoAutorizzato { get; set; }
        public string DataInvioRas { get; set; }
        public string DataInvioRichCapogruppo { get; set; }
        public string UserId { get; set; }
        public bool? Stato { get; set; }
        public string Messaggio { get; set; }
        public DateTime? DataOra { get; set; }
        public string PayLoad { get; set; }
    }
}
