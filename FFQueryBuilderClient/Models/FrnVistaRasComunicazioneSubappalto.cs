using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaRasComunicazioneSubappalto
    {
        public string Faci { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string RagioneSocialeSocieta { get; set; }
        public Guid IdFornitore { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string StatoDocumentoRda { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string Buyer { get; set; }
        public string UtenteBackOffice { get; set; }
        public string DataRichiestaAutorizzazione { get; set; }
        public string DescrizioneCluster { get; set; }
        public string DescrizioneTipoPratica { get; set; }
        public Guid IdRda { get; set; }
        public decimal? ImportoAutorizzatoRda { get; set; }
        public string NumeroRichiestaRda { get; set; }
        public string DataInvioRasRda { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string AutoreRda { get; set; }
        public string AreaOrg { get; set; }
        public string CodiceRda { get; set; }
        public string CodiceTipoPratica { get; set; }
        public bool? Capogruppo { get; set; }
        public string DescrizioneCapogruppo { get; set; }
        public string DataAutorizzazioneSubappalto { get; set; }
        public DateTime? DataComunicazioneRichiestaSubappalto { get; set; }
        public string CodiceStatoRda { get; set; }
    }
}
