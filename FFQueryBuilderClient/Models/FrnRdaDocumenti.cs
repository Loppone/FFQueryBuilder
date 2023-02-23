using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnRdaDocumenti
    {
        public int Id { get; set; }
        public Guid IdRda { get; set; }
        public string CodiceRda { get; set; }
        public string Tipologia { get; set; }
        public string Descrizione { get; set; }
        public string UserId { get; set; }
        public string IdSharepoint { get; set; }
        public string NomeFile { get; set; }
        public DateTime? DataCaricamento { get; set; }
        public bool? VisibileOperation { get; set; }
    }
}
