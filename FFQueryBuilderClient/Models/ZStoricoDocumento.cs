using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZStoricoDocumento
    {
        public Guid IdStoricoDocumento { get; set; }
        public Guid IdDocumento { get; set; }
        public string Urlrelativa { get; set; }
        public DateTime DataRichiestaDocumento { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataValidazione { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public DateTime? DataInizioValiditaRegolaritaContributiva { get; set; }
        public DateTime? DataFineValiditaRegolaritaContributiva { get; set; }
        public bool? RegolaritaContributivaValidata { get; set; }
        public Guid? Validatore { get; set; }
        public bool? RegolaritaContributivaForzata { get; set; }
        public int? ZzAnnoRiferimento { get; set; }
        public DateTime? ZzDataPresentazione { get; set; }
        public string ValidatoreSpuser { get; set; }
        public DateTime? DataRespingimento { get; set; }
        public string SpuserRespingimento { get; set; }
    }
}
