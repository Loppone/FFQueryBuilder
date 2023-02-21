using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class FrnAnagraficaEventi
    {
        public int Id { get; set; }
        public string Evento { get; set; }
        public string Mailtemplate { get; set; }
        public string Oggettotemplate { get; set; }
    }
}
