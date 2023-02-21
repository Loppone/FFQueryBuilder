using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class LogTrasferimentoFileSharepoint
    {
        public decimal Id { get; set; }
        public Guid IdDocumento { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceSap { get; set; }
        public DateTime? DataInizioProcessamento { get; set; }
        public DateTime? DataFineProcessamento { get; set; }
        public string UrlRelativa { get; set; }
        public string IdSharepoint { get; set; }
        public bool? FileNotFound { get; set; }
        public bool? Template { get; set; }
        public bool? Storico { get; set; }
    }
}
