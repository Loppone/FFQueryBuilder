using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class LogInvioSap
    {
        public int Id { get; set; }
        public DateTime? DataOra { get; set; }
        public string Funzione { get; set; }
        public string Payload { get; set; }
        public string Response { get; set; }
        public string Stato { get; set; }
        public string Eccezione { get; set; }
    }
}
