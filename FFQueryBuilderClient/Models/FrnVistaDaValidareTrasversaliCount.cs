using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDaValidareTrasversaliCount
    {
        public decimal Idtipodocumento { get; set; }
        public string Idfilesharepointupload { get; set; }
        public string Nomedocumento { get; set; }
        public DateTime? Datainiziovalidita { get; set; }
        public DateTime? Datafinevalidita { get; set; }
        public Guid? Idfornitore { get; set; }
        public DateTime? Dataupload { get; set; }
        public string Faci { get; set; }
    }
}
