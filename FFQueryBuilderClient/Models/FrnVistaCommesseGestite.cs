using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaCommesseGestite
    {
        public Guid IdCommessa { get; set; }
        public string DescrizioneCommessa { get; set; }
        public DateTime? DataInizioCommessa { get; set; }
        public DateTime? DataFineCommessa { get; set; }
        public string CodiceCommessa { get; set; }
        public int? Livello { get; set; }
        public string TipoCliente { get; set; }
        public string TipoCommessa { get; set; }
        public DateTime? DataProrogaPotenziale { get; set; }
        public DateTime? DataProrogaEffettiva { get; set; }
        public DateTime? DataFineProrogaEffettiva { get; set; }
        public string RagioneSociale { get; set; }
        public bool Utilizzata { get; set; }
        public bool? GestioneSp { get; set; }
        public bool? Capogruppo { get; set; }
        public string DescrizioneCapogruppo { get; set; }
    }
}
