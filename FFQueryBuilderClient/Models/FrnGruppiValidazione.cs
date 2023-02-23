using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnGruppiValidazione
    {
        public FrnGruppiValidazione()
        {
            FrnTipiDocumentos = new HashSet<FrnTipiDocumento>();
            FrnUtentiGruppiValidaziones = new HashSet<FrnUtentiGruppiValidazione>();
        }

        public decimal Id { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<FrnTipiDocumento> FrnTipiDocumentos { get; set; }
        public virtual ICollection<FrnUtentiGruppiValidazione> FrnUtentiGruppiValidaziones { get; set; }
    }
}
