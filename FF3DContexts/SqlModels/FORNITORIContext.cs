using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FF3DContexts.SqlModels
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

        public virtual DbSet<FrnDocumento> FrnDocumentos { get; set; }
        public virtual DbSet<FrnUtenti> FrnUtentis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=RKPSQL01PRD.intra.manutencoop.it\\PRD;Initial Catalog=FORNITORI;Persist Security Info=True;connect timeout=3600;User ID=svc_fornitori;Password=srdfHJ45/");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrnDocumento>(entity =>
            {
                entity.ToTable("Frn_Documento");

                entity.HasIndex(e => new { e.DataFineValidita, e.IdFornitore, e.IdTipoDocumento }, "DataFineValidita");

                entity.HasIndex(e => new { e.CodiceRda, e.IdTipoDocumento, e.Cartella, e.DataFineValidita, e.IdFornitore }, "NonClusteredIndexPerEscusioneDoppi");

                entity.HasIndex(e => e.CodiceRda, "NonClusteredIndex_frnDocumento_CodiceRDA");

                entity.HasIndex(e => e.IdOld, "documento-idold-20220320-175158");

                entity.HasIndex(e => e.IdOld, "idold-20220319-120837");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
