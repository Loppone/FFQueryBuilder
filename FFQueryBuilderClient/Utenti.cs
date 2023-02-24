namespace FFQueryBuilderClient
{
    public class Utenti
    {
        public string UserAd { get; set; }
        public short? LivelloAutorizzazione { get; set; }
        public string Nomecognome { get; set; }
        public bool? Visualizzareport { get; set; }
        public decimal? IdGruppoValidazione { get; set; }   // Da proprietà di navigazione
    }
}
