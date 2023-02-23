using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogInvioRilascioProtocollo
    {
        public int Id { get; set; }
        public string CodiceRda { get; set; }
        public DateTime? DataInvioSap { get; set; }
        public bool? Stato { get; set; }
        public string Messaggio { get; set; }
    }
}
