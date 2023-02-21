using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZViewDocumentiRdadaRichiedere
    {
        public string CodiceRda { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string ValidatoreSpuser { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public Guid IdDocumento { get; set; }
        public DateTime DataRichiestaDocumento { get; set; }
        public string Descrizione { get; set; }
        public string Urltemplate { get; set; }
        public string Urlrelativa { get; set; }
        public string SapBpid { get; set; }
        public int? IdRda { get; set; }
        public string UtenteBo { get; set; }
        public string Buyer { get; set; }
        public string DocumentState { get; set; }
        public string DescrizioneCommessa { get; set; }
        public int NumAlert { get; set; }
        public Guid? Societa { get; set; }
        public string NomeSocieta { get; set; }
        public Guid IdTipoDocumento { get; set; }
    }
}
