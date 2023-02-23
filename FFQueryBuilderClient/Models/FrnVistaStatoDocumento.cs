using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaStatoDocumento
    {
        public decimal Id { get; set; }
        public string CodiceRda { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string Faci { get; set; }
        public string Cartella { get; set; }
        public bool? OriginaleNecessario { get; set; }
        public bool? Contratto { get; set; }
        public bool? Subappalto { get; set; }
        public bool? RilascioOrdine { get; set; }
        public string IdFileSharepointUpload { get; set; }
        public DateTime? DataUpload { get; set; }
        public string UtenteUpload { get; set; }
        public int? StatoDocumento { get; set; }
        public string NomeDocumento { get; set; }
        public DateTime? DataValidazione { get; set; }
        public string UtenteValidatore { get; set; }
        public DateTime? DataRifiuto { get; set; }
        public string UtenteRifiuto { get; set; }
        public string DocumentState { get; set; }
    }
}
