using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaFornitoriDurc
    {
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string RagioneSociale { get; set; }
        public DateTime? DataFinePeriodoControllo { get; set; }
    }
}
