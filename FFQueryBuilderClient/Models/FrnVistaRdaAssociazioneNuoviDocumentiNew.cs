using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaRdaAssociazioneNuoviDocumentiNew
    {
        public string DescrizioneCommessa { get; set; }
        public string CodiceCommessa { get; set; }
        public string TipoCommessa { get; set; }
        public string Societa { get; set; }
        public string Cluster { get; set; }
        public string TipoPratica { get; set; }
        public string StatoRdaContratto { get; set; }
        public string CodiceSap { get; set; }
        public string CodiceSrm { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string CodiceRda { get; set; }
        public string Buyer { get; set; }
        public string UtenteBo { get; set; }
        public DateTime? DataPassaggioStato { get; set; }
        public string AreaOrganizzativa { get; set; }
        public string Autore { get; set; }
        public bool? RegolaritaContributiva { get; set; }
    }
}
