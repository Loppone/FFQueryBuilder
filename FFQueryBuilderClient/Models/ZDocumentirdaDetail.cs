using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZDocumentirdaDetail
    {
        public string CodiceRdacodiceCompleto { get; set; }
        public Guid IdDocumentoRda { get; set; }
        public Guid ZIdRda { get; set; }
        public string Gruppo { get; set; }
        public bool? OriginaleNecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? RilascioOrdine { get; set; }
        public bool? SpecificoPerRegContr { get; set; }
        public Guid? IdStoricoDocumento { get; set; }
        public bool? Chiusura { get; set; }
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
