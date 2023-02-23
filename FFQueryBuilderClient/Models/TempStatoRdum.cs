using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempStatoRdum
    {
        public Guid IdSocieta { get; set; }
        public string CodiceStato { get; set; }
        public string CodiceStatoOrigine { get; set; }
        public string DescrizioneStato { get; set; }
    }
}
