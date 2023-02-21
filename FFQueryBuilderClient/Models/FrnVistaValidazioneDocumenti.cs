using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaValidazioneDocumenti
    {
        public Guid IdFornitore { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string StatoDocumentoRda { get; set; }
        public string Performance { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string Buyer { get; set; }
        public string UtenteBackOffice { get; set; }
        public string DataRichiestaAutorizzazione { get; set; }
        public Guid IdRda { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string AutoreRda { get; set; }
        public string AreaOrg { get; set; }
        public string CodiceRda { get; set; }
    }
}
