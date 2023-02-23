using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaValidaDocumenti
    {
        public decimal Id { get; set; }
        public string CodiceDocumento { get; set; }
        public string NomeTipoDocumento { get; set; }
        public string CodiceRda { get; set; }
        public string RagioneSocialeSocieta { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public DateTime? DataUpload { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public int? IdStatoDocumento { get; set; }
        public string UtenteBackOffice { get; set; }
        public string Buyer { get; set; }
        public string Faci { get; set; }
        public string NomeDocumento { get; set; }
        public string UtenteValidatore { get; set; }
        public decimal? IdGruppoValidazione { get; set; }
        public string StatoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public bool? Periodico { get; set; }
        public DateTime? DataEmissione { get; set; }
        public Guid? IdFornitore { get; set; }
        public string TipologiaFaci { get; set; }
        public string MotivoRifiuto { get; set; }
    }
}
