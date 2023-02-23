using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempSocietum
    {
        public string CodiceSocieta { get; set; }
        public Guid IdSocieta { get; set; }
        public string RagioneSociale { get; set; }
        public Guid? IdSistema { get; set; }
        public bool? GestioneSp { get; set; }
        public bool? GestioneRegContr { get; set; }
    }
}
