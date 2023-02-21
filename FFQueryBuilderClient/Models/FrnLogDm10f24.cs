using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogDm10f24
    {
        public int Id { get; set; }
        public int? IdOrigine { get; set; }
        public DateTime? Dataora { get; set; }
        public string Esito { get; set; }
        public string Messaggio { get; set; }
    }
}
