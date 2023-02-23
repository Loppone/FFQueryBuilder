using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnRdaExtra
    {
        public Guid IdRda { get; set; }
        public string CodiceRda { get; set; }
        public string NumeroRichiesta { get; set; }
        public decimal? ImportoAutorizzato { get; set; }
        public DateTime? DataInvioRas { get; set; }
        public DateTime? DataInvioCapogruppo { get; set; }
        public DateTime? DataInvioRasInvioSap { get; set; }
        public DateTime? DataInvioCapogruppoInvioSap { get; set; }
        public DateTime? DataInvioProtocolloSap { get; set; }
        public DateTime? DataInvioRasDataOraInsUpd { get; set; }
        public DateTime? DataInvioCapogruppoDataOraInsUpd { get; set; }
    }
}
