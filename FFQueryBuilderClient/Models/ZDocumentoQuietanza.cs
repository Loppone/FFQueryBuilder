using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZDocumentoQuietanza
    {
        public Guid IdDocumentoQuietanza { get; set; }
        public Guid? IdRichiestaQuietanza { get; set; }
        public Guid? IdCommessa { get; set; }
        public string Referente { get; set; }
        public string Cliente { get; set; }
        public string Contratto { get; set; }
        public string Ordine { get; set; }
        public string NumFattura { get; set; }
        public string NumDocContabile { get; set; }
        public string NumPratica { get; set; }
        public DateTime? DataEmissione { get; set; }
        public string Anno { get; set; }
        public Guid IdSocieta { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? Importo { get; set; }
        public bool? CaricamentoManuale { get; set; }
        public bool? InviatoSap { get; set; }
    }
}
