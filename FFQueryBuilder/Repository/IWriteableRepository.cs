using System.Collections.Generic;

namespace FFQueryBuilder.Repository
{
    public interface IWriteableRepository : IContext
    {
        /// <summary>
        /// Aggiunge un record.
        /// </summary>
        /// <returns>Torna l'ID del record inserito o null per le tabelle senza PK di tipo numerico</returns>
        object Add(dynamic entity);

        /// <summary>
        /// Elimina un record.
        /// </summary>
        /// <returns>Torna il record cancellato</returns>
        dynamic Delete(Dictionary<string, object> row);

        /// <summary>
        /// Aggiorna un record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Torna il record modificato</returns>
        dynamic Update(dynamic entity);
    }
}
