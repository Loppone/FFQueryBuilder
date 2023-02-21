using System;
using System.Collections.Generic;

#nullable disable

namespace FFQueryBuilderClient.Models
{
    public partial class ZTipoDocumento
    {
        public Guid IdTipoDocumento { get; set; }
        public string CodiceDocumento { get; set; }
        public string NomeDocumento { get; set; }
        public string Descrizione { get; set; }
        public bool? IsTipoCustomPerCommessa { get; set; }
        public string Validatore { get; set; }
        public bool? DocPeriodico { get; set; }
        public int? DurataMesi { get; set; }
        public bool? RegolaritaContributiva { get; set; }
        public string Urltemplate { get; set; }
        public Guid? IdCommessa { get; set; }
        public bool? SpecificoPerRda { get; set; }
        public bool? InviaNotificaCaricamento { get; set; }
        public bool? DefaultRegolaritaContributiva { get; set; }
        public int? IdGruppoValidatore { get; set; }
        public string EmailGruppoValidatore { get; set; }
        public bool IsVisible { get; set; }
    }
}
