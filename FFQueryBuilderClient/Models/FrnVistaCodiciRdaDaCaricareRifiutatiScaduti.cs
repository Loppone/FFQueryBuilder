using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaCodiciRdaDaCaricareRifiutatiScaduti
    {
        public Guid IdRda { get; set; }
        public string CodiceRda { get; set; }
        public Guid IdFornitore { get; set; }
        public Guid IdSocieta { get; set; }
        public Guid IdCommessa { get; set; }
        public string CodiceStato { get; set; }
        public string CodiceStatoOrigine { get; set; }
        public string Buyer { get; set; }
        public string UtenteBo { get; set; }
        public string BuildingManager { get; set; }
        public DateTime? DataStato { get; set; }
        public DateTime? DataInizioRda { get; set; }
        public DateTime? DataFineRda { get; set; }
        public DateTime? DataRichiestaAutorizzazione { get; set; }
        public string Gruppo { get; set; }
        public Guid? IdAlert { get; set; }
        public string Descrizione { get; set; }
        public string AreaOrg { get; set; }
        public string AutoreRda { get; set; }
        public bool? RegolaritaContributiva { get; set; }
        public string CodiceStatoPrecedente { get; set; }
        public string CodiceStatoOriginePrecedente { get; set; }
        public DateTime? DataComunicazioneRichiestaSubappalto { get; set; }
        public bool? PrimaAssociazioneRegContr { get; set; }
        public bool? PreavvisoInviato { get; set; }
        public string Cluster { get; set; }
        public string CodiceTipoPratica { get; set; }
        public string CodiceTipoProtocollo { get; set; }
        public string CodiceCluster { get; set; }
        public bool? Manuale { get; set; }
        public string TipoPratica { get; set; }
        public string RaccoltaCompletata { get; set; }
        public string StatoDocFlow { get; set; }
        public bool? RegolaritaIvaIrpef { get; set; }
        public string CodiceFornitoreOrigine { get; set; }
        public DateTime? DataFirma { get; set; }
        public DateTime? DataChiusura { get; set; }
        public string DocFlow { get; set; }
        public string NumeroRichiesta { get; set; }
        public string ImportoAutorizzato { get; set; }
        public string DataIntegrRichAut { get; set; }
        public string NoteIntegrRas { get; set; }
        public string DataIntegrRichAutPostSilenzioAssenso { get; set; }
        public string NoteIntegrRaspostSilenzioAssenso { get; set; }
        public string SilenzioAssenso { get; set; }
        public string DataRichiestaClienteIntegrazioneRas { get; set; }
        public string VerificaSubappalto { get; set; }
        public string DataAutorizzazioneSubappalto { get; set; }
        public DateTime? DataPresaInCarico { get; set; }
        public string NumeroOrdineAcquisto { get; set; }
    }
}
