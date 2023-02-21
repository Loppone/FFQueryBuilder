using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaElencoRdaPerDocumento
    {
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public bool? SpecificoPerRda { get; set; }
        public string DescrizioneCommessa { get; set; }
        public string Nome { get; set; }
        public string CodiceRda { get; set; }
        public string Descrizione { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceFornitoreSap { get; set; }
        public string RagioneSocialeFornitore { get; set; }
        public string RagioneSocialeSocieta { get; set; }
    }
}
