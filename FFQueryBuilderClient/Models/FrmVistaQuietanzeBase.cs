using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrmVistaQuietanzeBase
    {
        public Guid IdDocumentoQuietanza { get; set; }
        public string Referente { get; set; }
        public string Cliente { get; set; }
        public string Contratto { get; set; }
        public string Ordine { get; set; }
        public string NumFattura { get; set; }
        public string NumDocContabile { get; set; }
        public string NumPratica { get; set; }
        public decimal? Importo { get; set; }
        public bool? CaricamentoManuale { get; set; }
        public string CodiceSocieta { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string CodiceCommessa { get; set; }
        public string DataEmissione { get; set; }
        public string DataPagamento { get; set; }
    }
}
