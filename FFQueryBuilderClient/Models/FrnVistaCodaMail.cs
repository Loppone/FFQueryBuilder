using System;
using System.Collections.Generic;

namespace FFQueryBuilderClient.Models
{
    public partial class FrnVistaCodaMail
    {
        public string EMailReferentePrimario { get; set; }
        public decimal Id { get; set; }
        public string Evento { get; set; }
        public Guid? IdFornitore { get; set; }
        public string CodiceRda { get; set; }
        public DateTime? DataInserimento { get; set; }
        public DateTime? DataInvio { get; set; }
        public string Oggetto { get; set; }
        public string Testo { get; set; }
        public string InviatoDa { get; set; }
        public string InviatoA { get; set; }
        public int? EventoId { get; set; }
        public string NomeCognome { get; set; }
        public int? IdDocumento { get; set; }
    }
}
