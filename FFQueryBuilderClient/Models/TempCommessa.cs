using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class TempCommessa
    {
        public Guid IdCommessa { get; set; }
        public Guid? IdSocieta { get; set; }
        public string IdStato { get; set; }
        public string DescrizioneCommessa { get; set; }
        public Guid? IdCliente { get; set; }
        public DateTime? DataInizioCommessa { get; set; }
        public DateTime? DataFineCommessa { get; set; }
        public string CodiceFiliale { get; set; }
        public string CodiceCommessa { get; set; }
        public int? Livello { get; set; }
        public string CodiceCliente { get; set; }
        public string Stato { get; set; }
        public DateTime? DataUltimaModifica { get; set; }
        public DateTime? DataPrimaRda { get; set; }
        public string TipoCliente { get; set; }
        public string CodiceCommessaLiv1 { get; set; }
        public bool Utilizzata { get; set; }
        public bool? DefaultPerRda { get; set; }
        public string TipoCommessa { get; set; }
        public DateTime? DataProrogaPotenziale { get; set; }
        public DateTime? DataProrogaEffettiva { get; set; }
        public DateTime? DataFineProrogaEffettiva { get; set; }
    }
}
