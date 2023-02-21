using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnLogCheckRegContr
    {
        public decimal Id { get; set; }
        public string UserId { get; set; }
        public DateTime? DataOra { get; set; }
        public Guid? IdFornitore { get; set; }
        public int? Anno { get; set; }
        public DateTime? DataInvioSap { get; set; }
    }
}
