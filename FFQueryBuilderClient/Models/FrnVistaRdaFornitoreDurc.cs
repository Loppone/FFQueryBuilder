using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaRdaFornitoreDurc
    {
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string CodiceRda { get; set; }
        public DateTime? DataInizioRda { get; set; }
        public DateTime? DataFineRda { get; set; }
        public DateTime? DataFinePeriodoControllo { get; set; }
        public string RagioneSocialeSocieta { get; set; }
    }
}
