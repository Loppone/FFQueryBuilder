using Microsoft.EntityFrameworkCore;

namespace FFQueryBuilder.Repository
{
    /// <summary>
    /// Interfaccia che espone il Contesto e il DbSet dinamico
    /// </summary>
    /// <remarks>Contesto e Entità sono elementi dinamici e quindi necessitano di essere passati come parametri</remarks>
    public interface IContext
    {
        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }

        public string ContextName { get; set; }
        public string EntityName { get; set; }
    }
}
