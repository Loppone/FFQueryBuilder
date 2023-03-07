using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FF3DContexts.OracleModels
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Woreq> Woreqs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseOracle("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ora11quality.intra.manutencoop.it)(PORT=1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = MP2T)));USER ID=MP2; Password=MP2;",
                        x => x.UseOracleSQLCompatibility("11")
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MP2");

            modelBuilder.Entity<Woreq>(entity =>
            {
                entity.HasKey(e => new { e.Requestnum, e.Datereleased, e.Siteid });

                entity.ToTable("WOREQ");

                entity.HasIndex(e => new { e.Stato, e.Datereleased, e.Siteid, e.Idrichgestman }, "IDXILA_TLCM_02");

                entity.HasIndex(e => new { e.Datereleased, e.Siteid, e.Idrichgestman, e.Requestnum }, "IDXILA_TLCM_04");

                entity.HasIndex(e => e.Idrichgestman, "IDXILA_TLCM_05");

                entity.HasIndex(e => new { e.Wotype, e.Stato, e.Siteid, e.Requestnum, e.Idrichgestman }, "IDXILA_TLCM_08");

                entity.HasIndex(e => new { e.Datereleased, e.Stato, e.Siteid, e.Idrichgestman, e.Requestnum }, "IDXILA_TLCM_09");

                entity.HasIndex(e => new { e.Wotype, e.Stato, e.Siteid }, "IDXILA_TLCM_12");

                entity.HasIndex(e => new { e.Siteid, e.Requestedby, e.Datereleased, e.Requestnum, e.Origineinserimento }, "IDX_TKT2014091810000021_01");

                entity.HasIndex(e => new { e.Requestnum, e.Siteid }, "IDX_TKT_0000000924");

                entity.HasIndex(e => new { e.Codservizio, e.Siteid }, "IDX_WOREQ_CSERVSITE");

                entity.HasIndex(e => new { e.Idrichgestman, e.Tasknum, e.Requestdate, e.Siteid, e.Datereleased }, "IDX_WOREQ_IDRITASREQDTSIDDTRE");

                entity.HasIndex(e => new { e.Siteid, e.Requestnum }, "IDX_WOREQ_SIREQNUM");

                entity.HasIndex(e => new { e.Siteid, e.Requestnum, e.Datereleased }, "WOREQ_IDX_001");

                entity.HasIndex(e => new { e.Datereleased, e.Siteid, e.Wotype, e.Stato }, "WOREQ_IDX_002");

                entity.HasIndex(e => new { e.Datereleased, e.Operatorecc, e.Codicecomp }, "WOREQ_IDX_004");

                entity.HasIndex(e => e.Ext2, "WOREQ_IDX_005");

                entity.HasIndex(e => new { e.Siteid, e.Wotype, e.Datarifprev }, "WOREQ_IDX_006");

                entity.HasIndex(e => new { e.Siteid, e.Requestnum, e.Wotype }, "WOREQ_IDX_007");

                entity.HasIndex(e => new { e.Requestdate, e.Operatorecc, e.Siteid }, "WOREQ_IDX_008");

                entity.HasIndex(e => new { e.Siteid, e.Requestnum, e.Tasknum }, "WOREQ_IDX_009");

                entity.HasIndex(e => new { e.Siteid, e.Idrichgestman }, "WOREQ_IDX_010");

                entity.Property(e => e.Requestnum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTNUM");

                entity.Property(e => e.Datereleased)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATERELEASED");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SITEID");

                entity.Property(e => e.Ala)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALA");

                entity.Property(e => e.Assignedto)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ASSIGNEDTO");

                entity.Property(e => e.Cdccliente)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CDCCLIENTE");

                entity.Property(e => e.Classificazione)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLASSIFICAZIONE");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE");

                entity.Property(e => e.Clienteticket)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTETICKET");

                entity.Property(e => e.Codiceati)
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("CODICEATI");

                entity.Property(e => e.Codiceavviso)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODICEAVVISO");

                entity.Property(e => e.Codicecomp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODICECOMP");

                entity.Property(e => e.Codicemac)
                    .HasMaxLength(170)
                    .IsUnicode(false)
                    .HasColumnName("CODICEMAC");

                entity.Property(e => e.Codicemac2)
                    .HasMaxLength(170)
                    .IsUnicode(false)
                    .HasColumnName("CODICEMAC2");

                entity.Property(e => e.Codicepe)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODICEPE");

                entity.Property(e => e.Codmotivoannull)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODMOTIVOANNULL");

                entity.Property(e => e.Codservizio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODSERVIZIO");

                entity.Property(e => e.Competenza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMPETENZA");

                entity.Property(e => e.Complesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLESSO");

                entity.Property(e => e.Componenti)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COMPONENTI");

                entity.Property(e => e.Convnum)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONVNUM");

                entity.Property(e => e.Danno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DANNO");

                entity.Property(e => e.DataDiffSms)
                    .HasColumnType("DATE")
                    .HasColumnName("DATA_DIFF_SMS");

                entity.Property(e => e.Dataautproc)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATAAUTPROC");

                entity.Property(e => e.Datafaxditta)
                    .HasColumnType("DATE")
                    .HasColumnName("DATAFAXDITTA");

                entity.Property(e => e.Dataprevconsprev)
                    .HasColumnType("DATE")
                    .HasColumnName("DATAPREVCONSPREV");

                entity.Property(e => e.Dataprevin)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATAPREVIN");

                entity.Property(e => e.Dataprevinmpf)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATAPREVINMPF");

                entity.Property(e => e.Dataprocesso)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATAPROCESSO");

                entity.Property(e => e.Dataricprev)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATARICPREV");

                entity.Property(e => e.Datarifprev)
                    .HasColumnType("DATE")
                    .HasColumnName("DATARIFPREV");

                entity.Property(e => e.Datasmsritardato)
                    .HasColumnType("DATE")
                    .HasColumnName("DATASMSRITARDATO");

                entity.Property(e => e.Datasopralluogo)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATASOPRALLUOGO");

                entity.Property(e => e.Datasosp)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DATASOSP");

                entity.Property(e => e.Datastatosms)
                    .HasColumnType("DATE")
                    .HasColumnName("DATASTATOSMS");

                entity.Property(e => e.Datastatosms2)
                    .HasColumnType("DATE")
                    .HasColumnName("DATASTATOSMS2");

                entity.Property(e => e.Descrizionebreve)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIZIONEBREVE");

                entity.Property(e => e.DestinazioneUso)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESTINAZIONE_USO");

                entity.Property(e => e.DispLocali)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DISP_LOCALI");

                entity.Property(e => e.Edificio)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EDIFICIO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Esitosap)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESITOSAP");

                entity.Property(e => e.Estduration)
                    .HasColumnType("FLOAT")
                    .HasColumnName("ESTDURATION");

                entity.Property(e => e.Ext)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXT");

                entity.Property(e => e.Ext2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EXT2");

                entity.Property(e => e.Faxauto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAXAUTO");

                entity.Property(e => e.Faxnum)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAXNUM");

                entity.Property(e => e.Faxstatoditta)
                    .HasColumnType("NUMBER(38)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("FAXSTATODITTA");

                entity.Property(e => e.Fee)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FEE");

                entity.Property(e => e.FileInvio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILE_INVIO");

                entity.Property(e => e.Finishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("FINISHDATE");

                entity.Property(e => e.Gestitocentrale)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GESTITOCENTRALE");

                entity.Property(e => e.Guasto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUASTO");

                entity.Property(e => e.Idcontesto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDCONTESTO");

                entity.Property(e => e.Idrichgestman)
                    .HasColumnType("NUMBER(38)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("IDRICHGESTMAN");

                entity.Property(e => e.Idworeqstato)
                    .HasPrecision(10)
                    .HasColumnName("IDWOREQSTATO");

                entity.Property(e => e.Importo)
                    .HasColumnType("FLOAT")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("IMPORTO");

                entity.Property(e => e.Impprevmntc)
                    .HasColumnType("FLOAT")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("IMPPREVMNTC");

                entity.Property(e => e.InFranchigia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_FRANCHIGIA");

                entity.Property(e => e.Incidente)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INCIDENTE");

                entity.Property(e => e.Indirizzointervento)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("INDIRIZZOINTERVENTO");

                entity.Property(e => e.Inserrato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INSERRATO");

                entity.Property(e => e.Inviamail)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("INVIAMAIL");

                entity.Property(e => e.Livello)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVELLO");

                entity.Property(e => e.Macchinari)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MACCHINARI");

                entity.Property(e => e.Macroatt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MACROATT");

                entity.Property(e => e.Mailrich)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MAILRICH");

                entity.Property(e => e.Motivoannullamento)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MOTIVOANNULLAMENTO");

                entity.Property(e => e.Motivochiusura)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVOCHIUSURA");

                entity.Property(e => e.Motivorifiuto)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVORIFIUTO");

                entity.Property(e => e.Motivososp)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MOTIVOSOSP");

                entity.Property(e => e.Mp2pal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MP2PAL");

                entity.Property(e => e.Mp2palbis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MP2PALBIS");

                entity.Property(e => e.Mp2palesito)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MP2PALESITO");

                entity.Property(e => e.Mp2palesitobis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MP2PALESITOBIS");

                entity.Property(e => e.Neve)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NEVE");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Noteapprovazione)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NOTEAPPROVAZIONE");

                entity.Property(e => e.Notecliente)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("NOTECLIENTE");

                entity.Property(e => e.Ntelrich)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NTELRICH");

                entity.Property(e => e.Odlpadre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ODLPADRE");

                entity.Property(e => e.Operatorecc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OPERATORECC");

                entity.Property(e => e.Oraprevconsprev)
                    .HasColumnType("DATE")
                    .HasColumnName("ORAPREVCONSPREV");

                entity.Property(e => e.Oraprocesso)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORAPROCESSO");

                entity.Property(e => e.Orarifprev)
                    .HasColumnType("DATE")
                    .HasColumnName("ORARIFPREV");

                entity.Property(e => e.Orasmsritardato)
                    .HasColumnType("DATE")
                    .HasColumnName("ORASMSRITARDATO");

                entity.Property(e => e.Orasopralluogo)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORASOPRALLUOGO");

                entity.Property(e => e.Orasosp)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORASOSP");

                entity.Property(e => e.Orastatosms)
                    .HasColumnType("DATE")
                    .HasColumnName("ORASTATOSMS");

                entity.Property(e => e.Orastatosms2)
                    .HasColumnType("DATE")
                    .HasColumnName("ORASTATOSMS2");

                entity.Property(e => e.Origine)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORIGINE");

                entity.Property(e => e.Origineinserimento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORIGINEINSERIMENTO");

                entity.Property(e => e.Pagernum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAGERNUM");

                entity.Property(e => e.PartiEdili)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PARTI_EDILI");

                entity.Property(e => e.Pdl)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PDL");

                entity.Property(e => e.Percorso)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PERCORSO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PHONE");

                entity.Property(e => e.Prcdc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PRCDC");

                entity.Property(e => e.Prcomp)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PRCOMP");

                entity.Property(e => e.Prcostomntc)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRCOSTOMNTC");

                entity.Property(e => e.Presaincarico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRESAINCARICO");

                entity.Property(e => e.Priority)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRIORITY");

                entity.Property(e => e.Prnord)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRNORD");

                entity.Property(e => e.Provenienza)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PROVENIENZA");

                entity.Property(e => e.Prprot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRPROT");

                entity.Property(e => e.Rdimadre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RDIMADRE");

                entity.Property(e => e.Referente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REFERENTE");

                entity.Property(e => e.Reparto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPARTO");

                entity.Property(e => e.Requestdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Requestedby)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTEDBY");

                entity.Property(e => e.Requesttime)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTTIME");

                entity.Property(e => e.Ricgestmankey)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RICGESTMANKEY");

                entity.Property(e => e.Richallcod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RICHALLCOD");

                entity.Property(e => e.Schedfinishdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SCHEDFINISHDATE");

                entity.Property(e => e.Schedfinishtime)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SCHEDFINISHTIME");

                entity.Property(e => e.Schedstartdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SCHEDSTARTDATE");

                entity.Property(e => e.Schedstarttime)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SCHEDSTARTTIME");

                entity.Property(e => e.Selected)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SELECTED");

                entity.Property(e => e.Sicurezza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SICUREZZA");

                entity.Property(e => e.Sp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SP");

                entity.Property(e => e.Stampafile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAMPAFILE");

                entity.Property(e => e.Stanza)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STANZA");

                entity.Property(e => e.Startdate)
                    .HasColumnType("DATE")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATE");

                entity.Property(e => e.Stato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATO");

                entity.Property(e => e.StatoInvio)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATO_INVIO");

                entity.Property(e => e.Statogestman)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATOGESTMAN");

                entity.Property(e => e.Statosap)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATOSAP");

                entity.Property(e => e.Statosms)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATOSMS");

                entity.Property(e => e.Statosms2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATOSMS2");

                entity.Property(e => e.Subrichiedente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBRICHIEDENTE");

                entity.Property(e => e.Taskdesc)
                    .HasMaxLength(72)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TASKDESC");

                entity.Property(e => e.Tasknum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TASKNUM");

                entity.Property(e => e.Tecnicoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TECNICOC");

                entity.Property(e => e.Timereleased)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMERELEASED");

                entity.Property(e => e.Tiporichiedente)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TIPORICHIEDENTE");

                entity.Property(e => e.Tmf)
                    .HasColumnType("NUMBER(38)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("TMF");

                entity.Property(e => e.Tmi)
                    .HasColumnType("NUMBER(38)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("TMI");

                entity.Property(e => e.Updatestamp)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UPDATESTAMP");

                entity.Property(e => e.Updateuser)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UPDATEUSER");

                entity.Property(e => e.Urgclienti)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("URGCLIENTI");

                entity.Property(e => e.Urgenza)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("URGENZA");

                entity.Property(e => e.Urgorigine)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("URGORIGINE");

                entity.Property(e => e.Utentechiamata)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UTENTECHIAMATA");

                entity.Property(e => e.Vano)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VANO");

                entity.Property(e => e.Wotype)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("WOTYPE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
