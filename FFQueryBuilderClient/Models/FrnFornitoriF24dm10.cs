using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnFornitoriF24dm10
    {
        public int Id { get; set; }
        public Guid IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public int? Mese { get; set; }
        public int? Anno { get; set; }
        public bool? Forzato { get; set; }
        public string ForzatoUser { get; set; }
        public DateTime? ForzatoData { get; set; }
    }
}
