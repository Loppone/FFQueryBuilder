using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnUtenti
    {
        public FrnUtenti()
        {
            FrnUtentiGruppiValidaziones = new HashSet<FrnUtentiGruppiValidazione>();
        }

        public string Userad { get; set; }
        public short? LivelloAutorizzazione { get; set; }
        public string Nomecognome { get; set; }
        public bool? Visualizzareport { get; set; }

        public virtual ICollection<FrnUtentiGruppiValidazione> FrnUtentiGruppiValidaziones { get; set; }
    }
}
