using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaQuietanzeNew
    {
        public DateTime? QuietanzaDataInvioSap { get; set; }
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public DateTime? DataOraRichiesta { get; set; }
        public DateTime? DataUpload { get; set; }
        public DateTime? DataOraUpload { get; set; }
        public string NomeDocumento { get; set; }
        public string DocumentState { get; set; }
        public DateTime? DataValidazione { get; set; }
        public DateTime? DataOraValidazione { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public DateTime? DataOraRifiuto { get; set; }
        public Guid IdDocumentoQuietanza { get; set; }
        public string Referente { get; set; }
        public string Cliente { get; set; }
        public string Contratto { get; set; }
        public string Ordine { get; set; }
        public string NumFattura { get; set; }
        public string NumDocContabile { get; set; }
        public string Anno { get; set; }
        public string NumPratica { get; set; }
        public decimal? Importo { get; set; }
        public bool? CaricamentoManuale { get; set; }
        public string CodiceSocieta { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string CodiceCommessa { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataOraEmissione { get; set; }
        public DateTime? DataPagamento { get; set; }
        public DateTime? DataOraPagamento { get; set; }
        public DateTime? SollecitoDataAttivazione { get; set; }
        public bool? SollecitoIsActive { get; set; }
        public int? SollecitoIdStato { get; set; }
        public DateTime? SollecitoDataUltimoInvio { get; set; }
        public int? SollecitoTipoSollecitoUltimoInvio { get; set; }
        public DateTime? SollecitoDataProssimoInvio { get; set; }
        public int? SollecitoNumeroSollecitiInviati { get; set; }
        public int? SollecitoNumeroMassimoSolleciti { get; set; }
        public int? StatoDocumento { get; set; }
        public string MotivoRifiuto { get; set; }
        public string UtenteValidatore { get; set; }
    }
}
