using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnStatoDocumento
    {
        public FrnStatoDocumento()
        {
            FrnDocumentos = new HashSet<FrnDocumento>();
        }

        public int Id { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<FrnDocumento> FrnDocumentos { get; set; }
    }
}
