﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaDaValidareUtentiBoCount
    {
        public string IdFileSharepointUpload { get; set; }
        public string UtenteBo { get; set; }
        public string CodiceDocumento { get; set; }
        public string Nome { get; set; }
        public string Codicerda { get; set; }
        public string Societa { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSociale { get; set; }
        public string SapBpid { get; set; }
        public DateTime? DataUpload { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public string Buyer { get; set; }
        public string Faci { get; set; }
        public string NomeDocumento { get; set; }
        public string UtenteValidatore { get; set; }
    }
}