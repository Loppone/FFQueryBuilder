using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDocumenti
    {
        public int? AbilitaCaricamentoFornitore { get; set; }
        public string CodiceRda { get; set; }
        public string NomeDocumento { get; set; }
        public string CodiceDocumento { get; set; }
        public string Commessa { get; set; }
        public string NomeFile { get; set; }
        public string IdFileSharepoint { get; set; }
        public string DescrizioneStato { get; set; }
        public int? StatoDocumento { get; set; }
        public decimal? Id { get; set; }
        public string Societa { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string IdFornitore { get; set; }
        public Guid? IdDocumentoQuietanza { get; set; }
        public string DataRichiesta { get; set; }
        public DateTime? DataRichiesta2 { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public DateTime? DataUpload { get; set; }
        public string NomeFileUpload { get; set; }
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public string UtenteRifiuto { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public DateTime? SollecitoDataAttivazione { get; set; }
        public bool? SollecitoIsActive { get; set; }
        public int? SollecitoIdStato { get; set; }
        public DateTime? SollecitoDataUltimoInvio { get; set; }
        public int? SollecitoTipoSollecitoUltimoInvio { get; set; }
        public DateTime? SollecitoDataProssimoInvio { get; set; }
        public int? SollecitoNumeroSollecitiInviati { get; set; }
        public int? SollecitoNumeroMassimoSolleciti { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string Buyer { get; set; }
        public string UtenteBo { get; set; }
        public bool? Periodico { get; set; }
        public decimal? DurataMesi { get; set; }
        public string MotivoRifiuto { get; set; }
        public bool? NonVisibile { get; set; }
        public bool? Scaduto { get; set; }
    }
}
