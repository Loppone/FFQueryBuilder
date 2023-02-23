﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaRdaCommessa
    {
        public DateTime? DataFineRda { get; set; }
        public decimal? IdGruppoValidazione { get; set; }
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string Faci { get; set; }
        public string Cartella { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string RagioneSocialeSocieta { get; set; }
        public Guid IdFornitore { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string NomeFileTemplate { get; set; }
        public string IdFileSharepointTemplate { get; set; }
        public string StatoDocumentoRda { get; set; }
        public string Performance { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public string UtenteUpload { get; set; }
        public string NomeDocumento { get; set; }
        public string StatoDocumento { get; set; }
        public int? IdStatoDocumento { get; set; }
        public string CodiceDocumento { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string Buyer { get; set; }
        public string UtenteBackOffice { get; set; }
        public string TipologiaFaci { get; set; }
        public string DescrizioneDocumento { get; set; }
        public bool? SpecificoPerCommessa { get; set; }
        public string UtenteValidatore { get; set; }
        public string UtenteRifiuto { get; set; }
        public string DataRichiestaAutorizzazione { get; set; }
        public string DataRifiuto { get; set; }
        public string DataValidazione { get; set; }
        public string DataUpload { get; set; }
        public string DescrizioneCluster { get; set; }
        public string DescrizioneTipoPratica { get; set; }
        public Guid IdRda { get; set; }
        public decimal? ImportoAutorizzatoRda { get; set; }
        public string NumeroRichiestaRda { get; set; }
        public string DataInvioRasRda { get; set; }
        public string CodiceFornitoreSrm { get; set; }
        public string AutoreRda { get; set; }
        public string AreaOrg { get; set; }
        public bool? Periodico { get; set; }
        public bool? IsSollecitoAttivo { get; set; }
        public int? NumeroSollecitiInviati { get; set; }
        public int? IdStatoSollecito { get; set; }
        public string DescrizioneStatoSollecito { get; set; }
        public string CodiceRda { get; set; }
        public bool? SpecificoPerRda { get; set; }
        public string DataInizioValidita { get; set; }
        public string DataFineValidita { get; set; }
        public string DataRichiesta { get; set; }
        public string DataEmissione { get; set; }
        public string MotivoRifiuto { get; set; }
        public string NomeTipoDocumento { get; set; }
    }
}