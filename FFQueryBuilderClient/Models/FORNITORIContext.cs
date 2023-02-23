using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FFQueryBuilderClient.Models
{
    public partial class FORNITORIContext : DbContext
    {
        public FORNITORIContext()
        {
        }

        public FORNITORIContext(DbContextOptions<FORNITORIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FrmVistaQuietanzeBase> FrmVistaQuietanzeBases { get; set; }
        public virtual DbSet<FrnAnagraficaEventi> FrnAnagraficaEventis { get; set; }
        public virtual DbSet<FrnCodaEmail> FrnCodaEmails { get; set; }
        public virtual DbSet<FrnControlloRegolaritaContributiva> FrnControlloRegolaritaContributivas { get; set; }
        public virtual DbSet<FrnDocumentiCommessa> FrnDocumentiCommessas { get; set; }
        public virtual DbSet<FrnDocumentiStornoValidazione> FrnDocumentiStornoValidaziones { get; set; }
        public virtual DbSet<FrnDocumento> FrnDocumentos { get; set; }
        public virtual DbSet<FrnDocumentoCommesse> FrnDocumentoCommesses { get; set; }
        public virtual DbSet<FrnDocumentoStorico> FrnDocumentoStoricos { get; set; }
        public virtual DbSet<FrnDurcF24dm10Log> FrnDurcF24dm10Logs { get; set; }
        public virtual DbSet<FrnFornitoriDurc> FrnFornitoriDurcs { get; set; }
        public virtual DbSet<FrnFornitoriF24dm10> FrnFornitoriF24dm10s { get; set; }
        public virtual DbSet<FrnGruppiValidazione> FrnGruppiValidaziones { get; set; }
        public virtual DbSet<FrnLogAzioniDocumenti> FrnLogAzioniDocumentis { get; set; }
        public virtual DbSet<FrnLogCheckRegContr> FrnLogCheckRegContrs { get; set; }
        public virtual DbSet<FrnLogDm10f24> FrnLogDm10f24s { get; set; }
        public virtual DbSet<FrnLogDurc> FrnLogDurcs { get; set; }
        public virtual DbSet<FrnLogInvioRasSap> FrnLogInvioRasSaps { get; set; }
        public virtual DbSet<FrnLogInvioRilascioProtocollo> FrnLogInvioRilascioProtocollos { get; set; }
        public virtual DbSet<FrnLogQuietanze> FrnLogQuietanzes { get; set; }
        public virtual DbSet<FrnLogRa> FrnLogRas { get; set; }
        public virtual DbSet<FrnParametri> FrnParametris { get; set; }
        public virtual DbSet<FrnPermessiSharepoint> FrnPermessiSharepoints { get; set; }
        public virtual DbSet<FrnRdaDocumenti> FrnRdaDocumentis { get; set; }
        public virtual DbSet<FrnRdaExtra> FrnRdaExtras { get; set; }
        public virtual DbSet<FrnStatoDocumento> FrnStatoDocumentos { get; set; }
        public virtual DbSet<FrnTipiDocumento> FrnTipiDocumentos { get; set; }
        public virtual DbSet<FrnTipoDocumentoLibero> FrnTipoDocumentoLiberos { get; set; }
        public virtual DbSet<FrnUtenti> FrnUtentis { get; set; }
        public virtual DbSet<FrnUtentiCruscotto> FrnUtentiCruscottos { get; set; }
        public virtual DbSet<FrnUtentiGruppiValidazione> FrnUtentiGruppiValidaziones { get; set; }
        public virtual DbSet<FrnVisibilitaDocumentoLibero> FrnVisibilitaDocumentoLiberos { get; set; }
        public virtual DbSet<FrnVistaCodaMail> FrnVistaCodaMails { get; set; }
        public virtual DbSet<FrnVistaCodiciRdaDaCaricareRifiutati> FrnVistaCodiciRdaDaCaricareRifiutatis { get; set; }
        public virtual DbSet<FrnVistaCodiciRdaDaCaricareRifiutatiScaduti> FrnVistaCodiciRdaDaCaricareRifiutatiScadutis { get; set; }
        public virtual DbSet<FrnVistaCommesse> FrnVistaCommesses { get; set; }
        public virtual DbSet<FrnVistaCommesseDaAssociare> FrnVistaCommesseDaAssociares { get; set; }
        public virtual DbSet<FrnVistaCommesseFornitori> FrnVistaCommesseFornitoris { get; set; }
        public virtual DbSet<FrnVistaCommesseGestite> FrnVistaCommesseGestites { get; set; }
        public virtual DbSet<FrnVistaConcatCommesseTipoDocumento> FrnVistaConcatCommesseTipoDocumentos { get; set; }
        public virtual DbSet<FrnVistaDocSolleciti> FrnVistaDocSollecitis { get; set; }
        public virtual DbSet<FrnVistaDocumenti> FrnVistaDocumentis { get; set; }
        public virtual DbSet<FrnVistaDocumentiBase> FrnVistaDocumentiBases { get; set; }
        public virtual DbSet<FrnVistaDocumentiLiberi> FrnVistaDocumentiLiberis { get; set; }
        public virtual DbSet<FrnVistaDocumentiPerRdaBase> FrnVistaDocumentiPerRdaBases { get; set; }
        public virtual DbSet<FrnVistaDocumentiPerRdum> FrnVistaDocumentiPerRda { get; set; }
        public virtual DbSet<FrnVistaDocumentoDm10f24> FrnVistaDocumentoDm10f24s { get; set; }
        public virtual DbSet<FrnVistaDocumentoDurc> FrnVistaDocumentoDurcs { get; set; }
        public virtual DbSet<FrnVistaElencoRdaPerDocumento> FrnVistaElencoRdaPerDocumentos { get; set; }
        public virtual DbSet<FrnVistaFornitoreDurcPeriodoControllo> FrnVistaFornitoreDurcPeriodoControllos { get; set; }
        public virtual DbSet<FrnVistaFornitori> FrnVistaFornitoris { get; set; }
        public virtual DbSet<FrnVistaFornitoriDurc> FrnVistaFornitoriDurcs { get; set; }
        public virtual DbSet<FrnVistaGroupRdaValidate> FrnVistaGroupRdaValidates { get; set; }
        public virtual DbSet<FrnVistaQuietanze> FrnVistaQuietanzes { get; set; }
        public virtual DbSet<FrnVistaQuietanzeNew> FrnVistaQuietanzeNews { get; set; }
        public virtual DbSet<FrnVistaQuietanzeOpt> FrnVistaQuietanzeOpts { get; set; }
        public virtual DbSet<FrnVistaRasBase> FrnVistaRasBases { get; set; }
        public virtual DbSet<FrnVistaRasComunicazioneSubappalto> FrnVistaRasComunicazioneSubappaltos { get; set; }
        public virtual DbSet<FrnVistaRasComunicazioniDaInviare> FrnVistaRasComunicazioniDaInviares { get; set; }
        public virtual DbSet<FrnVistaRasFull> FrnVistaRasFulls { get; set; }
        public virtual DbSet<FrnVistaRasFullDataInvioRasNulla> FrnVistaRasFullDataInvioRasNullas { get; set; }
        public virtual DbSet<FrnVistaRdaAssociazioneDocumentiEsistenti> FrnVistaRdaAssociazioneDocumentiEsistentis { get; set; }
        public virtual DbSet<FrnVistaRdaAssociazioneDocumentiEsistentiNew> FrnVistaRdaAssociazioneDocumentiEsistentiNews { get; set; }
        public virtual DbSet<FrnVistaRdaAssociazioneNuoviDocumenti> FrnVistaRdaAssociazioneNuoviDocumentis { get; set; }
        public virtual DbSet<FrnVistaRdaAssociazioneNuoviDocumentiNew> FrnVistaRdaAssociazioneNuoviDocumentiNews { get; set; }
        public virtual DbSet<FrnVistaRdaCommessa> FrnVistaRdaCommessas { get; set; }
        public virtual DbSet<FrnVistaRdaCommessaNew> FrnVistaRdaCommessaNews { get; set; }
        public virtual DbSet<FrnVistaRdaCommessaSocietum> FrnVistaRdaCommessaSocieta { get; set; }
        public virtual DbSet<FrnVistaRdaConAlberatura> FrnVistaRdaConAlberaturas { get; set; }
        public virtual DbSet<FrnVistaRdaFornitoreDurc> FrnVistaRdaFornitoreDurcs { get; set; }
        public virtual DbSet<FrnVistaRdaInAttesaDiDocumenti> FrnVistaRdaInAttesaDiDocumentis { get; set; }
        public virtual DbSet<FrnVistaRdaInAttesaDiDocumentiNew> FrnVistaRdaInAttesaDiDocumentiNews { get; set; }
        public virtual DbSet<FrnVistaRdaSenzaAlberatura> FrnVistaRdaSenzaAlberaturas { get; set; }
        public virtual DbSet<FrnVistaRdaTuttiDocumentiValidati> FrnVistaRdaTuttiDocumentiValidatis { get; set; }
        public virtual DbSet<FrnVistaRdum> FrnVistaRda { get; set; }
        public virtual DbSet<FrnVistaRilascioOrdine> FrnVistaRilascioOrdines { get; set; }
        public virtual DbSet<FrnVistaStatoDocumento> FrnVistaStatoDocumentos { get; set; }
        public virtual DbSet<FrnVistaStorico> FrnVistaStoricos { get; set; }
        public virtual DbSet<FrnVistaTipiDocumentoCommesse> FrnVistaTipiDocumentoCommesses { get; set; }
        public virtual DbSet<FrnVistaValidaDocumenti> FrnVistaValidaDocumentis { get; set; }
        public virtual DbSet<FrnVistaValidaDocumentiGenerica> FrnVistaValidaDocumentiGenericas { get; set; }
        public virtual DbSet<FrnVistaValidazioneDocumenti> FrnVistaValidazioneDocumentis { get; set; }
        public virtual DbSet<LogGeneraF24> LogGeneraF24s { get; set; }
        public virtual DbSet<LogInvioSap> LogInvioSaps { get; set; }
        public virtual DbSet<LogStorico> LogStoricos { get; set; }
        public virtual DbSet<LogTrasferimentoFileSharepoint> LogTrasferimentoFileSharepoints { get; set; }
        public virtual DbSet<Sollecito> Sollecitos { get; set; }
        public virtual DbSet<StatoSollecito> StatoSollecitos { get; set; }
        public virtual DbSet<TempAllType> TempAllTypes { get; set; }
        public virtual DbSet<TempCodiceCluster> TempCodiceClusters { get; set; }
        public virtual DbSet<TempCodiceTipoPratica> TempCodiceTipoPraticas { get; set; }
        public virtual DbSet<TempCommessa> TempCommessas { get; set; }
        public virtual DbSet<TempDocumento> TempDocumentos { get; set; }
        public virtual DbSet<TempDocumentoCommessa> TempDocumentoCommessas { get; set; }
        public virtual DbSet<TempDocumentoDm10f24> TempDocumentoDm10f24s { get; set; }
        public virtual DbSet<TempFornitore> TempFornitores { get; set; }
        public virtual DbSet<TempRdum> TempRda { get; set; }
        public virtual DbSet<TempSocietum> TempSocieta { get; set; }
        public virtual DbSet<TempStatoRdum> TempStatoRda { get; set; }
        public virtual DbSet<TempTipoDocumento> TempTipoDocumentos { get; set; }
        public virtual DbSet<TmpDocumentiDettRdum> TmpDocumentiDettRda { get; set; }
        public virtual DbSet<TmpDurcDaSistemare> TmpDurcDaSistemares { get; set; }
        public virtual DbSet<TmpMaxDurcValidoFonritore> TmpMaxDurcValidoFonritores { get; set; }
        public virtual DbSet<ViewAssociazioneRdaFaci> ViewAssociazioneRdaFacis { get; set; }
        public virtual DbSet<ViewAssociazioneRdaFaciBase> ViewAssociazioneRdaFaciBases { get; set; }
        public virtual DbSet<ViewDocScadutiDaRichiedere> ViewDocScadutiDaRichiederes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=RKPSQL01DEV.intra.manutencoop.tst\\DEV;Initial Catalog=FORNITORI;Persist Security Info=True;User ID=svc_fornitori;Password=espfLO77!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrmVistaQuietanzeBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frm_Vista_Quietanze_Base");

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.Contratto).HasMaxLength(10);

                entity.Property(e => e.DataEmissione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPagamento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.Importo).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NumDocContabile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumFattura).HasMaxLength(16);

                entity.Property(e => e.NumPratica)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Ordine).HasMaxLength(10);

                entity.Property(e => e.Referente).HasMaxLength(50);
            });

            modelBuilder.Entity<FrnAnagraficaEventi>(entity =>
            {
                entity.ToTable("Frn_Anagrafica_Eventi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Evento)
                    .HasMaxLength(255)
                    .HasColumnName("evento");

                entity.Property(e => e.Mailtemplate).HasColumnName("mailtemplate");

                entity.Property(e => e.Oggettotemplate).HasColumnName("oggettotemplate");
            });

            modelBuilder.Entity<FrnCodaEmail>(entity =>
            {
                entity.ToTable("Frn_Coda_Email");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento).HasColumnType("datetime");

                entity.Property(e => e.DataInvio).HasColumnType("datetime");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdFileSharepoint).HasMaxLength(50);

                entity.Property(e => e.InviatoDa).HasMaxLength(255);
            });

            modelBuilder.Entity<FrnControlloRegolaritaContributiva>(entity =>
            {
                entity.ToTable("Frn_Controllo_Regolarita_Contributiva");

                entity.HasIndex(e => new { e.IdFornitore, e.Anno }, "IX_Frn_Controllo_Regolarita_Contributiva")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DataOraUltimoInvio).HasColumnType("datetime");
            });

            modelBuilder.Entity<FrnDocumentiCommessa>(entity =>
            {
                entity.ToTable("FRN_DOCUMENTI_COMMESSA");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Cartella)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARTELLA");

                entity.Property(e => e.Contratto)
                    .HasColumnName("CONTRATTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Faci)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FACI");

                entity.Property(e => e.Firmadigitaleobbligatoria).HasColumnName("FIRMADIGITALEOBBLIGATORIA");

                entity.Property(e => e.Idtipodocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDTIPODOCUMENTO");

                entity.Property(e => e.Originalenecessario)
                    .HasColumnName("ORIGINALENECESSARIO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rialascioordine)
                    .HasColumnName("RIALASCIOORDINE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subappalto)
                    .HasColumnName("SUBAPPALTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateStamp).HasColumnType("datetime");

                entity.HasOne(d => d.IdtipodocumentoNavigation)
                    .WithMany(p => p.FrnDocumentiCommessas)
                    .HasForeignKey(d => d.Idtipodocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FRN_DOCUMENTI_COMMESSA_FRN_TIPI_DOCUMENTO");
            });

            modelBuilder.Entity<FrnDocumentiStornoValidazione>(entity =>
            {
                entity.ToTable("Frn_Documenti_StornoValidazione");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idDocumento");

                entity.Property(e => e.Motivo).HasColumnName("motivo");

                entity.Property(e => e.Utente)
                    .HasMaxLength(50)
                    .HasColumnName("utente");
            });

            modelBuilder.Entity<FrnDocumento>(entity =>
            {
                entity.ToTable("Frn_Documento");

                entity.HasIndex(e => e.CodiceRda, "Frn_Documento_IDX1");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AbilitaCaricamentoFornitore).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfermaPresaVisione).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaCaricareSuSp)
                    .HasColumnName("DaCaricareSuSP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInvioSollecito).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataPrevistaProssimoSollecito).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratoDaScaduto).HasDefaultValueSql("((0))");

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.Scaduto).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatoDocumento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSollecitoNavigation)
                    .WithMany(p => p.FrnDocumentos)
                    .HasForeignKey(d => d.IdSollecito)
                    .HasConstraintName("FK_Frn_Documento_Sollecito");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.FrnDocumentos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FRN_RDA_COMMESSA_FRN_TIPI_DOCUMENTO");

                entity.HasOne(d => d.StatoDocumentoNavigation)
                    .WithMany(p => p.FrnDocumentos)
                    .HasForeignKey(d => d.StatoDocumento)
                    .HasConstraintName("FK_FRN_RDA_COMMESSA_FRN_STATO_DOCUMENTO");
            });

            modelBuilder.Entity<FrnDocumentoCommesse>(entity =>
            {
                entity.HasKey(e => new { e.IdDocumento, e.IdCommessa })
                    .HasName("PK_DocumentoCommesse");

                entity.ToTable("Frn_DocumentoCommesse");

                entity.Property(e => e.IdDocumento).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdDocumentoNavigation)
                    .WithMany(p => p.FrnDocumentoCommesses)
                    .HasForeignKey(d => d.IdDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Frn_DocumentoCommesse_FRN_TIPI_DOCUMENTO");
            });

            modelBuilder.Entity<FrnDocumentoStorico>(entity =>
            {
                entity.ToTable("Frn_Documento_Storico");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaCaricareSuSp).HasColumnName("DaCaricareSuSP");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdFrnDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idFrnDocumento");

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.UpdateNote)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnDurcF24dm10Log>(entity =>
            {
                entity.ToTable("Frn_Durc_F24DM10_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioSAP");

                entity.Property(e => e.InseritoRimosso)
                    .HasMaxLength(20)
                    .HasComment("INSERITO oppure RIMOSSO");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasComment("Valori: DURC oppure F24DM10");

                entity.Property(e => e.Utente).HasMaxLength(50);

                entity.Property(e => e.ValiditaDurc)
                    .HasColumnType("datetime")
                    .HasColumnName("ValiditaDURC");

                entity.Property(e => e.ValiditaF24dm10Anno).HasColumnName("ValiditaF24DM10_Anno");

                entity.Property(e => e.ValiditaF24dm10Mese).HasColumnName("ValiditaF24DM10_Mese");
            });

            modelBuilder.Entity<FrnFornitoriDurc>(entity =>
            {
                entity.HasKey(e => e.IdFornitore);

                entity.ToTable("Frn_Fornitori_Durc");

                entity.Property(e => e.IdFornitore).ValueGeneratedNever();

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.ForzatoData).HasColumnType("datetime");

                entity.Property(e => e.ForzatoFinoA).HasColumnType("datetime");

                entity.Property(e => e.ForzatoFinoAdataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("ForzatoFinoADataInvioSAP");

                entity.Property(e => e.ForzatoUser).HasMaxLength(50);

                entity.Property(e => e.ValidoFinoA).HasColumnType("datetime");

                entity.Property(e => e.ValidoFinoAdataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("ValidoFinoADataInvioSAP");
            });

            modelBuilder.Entity<FrnFornitoriF24dm10>(entity =>
            {
                entity.ToTable("Frn_Fornitori_F24DM10");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.Forzato).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForzatoData).HasColumnType("datetime");

                entity.Property(e => e.ForzatoUser).HasMaxLength(50);
            });

            modelBuilder.Entity<FrnGruppiValidazione>(entity =>
            {
                entity.ToTable("Frn_Gruppi_Validazione");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Codice)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descrizione).HasMaxLength(300);
            });

            modelBuilder.Entity<FrnLogAzioniDocumenti>(entity =>
            {
                entity.ToTable("Frn_LogAzioniDocumenti");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Azione)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataOra).HasColumnType("datetime");

                entity.Property(e => e.IdDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.Utente)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnLogCheckRegContr>(entity =>
            {
                entity.ToTable("Frn_LogCheckRegContr");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DataInvioSap).HasColumnType("datetime");

                entity.Property(e => e.DataOra).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnLogDm10f24>(entity =>
            {
                entity.ToTable("Frn_LogDM10F24");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dataora)
                    .HasColumnType("datetime")
                    .HasColumnName("dataora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Esito).HasMaxLength(5);

                entity.Property(e => e.IdOrigine).HasColumnName("idOrigine");

                entity.Property(e => e.Messaggio).HasMaxLength(255);
            });

            modelBuilder.Entity<FrnLogDurc>(entity =>
            {
                entity.ToTable("Frn_LogDurc");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(50)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Messaggio).HasColumnName("messaggio");

                entity.Property(e => e.Stato)
                    .HasMaxLength(50)
                    .HasColumnName("stato");

                entity.Property(e => e.TipoInvio)
                    .HasMaxLength(50)
                    .HasColumnName("tipoInvio")
                    .HasComment("DURC oppure FORZATURA");
            });

            modelBuilder.Entity<FrnLogInvioRasSap>(entity =>
            {
                entity.ToTable("Frn_LogInvioRasSAP");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DataInvioRas).HasMaxLength(50);

                entity.Property(e => e.DataInvioRichCapogruppo).HasMaxLength(50);

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<FrnLogInvioRilascioProtocollo>(entity =>
            {
                entity.ToTable("Frn_LogInvioRilascioProtocollo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodiceRda).HasMaxLength(50);

                entity.Property(e => e.DataInvioSap).HasColumnType("datetime");
            });

            modelBuilder.Entity<FrnLogQuietanze>(entity =>
            {
                entity.ToTable("Frn_LogQuietanze");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Errore).HasColumnName("errore");

                entity.Property(e => e.IdDocumento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("idDocumento");

                entity.Property(e => e.IdDocumentoquietanza).HasColumnName("idDocumentoquietanza");

                entity.Property(e => e.Stato)
                    .HasMaxLength(50)
                    .HasColumnName("stato");
            });

            modelBuilder.Entity<FrnLogRa>(entity =>
            {
                entity.ToTable("Frn_LogRas");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioRas).HasColumnType("datetime");

                entity.Property(e => e.DataOra).HasColumnType("datetime");

                entity.Property(e => e.ImportoAutorizzato).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumeroRichiesta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnParametri>(entity =>
            {
                entity.ToTable("Frn_Parametri");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddMesiDurc).HasColumnName("AddMesiDURC");

                entity.Property(e => e.CodiceDocumentoDurc)
                    .HasMaxLength(50)
                    .HasColumnName("CodiceDocumentoDURC");

                entity.Property(e => e.CodiceDocumentoF24dm10)
                    .HasMaxLength(50)
                    .HasColumnName("CodiceDocumentoF24DM10");

                entity.Property(e => e.CodiceQuietanza).HasMaxLength(50);
            });

            modelBuilder.Entity<FrnPermessiSharepoint>(entity =>
            {
                entity.HasKey(e => e.CodiceSocieta);

                entity.ToTable("Frn_Permessi_Sharepoint");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.GruppoSp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GruppoSP");
            });

            modelBuilder.Entity<FrnRdaDocumenti>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdRda })
                    .HasName("PK_Frn_rda_Documenti");

                entity.ToTable("Frn_Rda_Documenti");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.CodiceRda).HasMaxLength(50);

                entity.Property(e => e.DataCaricamento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSharepoint).HasColumnName("idSharepoint");

                entity.Property(e => e.NomeFile).HasMaxLength(255);

                entity.Property(e => e.Tipologia).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<FrnRdaExtra>(entity =>
            {
                entity.HasKey(e => e.IdRda);

                entity.ToTable("Frn_Rda_Extra");

                entity.Property(e => e.IdRda).ValueGeneratedNever();

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioCapogruppo).HasColumnType("datetime");

                entity.Property(e => e.DataInvioCapogruppoDataOraInsUpd)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppo_DataOraInsUpd");

                entity.Property(e => e.DataInvioCapogruppoInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppoInvioSAP");

                entity.Property(e => e.DataInvioProtocolloSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioProtocolloSAP");

                entity.Property(e => e.DataInvioRas).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasDataOraInsUpd)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRas_DataOraInsUpd");

                entity.Property(e => e.DataInvioRasInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRasInvioSAP");

                entity.Property(e => e.ImportoAutorizzato).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroRichiesta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnStatoDocumento>(entity =>
            {
                entity.ToTable("FRN_STATO_DOCUMENTO");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnTipiDocumento>(entity =>
            {
                entity.ToTable("FRN_TIPI_DOCUMENTO");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.DaSollecitare).HasDefaultValueSql("((0))");

                entity.Property(e => e.Disabilitato).HasDefaultValueSql("((0))");

                entity.Property(e => e.DurataMesi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmailTracciabilita).HasMaxLength(255);

                entity.Property(e => e.EmailValidatore).HasMaxLength(100);

                entity.Property(e => e.IdFileSharepoint).HasMaxLength(50);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeFile).HasMaxLength(200);

                entity.Property(e => e.NonVisibile).HasDefaultValueSql("((0))");

                entity.Property(e => e.Periodico).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegolaritaContributiva).HasDefaultValueSql("((0))");

                entity.Property(e => e.RichiestaPresaVisione).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificoPerCommessa).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificoPerRda).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipologiaFaci).HasMaxLength(100);

                entity.Property(e => e.UpdateStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Validatore).HasMaxLength(100);

                entity.HasOne(d => d.IdGruppoValidazioneNavigation)
                    .WithMany(p => p.FrnTipiDocumentos)
                    .HasForeignKey(d => d.IdGruppoValidazione)
                    .HasConstraintName("FK_FRN_TIPI_DOCUMENTO_Frn_Gruppi_Validazione");
            });

            modelBuilder.Entity<FrnTipoDocumentoLibero>(entity =>
            {
                entity.ToTable("Frn_Tipo_Documento_Libero");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceDocumento)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione).IsUnicode(false);

                entity.Property(e => e.NomeDocumento)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnUtenti>(entity =>
            {
                entity.HasKey(e => e.Userad);

                entity.ToTable("Frn_Utenti");

                entity.Property(e => e.Userad)
                    .HasMaxLength(255)
                    .HasColumnName("userad")
                    .HasComment("0=sola visualizzazione; 1=modifica (se ha i permessi sul documento da gruppo validazione)");

                entity.Property(e => e.LivelloAutorizzazione).HasColumnName("livello_autorizzazione");

                entity.Property(e => e.Nomecognome)
                    .HasMaxLength(255)
                    .HasColumnName("nomecognome");

                entity.Property(e => e.Visualizzareport)
                    .HasColumnName("visualizzareport")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FrnUtentiCruscotto>(entity =>
            {
                entity.ToTable("Frn_Utenti_Cruscotto");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserAdMaster)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserAdSlave)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FrnUtentiGruppiValidazione>(entity =>
            {
                entity.ToTable("Frn_Utenti_GruppiValidazione");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdGruppoValidazione)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idGruppoValidazione");

                entity.Property(e => e.Userad)
                    .HasMaxLength(255)
                    .HasColumnName("userad");

                entity.HasOne(d => d.IdGruppoValidazioneNavigation)
                    .WithMany(p => p.FrnUtentiGruppiValidaziones)
                    .HasForeignKey(d => d.IdGruppoValidazione)
                    .HasConstraintName("FK_Frn_Utenti_GruppiValidazione_Frn_Utenti_GruppiValidazione");

                entity.HasOne(d => d.UseradNavigation)
                    .WithMany(p => p.FrnUtentiGruppiValidaziones)
                    .HasForeignKey(d => d.Userad)
                    .HasConstraintName("FK_Frn_Utenti_GruppiValidazione_Frn_Utenti");
            });

            modelBuilder.Entity<FrnVisibilitaDocumentoLibero>(entity =>
            {
                entity.ToTable("Frn_Visibilita_Documento_Libero");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaCodaMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_CodaMail");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento).HasColumnType("datetime");

                entity.Property(e => e.DataInvio).HasColumnType("datetime");

                entity.Property(e => e.EMailReferentePrimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferentePrimario");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InviatoDa).HasMaxLength(255);
            });

            modelBuilder.Entity<FrnVistaCodiciRdaDaCaricareRifiutati>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Codici_Rda_Da_Caricare_Rifiutati");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroOrdineAcquisto).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaCodiciRdaDaCaricareRifiutatiScaduti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Codici_Rda_Da_Caricare_Rifiutati_Scaduti");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroOrdineAcquisto).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaCommesse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Commesse");

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.IdDocumento).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<FrnVistaCommesseDaAssociare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Commesse_Da_Associare");

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.DataFineCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataFineProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataInizioCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataPrimaRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataPrimaRDA");

                entity.Property(e => e.DataProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataProrogaPotenziale).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipo).HasMaxLength(8);

                entity.Property(e => e.GestioneSp).HasColumnName("GestioneSP");

                entity.Property(e => e.RagioneSociale).HasMaxLength(100);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<FrnVistaCommesseFornitori>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Commesse_Fornitori");

                entity.Property(e => e.Cap)
                    .HasMaxLength(10)
                    .HasColumnName("CAP");

                entity.Property(e => e.Cellulare).HasMaxLength(16);

                entity.Property(e => e.CodiceCommessaLiv1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodiceFiscale).HasMaxLength(16);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.DataUltimoOdaBem)
                    .HasColumnType("datetime")
                    .HasColumnName("DataUltimoODA_BEM");

                entity.Property(e => e.EMailReferentePrimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferentePrimario");

                entity.Property(e => e.Fax).HasMaxLength(31);

                entity.Property(e => e.Indirizzo).HasMaxLength(71);

                entity.Property(e => e.InvioRegConSap).HasColumnName("InvioRegConSAP");

                entity.Property(e => e.Lingua).HasMaxLength(2);

                entity.Property(e => e.Localita).HasMaxLength(40);

                entity.Property(e => e.Nazione).HasMaxLength(40);

                entity.Property(e => e.NomeReferentePrimario)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizzAcquisti).HasMaxLength(4);

                entity.Property(e => e.PartitaIva).HasMaxLength(11);

                entity.Property(e => e.PartitaIvaInternazionale).HasMaxLength(20);

                entity.Property(e => e.PartitaIvaStenr)
                    .HasMaxLength(18)
                    .HasColumnName("PartitaIva_STENR");

                entity.Property(e => e.Provincia).HasMaxLength(40);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.SapBpid)
                    .HasMaxLength(50)
                    .HasColumnName("SAP_BPID");

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.UltimoInvioRegConSap)
                    .HasColumnType("datetime")
                    .HasColumnName("UltimoInvioRegConSAP");

                entity.Property(e => e.UrlAreaRiservata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPortaleSpecifico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UtenteAD");
            });

            modelBuilder.Entity<FrnVistaCommesseGestite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Commesse_Gestite");

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.DataFineCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataFineProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataInizioCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataProrogaPotenziale).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.GestioneSp).HasColumnName("GestioneSP");

                entity.Property(e => e.RagioneSociale).HasMaxLength(100);

                entity.Property(e => e.TipoCliente).HasMaxLength(8);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<FrnVistaConcatCommesseTipoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Concat_Commesse_TipoDocumento");

                entity.Property(e => e.CodiciCommesse).HasMaxLength(4000);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(4000);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<FrnVistaDocSolleciti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocSolleciti");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaCaricareSuSp).HasColumnName("DaCaricareSuSP");

                entity.Property(e => e.DataAttivazione).HasColumnType("datetime");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataProssimoInvio).HasColumnType("date");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUltimoInvio).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(50);

                entity.Property(e => e.EMailReferentePrimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferentePrimario");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdStatoSollecito).HasColumnName("idStatoSollecito");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaDocumenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Documenti");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiesta2).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneStato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DurataMesi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepoint).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdFornitore).HasMaxLength(50);

                entity.Property(e => e.NomeDocumento).HasMaxLength(300);

                entity.Property(e => e.NomeFile).HasMaxLength(200);

                entity.Property(e => e.NomeFileUpload).HasMaxLength(500);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.SollecitoDataAttivazione)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataAttivazione");

                entity.Property(e => e.SollecitoDataProssimoInvio)
                    .HasColumnType("date")
                    .HasColumnName("Sollecito_DataProssimoInvio");

                entity.Property(e => e.SollecitoDataUltimoInvio)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataUltimoInvio");

                entity.Property(e => e.SollecitoIdStato).HasColumnName("Sollecito_IdStato");

                entity.Property(e => e.SollecitoIsActive).HasColumnName("Sollecito_IsActive");

                entity.Property(e => e.SollecitoNumeroMassimoSolleciti).HasColumnName("Sollecito_NumeroMassimoSolleciti");

                entity.Property(e => e.SollecitoNumeroSollecitiInviati).HasColumnName("Sollecito_NumeroSollecitiInviati");

                entity.Property(e => e.SollecitoTipoSollecitoUltimoInvio).HasColumnName("Sollecito_TipoSollecitoUltimoInvio");

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaDocumentiBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Documenti_Base");

                entity.Property(e => e.DocumentState)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);
            });

            modelBuilder.Entity<FrnVistaDocumentiLiberi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocumentiLiberi");

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneStato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneStatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DurataMesi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepoint).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeFileTemplate).HasMaxLength(200);

                entity.Property(e => e.NomeFileUpload).HasMaxLength(500);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaDocumentiPerRdaBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocumentiPerRDA_Base");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraUpload).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);
            });

            modelBuilder.Entity<FrnVistaDocumentiPerRdum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocumentiPerRDA");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraUpload).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);
            });

            modelBuilder.Entity<FrnVistaDocumentoDm10f24>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocumentoDM10F24");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataOraCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraValidazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneStatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentState)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeDocumento).HasMaxLength(300);

                entity.Property(e => e.NomeFile).HasMaxLength(500);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.SapBpid)
                    .HasMaxLength(50)
                    .HasColumnName("SAP_BPID");

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaDocumentoDurc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_DocumentoDURC");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DataCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataOraCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraValidazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneStatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeDocumento).HasMaxLength(300);

                entity.Property(e => e.NomeFile).HasMaxLength(500);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.SapBpid)
                    .HasMaxLength(50)
                    .HasColumnName("SAP_BPID");

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaElencoRdaPerDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_ElencoRDA_per_Documento");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);
            });

            modelBuilder.Entity<FrnVistaFornitoreDurcPeriodoControllo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Fornitore_Durc_PeriodoControllo");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.DataFinePeriodoControllo).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");
            });

            modelBuilder.Entity<FrnVistaFornitori>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Fornitori");

                entity.Property(e => e.Cap)
                    .HasMaxLength(10)
                    .HasColumnName("CAP");

                entity.Property(e => e.Cellulare).HasMaxLength(16);

                entity.Property(e => e.CodiceFiscale).HasMaxLength(16);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.DataUltimoOdaBem)
                    .HasColumnType("datetime")
                    .HasColumnName("DataUltimoODA_BEM");

                entity.Property(e => e.EMailReferentePrimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferentePrimario");

                entity.Property(e => e.Fax).HasMaxLength(31);

                entity.Property(e => e.Indirizzo).HasMaxLength(71);

                entity.Property(e => e.InvioRegConSap).HasColumnName("InvioRegConSAP");

                entity.Property(e => e.Lingua).HasMaxLength(2);

                entity.Property(e => e.Localita).HasMaxLength(40);

                entity.Property(e => e.Nazione).HasMaxLength(40);

                entity.Property(e => e.NomeReferentePrimario)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizzAcquisti).HasMaxLength(4);

                entity.Property(e => e.PartitaIva).HasMaxLength(11);

                entity.Property(e => e.PartitaIvaInternazionale).HasMaxLength(20);

                entity.Property(e => e.PartitaIvaStenr)
                    .HasMaxLength(18)
                    .HasColumnName("PartitaIva_STENR");

                entity.Property(e => e.Provincia).HasMaxLength(40);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.SapBpid)
                    .HasMaxLength(50)
                    .HasColumnName("SAP_BPID");

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.UltimoInvioRegConSap)
                    .HasColumnType("datetime")
                    .HasColumnName("UltimoInvioRegConSAP");

                entity.Property(e => e.UrlAreaRiservata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPortaleSpecifico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UtenteAD");
            });

            modelBuilder.Entity<FrnVistaFornitoriDurc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Fornitori_Durc");

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.DataFinePeriodoControllo).HasColumnType("datetime");

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);
            });

            modelBuilder.Entity<FrnVistaGroupRdaValidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Group_Rda_Validate");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Massimo).HasColumnName("massimo");

                entity.Property(e => e.Minimo).HasColumnName("minimo");
            });

            modelBuilder.Entity<FrnVistaQuietanze>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Quietanze");

                entity.Property(e => e.Anno)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.Contratto).HasMaxLength(10);

                entity.Property(e => e.DataEmissione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPagamento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiesta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRifiuto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataUpload)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataValidazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DocumentState).HasMaxLength(2);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Importo).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NumDocContabile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumFattura).HasMaxLength(16);

                entity.Property(e => e.NumPratica)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Ordine).HasMaxLength(10);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Referente).HasMaxLength(50);

                entity.Property(e => e.SollecitoDataAttivazione)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataAttivazione");

                entity.Property(e => e.SollecitoDataProssimoInvio)
                    .HasColumnType("date")
                    .HasColumnName("Sollecito_DataProssimoInvio");

                entity.Property(e => e.SollecitoDataUltimoInvio)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataUltimoInvio");

                entity.Property(e => e.SollecitoIdStato).HasColumnName("Sollecito_IdStato");

                entity.Property(e => e.SollecitoIsActive).HasColumnName("Sollecito_IsActive");

                entity.Property(e => e.SollecitoNumeroMassimoSolleciti).HasColumnName("Sollecito_NumeroMassimoSolleciti");

                entity.Property(e => e.SollecitoNumeroSollecitiInviati).HasColumnName("Sollecito_NumeroSollecitiInviati");

                entity.Property(e => e.SollecitoTipoSollecitoUltimoInvio).HasColumnName("Sollecito_TipoSollecitoUltimoInvio");
            });

            modelBuilder.Entity<FrnVistaQuietanzeNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Quietanze_New");

                entity.Property(e => e.Anno)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.Contratto).HasMaxLength(10);

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataOraEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataOraPagamento).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataOraUpload).HasColumnType("datetime");

                entity.Property(e => e.DataOraValidazione).HasColumnType("datetime");

                entity.Property(e => e.DataPagamento).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DocumentState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Importo).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NumDocContabile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumFattura).HasMaxLength(16);

                entity.Property(e => e.NumPratica)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Ordine).HasMaxLength(10);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Referente).HasMaxLength(50);

                entity.Property(e => e.SollecitoDataAttivazione)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataAttivazione");

                entity.Property(e => e.SollecitoDataProssimoInvio)
                    .HasColumnType("date")
                    .HasColumnName("Sollecito_DataProssimoInvio");

                entity.Property(e => e.SollecitoDataUltimoInvio)
                    .HasColumnType("datetime")
                    .HasColumnName("Sollecito_DataUltimoInvio");

                entity.Property(e => e.SollecitoIdStato).HasColumnName("Sollecito_IdStato");

                entity.Property(e => e.SollecitoIsActive).HasColumnName("Sollecito_IsActive");

                entity.Property(e => e.SollecitoNumeroMassimoSolleciti).HasColumnName("Sollecito_NumeroMassimoSolleciti");

                entity.Property(e => e.SollecitoNumeroSollecitiInviati).HasColumnName("Sollecito_NumeroSollecitiInviati");

                entity.Property(e => e.SollecitoTipoSollecitoUltimoInvio).HasColumnName("Sollecito_TipoSollecitoUltimoInvio");

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaQuietanzeOpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Quietanze_Opt");

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.Contratto).HasMaxLength(10);

                entity.Property(e => e.DataEmissione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPagamento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DocumentState)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Importo).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NumDocContabile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumFattura).HasMaxLength(16);

                entity.Property(e => e.NumPratica)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Ordine).HasMaxLength(10);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.Referente).HasMaxLength(50);
            });

            modelBuilder.Entity<FrnVistaRasBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Ras_Base");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoRda)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaRasComunicazioneSubappalto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Ras_Comunicazione_Subappalto");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoRda)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaRasComunicazioniDaInviare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_RasComunicazioniDaInviare");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessaLiv1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(10);

                entity.Property(e => e.DataAutorizzazioneSubappaltosStr)
                    .HasMaxLength(8)
                    .HasColumnName("DataAutorizzazioneSubappaltosSTR");

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutStr).HasMaxLength(4000);

                entity.Property(e => e.DataInvioCapoGruppo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioCapogruppoDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioCapogruppoInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppoInvioSAP");

                entity.Property(e => e.DataInvioRasDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRasInvioSAP");

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRasStr).HasMaxLength(4000);

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCluster)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneCommessaLivello1).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Faci)
                    .HasMaxLength(24)
                    .HasColumnName("FACI");

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OkDocumenti)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRasFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Ras_Full");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessaLiv1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(10);

                entity.Property(e => e.DataAutorizzazioneSubappaltosStr)
                    .HasMaxLength(8)
                    .HasColumnName("DataAutorizzazioneSubappaltosSTR");

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutStr).HasMaxLength(4000);

                entity.Property(e => e.DataInvioCapoGruppo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioCapogruppoDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioCapogruppoInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppoInvioSAP");

                entity.Property(e => e.DataInvioRasDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRasInvioSAP");

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRasStr).HasMaxLength(4000);

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCluster)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneCommessaLivello1).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Faci)
                    .HasMaxLength(24)
                    .HasColumnName("FACI");

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OkDocumenti)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRasFullDataInvioRasNulla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Ras_Full_DataInvioRasNulla");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessaLiv1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(10);

                entity.Property(e => e.DataAutorizzazioneSubappaltosStr)
                    .HasMaxLength(8)
                    .HasColumnName("DataAutorizzazioneSubappaltosSTR");

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutStr).HasMaxLength(4000);

                entity.Property(e => e.DataInvioCapoGruppo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioCapogruppoDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioCapogruppoInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppoInvioSAP");

                entity.Property(e => e.DataInvioRasDateTime).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRasInvioSAP");

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRasStr).HasMaxLength(4000);

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DescrizioneCapogruppo).HasMaxLength(500);

                entity.Property(e => e.DescrizioneCluster)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneCommessaLivello1).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Faci)
                    .HasMaxLength(24)
                    .HasColumnName("FACI");

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OkDocumenti)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRdaAssociazioneDocumentiEsistenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Associazione_Documenti_Esistenti");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaAssociazioneDocumentiEsistentiNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Associazione_Documenti_Esistenti_New");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaAssociazioneNuoviDocumenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Associazione_Nuovi_Documenti");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaAssociazioneNuoviDocumentiNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Associazione_Nuovi_Documenti_New");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaCommessa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FRN_VISTA_RDA_COMMESSA");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFineValidita)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataInizioValidita)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioRasRda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiesta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataRifiuto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataUpload)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataValidazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneStatoSollecito).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointTemplate).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NomeFileTemplate).HasMaxLength(200);

                entity.Property(e => e.NomeTipoDocumento).HasMaxLength(300);

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Performance)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.StatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipologiaFaci).HasMaxLength(100);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaRdaCommessaNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FRN_VISTA_RDA_COMMESSA_NEW");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasRda).HasColumnType("datetime");

                entity.Property(e => e.DataOraRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataOraRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataOraUpload).HasColumnType("datetime");

                entity.Property(e => e.DataOraValidazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DescrizioneStatoSollecito).HasMaxLength(50);

                entity.Property(e => e.DescrizioneTipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FACI");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointTemplate).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImportoAutorizzatoRda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NomeFileTemplate).HasMaxLength(200);

                entity.Property(e => e.NomeTipoDocumento).HasMaxLength(300);

                entity.Property(e => e.NumeroRichiestaRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Performance)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.StatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipologiaFaci).HasMaxLength(100);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaRdaCommessaSocietum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Commessa_Societa");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroOrdineAcquisto).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRdaConAlberatura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Con_Alberatura");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRdaFornitoreDurc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Fornitore_Durc");

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.DataFinePeriodoControllo).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);
            });

            modelBuilder.Entity<FrnVistaRdaInAttesaDiDocumenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_In_Attesa_Di_Documenti");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaInAttesaDiDocumentiNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_In_Attesa_Di_Documenti_New");

                entity.Property(e => e.AreaOrganizzativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceSap).HasMaxLength(10);

                entity.Property(e => e.CodiceSrm).HasMaxLength(50);

                entity.Property(e => e.DataPassaggioStato).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.StatoRdaContratto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");
            });

            modelBuilder.Entity<FrnVistaRdaSenzaAlberatura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_Senza_Alberatura");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRdaTuttiDocumentiValidati>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda_TuttiDocumenti_Validati");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Massimo).HasColumnName("massimo");

                entity.Property(e => e.Minimo).HasColumnName("minimo");
            });

            modelBuilder.Entity<FrnVistaRdum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Rda");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroOrdineAcquisto).HasMaxLength(50);

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<FrnVistaRilascioOrdine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_RilascioOrdine");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRdaRilascioOrdine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataInvioCapogruppo).HasColumnType("datetime");

                entity.Property(e => e.DataInvioCapogruppoDataOraInsUpd)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppo_DataOraInsUpd");

                entity.Property(e => e.DataInvioCapogruppoInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioCapogruppoInvioSAP");

                entity.Property(e => e.DataInvioProtocolloSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioProtocolloSAP");

                entity.Property(e => e.DataInvioRas).HasColumnType("datetime");

                entity.Property(e => e.DataInvioRasDataOraInsUpd)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRas_DataOraInsUpd");

                entity.Property(e => e.DataInvioRasInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInvioRasInvioSAP");

                entity.Property(e => e.ImportoAutorizzato).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Massimo).HasColumnName("massimo");

                entity.Property(e => e.Minimo).HasColumnName("minimo");

                entity.Property(e => e.NumeroRichiesta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaStatoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Stato_Documento");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.DocumentState)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaStorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Storico");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DescrizioneStato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idDocumento");

                entity.Property(e => e.IdDocumentoStorico).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.Societa).HasMaxLength(100);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaTipiDocumentoCommesse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_TipiDocumento_Commesse");

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiciCommesse).HasMaxLength(4000);

                entity.Property(e => e.DescrizioniCommesse).HasMaxLength(4000);

                entity.Property(e => e.DurataMesi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmailTracciabilita).HasMaxLength(255);

                entity.Property(e => e.EmailValidatore).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepoint).HasMaxLength(50);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nome).HasMaxLength(300);

                entity.Property(e => e.NomeFile).HasMaxLength(200);

                entity.Property(e => e.TipologiaFaci).HasMaxLength(100);

                entity.Property(e => e.Validatore).HasMaxLength(100);
            });

            modelBuilder.Entity<FrnVistaValidaDocumenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Valida_Documenti");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdGruppoValidazione).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NomeTipoDocumento).HasMaxLength(300);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.RagioneSocialeSocieta).HasMaxLength(100);

                entity.Property(e => e.StatoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipologiaFaci).HasMaxLength(100);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrnVistaValidaDocumentiGenerica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_ValidaDocumenti_Generica");

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);
            });

            modelBuilder.Entity<FrnVistaValidazioneDocumenti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Frn_Vista_Validazione_Documenti");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreSap).HasMaxLength(10);

                entity.Property(e => e.CodiceFornitoreSrm).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.DataRichiestaAutorizzazione)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.Performance)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RagioneSocialeFornitore).HasMaxLength(150);

                entity.Property(e => e.StatoDocumentoRda)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBackOffice)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogGeneraF24>(entity =>
            {
                entity.HasKey(e => e.IdFornitore);

                entity.ToTable("Log_GeneraF24");

                entity.Property(e => e.IdFornitore)
                    .ValueGeneratedNever()
                    .HasColumnName("idFornitore");

                entity.Property(e => e.DataOraProcess).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogInvioSap>(entity =>
            {
                entity.ToTable("Log_InvioSAP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataOra)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Funzione).HasMaxLength(50);

                entity.Property(e => e.Stato).HasMaxLength(10);
            });

            modelBuilder.Entity<LogStorico>(entity =>
            {
                entity.ToTable("Log_Storico");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Errore).HasColumnName("errore");

                entity.Property(e => e.IdFrnDocumento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("idFrnDocumento");

                entity.Property(e => e.IdFrnDocumentoStorico)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("idFrnDocumentoStorico");

                entity.Property(e => e.Stato)
                    .HasMaxLength(50)
                    .HasColumnName("stato");
            });

            modelBuilder.Entity<LogTrasferimentoFileSharepoint>(entity =>
            {
                entity.ToTable("Log_TrasferimentoFileSharepoint");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiceSap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataFineProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DataInizioProcessamento).HasColumnType("datetime");

                entity.Property(e => e.IdSharepoint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlRelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sollecito>(entity =>
            {
                entity.ToTable("Sollecito");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DataAttivazione)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProssimoInvio).HasColumnType("date");

                entity.Property(e => e.DataUltimoInvio).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<StatoSollecito>(entity =>
            {
                entity.ToTable("StatoSollecito");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempAllType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_ALL_TYPES");

                entity.Property(e => e.Binary)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Char)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Decimal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Money).HasColumnType("money");

                entity.Property(e => e.Nchar)
                    .HasMaxLength(10)
                    .HasColumnName("NChar")
                    .IsFixedLength();

                entity.Property(e => e.Ntext)
                    .HasColumnType("ntext")
                    .HasColumnName("NText");

                entity.Property(e => e.Numeric).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NvarChar)
                    .HasMaxLength(50)
                    .HasColumnName("NVarChar");

                entity.Property(e => e.SmallDatetime).HasColumnType("smalldatetime");

                entity.Property(e => e.SmallMoney).HasColumnType("smallmoney");

                entity.Property(e => e.SqlVariant).HasColumnType("sql_variant");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VarBinary).HasMaxLength(50);

                entity.Property(e => e.Varchar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xml).HasColumnType("xml");
            });

            modelBuilder.Entity<TempCodiceCluster>(entity =>
            {
                entity.HasKey(e => e.Codice);

                entity.ToTable("TEMP_CodiceCluster");

                entity.Property(e => e.Codice)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCodiceTipoPratica>(entity =>
            {
                entity.HasKey(e => e.Codice);

                entity.ToTable("TEMP_CodiceTipoPratica");

                entity.Property(e => e.Codice)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCommessa>(entity =>
            {
                entity.HasKey(e => e.IdCommessa);

                entity.ToTable("TEMP_Commessa");

                entity.Property(e => e.IdCommessa).ValueGeneratedNever();

                entity.Property(e => e.CodiceCliente)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodiceCommessa).HasMaxLength(24);

                entity.Property(e => e.CodiceCommessaLiv1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodiceFiliale)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DataFineCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataFineProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataInizioCommessa).HasColumnType("datetime");

                entity.Property(e => e.DataPrimaRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataPrimaRDA");

                entity.Property(e => e.DataProrogaEffettiva).HasColumnType("datetime");

                entity.Property(e => e.DataProrogaPotenziale).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaModifica).HasColumnType("datetime");

                entity.Property(e => e.DefaultPerRda).HasColumnName("DefaultPerRDA");

                entity.Property(e => e.DescrizioneCommessa).HasMaxLength(50);

                entity.Property(e => e.IdStato)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stato).HasMaxLength(2);

                entity.Property(e => e.TipoCliente).HasMaxLength(8);

                entity.Property(e => e.TipoCommessa)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TempDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_Documento");

                entity.Property(e => e.DataCaricamento).HasColumnType("datetime");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataFineValiditaRegolaritaContributiva).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValiditaRegolaritaContributiva).HasColumnType("datetime");

                entity.Property(e => e.DataRespingimento).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaDocumento).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.IdDocumentoDm10f24).HasColumnName("IdDocumentoDM10F24");

                entity.Property(e => e.SpuserInserimento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPUserInserimento");

                entity.Property(e => e.SpuserRespingimento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPUserRespingimento");

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.ValidatoreSpuser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ValidatoreSPUser");

                entity.Property(e => e.ZzAnnoRiferimento).HasColumnName("ZZ_AnnoRiferimento");

                entity.Property(e => e.ZzDataPresentazione)
                    .HasColumnType("datetime")
                    .HasColumnName("ZZ_DataPresentazione");
            });

            modelBuilder.Entity<TempDocumentoCommessa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_DocumentoCommessa");

                entity.Property(e => e.CodiceCommessa)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumentoNew).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TempDocumentoDm10f24>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoDm10f24)
                    .IsClustered(false);

                entity.ToTable("TEMP_DocumentoDM10F24");

                entity.HasIndex(e => e.IdDocumentoDm10f24, "ClusteredIndex-20210714-003241")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.IdDocumentoDm10f24)
                    .ValueGeneratedNever()
                    .HasColumnName("IdDocumentoDM10F24");
            });

            modelBuilder.Entity<TempFornitore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_Fornitore");

                entity.Property(e => e.Cap)
                    .HasMaxLength(10)
                    .HasColumnName("CAP");

                entity.Property(e => e.Cellulare).HasMaxLength(16);

                entity.Property(e => e.CodiceFiscale).HasMaxLength(16);

                entity.Property(e => e.CodiceFornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("CodiceFornitore_SAP");

                entity.Property(e => e.DataUltimoOdaBem)
                    .HasColumnType("datetime")
                    .HasColumnName("DataUltimoODA_BEM");

                entity.Property(e => e.EMailReferentePrimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferentePrimario");

                entity.Property(e => e.Fax).HasMaxLength(31);

                entity.Property(e => e.Indirizzo).HasMaxLength(71);

                entity.Property(e => e.InvioRegConSap).HasColumnName("InvioRegConSAP");

                entity.Property(e => e.Lingua).HasMaxLength(2);

                entity.Property(e => e.Localita).HasMaxLength(40);

                entity.Property(e => e.Nazione).HasMaxLength(40);

                entity.Property(e => e.NomeReferentePrimario)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizzAcquisti).HasMaxLength(4);

                entity.Property(e => e.PartitaIva).HasMaxLength(11);

                entity.Property(e => e.PartitaIvaInternazionale).HasMaxLength(20);

                entity.Property(e => e.PartitaIvaStenr)
                    .HasMaxLength(18)
                    .HasColumnName("PartitaIva_STENR");

                entity.Property(e => e.Provincia).HasMaxLength(40);

                entity.Property(e => e.RagioneSociale).HasMaxLength(150);

                entity.Property(e => e.SapBpid)
                    .HasMaxLength(50)
                    .HasColumnName("SAP_BPID");

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.UltimoInvioRegConSap)
                    .HasColumnType("datetime")
                    .HasColumnName("UltimoInvioRegConSAP");

                entity.Property(e => e.UrlAreaRiservata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPortaleSpecifico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UtenteAD");
            });

            modelBuilder.Entity<TempRdum>(entity =>
            {
                entity.HasKey(e => e.IdRda);

                entity.ToTable("TEMP_RDA");

                entity.Property(e => e.IdRda)
                    .ValueGeneratedNever()
                    .HasColumnName("IdRDA");

                entity.Property(e => e.AreaOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoreRda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AutoreRDA");

                entity.Property(e => e.BuildingManager)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceCluster)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceFornitoreOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodiceRDA");

                entity.Property(e => e.CodiceStato)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOriginePrecedente)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoPrecedente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoPratica)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceTipoProtocollo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(8);

                entity.Property(e => e.DataChiusura).HasColumnType("datetime");

                entity.Property(e => e.DataComunicazioneRichiestaSubappalto).HasColumnType("datetime");

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.DataFirma).HasColumnType("datetime");

                entity.Property(e => e.DataInizioRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataInizioRDA");

                entity.Property(e => e.DataIntegrRichAut).HasMaxLength(8);

                entity.Property(e => e.DataIntegrRichAutPostSilenzioAssenso).HasMaxLength(8);

                entity.Property(e => e.DataPresaInCarico).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaAutorizzazione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiestaClienteIntegrazioneRas)
                    .HasMaxLength(8)
                    .HasColumnName("DataRichiestaClienteIntegrazioneRAS");

                entity.Property(e => e.DataStato).HasColumnType("datetime");

                entity.Property(e => e.Descrizione).HasMaxLength(400);

                entity.Property(e => e.DocFlow).HasMaxLength(50);

                entity.Property(e => e.Gruppo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImportoAutorizzato).HasMaxLength(20);

                entity.Property(e => e.NoteIntegrRas)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRAS");

                entity.Property(e => e.NoteIntegrRaspostSilenzioAssenso)
                    .HasMaxLength(255)
                    .HasColumnName("NoteIntegrRASPostSilenzioAssenso");

                entity.Property(e => e.NumeroRichiesta).HasMaxLength(50);

                entity.Property(e => e.RaccoltaCompletata)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SilenzioAssenso).HasMaxLength(1);

                entity.Property(e => e.StatoDocFlow)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPratica)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteBo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UtenteBO");

                entity.Property(e => e.VerificaSubappalto).HasMaxLength(1);
            });

            modelBuilder.Entity<TempSocietum>(entity =>
            {
                entity.HasKey(e => e.IdSocieta);

                entity.ToTable("TEMP_Societa");

                entity.Property(e => e.IdSocieta).ValueGeneratedNever();

                entity.Property(e => e.CodiceSocieta).HasMaxLength(4);

                entity.Property(e => e.GestioneSp).HasColumnName("GestioneSP");

                entity.Property(e => e.RagioneSociale).HasMaxLength(100);
            });

            modelBuilder.Entity<TempStatoRdum>(entity =>
            {
                entity.HasKey(e => new { e.IdSocieta, e.CodiceStato, e.CodiceStatoOrigine });

                entity.ToTable("TEMP_StatoRDA");

                entity.Property(e => e.CodiceStato)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceStatoOrigine)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneStato)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempTipoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_TipoDocumento");

                entity.Property(e => e.CodiceDocumento)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione).IsUnicode(false);

                entity.Property(e => e.EmailGruppoValidatore).HasMaxLength(50);

                entity.Property(e => e.NomeDocumento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificoPerRda).HasColumnName("SpecificoPerRDA");

                entity.Property(e => e.Urltemplate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("URLTemplate");

                entity.Property(e => e.Validatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpDocumentiDettRdum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tmp_documenti_dettRDA");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaCaricareSuSp).HasColumnName("DaCaricareSuSP");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRda).HasColumnName("IdRDA");

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpDurcDaSistemare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tmp_durc_da_sistemare");

                entity.Property(e => e.Idold).HasColumnName("idold");
            });

            modelBuilder.Entity<TmpMaxDurcValidoFonritore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tmp_max_durc_valido_fonritore");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewAssociazioneRdaFaci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AssociazioneRdaFaci");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaCaricareSuSp).HasColumnName("DaCaricareSuSP");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointTemplate).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NomeDocumentoTemplate).HasMaxLength(300);

                entity.Property(e => e.NomeFileTemplate).HasMaxLength(200);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewAssociazioneRdaFaciBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AssociazioneRdaFaci_Base");

                entity.Property(e => e.Cartella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaCaricareSuSp).HasColumnName("DaCaricareSuSP");

                entity.Property(e => e.DataEmissione).HasColumnType("datetime");

                entity.Property(e => e.DataFineValidita).HasColumnType("datetime");

                entity.Property(e => e.DataInizioValidita).HasColumnType("datetime");

                entity.Property(e => e.DataPresaVisione).HasColumnType("datetime");

                entity.Property(e => e.DataRichiesta).HasColumnType("datetime");

                entity.Property(e => e.DataRifiuto).HasColumnType("datetime");

                entity.Property(e => e.DataUpload).HasColumnType("datetime");

                entity.Property(e => e.DataValidazione).HasColumnType("datetime");

                entity.Property(e => e.Faci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuidRifiuto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuidValidazione)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoLibero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDocumentoRda).HasColumnName("idDocumentoRDA");

                entity.Property(e => e.IdFileSharepointTemplate).HasMaxLength(50);

                entity.Property(e => e.IdFileSharepointUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSollecito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTipoDocumento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomeDocumento).HasMaxLength(500);

                entity.Property(e => e.NomeDocumentoTemplate).HasMaxLength(300);

                entity.Property(e => e.NomeFileTemplate).HasMaxLength(200);

                entity.Property(e => e.QuietanzaDataInvioSap)
                    .HasColumnType("datetime")
                    .HasColumnName("QuietanzaDataInvioSAP");

                entity.Property(e => e.Urlrelativa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLRelativa");

                entity.Property(e => e.UtenteInserimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteRifiuto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteUpload)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtenteValidatore)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDocScadutiDaRichiedere>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDocScadutiDaRichiedere");

                entity.Property(e => e.CodiceDocumento).HasMaxLength(50);

                entity.Property(e => e.CodiceRda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodicefornitoreSap)
                    .HasMaxLength(10)
                    .HasColumnName("codicefornitore_sap");

                entity.Property(e => e.DataAutorizzazioneSubappalto).HasMaxLength(10);

                entity.Property(e => e.DataFineRda)
                    .HasColumnType("datetime")
                    .HasColumnName("DataFineRDA");

                entity.Property(e => e.EMailReferenteprimario)
                    .HasMaxLength(255)
                    .HasColumnName("eMailReferenteprimario");

                entity.Property(e => e.FineValidita).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.IdTipoDoc)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idTipoDoc");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nome)
                    .HasMaxLength(300)
                    .HasColumnName("nome");

                entity.Property(e => e.RagioneSociale)
                    .HasMaxLength(150)
                    .HasColumnName("ragioneSociale");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
