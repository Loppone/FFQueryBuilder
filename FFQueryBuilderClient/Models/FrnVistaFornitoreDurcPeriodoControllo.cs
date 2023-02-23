using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaFornitoreDurcPeriodoControllo
    {
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public DateTime? DataInizioRda { get; set; }
        public DateTime? DataFineRda { get; set; }
        public DateTime? DataFinePeriodoControllo { get; set; }
    }
}
