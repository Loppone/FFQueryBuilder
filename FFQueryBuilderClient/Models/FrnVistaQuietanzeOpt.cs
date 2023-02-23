using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaQuietanzeOpt
    {
        public Guid? IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string Nome { get; set; }
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string DocumentState { get; set; }
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
