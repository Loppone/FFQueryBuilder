using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempDocumento
    {
        public Guid IdDocumento { get; set; }
        public Guid IdTipoDocumento { get; set; }
        public string Urlrelativa { get; set; }
        public Guid IdFornitore { get; set; }
        public DateTime DataRichiestaDocumento { get; set; }
        public Guid? IdAlert { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataValidazione { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public DateTime? DataInizioValiditaRegolaritaContributiva { get; set; }
        public DateTime? DataFineValiditaRegolaritaContributiva { get; set; }
        public bool? RegolaritaContributivaValidata { get; set; }
        public bool? RegolaritaContributivaForzata { get; set; }
        public int? ZzAnnoRiferimento { get; set; }
        public DateTime? ZzDataPresentazione { get; set; }
        public string ValidatoreSpuser { get; set; }
        public Guid? IdRda { get; set; }
        public string SpuserInserimento { get; set; }
        public byte CaricatoDa { get; set; }
        public bool? CaricatoLiberamente { get; set; }
        public Guid? IdDocumentoRichiesto { get; set; }
        public Guid? IdDocumentoQuietanza { get; set; }
        public DateTime? DataRespingimento { get; set; }
        public string SpuserRespingimento { get; set; }
        public Guid? IdDocumentoDm10f24 { get; set; }
    }
}
