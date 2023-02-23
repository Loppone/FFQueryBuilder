using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnUtenti
    {
        public FrnUtenti()
        {
            FrnUtentiGruppiValidaziones = new HashSet<FrnUtentiGruppiValidazione>();
        }

        /// <summary>
        /// 0=sola visualizzazione; 1=modifica (se ha i permessi sul documento da gruppo validazione)
        /// </summary>
        public string Userad { get; set; }
        public short? LivelloAutorizzazione { get; set; }
        public string Nomecognome { get; set; }
        public bool? Visualizzareport { get; set; }

        public virtual ICollection<FrnUtentiGruppiValidazione> FrnUtentiGruppiValidaziones { get; set; }
    }
}
