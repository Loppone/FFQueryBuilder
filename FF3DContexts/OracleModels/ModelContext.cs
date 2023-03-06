using Microsoft.EntityFrameworkCore;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             //   optionsBuilder.UseOracle("User Id=MP2;Password=MP2;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = ora11quality.intra.manutencoop.it)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = MP2T)))");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MP2");

 

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
