using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnDurcF24dm10Log
    {
        public int Id { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string Tipo { get; set; }
        public DateTime? Data { get; set; }
        public string Utente { get; set; }
        public string Azione { get; set; }
        public DateTime? ValiditaDurc { get; set; }
        public int? ValiditaF24dm10Mese { get; set; }
        public int? ValiditaF24dm10Anno { get; set; }
        public string InseritoRimosso { get; set; }
        public DateTime? DataInvioSap { get; set; }
    }
}
