using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnUtentiGruppiValidazione
    {
        public decimal Id { get; set; }
        public string Userad { get; set; }
        public decimal? IdGruppoValidazione { get; set; }

        public virtual FrnGruppiValidazione IdGruppoValidazioneNavigation { get; set; }
        public virtual FrnUtenti UseradNavigation { get; set; }
    }
}
